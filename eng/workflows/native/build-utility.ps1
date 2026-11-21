#!/usr/bin/env pwsh
$ErrorActionPreference = "Stop"
$PSNativeCommandUseErrorActionPreference = $true
Set-StrictMode -Version Latest

function Validate-ChosenRuntime {
  param([string[]]$supportedRuntimes, [string]$runtime)
  Write-Host "Supported runtimes: $supportedRuntimes"

  if (-not $runtime) {
    Write-Host "Please choose a runtime by providing it as the first argument or setting the CHOSEN_RUNTIME env var"
    exit 1
  }

  Write-Host "Chosen runtime: $runtime"
  if (-not ($runtime -in $supportedRuntimes)) {
    Write-Host "Unknown runtime: $runtime"
    exit 1
  }
}

# Use for all Silk Linux builds
# This ensures a consistent build environment that can be ran locally
# This is especially important for Linux because distros differ drastically when it comes to cross compilation
function Enter-SilkDebianContainer {
  # $runtime - Eg: linux-x64
  # $script - Eg: sources/SDL/Native/build.ps1
  param([string]$runtime, [string]$script)

  # Config
  $repoRoot = Join-Path $PSScriptRoot "../../.."

  if (-not $env:SILKDOTNET_DOCKER) {
    $docker = "docker"
    if (Get-Command podman -ErrorAction Ignore) {
      $docker = "podman"
    }

    $name = "silk-native-$PID"
    try {
      & $docker build -t silkdotnet-builder:latest --platform=linux/amd64 -f $repoRoot/eng/workflows/native/debian/Dockerfile $repoRoot/eng/workflows
      & $docker run --rm --init --name $name -e SILKDOTNET_DOCKER=1 -e CHOSEN_RUNTIME=$runtime -v "${repoRoot}:/data/repo" silkdotnet-builder:latest bash -c "/data/repo/$script"
    } finally {
      & $docker rm -f $name
    }

    exit 0
  }

  . $repoRoot/eng/workflows/dependencies/initialize-env.ps1
}
