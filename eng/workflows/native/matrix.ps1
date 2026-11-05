#!/usr/bin/env pwsh
$ErrorActionPreference = "Stop"
$PSNativeCommandUseErrorActionPreference = $true
Set-StrictMode -Version Latest

# Inputs
$chosenJobs = @(-split $env:CHOSEN_JOBS | Where-Object { $_ })

# Config
$buildsJsonPath = Join-Path $PSScriptRoot "../builds.json"
$buildsJson = Get-Content -Path $buildsJsonPath -Raw | ConvertFrom-Json
$jobNames = @($buildsJson.native.jobs.PSObject.Properties.Name | Sort-Object -Unique)
$repoRoot = Join-Path $PSScriptRoot "../../.."

# Matrix
$matrix = @()
foreach ($chosenJob in $chosenJobs) {
  if (-not ($chosenJob -in $jobNames)) {
    Write-Host Unknown job name: $chosenJob
    continue
  }

  $job = $buildsJson.native.jobs.PSObject.Properties[$chosenJob];
  foreach ($build in $job.Value.builds.PSObject.Properties) {
    # TODO: Unify script extensions
    $script = Get-ChildItem -Path (Join-Path $repoRoot $job.Value.path) -Filter "build-$($build.Name).*" | Select-Object -First 1

    $matrix += [ordered]@{
      job = $job.Name
      os = $build.Value
      runtime = $build.Name

      dir = $job.Value.path
      exec = $script.Name
    }
  }
}

Write-Output "matrix<<EOF"
Write-Output (ConvertTo-Json -InputObject $matrix -Depth 10)
Write-Output "EOF"
