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
if ($previousCommentId -eq "0") {
  $previousCommentId = ""
}

if ($previousCommentId) {
  $mustComment = true
}

$notAllReferenced = $false
foreach ($affectedJob in $affectedJobs) {
  if (-not ($affectedJob -in $chosenJobs)) {
    $notAllReferenced = $true
    break;
  }
}

$mustComment = $false
$comment = "## Silk native build"
if ($notAllReferenced) {
  $mustComment = $true
  $comment += "`n`nSome of the native library builds modified in this PR were not referenced in the PR description. Please ensure that the PR description contains ``/native $affectedJobs``. These libraries won't be rebuilt without this being specified. If you believe this is in error, then please write a comment explaining why and ignore this suggestion. This comment will be automatically updated if rectified."
}
else {
  $comment += "`n`nAll native library builds modified in this PR shall attempt to be built by CI."
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

      runtime = $build.Name
      os = $build.Value

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
