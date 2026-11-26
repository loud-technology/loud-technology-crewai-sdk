
#nullable enable

namespace Softplan.Soft.Suite.CrewAI.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class Error
    {
        /// <summary>
        /// Error type or title<br/>
        /// Example: Authentication Error
        /// </summary>
        /// <example>Authentication Error</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error1 { get; set; }

        /// <summary>
        /// Detailed error message<br/>
        /// Example: Invalid bearer token provided
        /// </summary>
        /// <example>Invalid bearer token provided</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Error" /> class.
        /// </summary>
        /// <param name="error1">
        /// Error type or title<br/>
        /// Example: Authentication Error
        /// </param>
        /// <param name="message">
        /// Detailed error message<br/>
        /// Example: Invalid bearer token provided
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Error(
            string? error1,
            string? message)
        {
            this.Error1 = error1;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Error" /> class.
        /// </summary>
        public Error()
        {
        }

    }
}