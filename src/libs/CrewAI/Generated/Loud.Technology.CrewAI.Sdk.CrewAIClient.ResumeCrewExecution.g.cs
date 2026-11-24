
#nullable enable

namespace Loud.Technology.CrewAI.Sdk
{
    public partial class CrewAIClient
    {

        private static readonly global::Loud.Technology.CrewAI.Sdk.AutoSDKServer[] s_ResumeCrewExecutionServers = new global::Loud.Technology.CrewAI.Sdk.AutoSDKServer[]
        {            new global::Loud.Technology.CrewAI.Sdk.AutoSDKServer(
                id: "https-your-actual-crew-name-crewai-com",
                name: "your-actual-crew-name.crewai.com",
                url: "https://your-actual-crew-name.crewai.com/",
                description: ""),
            new global::Loud.Technology.CrewAI.Sdk.AutoSDKServer(
                id: "https-my-travel-crew-crewai-com",
                name: "Example travel planning crew (replace with your URL)",
                url: "https://my-travel-crew.crewai.com/",
                description: "Example travel planning crew (replace with your URL)"),
            new global::Loud.Technology.CrewAI.Sdk.AutoSDKServer(
                id: "https-content-creation-crew-crewai-com",
                name: "Example content creation crew (replace with your URL)",
                url: "https://content-creation-crew.crewai.com/",
                description: "Example content creation crew (replace with your URL)"),
            new global::Loud.Technology.CrewAI.Sdk.AutoSDKServer(
                id: "https-research-assistant-crew-crewai-com",
                name: "Example research assistant crew (replace with your URL)",
                url: "https://research-assistant-crew.crewai.com/",
                description: "Example research assistant crew (replace with your URL)"),
        };


        private static readonly global::Loud.Technology.CrewAI.Sdk.EndPointSecurityRequirement s_ResumeCrewExecutionSecurityRequirement0 =
            new global::Loud.Technology.CrewAI.Sdk.EndPointSecurityRequirement
            {
                Authorizations = new global::Loud.Technology.CrewAI.Sdk.EndPointAuthorizationRequirement[]
                {                    new global::Loud.Technology.CrewAI.Sdk.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        SchemeId = "HttpBearer",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::Loud.Technology.CrewAI.Sdk.EndPointSecurityRequirement[] s_ResumeCrewExecutionSecurityRequirements =
            new global::Loud.Technology.CrewAI.Sdk.EndPointSecurityRequirement[]
            {                s_ResumeCrewExecutionSecurityRequirement0,
            };
        partial void PrepareResumeCrewExecutionArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Loud.Technology.CrewAI.Sdk.ResumeCrewExecutionRequest request);
        partial void PrepareResumeCrewExecutionRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Loud.Technology.CrewAI.Sdk.ResumeCrewExecutionRequest request);
        partial void ProcessResumeCrewExecutionResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessResumeCrewExecutionResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Resume Crew Execution with Human Feedback<br/>
        /// **📋 Reference Example Only** - *This shows the request format. To test with your actual crew, copy the cURL example and replace the URL + token with your real values.*<br/>
        /// Resume a paused crew execution with human feedback for Human-in-the-Loop (HITL) workflows.<br/>
        /// When a task with `human_input=True` completes, the crew execution pauses and waits for human feedback.<br/>
        /// **IMPORTANT**: You must provide the same webhook URLs (`taskWebhookUrl`, `stepWebhookUrl`, `crewWebhookUrl`)<br/>
        /// that were used in the original kickoff call. Webhook configurations are NOT automatically carried over -<br/>
        /// they must be explicitly provided in the resume request to continue receiving notifications.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.CrewAI.Sdk.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Loud.Technology.CrewAI.Sdk.ResumeCrewExecutionResponse> ResumeCrewExecutionAsync(

            global::Loud.Technology.CrewAI.Sdk.ResumeCrewExecutionRequest request,
            global::Loud.Technology.CrewAI.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await ResumeCrewExecutionAsResponseAsync(

                request: request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Resume Crew Execution with Human Feedback<br/>
        /// **📋 Reference Example Only** - *This shows the request format. To test with your actual crew, copy the cURL example and replace the URL + token with your real values.*<br/>
        /// Resume a paused crew execution with human feedback for Human-in-the-Loop (HITL) workflows.<br/>
        /// When a task with `human_input=True` completes, the crew execution pauses and waits for human feedback.<br/>
        /// **IMPORTANT**: You must provide the same webhook URLs (`taskWebhookUrl`, `stepWebhookUrl`, `crewWebhookUrl`)<br/>
        /// that were used in the original kickoff call. Webhook configurations are NOT automatically carried over -<br/>
        /// they must be explicitly provided in the resume request to continue receiving notifications.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.CrewAI.Sdk.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Loud.Technology.CrewAI.Sdk.AutoSDKHttpResponse<global::Loud.Technology.CrewAI.Sdk.ResumeCrewExecutionResponse>> ResumeCrewExecutionAsResponseAsync(

            global::Loud.Technology.CrewAI.Sdk.ResumeCrewExecutionRequest request,
            global::Loud.Technology.CrewAI.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareResumeCrewExecutionArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::Loud.Technology.CrewAI.Sdk.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_ResumeCrewExecutionSecurityRequirements,
                operationName: "ResumeCrewExecutionAsync");

