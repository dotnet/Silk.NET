#!/usr/bin/env pwsh
$ErrorActionPreference = "Stop"
$PSNativeCommandUseErrorActionPreference = $true
Set-StrictMode -Version Latest

$os = switch ($true) {
  $IsWindows { "windows" }
  $IsLinux { "linux" }
  $IsMacOS { "macos" }
}

$arch = switch ([System.Runtime.InteropServices.RuntimeInformation]::OSArchitecture) {
  "Arm64" { "aarch64" }
  "X64" { "x86_64" }
}

$outputPath = "$PSScriptRoot/zig"
$archivePath = "$PSScriptRoot/zig.archive"

$json = (Invoke-RestMethod https://ziglang.org/download/index.json)
$latestVersion = $json.PSObject.Properties.Name |
  Where-Object { $_ -match "^(?<major>[\d]+)(\.(?<minor>[\d]+))?(\.(?<patch>[\d]+))$" } |
  ForEach-Object { @{ major = [int]$matches.major; minor = [int]$matches.minor ?? 0; patch = [int]$matches.patch ?? 0; version = $matches.0 } } |
  Sort-Object major, minor, patch |
  Select-Object -last 1
$url = $json.($latestVersion.version)."$arch-$os".tarball

Write-Host "Downloading: $url"
Write-Host "Output path: $outputPath"

Remove-Item -Recurse -Force $outputPath -ErrorAction Ignore
New-Item -ItemType Directory $outputPath
try {
  Invoke-WebRequest -Uri $url -OutFile $archivePath
  if ($IsWindows) {
    [System.IO.Compression.ZipFile]::ExtractToDirectory($archivePath, $outputPath, $true)
  } else {
    tar xf $archivePath --directory $outputPath
  }
} finally {
  Remove-Item $archivePath -ErrorAction Ignore
}

# Move extracted files one level up
$innerPath = (Get-ChildItem -Directory $outputPath).FullName
Get-ChildItem -Force $innerPath | Move-Item -Destination $outputPath
