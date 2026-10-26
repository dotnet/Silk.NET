#!/usr/bin/env pwsh
$ErrorActionPreference = "Stop"
$PSNativeCommandUseErrorActionPreference = $true
Set-StrictMode -Version Latest

$buildsJsonPath = Join-Path $PSScriptRoot "../builds.json"
$buildsJson = Get-Content -Path $buildsJsonPath -Raw | ConvertFrom-Json

$matrix = @()

$chosenJobs = $args
foreach ($chosenJob in $chosenJobs) {
  $job = $buildsJson.bindings.$chosenJob
  foreach ($cache in $job.caches.PSObject.Properties) {
    $matrix += @{
      os = $cache.Name
      caches = $cache.Value
      submodules = $job.submodules
    }
  }
}

$matrixJson = $matrix | ConvertTo-Json

Write-Host "matrix<<EOF"
Write-Host $matrixJson
Write-Host "EOF"
