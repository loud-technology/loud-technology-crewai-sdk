#nullable enable

namespace Loud.Technology.CrewAI.Sdk
{
    public partial interface ICrewAIClient
    {
        /// <summary>
        /// Get Required Inputs<br/>
        /// **📋 Reference Example Only** - *This shows the request format. To test with your actual crew, copy the cURL example and replace the URL + token with your real values.*<br/>
        /// Retrieves the list of all required input parameters that your crew expects for execution.<br/>
        /// Use this endpoint to discover what inputs you need to provide when starting a crew execution.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.CrewAI.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.CrewAI.Sdk.GetRequiredInputsResponse> GetRequiredInputsAsync(
            global::Loud.Technology.CrewAI.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Required Inputs<br/>
        /// **📋 Reference Example Only** - *This shows the request format. To test with your actual crew, copy the cURL example and replace the URL + token with your real values.*<br/>
        /// Retrieves the list of all required input parameters that your crew expects for execution.<br/>
        /// Use this endpoint to discover what inputs you need to provide when starting a crew execution.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.CrewAI.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.CrewAI.Sdk.AutoSDKHttpResponse<global::Loud.Technology.CrewAI.Sdk.GetRequiredInputsResponse>> GetRequiredInputsAsResponseAsync(
            global::Loud.Technology.CrewAI.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}