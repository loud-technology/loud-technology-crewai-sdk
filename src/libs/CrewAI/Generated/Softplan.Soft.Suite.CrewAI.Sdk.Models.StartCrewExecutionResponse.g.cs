
#nullable enable

namespace Softplan.Soft.Suite.CrewAI.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class StartCrewExecutionResponse
    {
        /// <summary>
        /// Unique identifier for tracking this execution<br/>
        /// Example: abcd1234-5678-90ef-ghij-klmnopqrstuv
        /// </summary>
        /// <example>abcd1234-5678-90ef-ghij-klmnopqrstuv</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("kickoff_id")]
        public string? KickoffId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StartCrewExecutionResponse" /> class.
        /// </summary>
        /// <param name="kickoffId">
        /// Unique identifier for tracking this execution<br/>
        /// Example: abcd1234-5678-90ef-ghij-klmnopqrstuv
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StartCrewExecutionResponse(
            string? kickoffId)
        {
            this.KickoffId = kickoffId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StartCrewExecutionResponse" /> class.
        /// </summary>
        public StartCrewExecutionResponse()
        {
        }

    }
}