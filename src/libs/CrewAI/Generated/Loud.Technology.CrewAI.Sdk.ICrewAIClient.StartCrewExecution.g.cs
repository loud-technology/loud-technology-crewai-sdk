#nullable enable

namespace Loud.Technology.CrewAI.Sdk
{
    public partial interface ICrewAIClient
    {
        /// <summary>
        /// Start Crew Execution<br/>
        /// **📋 Reference Example Only** - *This shows the request format. To test with your actual crew, copy the cURL example and replace the URL + token with your real values.*<br/>
        /// Initiates a new crew execution with the provided inputs. Returns a kickoff ID that can be used<br/>
        /// to track the execution progress and retrieve results.<br/>
        /// Crew executions can take anywhere from seconds to minutes depending on their complexity.<br/>
        /// Consider using webhooks for real-time notifications or implement polling with the status endpoint.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.CrewAI.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.CrewAI.Sdk.StartCrewExecutionResponse> StartCrewExecutionAsync(

            global::Loud.Technology.CrewAI.Sdk.StartCrewExecutionRequest request,
            global::Loud.Technology.CrewAI.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Start Crew Execution<br/>
        /// **📋 Reference Example Only** - *This shows the request format. To test with your actual crew, copy the cURL example and replace the URL + token with your real values.*<br/>
        /// Initiates a new crew execution with the provided inputs. Returns a kickoff ID that can be used<br/>
        /// to track the execution progress and retrieve results.<br/>
        /// Crew executions can take anywhere from seconds to minutes depending on their complexity.<br/>
        /// Consider using webhooks for real-time notifications or implement polling with the status endpoint.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.CrewAI.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.CrewAI.Sdk.AutoSDKHttpResponse<global::Loud.Technology.CrewAI.Sdk.StartCrewExecutionResponse>> StartCrewExecutionAsResponseAsync(

            global::Loud.Technology.CrewAI.Sdk.StartCrewExecutionRequest request,
            global::Loud.Technology.CrewAI.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Start Crew Execution<br/>
        /// **📋 Reference Example Only** - *This shows the request format. To test with your actual crew, copy the cURL example and replace the URL + token with your real values.*<br/>
        /// Initiates a new crew execution with the provided inputs. Returns a kickoff ID that can be used<br/>
        /// to track the execution progress and retrieve results.<br/>
        /// Crew executions can take anywhere from seconds to minutes depending on their complexity.<br/>
        /// Consider using webhooks for real-time notifications or implement polling with the status endpoint.
        /// </summary>
        /// <param name="inputs">
        /// Key-value pairs of all required inputs for your crew<br/>
        /// Example: {"budget":"1000 USD","interests":"games, tech, ai, relaxing hikes, amazing food","duration":"7 days","age":"35"}
        /// </param>
        /// <param name="meta">
        /// Additional metadata to pass to the crew<br/>
        /// Example: {"requestId":"user-request-12345","source":"mobile-app"}
        /// </param>
        /// <param name="taskWebhookUrl">
        /// Callback URL executed after each task completion<br/>
        /// Example: https://your-server.com/webhooks/task
        /// </param>
        /// <param name="stepWebhookUrl">
        /// Callback URL executed after each agent thought/action<br/>
        /// Example: https://your-server.com/webhooks/step
        /// </param>
        /// <param name="crewWebhookUrl">
        /// Callback URL executed when the crew execution completes<br/>
        /// Example: https://your-server.com/webhooks/crew
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.CrewAI.Sdk.StartCrewExecutionResponse> StartCrewExecutionAsync(
            global::System.Collections.Generic.Dictionary<string, string> inputs,
            object? meta = default,
            string? taskWebhookUrl = default,
            string? stepWebhookUrl = default,
            string? crewWebhookUrl = default,
            global::Loud.Technology.CrewAI.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}