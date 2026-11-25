#nullable enable

namespace Softplan.Soft.Suite.CrewAI.Sdk
{
    public partial interface ICrewAIClient
    {
        /// <summary>
        /// Resume Crew Execution with Human Feedback<br/>
        /// **📋 Reference Example Only** - *This shows the request format. To test with your actual crew, copy the cURL example and replace the URL + token with your real values.*<br/>
        /// Resume a paused crew execution with human feedback for Human-in-the-Loop (HITL) workflows.<br/>
        /// When a task with `human_input=True` completes, the crew execution pauses and waits for human feedback.<br/>
        /// **IMPORTANT**: You must provide the same webhook URLs (`taskWebhookUrl`, `stepWebhookUrl`, `crewWebhookUrl`)<br/>
        /// that were used in the original kickoff call. Webhook configurations are NOT automatically carried over -<br/>
        /// they must be explicitly provided in the resume request to continue receiving notifications.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.CrewAI.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.CrewAI.Sdk.ResumeCrewExecutionResponse> ResumeCrewExecutionAsync(

            global::Softplan.Soft.Suite.CrewAI.Sdk.ResumeCrewExecutionRequest request,
            global::Softplan.Soft.Suite.CrewAI.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Resume Crew Execution with Human Feedback<br/>
        /// **📋 Reference Example Only** - *This shows the request format. To test with your actual crew, copy the cURL example and replace the URL + token with your real values.*<br/>
        /// Resume a paused crew execution with human feedback for Human-in-the-Loop (HITL) workflows.<br/>
        /// When a task with `human_input=True` completes, the crew execution pauses and waits for human feedback.<br/>
        /// **IMPORTANT**: You must provide the same webhook URLs (`taskWebhookUrl`, `stepWebhookUrl`, `crewWebhookUrl`)<br/>
        /// that were used in the original kickoff call. Webhook configurations are NOT automatically carried over -<br/>
        /// they must be explicitly provided in the resume request to continue receiving notifications.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.CrewAI.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.CrewAI.Sdk.AutoSDKHttpResponse<global::Softplan.Soft.Suite.CrewAI.Sdk.ResumeCrewExecutionResponse>> ResumeCrewExecutionAsResponseAsync(

            global::Softplan.Soft.Suite.CrewAI.Sdk.ResumeCrewExecutionRequest request,
            global::Softplan.Soft.Suite.CrewAI.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Resume Crew Execution with Human Feedback<br/>
        /// **📋 Reference Example Only** - *This shows the request format. To test with your actual crew, copy the cURL example and replace the URL + token with your real values.*<br/>
        /// Resume a paused crew execution with human feedback for Human-in-the-Loop (HITL) workflows.<br/>
        /// When a task with `human_input=True` completes, the crew execution pauses and waits for human feedback.<br/>
        /// **IMPORTANT**: You must provide the same webhook URLs (`taskWebhookUrl`, `stepWebhookUrl`, `crewWebhookUrl`)<br/>
        /// that were used in the original kickoff call. Webhook configurations are NOT automatically carried over -<br/>
        /// they must be explicitly provided in the resume request to continue receiving notifications.
        /// </summary>
        /// <param name="executionId">
        /// The unique identifier for the crew execution (from kickoff)<br/>
        /// Example: abcd1234-5678-90ef-ghij-klmnopqrstuv
        /// </param>
        /// <param name="taskId">
        /// The ID of the task that requires human feedback<br/>
        /// Example: research_task
        /// </param>
        /// <param name="humanFeedback">
        /// Your feedback on the task output. This will be incorporated as additional context for subsequent task executions.<br/>
        /// Example: Great research! Please add more details about recent developments in the field.
        /// </param>
        /// <param name="isApprove">
        /// Whether you approve the task output: true = positive feedback (continue), false = negative feedback (retry task)<br/>
        /// Example: true
        /// </param>
        /// <param name="taskWebhookUrl">
        /// Callback URL executed after each task completion. MUST be provided to continue receiving task notifications.<br/>
        /// Example: https://your-server.com/webhooks/task
        /// </param>
        /// <param name="stepWebhookUrl">
        /// Callback URL executed after each agent thought/action. MUST be provided to continue receiving step notifications.<br/>
        /// Example: https://your-server.com/webhooks/step
        /// </param>
        /// <param name="crewWebhookUrl">
        /// Callback URL executed when the crew execution completes. MUST be provided to receive completion notification.<br/>
        /// Example: https://your-server.com/webhooks/crew
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.CrewAI.Sdk.ResumeCrewExecutionResponse> ResumeCrewExecutionAsync(
            string executionId,
            string taskId,
            string humanFeedback,
            bool isApprove,
            string? taskWebhookUrl = default,
            string? stepWebhookUrl = default,
            string? crewWebhookUrl = default,
            global::Softplan.Soft.Suite.CrewAI.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}