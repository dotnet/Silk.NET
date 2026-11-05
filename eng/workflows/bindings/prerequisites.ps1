$ErrorActionPreference = "Stop"
$PSNativeCommandUseErrorActionPreference = $true
Set-StrictMode -Version Latest

# Input
$apply = $args -eq "--apply"
$chosenJob = $env:JOB

# Config
$buildsJsonPath = Join-Path $PSScriptRoot "../builds.json"
$buildsJson = Get-Content -Path $buildsJsonPath -Raw | ConvertFrom-Json
$jobNames = @($buildsJson.bindings.jobs.PSObject.Properties.Name | Sort-Object -Unique)

# Log if dry run
if (-not $apply) {
  Write-Host "Running as a dry run. Please use the --apply option if you want the prerequisites to be applied"
}

# Job
if (-not ($chosenJob -in $jobNames)) {
  Write-Host Unknown job name: $chosenJob
  exit 1
}

$job = $buildsJson.bindings.jobs.PSObject.Properties[$chosenJob].Value

# Submodules
$submodules = $job.submodules
if ($submodules.Count -gt 0) {
  Write-Host "Initializing submodules: $($submodules -join ", ")"
  if ($apply) {
    git submodule update --init --recursive --depth 1 $submodules
  }
}

# .NET
Write-Host "Restoring .NET and its workloads"
if ($apply) {
  dotnet workload restore
  dotnet restore
}
