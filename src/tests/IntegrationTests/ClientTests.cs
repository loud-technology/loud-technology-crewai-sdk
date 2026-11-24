using System.Net;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;

namespace Loud.Technology.CrewAI.Sdk.IntegrationTests;

[TestClass]
public sealed class ClientTests
{
    private static readonly Uri CrewUrl = new("https://my-crew.example.com");

    [TestMethod]
    public void Constructor_ConfiguresDefaultBaseUrlAndBearerAuthentication()
    {
        using var client = new CrewAIClient("test-bearer-token");

        client.BaseUri.Should().Be(new Uri("https://your-actual-crew-name.crewai.com/"));
        var authorization = client.Authorizations.Should().ContainSingle().Which;
        authorization.Type.Should().Be("Http");
        authorization.Name.Should().Be("Bearer");
        authorization.Value.Should().Be("test-bearer-token");
    }

    [TestMethod]
    public async Task GetRequiredInputs_ReadsTheInputNamesFromTheCrewUrl()
    {
        var handler = RecordingHandler.Json("""{"inputs":["budget","interests","duration"]}""");
        using var client = CreateClient(handler);

        var response = await client.GetRequiredInputsAsync();

        handler.Method.Should().Be(HttpMethod.Get);
        handler.RequestUri.Should().Be(new Uri("https://my-crew.example.com/inputs"));
        handler.Authorization.Should().Be(new AuthenticationHeaderValue("Bearer", "test-bearer-token"));
        response.Inputs.Should().Equal("budget", "interests", "duration");
    }

    [TestMethod]
    public async Task StartCrewExecution_SendsInputsAndWebhooksAndReturnsTheKickoffId()
    {
        var handler = RecordingHandler.Json("""{"kickoff_id":"abcd1234-5678-90ef-ghij-klmnopqrstuv"}""");
        using var client = CreateClient(handler);

        var response = await client.StartCrewExecutionAsync(
            new StartCrewExecutionRequest
            {
                Inputs = new() { ["budget"] = "1000 USD", ["duration"] = "7 days" },
                TaskWebhookUrl = "https://hooks.example.com/task",
                StepWebhookUrl = "https://hooks.example.com/step",
                CrewWebhookUrl = "https://hooks.example.com/crew",
            });

        handler.Method.Should().Be(HttpMethod.Post);
        handler.RequestUri.Should().Be(new Uri("https://my-crew.example.com/kickoff"));
        handler.Authorization.Should().Be(new AuthenticationHeaderValue("Bearer", "test-bearer-token"));

        using var body = JsonDocument.Parse(handler.Body!);
        var root = body.RootElement;
        root.GetProperty("inputs").GetProperty("budget").GetString().Should().Be("1000 USD");
        root.GetProperty("inputs").GetProperty("duration").GetString().Should().Be("7 days");
        root.GetProperty("taskWebhookUrl").GetString().Should().Be("https://hooks.example.com/task");
        root.GetProperty("stepWebhookUrl").GetString().Should().Be("https://hooks.example.com/step");
        root.GetProperty("crewWebhookUrl").GetString().Should().Be("https://hooks.example.com/crew");

        response.KickoffId.Should().Be("abcd1234-5678-90ef-ghij-klmnopqrstuv");
    }

    [TestMethod]
    public async Task StartCrewExecution_OmitsWebhooksThatWereNotSet()
    {
        var handler = RecordingHandler.Json("""{"kickoff_id":"k-1"}""");
        using var client = CreateClient(handler);

        await client.StartCrewExecutionAsync(new Dictionary<string, string> { ["topic"] = "AI" });

        using var body = JsonDocument.Parse(handler.Body!);
        body.RootElement.EnumerateObject().Select(property => property.Name).Should().Equal("inputs");
    }

