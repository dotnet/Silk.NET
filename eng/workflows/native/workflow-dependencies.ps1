#!/usr/bin/env pwsh
$ErrorActionPreference = "Stop"
$PSNativeCommandUseErrorActionPreference = $true
Set-StrictMode -Version Latest

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
