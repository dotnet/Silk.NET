#!/usr/bin/env pwsh
$ErrorActionPreference = "Stop"
$PSNativeCommandUseErrorActionPreference = $true
Set-StrictMode -Version Latest

# Config
$buildsJsonPath = Join-Path $PSScriptRoot "../builds.json"
$buildsJson = Get-Content -Path $buildsJsonPath -Raw | ConvertFrom-Json
$jobNames = @($buildsJson.bindings.jobs.PSObject.Properties.Name | Sort-Object -Unique)

# Path filters
Write-Output "workflowFilters<<EOF"
foreach ($jobName in $jobNames) {
  $job = $buildsJson.bindings.jobs.$jobName

  $paths = @()
  $paths += @($buildsJson.bindings.sharedDependencies)
  $paths += @($job.submodules)

  if ("dependencies" -in $job.PSObject.Properties.Name) {
    $paths += @($job.dependencies)
  }

  Write-Output "${jobName}: $(ConvertTo-Json -InputObject $paths -Compress)"
}
Write-Output "EOF"
