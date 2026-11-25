
#nullable enable

namespace Softplan.Soft.Suite.CrewAI.Sdk
{
    /// <summary>
    /// Additional metadata to pass to the crew<br/>
    /// Example: {"requestId":"user-request-12345","source":"mobile-app"}
    /// </summary>
    public sealed partial class StartCrewExecutionRequestMeta
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}