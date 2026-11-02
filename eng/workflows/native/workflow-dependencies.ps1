#!/usr/bin/env pwsh
$ErrorActionPreference = "Stop"
$PSNativeCommandUseErrorActionPreference = $true
Set-StrictMode -Version Latest

# Config
$buildsJsonPath = Join-Path $PSScriptRoot "../builds.json"
$buildsJson = Get-Content -Path $buildsJsonPath -Raw | ConvertFrom-Json
$jobNames = @($buildsJson.native.jobs.PSObject.Properties.Name | Sort-Object -Unique)

# Path filters
Write-Output "workflowFilters<<EOF"
foreach ($jobName in $jobNames) {
  $job = $buildsJson.native.jobs.$jobName

  $paths = @()
  $paths += @($buildsJson.native.sharedDependencies)
  $paths += "$($job.path)/*"
  $paths += @($job.submodules)

  if ("dependencies" -in $job.PSObject.Properties.Name) {
    $paths += @($job.dependencies)
  }

  Write-Output "${jobName}: $(ConvertTo-Json -InputObject $paths -Compress)"
}
Write-Output "EOF"
