#!/usr/bin/env pwsh
$ErrorActionPreference = "Stop"
$PSNativeCommandUseErrorActionPreference = $true
Set-StrictMode -Version Latest

$buildsJsonPath = Join-Path $PSScriptRoot "../builds.json"
$buildsJson = Get-Content -Path $buildsJsonPath -Raw | ConvertFrom-Json

$scrapeMatrix = @()
$regenerateMatrix = @()

$chosenJobs = $args
foreach ($chosenJob in $chosenJobs) {
  $job = $buildsJson.bindings.$chosenJob

  foreach ($cache in $job.caches.PSObject.Properties) {
    $scrapeMatrix += @{
      job = $chosenJob
      os = $cache.Name
      caches = $cache.Value
      submodules = $job.submodules
    }
  }

  $regenerateMatrix += @{
    job = $chosenJob
    submodules = $job.submodules
  }
}

Write-Output "scrapeMatrix<<EOF"
Write-Output (ConvertTo-Json -InputObject $scrapeMatrix -Depth 10)
Write-Output "EOF"

Write-Output "regenerateMatrix<<EOF"
Write-Output (ConvertTo-Json -InputObject $regenerateMatrix -Depth 10)
Write-Output "EOF"
