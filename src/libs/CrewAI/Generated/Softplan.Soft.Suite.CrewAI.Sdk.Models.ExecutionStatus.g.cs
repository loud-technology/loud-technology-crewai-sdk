
#nullable enable

namespace Softplan.Soft.Suite.CrewAI.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ExecutionStatus
    {
        /// <summary>
        /// Execution state, such as PENDING, STARTED, RUNNING, SUCCESS, FAILED, FAILURE or NOT FOUND.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        public string? State { get; set; }

        /// <summary>
        /// Human-readable status. On a failed execution it carries the error message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Final output of the crew or flow, set when the state is SUCCESS.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        public string? Result { get; set; }

        /// <summary>
        /// Last step the crew or flow executed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_step")]
        public object? LastStep { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecutionStatus" /> class.
        /// </summary>
        /// <param name="state">
        /// Execution state, such as PENDING, STARTED, RUNNING, SUCCESS, FAILED, FAILURE or NOT FOUND.
        /// </param>
        /// <param name="status">
        /// Human-readable status. On a failed execution it carries the error message.
        /// </param>
        /// <param name="result">
        /// Final output of the crew or flow, set when the state is SUCCESS.
        /// </param>
        /// <param name="lastStep">
        /// Last step the crew or flow executed.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExecutionStatus(
            string? state,
            string? status,
            string? result,
            object? lastStep)
        {
            this.State = state;
            this.Status = status;
            this.Result = result;
            this.LastStep = lastStep;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecutionStatus" /> class.
        /// </summary>
        public ExecutionStatus()
        {
        }

    }
}