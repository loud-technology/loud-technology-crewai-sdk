
#nullable enable

namespace Softplan.Soft.Suite.CrewAI.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ResumeCrewExecutionRequest
    {
        /// <summary>
        /// The unique identifier for the crew execution (from kickoff)<br/>
        /// Example: abcd1234-5678-90ef-ghij-klmnopqrstuv
        /// </summary>
        /// <example>abcd1234-5678-90ef-ghij-klmnopqrstuv</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("execution_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ExecutionId { get; set; }

        /// <summary>
        /// The ID of the task that requires human feedback<br/>
        /// Example: research_task
        /// </summary>
        /// <example>research_task</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TaskId { get; set; }

        /// <summary>
        /// Your feedback on the task output. This will be incorporated as additional context for subsequent task executions.<br/>
        /// Example: Great research! Please add more details about recent developments in the field.
        /// </summary>
        /// <example>Great research! Please add more details about recent developments in the field.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("human_feedback")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HumanFeedback { get; set; }

        /// <summary>
        /// Whether you approve the task output: true = positive feedback (continue), false = negative feedback (retry task)<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_approve")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsApprove { get; set; }

        /// <summary>
        /// Callback URL executed after each task completion. MUST be provided to continue receiving task notifications.<br/>
        /// Example: https://your-server.com/webhooks/task
        /// </summary>
        /// <example>https://your-server.com/webhooks/task</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("taskWebhookUrl")]
        public string? TaskWebhookUrl { get; set; }

        /// <summary>
        /// Callback URL executed after each agent thought/action. MUST be provided to continue receiving step notifications.<br/>
        /// Example: https://your-server.com/webhooks/step
        /// </summary>
        /// <example>https://your-server.com/webhooks/step</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("stepWebhookUrl")]
        public string? StepWebhookUrl { get; set; }

        /// <summary>
        /// Callback URL executed when the crew execution completes. MUST be provided to receive completion notification.<br/>
        /// Example: https://your-server.com/webhooks/crew
        /// </summary>
        /// <example>https://your-server.com/webhooks/crew</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("crewWebhookUrl")]
        public string? CrewWebhookUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResumeCrewExecutionRequest" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResumeCrewExecutionRequest(
            string executionId,
            string taskId,
            string humanFeedback,
            bool isApprove,
            string? taskWebhookUrl,
            string? stepWebhookUrl,
            string? crewWebhookUrl)
        {
            this.ExecutionId = executionId ?? throw new global::System.ArgumentNullException(nameof(executionId));
            this.TaskId = taskId ?? throw new global::System.ArgumentNullException(nameof(taskId));
            this.HumanFeedback = humanFeedback ?? throw new global::System.ArgumentNullException(nameof(humanFeedback));
            this.IsApprove = isApprove;
            this.TaskWebhookUrl = taskWebhookUrl;
            this.StepWebhookUrl = stepWebhookUrl;
            this.CrewWebhookUrl = crewWebhookUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResumeCrewExecutionRequest" /> class.
        /// </summary>
        public ResumeCrewExecutionRequest()
        {
        }

    }
}