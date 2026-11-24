#!/usr/bin/env bash
set -euo pipefail

readonly AUTOSDK_VERSION="0.34.6"
readonly OPENAPI_URL="https://raw.githubusercontent.com/crewAIInc/crewAI/main/docs/v1.15.9/enterprise-api.base.yaml"
readonly DEFAULT_BASE_URL="https://your-actual-crew-name.crewai.com"

installed_version="$(autosdk --version 2>/dev/null || true)"

if [[ "${installed_version%%+*}" != "${AUTOSDK_VERSION}" ]]; then
  dotnet tool update --global autosdk.cli --version "${AUTOSDK_VERSION}" --allow-downgrade
fi

downloaded_spec="$(mktemp)"
trap 'rm -f "${downloaded_spec}"' EXIT

curl --fail --silent --show-error --location --retry 3 --output "${downloaded_spec}" "${OPENAPI_URL}"
uv run --quiet --no-project --with pyyaml==6.0.2 python -I apply-openapi-overrides.py "${downloaded_spec}" openapi.json

rm -rf Generated

autosdk generate openapi.json \
  --namespace Loud.Technology.CrewAI.Sdk \
  --clientClassName CrewAIClient \
  --targetFramework net10.0 \
  --output Generated \
  --base-url "${DEFAULT_BASE_URL}" \
  --base-url-env CREWAI_BASE_URL \
  --security-scheme Http:Header:Bearer \
  --api-key-env CREWAI_BEARER_TOKEN \
  --exclude-deprecated-operations
