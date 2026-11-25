
#nullable enable

namespace Softplan.Soft.Suite.CrewAI.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class StartCrewExecutionRequest
    {
        /// <summary>
        /// Key-value pairs of all required inputs for your crew<br/>
        /// Example: {"budget":"1000 USD","interests":"games, tech, ai, relaxing hikes, amazing food","duration":"7 days","age":"35"}
        /// </summary>
        /// <example>{"budget":"1000 USD","interests":"games, tech, ai, relaxing hikes, amazing food","duration":"7 days","age":"35"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> Inputs { get; set; }

        /// <summary>
        /// Additional metadata to pass to the crew<br/>
        /// Example: {"requestId":"user-request-12345","source":"mobile-app"}
        /// </summary>
        /// <example>{"requestId":"user-request-12345","source":"mobile-app"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta")]
        public object? Meta { get; set; }

        /// <summary>
        /// Callback URL executed after each task completion<br/>
        /// Example: https://your-server.com/webhooks/task
        /// </summary>
        /// <example>https://your-server.com/webhooks/task</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("taskWebhookUrl")]
        public string? TaskWebhookUrl { get; set; }

        /// <summary>
        /// Callback URL executed after each agent thought/action<br/>
        /// Example: https://your-server.com/webhooks/step
        /// </summary>
        /// <example>https://your-server.com/webhooks/step</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("stepWebhookUrl")]
        public string? StepWebhookUrl { get; set; }

        /// <summary>
        /// Callback URL executed when the crew execution completes<br/>
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
        /// Initializes a new instance of the <see cref="StartCrewExecutionRequest" /> class.
        /// </summary>
        /// <param name="inputs">
        /// Key-value pairs of all required inputs for your crew<br/>
        /// Example: {"budget":"1000 USD","interests":"games, tech, ai, relaxing hikes, amazing food","duration":"7 days","age":"35"}
        /// </param>
        /// <param name="meta">
        /// Additional metadata to pass to the crew<br/>
        /// Example: {"requestId":"user-request-12345","source":"mobile-app"}
        /// </param>
        /// <param name="taskWebhookUrl">
        /// Callback URL executed after each task completion<br/>
        /// Example: https://your-server.com/webhooks/task
        /// </param>
        /// <param name="stepWebhookUrl">
        /// Callback URL executed after each agent thought/action<br/>
        /// Example: https://your-server.com/webhooks/step
        /// </param>
        /// <param name="crewWebhookUrl">
        /// Callback URL executed when the crew execution completes<br/>
        /// Example: https://your-server.com/webhooks/crew
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StartCrewExecutionRequest(
            global::System.Collections.Generic.Dictionary<string, string> inputs,
            object? meta,
            string? taskWebhookUrl,
            string? stepWebhookUrl,
            string? crewWebhookUrl)
        {
            this.Inputs = inputs ?? throw new global::System.ArgumentNullException(nameof(inputs));
            this.Meta = meta;
            this.TaskWebhookUrl = taskWebhookUrl;
            this.StepWebhookUrl = stepWebhookUrl;
            this.CrewWebhookUrl = crewWebhookUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StartCrewExecutionRequest" /> class.
        /// </summary>
        public StartCrewExecutionRequest()
        {
        }

    }
}