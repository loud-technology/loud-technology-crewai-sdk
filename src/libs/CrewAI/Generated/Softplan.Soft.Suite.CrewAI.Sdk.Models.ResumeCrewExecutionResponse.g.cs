
#nullable enable

namespace Softplan.Soft.Suite.CrewAI.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ResumeCrewExecutionResponse
    {
        /// <summary>
        /// Status of the resumed execution<br/>
        /// Example: resumed
        /// </summary>
        /// <example>resumed</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Softplan.Soft.Suite.CrewAI.Sdk.JsonConverters.ResumeCrewExecutionResponseStatusJsonConverter))]
        public global::Softplan.Soft.Suite.CrewAI.Sdk.ResumeCrewExecutionResponseStatus? Status { get; set; }

        /// <summary>
        /// Human-readable message about the resume operation<br/>
        /// Example: Execution resumed successfully
        /// </summary>
        /// <example>Execution resumed successfully</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResumeCrewExecutionResponse" /> class.
        /// </summary>
        /// <param name="status">
        /// Status of the resumed execution<br/>
        /// Example: resumed
        /// </param>
        /// <param name="message">
        /// Human-readable message about the resume operation<br/>
        /// Example: Execution resumed successfully
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResumeCrewExecutionResponse(
            global::Softplan.Soft.Suite.CrewAI.Sdk.ResumeCrewExecutionResponseStatus? status,
            string? message)
        {
            this.Status = status;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResumeCrewExecutionResponse" /> class.
        /// </summary>
        public ResumeCrewExecutionResponse()
        {
        }

    }
}