
#nullable enable

namespace Softplan.Soft.Suite.CrewAI.Sdk
{
    public partial class CrewAIClient
    {

        private static readonly global::Softplan.Soft.Suite.CrewAI.Sdk.AutoSDKServer[] s_StartCrewExecutionServers = new global::Softplan.Soft.Suite.CrewAI.Sdk.AutoSDKServer[]
        {            new global::Softplan.Soft.Suite.CrewAI.Sdk.AutoSDKServer(
                id: "https-your-actual-crew-name-crewai-com",
                name: "your-actual-crew-name.crewai.com",
                url: "https://your-actual-crew-name.crewai.com/",
                description: ""),
            new global::Softplan.Soft.Suite.CrewAI.Sdk.AutoSDKServer(
                id: "https-my-travel-crew-crewai-com",
                name: "Example travel planning crew (replace with your URL)",
                url: "https://my-travel-crew.crewai.com/",
                description: "Example travel planning crew (replace with your URL)"),
            new global::Softplan.Soft.Suite.CrewAI.Sdk.AutoSDKServer(
                id: "https-content-creation-crew-crewai-com",
                name: "Example content creation crew (replace with your URL)",
                url: "https://content-creation-crew.crewai.com/",
                description: "Example content creation crew (replace with your URL)"),
            new global::Softplan.Soft.Suite.CrewAI.Sdk.AutoSDKServer(
                id: "https-research-assistant-crew-crewai-com",
                name: "Example research assistant crew (replace with your URL)",
                url: "https://research-assistant-crew.crewai.com/",
                description: "Example research assistant crew (replace with your URL)"),
        };


        private static readonly global::Softplan.Soft.Suite.CrewAI.Sdk.EndPointSecurityRequirement s_StartCrewExecutionSecurityRequirement0 =
            new global::Softplan.Soft.Suite.CrewAI.Sdk.EndPointSecurityRequirement
            {
                Authorizations = new global::Softplan.Soft.Suite.CrewAI.Sdk.EndPointAuthorizationRequirement[]
                {                    new global::Softplan.Soft.Suite.CrewAI.Sdk.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        SchemeId = "HttpBearer",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::Softplan.Soft.Suite.CrewAI.Sdk.EndPointSecurityRequirement[] s_StartCrewExecutionSecurityRequirements =
            new global::Softplan.Soft.Suite.CrewAI.Sdk.EndPointSecurityRequirement[]
            {                s_StartCrewExecutionSecurityRequirement0,
            };
        partial void PrepareStartCrewExecutionArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Softplan.Soft.Suite.CrewAI.Sdk.StartCrewExecutionRequest request);
        partial void PrepareStartCrewExecutionRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Softplan.Soft.Suite.CrewAI.Sdk.StartCrewExecutionRequest request);
        partial void ProcessStartCrewExecutionResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessStartCrewExecutionResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

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
        /// <exception cref="global::Softplan.Soft.Suite.CrewAI.Sdk.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.CrewAI.Sdk.StartCrewExecutionResponse> StartCrewExecutionAsync(

            global::Softplan.Soft.Suite.CrewAI.Sdk.StartCrewExecutionRequest request,
            global::Softplan.Soft.Suite.CrewAI.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await StartCrewExecutionAsResponseAsync(

                request: request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
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
        /// <exception cref="global::Softplan.Soft.Suite.CrewAI.Sdk.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.CrewAI.Sdk.AutoSDKHttpResponse<global::Softplan.Soft.Suite.CrewAI.Sdk.StartCrewExecutionResponse>> StartCrewExecutionAsResponseAsync(

            global::Softplan.Soft.Suite.CrewAI.Sdk.StartCrewExecutionRequest request,
            global::Softplan.Soft.Suite.CrewAI.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareStartCrewExecutionArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::Softplan.Soft.Suite.CrewAI.Sdk.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_StartCrewExecutionSecurityRequirements,
                operationName: "StartCrewExecutionAsync");

