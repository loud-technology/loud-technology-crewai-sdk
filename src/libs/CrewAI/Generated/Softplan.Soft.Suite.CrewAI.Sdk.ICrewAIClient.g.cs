
#nullable enable

namespace Softplan.Soft.Suite.CrewAI.Sdk
{
    /// <summary>
    /// REST API for interacting with your deployed CrewAI crews on CrewAI AMP.<br/>
    /// ## Getting Started<br/>
    /// 1. **Find your crew URL**: Get your unique crew URL from the CrewAI AMP dashboard<br/>
    /// 2. **Copy examples**: Use the code examples from each endpoint page as templates<br/>
    /// 3. **Replace placeholders**: Update URLs and tokens with your actual values<br/>
    /// 4. **Test with your tools**: Use cURL, Postman, or your preferred API client<br/>
    /// ## Authentication<br/>
    /// All API requests require a bearer token for authentication. There are two types of tokens:<br/>
    /// - **Bearer Token**: Organization-level token for full crew operations<br/>
    /// - **User Bearer Token**: User-scoped token for individual access with limited permissions<br/>
    /// You can find your bearer tokens in the Status tab of your crew's detail page in the CrewAI AMP dashboard.<br/>
    /// ## Reference Documentation<br/>
    /// This documentation provides comprehensive examples for each endpoint:<br/>
    /// - **Request formats** with all required and optional parameters<br/>
    /// - **Response examples** for success and error scenarios<br/>
    /// - **Code samples** in multiple programming languages<br/>
    /// - **Authentication patterns** with proper Bearer token usage<br/>
    /// Copy the examples and customize them with your actual crew URL and authentication tokens.<br/>
    /// ## Workflow<br/>
    /// 1. **Discover inputs** using `GET /inputs`<br/>
    /// 2. **Start execution** using `POST /kickoff`<br/>
    /// 3. **Monitor progress** using `GET /status/{kickoff_id}`<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface ICrewAIClient : global::System.IDisposable
    {
        /// <summary>
        /// The HttpClient instance.
        /// </summary>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <summary>
        /// The base URL for the API.
        /// </summary>
        public System.Uri? BaseUri { get; }


        /// <summary>
        /// The server options available for this client.
        /// </summary>
        public global::System.Collections.Generic.IReadOnlyList<global::Softplan.Soft.Suite.CrewAI.Sdk.AutoSDKServer> AvailableServers { get; }

        /// <summary>
        /// The currently selected server for this client, if any.
        /// </summary>
        public global::Softplan.Soft.Suite.CrewAI.Sdk.AutoSDKServer? SelectedServer { get; set; }

        /// <summary>
        /// Selects one of the generated server options by id.
        /// </summary>
        public bool TrySelectServer(string serverId);

        /// <summary>
        /// Clears the currently selected server.
        /// </summary>
        public void ClearSelectedServer();

        /// <summary>
        /// The authorizations to use for the requests.
        /// </summary>
        public global::System.Collections.Generic.List<global::Softplan.Soft.Suite.CrewAI.Sdk.EndPointAuthorization> Authorizations { get; }

        /// <summary>
        /// Gets or sets a value indicating whether the response content should be read as a string.
        /// True by default in debug builds, false otherwise.
        /// When false, successful responses are deserialized directly from the response stream for better performance.
        /// Error responses are always read as strings regardless of this setting,
        /// ensuring <see cref="ApiException.ResponseBody"/> is populated.
        /// </summary>
        public bool ReadResponseAsString { get; set; }
        /// <summary>
        /// Client-wide request defaults such as headers, query parameters, retries, and timeout.
        /// </summary>
        public global::Softplan.Soft.Suite.CrewAI.Sdk.AutoSDKClientOptions Options { get; }


        /// <summary>
        ///
        /// </summary>
        global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; }


    }
}