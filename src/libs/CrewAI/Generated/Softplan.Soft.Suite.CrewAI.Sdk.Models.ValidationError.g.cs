
#nullable enable

namespace Softplan.Soft.Suite.CrewAI.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ValidationError
    {
        /// <summary>
        /// Example: Validation Error
        /// </summary>
        /// <example>Validation Error</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Example: Missing required inputs
        /// </summary>
        /// <example>Missing required inputs</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("details")]
        public global::Softplan.Soft.Suite.CrewAI.Sdk.ValidationErrorDetails? Details { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationError" /> class.
        /// </summary>
        /// <param name="error">
        /// Example: Validation Error
        /// </param>
        /// <param name="message">
        /// Example: Missing required inputs
        /// </param>
        /// <param name="details"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ValidationError(
            string? error,
            string? message,
            global::Softplan.Soft.Suite.CrewAI.Sdk.ValidationErrorDetails? details)
        {
            this.Error = error;
            this.Message = message;
            this.Details = details;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationError" /> class.
        /// </summary>
        public ValidationError()
        {
        }

    }
}