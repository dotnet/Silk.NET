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
    $dir = $job.Value.path
    $runtime = $build.Name

    # $outputs is passed to actions/upload-artifact, which expects globs
    $outputs = @()
    if ($runtime -like "*-*") {
      $outputs += "$dir/runtimes/$runtime/**/*"
    } else {
      $outputs += "$dir/runtimes/$runtime*/**/*"
    }

    $outputs += "$dir/lib/*$runtime*/**/*"
    $outputs += "$dir/*$runtime*/**/*"

    $matrix += [ordered]@{
      job = $job.Name
      runner = $build.Value.runner
      runtime = $runtime

      dir = $dir
      outputs = $outputs -join "`n"
    }
  }
}

Write-Output "matrix<<EOF"
Write-Output (ConvertTo-Json -InputObject $matrix -Depth 10)
Write-Output "EOF"
