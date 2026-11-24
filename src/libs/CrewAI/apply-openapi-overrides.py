#!/usr/bin/env python3
"""Convert CrewAI's published AMP OpenAPI document to JSON and align it with the live API."""

from __future__ import annotations

import json
import sys
from pathlib import Path
from typing import Any

import yaml


def execution_status_schema() -> dict[str, Any]:
    # The published oneOf (status: running/completed/error) does not match the live API. CrewAI's own
    # client (crewai-tools InvokeCrewAIAutomationTool) and Semantic Kernel's CrewAI plugin both read
    # `state` and a string `result`. `state` stays a string because AutoSDK maps an unknown enum value
    # to the first member, which would turn a new terminal state into an endless poll.
    return {
        "type": "object",
        "properties": {
            "state": {
                "type": "string",
                "description": "Execution state, such as PENDING, STARTED, RUNNING, SUCCESS, FAILED, FAILURE or NOT FOUND.",
            },
            "status": {
                "type": "string",
                "description": "Human-readable status. On a failed execution it carries the error message.",
            },
            "result": {
                "type": "string",
                "description": "Final output of the crew or flow, set when the state is SUCCESS.",
            },
            "last_step": {
                "type": "object",
                "additionalProperties": True,
                "description": "Last step the crew or flow executed.",
            },
        },
    }


def drop_uuid_format(schema: dict[str, Any]) -> None:
    # Kickoff ids are opaque strings; the spec's own example is not a valid UUID.
    if schema.get("format") == "uuid":
        del schema["format"]


def apply_overrides(spec: dict[str, Any]) -> None:
    schemas = spec["components"]["schemas"]
    for name in ("ExecutionRunning", "ExecutionCompleted", "ExecutionError", "TaskResult"):
        schemas.pop(name, None)
    schemas["ExecutionStatus"] = execution_status_schema()

    paths = spec["paths"]
    status = paths["/status/{kickoff_id}"]["get"]
    status["responses"]["200"]["content"]["application/json"] = {
        "schema": {"$ref": "#/components/schemas/ExecutionStatus"}
    }
    for parameter in status["parameters"]:
        drop_uuid_format(parameter["schema"])

    kickoff = paths["/kickoff"]["post"]["responses"]["200"]["content"]["application/json"]["schema"]
    drop_uuid_format(kickoff["properties"]["kickoff_id"])

    resume = paths["/resume"]["post"]["requestBody"]["content"]["application/json"]["schema"]
    drop_uuid_format(resume["properties"]["execution_id"])


def main() -> None:
    if len(sys.argv) != 3:
        raise SystemExit(f"usage: {Path(sys.argv[0]).name} OPENAPI_YAML OPENAPI_JSON")

    spec = yaml.safe_load(Path(sys.argv[1]).read_text(encoding="utf-8"))
    apply_overrides(spec)
    Path(sys.argv[2]).write_text(json.dumps(spec, ensure_ascii=False, indent=2) + "\n", encoding="utf-8")


if __name__ == "__main__":
    main()
