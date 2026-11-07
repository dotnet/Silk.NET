#!/usr/bin/env pwsh
$ErrorActionPreference = "Stop"
$PSNativeCommandUseErrorActionPreference = $true
Set-StrictMode -Version Latest

# Inputs
$chosenJobs = @(-split $env:CHOSEN_JOBS | Where-Object { $_ })

# Config
$buildsJsonPath = Join-Path $PSScriptRoot "../builds.json"
$buildsJson = Get-Content -Path $buildsJsonPath -Raw | ConvertFrom-Json
$jobNames = @($buildsJson.bindings.jobs.PSObject.Properties.Name | Sort-Object -Unique)

# Matrices
$scrapeMatrix = @()
$regenerateMatrix = @()
foreach ($chosenJob in $chosenJobs) {
  if (-not ($chosenJob -in $jobNames)) {
    Write-Host Unknown job name: $chosenJob
    continue
  }

  $job = $buildsJson.bindings.jobs.PSObject.Properties[$chosenJob]

  foreach ($cache in $job.Value.caches.PSObject.Properties) {
    $scrapeMatrix += [ordered]@{
      job = $job.Name
      os = $cache.Name

      caches = $cache.Value
    }
  }

  $regenerateMatrix += [ordered]@{
    job = $job.Name
  }
}

Write-Output "scrapeMatrix<<EOF"
Write-Output (ConvertTo-Json -InputObject $scrapeMatrix -Depth 10)
Write-Output "EOF"

Write-Output "regenerateMatrix<<EOF"
Write-Output (ConvertTo-Json -InputObject $regenerateMatrix -Depth 10)
Write-Output "EOF"
