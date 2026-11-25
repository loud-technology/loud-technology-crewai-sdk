namespace Softplan.Soft.Suite.CrewAI.Sdk.IntegrationTests;

[TestClass]
public sealed class LiveTests
{
    [TestMethod]
    public async Task GetRequiredInputs_ReturnsTheInputNamesOfTheDeployedCrew()
    {
        var baseUrl = RequireEnvironmentVariable("CREWAI_BASE_URL");
        var token = RequireEnvironmentVariable("CREWAI_BEARER_TOKEN");
        using var client = new CrewAIClient(token, baseUri: new Uri(baseUrl));

        var response = await client.GetRequiredInputsAsync();

        response.Inputs.Should().NotBeNull();
    }

    private static string RequireEnvironmentVariable(string name) =>
        Environment.GetEnvironmentVariable(name) is { Length: > 0 } value
            ? value
            : throw new AssertInconclusiveException($"{name} environment variable is not set.");
}
