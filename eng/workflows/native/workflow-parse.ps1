#!/usr/bin/env pwsh
$ErrorActionPreference = "Stop"
$PSNativeCommandUseErrorActionPreference = $true
Set-StrictMode -Version Latest

# Inputs
$message = $env:COMMENT_BODY

# Config
$buildsJsonPath = Join-Path $PSScriptRoot "../builds.json"
$buildsJson = Get-Content -Path $buildsJsonPath -Raw | ConvertFrom-Json
$jobNames = @($buildsJson.native.PSObject.Properties.Name | Sort-Object -Unique)

# Path filters
Write-Output "workflow_filters<<EOF"
foreach ($jobName in $jobNames) {
  $job = $buildsJson.native.$jobName
  $paths = @("`"$($job.path)/*`"") + @($job.submodules | ForEach-Object { "`"$_`"" })
  Write-Output "${jobName}: [$($paths -join ', ')]"
}
Write-Output "EOF"

# Jobs
$jobs = @()
foreach ($line in $message -split "`r?`n") {
  $words = @(-split $line)
  if ($words.Count -gt 0 -and $words[0] -eq "/native") {
    foreach ($chosenJob in @($words | Select-Object -Skip 1)) {
      if (-not ($chosenJob -in $jobNames)) {
        Write-Host Unknown job name: $chosenJob
        continue
      }

      $jobs += $chosenJob
    }
  }
}

$jobs = @($jobs | Sort-Object -Unique)
Write-Output "jobs=$jobs"
