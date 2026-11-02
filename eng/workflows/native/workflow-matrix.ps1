#!/usr/bin/env pwsh
$ErrorActionPreference = "Stop"
$PSNativeCommandUseErrorActionPreference = $true
Set-StrictMode -Version Latest

# Inputs
$chosenJobs = @(-split $env:CHOSEN_JOBS | Where-Object { $_ })
$affectedJobs = @(-split $env:AFFECTED_JOBS | Where-Object { $_ })
$previousCommentId = $env:PREVIOUS_COMMENT_ID

# Config
$buildsJsonPath = Join-Path $PSScriptRoot "../builds.json"
$buildsJson = Get-Content -Path $buildsJsonPath -Raw | ConvertFrom-Json
$jobNames = @($buildsJson.native.PSObject.Properties.Name | Sort-Object -Unique)

$repoRoot = Join-Path $PSScriptRoot "../../.."

# PR Comment
$mustComment = $false
$comment = "## Silk native build reminder"

if ($previousCommentId -eq "0") {
  $previousCommentId = ""
}

if ($previousCommentId) {
  $mustComment = $true
}

if ($affectedJobs.Count -gt 0) {
  $mustComment = $true
  $comment += "`n`nSome of the native builds were affected by this PR. Please rebuild these by posting a comment with ``/native $affectedJobs``.`n`nIf you believe this is in error, then please write a comment explaining why and ignore this reminder."
} else {
  $comment += "`n`nNo native builds were affected by this PR."
}

# Matrix
$matrix = @()
foreach ($chosenJob in $chosenJobs) {
  if (-not ($chosenJob -in $jobNames)) {
    Write-Host Unknown job name: $chosenJob
    continue
  }

  $job = $buildsJson.native.PSObject.Properties[$chosenJob];
  foreach ($build in $job.Value.builds.PSObject.Properties) {
    # TODO: Unify script extensions
    $script = Get-ChildItem -Path (Join-Path $repoRoot $job.Value.path) -Filter "build-$($build.Name).*" | Select-Object -First 1

    $matrix += @{
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

if ($mustComment) {
  Write-Output "comment<<EOF"
  Write-Output $comment
  Write-Output "EOF"
}
