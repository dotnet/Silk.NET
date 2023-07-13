[CmdletBinding(PositionalBinding=$false)]
Param(
  [ValidateSet("<auto>", "amd64", "x64", "x86", "arm64", "arm")][string] $architecture = "",
  [switch] $build,
  [switch] $ci,
  [ValidateSet("Debug", "Release")][string] $configuration = "Debug",
  [switch] $help,
  [switch] $pack,
  [switch] $restore,
  [string] $solution = "",
  [switch] $test,
  [ValidateSet("quiet", "minimal", "normal", "detailed", "diagnostic")][string] $verbosity = "minimal",
  [Parameter(ValueFromRemainingArguments=$true)][String[]]$properties
)

Set-StrictMode -Version 2.0
$ErrorActionPreference = "Stop"
[Net.ServicePointManager]::SecurityProtocol = [Net.SecurityProtocolType]::Tls12

function Build() {
  $logFile = Join-Path -Path $LogDir -ChildPath "$configuration\build.binlog"
  & dotnet build -c "$configuration" --no-restore -v "$verbosity" /bl:"$logFile" /err "$properties" "$solution"

  if ($LastExitCode -ne 0) {
    throw "'Build' failed for '$solution'"
  }
}

function Create-Directory([string[]] $Path) {
  if (!(Test-Path -Path $Path)) {
    New-Item -Path $Path -Force -ItemType "Directory" | Out-Null
  }
}

function Help() {
    Write-Host -Object "Common settings:"
    Write-Host -Object "  -configuration <value>  Build configuration (Debug, Release)"
    Write-Host -Object "  -verbosity <value>      Msbuild verbosity (q[uiet], m[inimal], n[ormal], d[etailed], and diag[nostic])"
    Write-Host -Object "  -help                   Print help and exit"
    Write-Host -Object ""
    Write-Host -Object "Actions:"
    Write-Host -Object "  -restore                Restore dependencies"
    Write-Host -Object "  -build                  Build solution"
    Write-Host -Object "  -test                   Run all tests in the solution"
    Write-Host -Object "  -pack                   Package build artifacts"
    Write-Host -Object ""
    Write-Host -Object "Advanced settings:"
    Write-Host -Object "  -solution <value>       Path to solution to build"
    Write-Host -Object "  -ci                     Set when running on CI server"
    Write-Host -Object "  -architecture <value>   Test Architecture (<auto>, amd64, x64, x86, arm64, arm)"
    Write-Host -Object ""
    Write-Host -Object "Command line arguments not listed above are passed through to MSBuild."
    Write-Host -Object "The above arguments can be shortened as much as to be unambiguous (e.g. -co for configuration, -t for test, etc.)."
}

function Pack() {
  $logFile = Join-Path -Path $LogDir -ChildPath "$configuration\pack.binlog"
  & dotnet pack -c "$configuration" --no-build --no-restore -v "$verbosity" /bl:"$logFile" /err "$properties" "$solution"

  if ($LastExitCode -ne 0) {
    throw "'Pack' failed for '$solution'"
  }
}

function Restore() {
  $logFile = Join-Path -Path $LogDir -ChildPath "$configuration\restore.binlog"
  & dotnet restore -v "$verbosity" /bl:"$logFile" /err "$properties" "$solution"

  if ($LastExitCode -ne 0) {
    throw "'Restore' failed for '$solution'"
  }
}

function Test() {
  $logFile = Join-Path -Path $LogDir -ChildPath "$configuration\test.binlog"
  & dotnet test -c "$configuration" --no-build --no-restore -v "$verbosity" /bl:"$logFile" /err "$properties" "$solution"

  if ($LastExitCode -ne 0) {
    throw "'Test' failed for '$solution'"
  }
}

try {
  if ($help) {
    Help
    exit 0
  }

  if ($ci) {
    $build = $true
    $pack = $true
    $restore = $true
    $test = $true

    if ($architecture -eq "") {
      $architecture = "<auto>"
    }
  }

  $RepoRoot = Join-Path -Path $PSScriptRoot -ChildPath ".."

  if ($solution -eq "") {
    $solution = Join-Path -Path $RepoRoot -ChildPath "$NewRepo.sln"
  }

  $ArtifactsDir = Join-Path -Path $RepoRoot -ChildPath "artifacts"
  Create-Directory -Path $ArtifactsDir

  $LogDir = Join-Path -Path $ArtifactsDir -ChildPath "log"
  Create-Directory -Path $LogDir

  if ($architecture -ne "") {
    $DOTNET_SKIP_FIRST_TIME_EXPERIENCE = 1

    $DotNetInstallScript = Join-Path -Path $ArtifactsDir -ChildPath "dotnet-install.ps1"
    Invoke-WebRequest -Uri "https://dot.net/v1/dotnet-install.ps1" -OutFile $DotNetInstallScript -UseBasicParsing

    $DotNetInstallDirectory = Join-Path -Path $ArtifactsDir -ChildPath "dotnet"
    Create-Directory -Path $DotNetInstallDirectory

    & $DotNetInstallScript -Channel release/3.0.1xx -Version latest -InstallDir $DotNetInstallDirectory -Architecture $architecture
    & $DotNetInstallScript -Channel 2.1 -Version latest -InstallDir $DotNetInstallDirectory  -Architecture $architecture -Runtime dotnet

    $env:PATH="$DotNetInstallDirectory;$env:PATH"
  }

  if ($restore) {
    Restore
  }

  if ($build) {
    Build
  }

  if ($test) {
    Test
  }

  if ($pack) {
    Pack
  }
}
catch {
  Write-Host -Object $_
  Write-Host -Object $_.Exception
  Write-Host -Object $_.ScriptStackTrace
  exit 1
}
