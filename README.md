<div align="center">
  <img src="assets/nuget-icon.png" alt="CrewAI AMP .NET SDK" width="112" />
  <h1>CrewAI AMP .NET SDK</h1>
  <p><strong>A .NET client for the API of a crew or flow deployed on CrewAI AMP.</strong></p>
  <p>Generated C# operations from the CrewAI AMP OpenAPI specification. You get typed calls to read the inputs, start an execution, poll its status, and resume it with human feedback.</p>

  [![CI](https://github.com/softplan/softplan-soft-suite-crewai-sdk-dotnet/actions/workflows/dotnet.yml/badge.svg?branch=main)](https://github.com/softplan/softplan-soft-suite-crewai-sdk-dotnet/actions/workflows/dotnet.yml)
  [![License: MIT](https://img.shields.io/badge/license-MIT-blue.svg)](LICENSE)
  [![.NET 10](https://img.shields.io/badge/.NET-10.0-512BD4?logo=dotnet)](https://dotnet.microsoft.com/)
</div>

---

> [!NOTE]
> This community SDK is maintained by Softplan and generated from the CrewAI AMP OpenAPI specification. It is not an official CrewAI SDK.

## What you get

- **Four typed operations.** `CrewAIClient` has `GetRequiredInputsAsync`, `StartCrewExecutionAsync`, `GetExecutionStatusAsync`, and `ResumeCrewExecutionAsync`. Each supports cancellation and has an `...AsResponseAsync` variant that returns the HTTP response with the model. The start and resume operations also take their fields as plain arguments.
- **Bearer authentication.** The constructor takes your bearer token and sends it on every request.
- **One base URL per deployment.** Every crew or flow has its own URL, so you pass the URL of the deployment you call.
- **Source-generated serialization.** The models use `System.Text.Json` source generation, and the project builds with the trim and AOT analyzers on.
- **Pinned spec.** `generate.sh` regenerates the whole client from the CrewAI v1.15.9 specification.
- **Release-ready packages.** MinVer derives package versions from Git tags, Source Link connects packages to source, and symbol packages improve debugging.

## Requirements

- [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0) or later to build
- The URL of a crew or flow deployed on CrewAI AMP
- The Bearer token or User Bearer token of that deployment. The specification says you find both in the Status tab of the crew's detail page in the CrewAI AMP dashboard.

The default base URL in the client, `https://your-actual-crew-name.crewai.com`, is the placeholder from the specification. Pass your own URL as `baseUri`.

## Install

### NuGet.org

```bash
dotnet add package CrewAI
```

### GitHub Packages

The same package is published to the [Softplan GitHub Packages registry](https://github.com/orgs/softplan/packages?repo_name=softplan-soft-suite-crewai-sdk-dotnet). GitHub requires authentication to download NuGet packages.

Create a [personal access token (classic)](https://github.com/settings/tokens) with the `read:packages` scope, then register the source once:

```bash
export GITHUB_PACKAGES_USER="your-github-username"
export GITHUB_PACKAGES_TOKEN="ghp_your-read-packages-token"

dotnet nuget add source \
  --username "$GITHUB_PACKAGES_USER" \
  --password "$GITHUB_PACKAGES_TOKEN" \
  --store-password-in-clear-text \
  --name softplan \
  "https://nuget.pkg.github.com/softplan/index.json"

dotnet add package CrewAI \
  --source "https://nuget.pkg.github.com/softplan/index.json"
```

Use a token limited to `read:packages`, never commit it, and authorize it for the organization if Softplan enforces SAML SSO.

## Quick start

This program reads the inputs the crew expects, starts an execution, and polls its status until it finishes.

```csharp
using Softplan.Soft.Suite.CrewAI.Sdk;

using var client = new CrewAIClient(
    Environment.GetEnvironmentVariable("CREWAI_BEARER_TOKEN")!,
    baseUri: new Uri(Environment.GetEnvironmentVariable("CREWAI_BASE_URL")!));

var required = await client.GetRequiredInputsAsync();
Console.WriteLine(string.Join(", ", required.Inputs ?? []));

var kickoff = await client.StartCrewExecutionAsync(
    new Dictionary<string, string>
    {
        ["topic"] = "AI agents",
        ["audience"] = "engineers",
    });

while (true)
{
    var status = await client.GetExecutionStatusAsync(kickoff.KickoffId!);
    if (status.State is "SUCCESS")
    {
        Console.WriteLine(status.Result);
        break;
    }

    if (status.State is "FAILED" or "FAILURE")
    {
        throw new InvalidOperationException(status.Status);
    }

    await Task.Delay(TimeSpan.FromSeconds(5));
}
```

Kickoff inputs are a `Dictionary<string, string>`, as the specification declares. The input names come from `GetRequiredInputsAsync`.

To receive callbacks instead of polling, set `TaskWebhookUrl`, `StepWebhookUrl`, or `CrewWebhookUrl` on `StartCrewExecutionRequest`. To attach metadata, set `Meta`.

### Resume an execution that waits for human feedback

A task with `human_input=True` pauses the execution. Resume it with the `execution_id` that the kickoff returned and the `task_id` of the paused task:

```csharp
var resumed = await client.ResumeCrewExecutionAsync(
    new ResumeCrewExecutionRequest
    {
        ExecutionId = kickoff.KickoffId!,
        TaskId = "research_task",
        HumanFeedback = "Add more detail on recent developments.",
        IsApprove = false,
        CrewWebhookUrl = "https://example.com/webhooks/crew",
    });
```

`IsApprove = true` continues the execution, and `false` retries the task with your feedback. The specification states that webhook configuration does not carry over from the kickoff, so pass the same webhook URLs again to keep receiving notifications.

### Execution states

`ExecutionStatus.State` is a string. Semantic Kernel's CrewAI plugin lists the states `PENDING`, `STARTED`, `RUNNING`, `SUCCESS`, `FAILED`, `FAILURE`, and `NOT FOUND`. Compare against the terminal states you care about and keep polling on any other value, so a state that CrewAI adds later does not end your loop.

`Result` holds the final output as a string when the state is `SUCCESS`. `Status` is a human-readable message that carries the error on a failed execution. `LastStep` is the last step the crew or flow ran, as a `JsonElement`.

### Errors

A non-success response throws `ApiException`. Read `StatusCode` and `ResponseBody`. A declared error body surfaces as `ApiException<Error>`, which derives from `ApiException`.

## Configuration

| Variable | Read by | Purpose |
|---|---|---|
| `CREWAI_BEARER_TOKEN` | `CrewAIClient.CreateFromEnvironment()`, live test | Bearer token of the deployment |
| `CREWAI_BASE_URL` | `CrewAIClient.CreateFromEnvironment()`, live test | URL of the deployed crew or flow |

The constructor does not read the environment. Your application passes the token and the `baseUri`, or calls `CreateFromEnvironment()`.

To control proxies, timeouts, or telemetry, pass your own `HttpClient`:

```csharp
using var client = new CrewAIClient(
    token,
    httpClient: new HttpClient(new SocketsHttpHandler { PooledConnectionLifetime = TimeSpan.FromMinutes(5) }),
    baseUri: new Uri("https://my-crew.crewai.com"));
```

## Spec overrides

`generate.sh` does not feed the published specification to AutoSDK unchanged. `apply-openapi-overrides.py` converts the YAML to `openapi.json` and makes two changes.

- **It replaces the schema of `GET /status/{kickoff_id}`.** The published specification describes a `oneOf` of three bodies, with `status` set to `running`, `completed`, or `error`. That does not match the live API. CrewAI's own client, [`invoke_crewai_automation_tool.py`](https://github.com/crewAIInc/crewAI/blob/main/lib/crewai-tools/src/crewai_tools/tools/invoke_crewai_automation_tool/invoke_crewai_automation_tool.py), reads `state` and a string `result`. Semantic Kernel's CrewAI plugin ([`CrewAIStatusResponse.cs`](https://github.com/microsoft/semantic-kernel/blob/main/dotnet/src/Plugins/Plugins.AI/CrewAI/Models/CrewAIStatusResponse.cs)) reads `state`, `result`, and `last_step`. The override defines one `ExecutionStatus` with `state`, `status`, `result`, and `last_step`. It keeps `state` a string, because AutoSDK maps an enum value it does not know to the first member, and a new terminal state from CrewAI would then read as the first state and keep your polling loop running.
- **It drops `format: uuid` from the kickoff id.** The id is an opaque string, and the specification's own example, `abcd1234-5678-90ef-ghij-klmnopqrstuv`, is not a valid UUID. The override removes the format from the `kickoff_id` path parameter, the `kickoff_id` response property, and the `execution_id` request property.

## Regenerate the SDK

The project follows AutoSDK's [First SDK](https://autosdk.net/docs/getting-started/first-sdk) layout. `generate.sh` is the single source of truth for generation. It needs `curl`, [`uv`](https://docs.astral.sh/uv/), and the .NET SDK.

```bash
cd src/libs/CrewAI
./generate.sh
```

The script installs AutoSDK 0.34.6 unless that version is already installed. It then downloads the `docs/v1.15.9/enterprise-api.base.yaml` specification from the CrewAI repository, writes the overridden `openapi.json`, replaces `Generated/`, and creates a .NET 10 client with Bearer authentication. `uv` runs the override script with PyYAML 6.0.2. Two runs produce identical files.

The URL is pinned to v1.15.9, so no scheduled workflow regenerates the client. To move to another CrewAI release, change `OPENAPI_URL` in `generate.sh`, regenerate, and check whether the status override still applies.

```text
Softplan.Soft.Suite.CrewAI.Sdk.slnx
├── src/
│   ├── libs/CrewAI/
│   │   ├── Softplan.Soft.Suite.CrewAI.Sdk.csproj
│   │   ├── openapi.json
│   │   ├── generate.sh
│   │   ├── apply-openapi-overrides.py
│   │   └── Generated/
│   └── tests/IntegrationTests/
└── .github/workflows/
```

## Build and test

```bash
dotnet restore Softplan.Soft.Suite.CrewAI.Sdk.slnx
dotnet build Softplan.Soft.Suite.CrewAI.Sdk.slnx --configuration Release --no-restore
dotnet test Softplan.Soft.Suite.CrewAI.Sdk.slnx --configuration Release --no-build
```

The contract tests run without a network. They record the HTTP request and check the default base URL, the Bearer header, the path, and the JSON of each of the four operations, including a status body with a state the specification never listed. The live test calls `GetRequiredInputsAsync` only, which reads and starts nothing. It runs when `CREWAI_BASE_URL` and `CREWAI_BEARER_TOKEN` are set. Otherwise MSTest marks it inconclusive.

## Versioning and releases

Packages use [MinVer](https://github.com/adamralph/minver). A stable version comes directly from a semantic Git tag:

```bash
git tag v1.0.0
git push origin v1.0.0
```

The CI workflow restores, builds, tests, and packs in `Release`. Version tags publish the same `.nupkg` to both NuGet.org and the Softplan GitHub Packages registry. GitHub Packages uses the workflow `GITHUB_TOKEN`. NuGet.org uses Trusted Publishing, which exchanges a GitHub OIDC token for a short-lived API key. For that, create the `nuget-org` environment in the repository settings, set the `NUGET_USER` Actions variable to your NuGet.org profile username, and add a Trusted Publishing policy for this repository on NuGet.org. Untagged builds are retained as artifacts and are not published.

## Contributing

1. Fork the repository and create a focused branch.
2. If the API changed, edit `generate.sh` or `apply-openapi-overrides.py` rather than the generated C# files.
3. Regenerate, then run the Release build and test commands above.
4. Open a pull request describing the upstream spec change and behavior impact.

Generated files are intentionally committed so package builds are deterministic and consumers can inspect the exact API surface.

## Security and support

- Report SDK bugs through [GitHub Issues](https://github.com/softplan/softplan-soft-suite-crewai-sdk-dotnet/issues).
- For CrewAI AMP behavior, tokens, or access, contact CrewAI through the channels it provides.
- Do not disclose bearer tokens or crew URLs in public issues.

## License

Licensed under the [MIT License](LICENSE). CrewAI AMP is a separate service and is subject to its own terms.
