#!/usr/bin/env pwsh
$ErrorActionPreference = "Stop"
$PSNativeCommandUseErrorActionPreference = $true
Set-StrictMode -Version Latest

# Hardcoded for now
$chosenJobs = @(
  "OpenXR"
)

$buildsJsonPath = Join-Path $PSScriptRoot "builds.json"
$json = Get-Content -Path $buildsJsonPath -Raw | ConvertFrom-Json
