#nullable enable

namespace Loud.Technology.CrewAI.Sdk
{
    public partial interface ICrewAIClient
    {
        /// <summary>
        /// Get Execution Status<br/>
        /// **📋 Reference Example Only** - *This shows the request format. To test with your actual crew, copy the cURL example and replace the URL + token with your real values.*<br/>
        /// Retrieves the current status and results of a crew execution using its kickoff ID.<br/>
        /// The response structure varies depending on the execution state:<br/>
        /// - **running**: Execution in progress with current task info<br/>
        /// - **completed**: Execution finished with full results<br/>
        /// - **error**: Execution failed with error details
        /// </summary>
        /// <param name="kickoffId">
        /// Example: abcd1234-5678-90ef-ghij-klmnopqrstuv
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.CrewAI.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.CrewAI.Sdk.ExecutionStatus> GetExecutionStatusAsync(
            string kickoffId,
            global::Loud.Technology.CrewAI.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Execution Status<br/>
        /// **📋 Reference Example Only** - *This shows the request format. To test with your actual crew, copy the cURL example and replace the URL + token with your real values.*<br/>
        /// Retrieves the current status and results of a crew execution using its kickoff ID.<br/>
        /// The response structure varies depending on the execution state:<br/>
        /// - **running**: Execution in progress with current task info<br/>
        /// - **completed**: Execution finished with full results<br/>
        /// - **error**: Execution failed with error details
        /// </summary>
        /// <param name="kickoffId">
        /// Example: abcd1234-5678-90ef-ghij-klmnopqrstuv
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.CrewAI.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.CrewAI.Sdk.AutoSDKHttpResponse<global::Loud.Technology.CrewAI.Sdk.ExecutionStatus>> GetExecutionStatusAsResponseAsync(
            string kickoffId,
            global::Loud.Technology.CrewAI.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}