    [TestMethod]
    public async Task GetExecutionStatus_ReadsAFinishedExecution()
    {
        var handler = RecordingHandler.Json(
            """
            {
              "state": "SUCCESS",
              "status": "completed",
              "result": "final text",
              "last_step": { "tool": "search", "thought": "done" }
            }
            """);
        using var client = CreateClient(handler);

        var status = await client.GetExecutionStatusAsync("abcd1234-5678-90ef-ghij-klmnopqrstuv");

        handler.Method.Should().Be(HttpMethod.Get);
        handler.RequestUri.Should().Be(new Uri("https://my-crew.example.com/status/abcd1234-5678-90ef-ghij-klmnopqrstuv"));
        handler.Authorization.Should().Be(new AuthenticationHeaderValue("Bearer", "test-bearer-token"));
        status.State.Should().Be("SUCCESS");
        status.Status.Should().Be("completed");
        status.Result.Should().Be("final text");
        var lastStep = status.LastStep.Should().BeOfType<JsonElement>().Subject;
        lastStep.GetProperty("tool").GetString().Should().Be("search");
    }

    [TestMethod]
    [DataRow("RUNNING")]
    [DataRow("A_STATE_THE_SPEC_NEVER_LISTED")]
    public async Task GetExecutionStatus_ReadsAnUnfinishedExecutionWithoutAResult(string state)
    {
        var handler = RecordingHandler.Json($$"""{"state":"{{state}}"}""");
        using var client = CreateClient(handler);

        var status = await client.GetExecutionStatusAsync("kickoff-42");

        handler.RequestUri!.AbsolutePath.Should().Be("/status/kickoff-42");
        status.State.Should().Be(state);
        status.Result.Should().BeNull();
        status.LastStep.Should().BeNull();
    }

    [TestMethod]
    public async Task ResumeCrewExecution_SendsTheHumanFeedback()
    {
        var handler = RecordingHandler.Json("""{"status":"resumed","message":"Execution resumed successfully"}""");
        using var client = CreateClient(handler);

        var response = await client.ResumeCrewExecutionAsync(
            new ResumeCrewExecutionRequest
            {
                ExecutionId = "kickoff-42",
                TaskId = "research_task",
                HumanFeedback = "Add recent developments.",
                IsApprove = false,
            });

        handler.Method.Should().Be(HttpMethod.Post);
        handler.RequestUri.Should().Be(new Uri("https://my-crew.example.com/resume"));
        handler.Authorization.Should().Be(new AuthenticationHeaderValue("Bearer", "test-bearer-token"));

        using var body = JsonDocument.Parse(handler.Body!);
        var root = body.RootElement;
        root.GetProperty("execution_id").GetString().Should().Be("kickoff-42");
        root.GetProperty("task_id").GetString().Should().Be("research_task");
        root.GetProperty("human_feedback").GetString().Should().Be("Add recent developments.");
        root.GetProperty("is_approve").GetBoolean().Should().BeFalse();

        response.Status.Should().Be(ResumeCrewExecutionResponseStatus.Resumed);
        response.Message.Should().Be("Execution resumed successfully");
    }

    private static CrewAIClient CreateClient(RecordingHandler handler) =>
        new(
            apiKey: "test-bearer-token",
            httpClient: new HttpClient(handler),
            baseUri: CrewUrl);

    private sealed class RecordingHandler(HttpResponseMessage response) : HttpMessageHandler
    {
        public HttpMethod? Method { get; private set; }
        public Uri? RequestUri { get; private set; }
        public AuthenticationHeaderValue? Authorization { get; private set; }
        public string? Body { get; private set; }

        public static RecordingHandler Json(string json) =>
            new(new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent(json, Encoding.UTF8, "application/json"),
            });

        protected override async Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            Method = request.Method;
            RequestUri = request.RequestUri;
            Authorization = request.Headers.Authorization;
            Body = request.Content is null
                ? null
                : await request.Content.ReadAsStringAsync(cancellationToken);

            return response;
        }
    }
}
