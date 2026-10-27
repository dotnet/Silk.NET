#!/usr/bin/env pwsh
$ErrorActionPreference = "Stop"
$PSNativeCommandUseErrorActionPreference = $true
Set-StrictMode -Version Latest

# Inputs
$affectedJobs = @(-split $env:AFFECTED_JOBS | Where-Object { $_ })
$chosenJobs = @(-split $env:CHOSEN_JOBS | Where-Object { $_ })
$existingNoticeId = $env:PR_EXISTING_NOTICE_ID

# Config
$buildsJsonPath = Join-Path $PSScriptRoot "../builds.json"
$buildsJson = Get-Content -Path $buildsJsonPath -Raw | ConvertFrom-Json
$jobNames = @($buildsJson.native.PSObject.Properties.Name | Sort-Object -Unique)

$repoRoot = Join-Path $PSScriptRoot "../../.."

# PR Notice
if ($existingNoticeId -eq "0") {
  $existingNoticeId = ""
}

$notAllReferenced = $false
foreach ($affectedJob in $affectedJobs) {
  if (-not ($affectedJob -in $chosenJobs)) {
    $notAllReferenced = $true
    break;
  }
}

$comment = "**Silk native build**"
if ($notAllReferenced) {
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

  foreach ($job in $buildsJson.native.$chosenJob) {
    foreach ($build in $job.builds.PSObject.Properties) {
      # TODO: Unify script extensions
      $script = Get-ChildItem -Path (Join-Path $repoRoot $job.path) -Filter "build-$($build.Name).*" | Select-Object -First 1

      $matrix += @{
        job = $chosenJob

        runtime = $build.Name
        os = $build.Value

        dir = $job.Path
        exec = $script.Name
      }
    }
  }
}

Write-Output "matrix<<EOF"
Write-Output (ConvertTo-Json -InputObject $matrix -Depth 10)
Write-Output "EOF"

Write-Output "comment<<EOF"
Write-Output $comment
Write-Output "EOF"