            using var __timeoutCancellationTokenSource = global::Softplan.Soft.Suite.CrewAI.Sdk.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::Softplan.Soft.Suite.CrewAI.Sdk.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::Softplan.Soft.Suite.CrewAI.Sdk.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {

                            var __pathBuilder = new global::Softplan.Soft.Suite.CrewAI.Sdk.PathBuilder(
                                path: "/kickoff",
                                baseUri: ResolveBaseUri(
                                servers: s_StartCrewExecutionServers,
                                defaultBaseUrl: "https://your-actual-crew-name.crewai.com/"));
                            var __path = __pathBuilder.ToString();
                __path = global::Softplan.Soft.Suite.CrewAI.Sdk.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Post,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }
                            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
                            var __httpRequestContent = new global::System.Net.Http.StringContent(
                                content: __httpRequestContentBody,
                                encoding: global::System.Text.Encoding.UTF8,
                                mediaType: "application/json");
                            __httpRequest.Content = __httpRequestContent;
                global::Softplan.Soft.Suite.CrewAI.Sdk.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareStartCrewExecutionRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    request: request);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::Softplan.Soft.Suite.CrewAI.Sdk.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::Softplan.Soft.Suite.CrewAI.Sdk.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "StartCrewExecution",
                                methodName: "StartCrewExecutionAsync",
                                pathTemplate: "\"/kickoff\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __retryDelay = global::Softplan.Soft.Suite.CrewAI.Sdk.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: null,
                            attempt: __attempt);
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::Softplan.Soft.Suite.CrewAI.Sdk.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Softplan.Soft.Suite.CrewAI.Sdk.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "StartCrewExecution",
                                methodName: "StartCrewExecutionAsync",
                                pathTemplate: "\"/kickoff\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                retryDelay: __willRetry ? __retryDelay : (global::System.TimeSpan?)null,
                                retryReason: "exception",
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Softplan.Soft.Suite.CrewAI.Sdk.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::Softplan.Soft.Suite.CrewAI.Sdk.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        var __retryDelay = global::Softplan.Soft.Suite.CrewAI.Sdk.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: __response,
                            attempt: __attempt);
                        await global::Softplan.Soft.Suite.CrewAI.Sdk.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Softplan.Soft.Suite.CrewAI.Sdk.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "StartCrewExecution",
                                methodName: "StartCrewExecutionAsync",
                                pathTemplate: "\"/kickoff\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                retryDelay: __retryDelay,
                                retryReason: "status:" + ((int)__response.StatusCode).ToString(global::System.Globalization.CultureInfo.InvariantCulture),
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Softplan.Soft.Suite.CrewAI.Sdk.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessStartCrewExecutionResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Softplan.Soft.Suite.CrewAI.Sdk.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Softplan.Soft.Suite.CrewAI.Sdk.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "StartCrewExecution",
                                methodName: "StartCrewExecutionAsync",
                                pathTemplate: "\"/kickoff\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::Softplan.Soft.Suite.CrewAI.Sdk.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Softplan.Soft.Suite.CrewAI.Sdk.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "StartCrewExecution",
                                methodName: "StartCrewExecutionAsync",
                                pathTemplate: "\"/kickoff\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                            // Invalid request body or missing required inputs
                            if ((int)__response.StatusCode == 400)
                            {
                                string? __content_400 = null;
                                global::System.Exception? __exception_400 = null;
                                global::Softplan.Soft.Suite.CrewAI.Sdk.Error? __value_400 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_400 = global::Softplan.Soft.Suite.CrewAI.Sdk.Error.FromJson(__content_400, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_400 = global::Softplan.Soft.Suite.CrewAI.Sdk.Error.FromJson(__content_400, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_400 = __ex;
                                }


                                throw global::Softplan.Soft.Suite.CrewAI.Sdk.ApiException<global::Softplan.Soft.Suite.CrewAI.Sdk.Error>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_400,
                                    responseBody: __content_400,
                                    responseObject: __value_400,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Authentication failed - check your bearer token
                            if ((int)__response.StatusCode == 401)
                            {
                                string? __content_401 = null;
                                global::System.Exception? __exception_401 = null;
                                global::Softplan.Soft.Suite.CrewAI.Sdk.Error? __value_401 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_401 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_401 = global::Softplan.Soft.Suite.CrewAI.Sdk.Error.FromJson(__content_401, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_401 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_401 = global::Softplan.Soft.Suite.CrewAI.Sdk.Error.FromJson(__content_401, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_401 = __ex;
                                }


                                throw global::Softplan.Soft.Suite.CrewAI.Sdk.ApiException<global::Softplan.Soft.Suite.CrewAI.Sdk.Error>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_401 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_401,
                                    responseBody: __content_401,
                                    responseObject: __value_401,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Validation error - ensure all required inputs are provided
                            if ((int)__response.StatusCode == 422)
                            {
                                string? __content_422 = null;
                                global::System.Exception? __exception_422 = null;
                                global::Softplan.Soft.Suite.CrewAI.Sdk.ValidationError? __value_422 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_422 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_422 = global::Softplan.Soft.Suite.CrewAI.Sdk.ValidationError.FromJson(__content_422, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_422 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_422 = global::Softplan.Soft.Suite.CrewAI.Sdk.ValidationError.FromJson(__content_422, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_422 = __ex;
                                }


                                throw global::Softplan.Soft.Suite.CrewAI.Sdk.ApiException<global::Softplan.Soft.Suite.CrewAI.Sdk.ValidationError>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_422 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_422,
                                    responseBody: __content_422,
                                    responseObject: __value_422,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Internal server error
                            if ((int)__response.StatusCode == 500)
                            {
                                string? __content_500 = null;
                                global::System.Exception? __exception_500 = null;
                                global::Softplan.Soft.Suite.CrewAI.Sdk.Error? __value_500 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_500 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_500 = global::Softplan.Soft.Suite.CrewAI.Sdk.Error.FromJson(__content_500, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_500 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_500 = global::Softplan.Soft.Suite.CrewAI.Sdk.Error.FromJson(__content_500, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_500 = __ex;
                                }


                                throw global::Softplan.Soft.Suite.CrewAI.Sdk.ApiException<global::Softplan.Soft.Suite.CrewAI.Sdk.Error>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_500 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_500,
                                    responseBody: __content_500,
                                    responseObject: __value_500,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessResponseContent(
                                    client: HttpClient,
                                    response: __response,
                                    content: ref __content);
                                ProcessStartCrewExecutionResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::Softplan.Soft.Suite.CrewAI.Sdk.StartCrewExecutionResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::Softplan.Soft.Suite.CrewAI.Sdk.AutoSDKHttpResponse<global::Softplan.Soft.Suite.CrewAI.Sdk.StartCrewExecutionResponse>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Softplan.Soft.Suite.CrewAI.Sdk.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    throw global::Softplan.Soft.Suite.CrewAI.Sdk.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }
                            else
                            {
                                try
                                {
                                    __response.EnsureSuccessStatusCode();
                                    using var __content = await __response.Content.ReadAsStreamAsync(
                #if NET5_0_OR_GREATER
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    var __value = await global::Softplan.Soft.Suite.CrewAI.Sdk.StartCrewExecutionResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::Softplan.Soft.Suite.CrewAI.Sdk.AutoSDKHttpResponse<global::Softplan.Soft.Suite.CrewAI.Sdk.StartCrewExecutionResponse>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Softplan.Soft.Suite.CrewAI.Sdk.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    string? __content = null;
                                    try
                                    {
                                        __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                            __effectiveCancellationToken
                #endif
                                        ).ConfigureAwait(false);
                                    }
                                    catch (global::System.Exception)
                                    {
                                    }

                                    throw global::Softplan.Soft.Suite.CrewAI.Sdk.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
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
        public async global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.CrewAI.Sdk.StartCrewExecutionResponse> StartCrewExecutionAsync(
            global::System.Collections.Generic.Dictionary<string, string> inputs,
            object? meta = default,
            string? taskWebhookUrl = default,
            string? stepWebhookUrl = default,
            string? crewWebhookUrl = default,
            global::Softplan.Soft.Suite.CrewAI.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Softplan.Soft.Suite.CrewAI.Sdk.StartCrewExecutionRequest
            {
                Inputs = inputs,
                Meta = meta,
                TaskWebhookUrl = taskWebhookUrl,
                StepWebhookUrl = stepWebhookUrl,
                CrewWebhookUrl = crewWebhookUrl,
            };

            return await StartCrewExecutionAsync(
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}