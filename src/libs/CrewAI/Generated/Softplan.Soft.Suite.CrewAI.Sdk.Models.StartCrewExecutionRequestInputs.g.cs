
#nullable enable

namespace Softplan.Soft.Suite.CrewAI.Sdk
{
    /// <summary>
    /// Key-value pairs of all required inputs for your crew<br/>
    /// Example: {"budget":"1000 USD","interests":"games, tech, ai, relaxing hikes, amazing food","duration":"7 days","age":"35"}
    /// </summary>
    public sealed partial class StartCrewExecutionRequestInputs
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}