            using var __timeoutCancellationTokenSource = global::Loud.Technology.CrewAI.Sdk.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::Loud.Technology.CrewAI.Sdk.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::Loud.Technology.CrewAI.Sdk.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {

                            var __pathBuilder = new global::Loud.Technology.CrewAI.Sdk.PathBuilder(
                                path: "/resume",
                                baseUri: ResolveBaseUri(
                                servers: s_ResumeCrewExecutionServers,
                                defaultBaseUrl: "https://your-actual-crew-name.crewai.com/"));
                            var __path = __pathBuilder.ToString();
                __path = global::Loud.Technology.CrewAI.Sdk.AutoSDKRequestOptionsSupport.AppendQueryParameters(
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
                global::Loud.Technology.CrewAI.Sdk.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareResumeCrewExecutionRequest(
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
                    await global::Loud.Technology.CrewAI.Sdk.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::Loud.Technology.CrewAI.Sdk.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ResumeCrewExecution",
                                methodName: "ResumeCrewExecutionAsync",
                                pathTemplate: "\"/resume\"",
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
                        var __retryDelay = global::Loud.Technology.CrewAI.Sdk.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: null,
                            attempt: __attempt);
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::Loud.Technology.CrewAI.Sdk.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Loud.Technology.CrewAI.Sdk.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ResumeCrewExecution",
                                methodName: "ResumeCrewExecutionAsync",
                                pathTemplate: "\"/resume\"",
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
                        await global::Loud.Technology.CrewAI.Sdk.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::Loud.Technology.CrewAI.Sdk.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        var __retryDelay = global::Loud.Technology.CrewAI.Sdk.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: __response,
                            attempt: __attempt);
                        await global::Loud.Technology.CrewAI.Sdk.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Loud.Technology.CrewAI.Sdk.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ResumeCrewExecution",
                                methodName: "ResumeCrewExecutionAsync",
                                pathTemplate: "\"/resume\"",
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
                        await global::Loud.Technology.CrewAI.Sdk.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
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
                ProcessResumeCrewExecutionResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Loud.Technology.CrewAI.Sdk.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Loud.Technology.CrewAI.Sdk.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ResumeCrewExecution",
                                methodName: "ResumeCrewExecutionAsync",
                                pathTemplate: "\"/resume\"",
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
                    await global::Loud.Technology.CrewAI.Sdk.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Loud.Technology.CrewAI.Sdk.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ResumeCrewExecution",
                                methodName: "ResumeCrewExecutionAsync",
                                pathTemplate: "\"/resume\"",
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
                            // Invalid request body or execution not in pending state
                            if ((int)__response.StatusCode == 400)
                            {
                                string? __content_400 = null;
                                global::System.Exception? __exception_400 = null;
                                global::Loud.Technology.CrewAI.Sdk.Error? __value_400 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_400 = global::Loud.Technology.CrewAI.Sdk.Error.FromJson(__content_400, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_400 = global::Loud.Technology.CrewAI.Sdk.Error.FromJson(__content_400, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_400 = __ex;
                                }


                                throw global::Loud.Technology.CrewAI.Sdk.ApiException<global::Loud.Technology.CrewAI.Sdk.Error>.Create(
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
                                global::Loud.Technology.CrewAI.Sdk.Error? __value_401 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_401 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_401 = global::Loud.Technology.CrewAI.Sdk.Error.FromJson(__content_401, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_401 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_401 = global::Loud.Technology.CrewAI.Sdk.Error.FromJson(__content_401, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_401 = __ex;
                                }


                                throw global::Loud.Technology.CrewAI.Sdk.ApiException<global::Loud.Technology.CrewAI.Sdk.Error>.Create(
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
                            // Execution ID or Task ID not found
                            if ((int)__response.StatusCode == 404)
                            {
                                string? __content_404 = null;
                                global::System.Exception? __exception_404 = null;
                                global::Loud.Technology.CrewAI.Sdk.Error? __value_404 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_404 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_404 = global::Loud.Technology.CrewAI.Sdk.Error.FromJson(__content_404, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_404 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_404 = global::Loud.Technology.CrewAI.Sdk.Error.FromJson(__content_404, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_404 = __ex;
                                }


                                throw global::Loud.Technology.CrewAI.Sdk.ApiException<global::Loud.Technology.CrewAI.Sdk.Error>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_404 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_404,
                                    responseBody: __content_404,
                                    responseObject: __value_404,
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
                                global::Loud.Technology.CrewAI.Sdk.Error? __value_500 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_500 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_500 = global::Loud.Technology.CrewAI.Sdk.Error.FromJson(__content_500, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_500 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_500 = global::Loud.Technology.CrewAI.Sdk.Error.FromJson(__content_500, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_500 = __ex;
                                }


                                throw global::Loud.Technology.CrewAI.Sdk.ApiException<global::Loud.Technology.CrewAI.Sdk.Error>.Create(
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
                                ProcessResumeCrewExecutionResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::Loud.Technology.CrewAI.Sdk.ResumeCrewExecutionResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::Loud.Technology.CrewAI.Sdk.AutoSDKHttpResponse<global::Loud.Technology.CrewAI.Sdk.ResumeCrewExecutionResponse>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Loud.Technology.CrewAI.Sdk.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    throw global::Loud.Technology.CrewAI.Sdk.ApiException.Create(
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

                                    var __value = await global::Loud.Technology.CrewAI.Sdk.ResumeCrewExecutionResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::Loud.Technology.CrewAI.Sdk.AutoSDKHttpResponse<global::Loud.Technology.CrewAI.Sdk.ResumeCrewExecutionResponse>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Loud.Technology.CrewAI.Sdk.AutoSDKHttpResponse.CreateHeaders(__response),
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

                                    throw global::Loud.Technology.CrewAI.Sdk.ApiException.Create(
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
        /// Resume Crew Execution with Human Feedback<br/>
        /// **📋 Reference Example Only** - *This shows the request format. To test with your actual crew, copy the cURL example and replace the URL + token with your real values.*<br/>
        /// Resume a paused crew execution with human feedback for Human-in-the-Loop (HITL) workflows.<br/>
        /// When a task with `human_input=True` completes, the crew execution pauses and waits for human feedback.<br/>
        /// **IMPORTANT**: You must provide the same webhook URLs (`taskWebhookUrl`, `stepWebhookUrl`, `crewWebhookUrl`)<br/>
        /// that were used in the original kickoff call. Webhook configurations are NOT automatically carried over -<br/>
        /// they must be explicitly provided in the resume request to continue receiving notifications.
        /// </summary>
        /// <param name="executionId">
        /// The unique identifier for the crew execution (from kickoff)<br/>
        /// Example: abcd1234-5678-90ef-ghij-klmnopqrstuv
        /// </param>
        /// <param name="taskId">
        /// The ID of the task that requires human feedback<br/>
        /// Example: research_task
        /// </param>
        /// <param name="humanFeedback">
        /// Your feedback on the task output. This will be incorporated as additional context for subsequent task executions.<br/>
        /// Example: Great research! Please add more details about recent developments in the field.
        /// </param>
        /// <param name="isApprove">
        /// Whether you approve the task output: true = positive feedback (continue), false = negative feedback (retry task)<br/>
        /// Example: true
        /// </param>
        /// <param name="taskWebhookUrl">
        /// Callback URL executed after each task completion. MUST be provided to continue receiving task notifications.<br/>
        /// Example: https://your-server.com/webhooks/task
        /// </param>
        /// <param name="stepWebhookUrl">
        /// Callback URL executed after each agent thought/action. MUST be provided to continue receiving step notifications.<br/>
        /// Example: https://your-server.com/webhooks/step
        /// </param>
        /// <param name="crewWebhookUrl">
        /// Callback URL executed when the crew execution completes. MUST be provided to receive completion notification.<br/>
        /// Example: https://your-server.com/webhooks/crew
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Loud.Technology.CrewAI.Sdk.ResumeCrewExecutionResponse> ResumeCrewExecutionAsync(
            string executionId,
            string taskId,
            string humanFeedback,
            bool isApprove,
            string? taskWebhookUrl = default,
            string? stepWebhookUrl = default,
            string? crewWebhookUrl = default,
            global::Loud.Technology.CrewAI.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Loud.Technology.CrewAI.Sdk.ResumeCrewExecutionRequest
            {
                ExecutionId = executionId,
                TaskId = taskId,
                HumanFeedback = humanFeedback,
                IsApprove = isApprove,
                TaskWebhookUrl = taskWebhookUrl,
                StepWebhookUrl = stepWebhookUrl,
                CrewWebhookUrl = crewWebhookUrl,
            };

            return await ResumeCrewExecutionAsync(
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}