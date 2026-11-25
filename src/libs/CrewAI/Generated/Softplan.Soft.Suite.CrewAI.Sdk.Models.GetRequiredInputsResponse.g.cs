
#nullable enable

namespace Softplan.Soft.Suite.CrewAI.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetRequiredInputsResponse
    {
        /// <summary>
        /// Array of required input parameter names<br/>
        /// Example: [budget, interests, duration, age]
        /// </summary>
        /// <example>[budget, interests, duration, age]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs")]
        public global::System.Collections.Generic.IList<string>? Inputs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRequiredInputsResponse" /> class.
        /// </summary>
        /// <param name="inputs">
        /// Array of required input parameter names<br/>
        /// Example: [budget, interests, duration, age]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetRequiredInputsResponse(
            global::System.Collections.Generic.IList<string>? inputs)
        {
            this.Inputs = inputs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRequiredInputsResponse" /> class.
        /// </summary>
        public GetRequiredInputsResponse()
        {
        }

    }
}