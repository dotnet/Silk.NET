#!/usr/bin/env pwsh
$ErrorActionPreference = "Stop"
$PSNativeCommandUseErrorActionPreference = $true
Set-StrictMode -Version Latest

# Inputs
$chosenJobs = $env:CHOSEN_JOBS

# Config
$buildsJsonPath = Join-Path $PSScriptRoot "../builds.json"
$buildsJson = Get-Content -Path $buildsJsonPath -Raw | ConvertFrom-Json
$jobNames = @($buildsJson.bindings.PSObject.Properties.Name | Sort-Object -Unique)

# Matrices
$scrapeMatrix = @()
$regenerateMatrix = @()
foreach ($chosenJob in $chosenJobs) {
  if (-not ($chosenJob -in $jobNames)) {
    Write-Host Unknown job name: $chosenJob
    continue
  }

  $job = $buildsJson.bindings.PSObject.Properties[$chosenJob]

  foreach ($cache in $job.Value.caches.PSObject.Properties) {
    $scrapeMatrix += @{
      job = $job.Name
      os = $cache.Name
      caches = $cache.Value
      submodules = $job.Value.submodules
    }
  }

  $regenerateMatrix += @{
    job = $job.Name
    submodules = $job.Value.submodules
  }
}

Write-Output "scrapeMatrix<<EOF"
Write-Output (ConvertTo-Json -InputObject $scrapeMatrix -Depth 10)
Write-Output "EOF"

Write-Output "regenerateMatrix<<EOF"
Write-Output (ConvertTo-Json -InputObject $regenerateMatrix -Depth 10)
Write-Output "EOF"
