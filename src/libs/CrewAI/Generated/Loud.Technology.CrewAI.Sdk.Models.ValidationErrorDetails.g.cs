
#nullable enable

namespace Loud.Technology.CrewAI.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ValidationErrorDetails
    {
        /// <summary>
        /// Example: [budget, interests]
        /// </summary>
        /// <example>[budget, interests]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("missing_inputs")]
        public global::System.Collections.Generic.IList<string>? MissingInputs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationErrorDetails" /> class.
        /// </summary>
        /// <param name="missingInputs">
        /// Example: [budget, interests]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ValidationErrorDetails(
            global::System.Collections.Generic.IList<string>? missingInputs)
        {
            this.MissingInputs = missingInputs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationErrorDetails" /> class.
        /// </summary>
        public ValidationErrorDetails()
        {
        }

    }
}