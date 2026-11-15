#!/usr/bin/env pwsh
$ErrorActionPreference = "Stop"
$PSNativeCommandUseErrorActionPreference = $true
Set-StrictMode -Version Latest

Push-Location $PSScriptRoot
try {
  # Config
  $submodulePath = Join-Path $PSScriptRoot "../../../eng/submodules/openal-soft"
  $versionFile = Join-Path $PSScriptRoot "version.txt"

  # Submodule
  if (-not (Test-Path (Join-Path $submodulePath "CMakeLists.txt"))) {
    git submodule update --init --recursive --depth 1 $submodulePath
  }

  # Update
  Push-Location $submodulePath
  try {
    git fetch --tags

    $latest = @(-split (git for-each-ref --sort=-committerdate --count=1 --contains=HEAD "refs/tags/[0-9]*"))
    if (($latest.Count -eq 0 -or -not $latest[0]) -and (Get-Content $versionFile -Raw) -like "*-*") {
      git fetch origin master
      $latest = @(-split "FETCH_HEAD")
    }

    if ($latest.Count -gt 0 -and $latest[0]) {
      git checkout $latest[0]
      (git describe --tags --match "[0-9]*") -replace "-[0-9]+\-", "-" > $versionFile
    }
  } finally {
    Pop-Location
  }
  git add $submodulePath $versionFile
} finally {
  Pop-Location
}
