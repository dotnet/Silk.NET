#!/usr/bin/env pwsh
$ErrorActionPreference = "Stop"
$PSNativeCommandUseErrorActionPreference = $true
Set-StrictMode -Version Latest

apt-get install -y default-jdk-headless

curl -fsSL https://dl.google.com/android/cli/latest/linux_x86_64/install.sh | bash
$env:PATH += ":/root/.local/bin"

android sdk list --all

$androidVersion = android sdk list --all |
  Where-Object { $_ -match "platforms/android-(?<version>(?<major>[\d]+)(\.(?<minor>[\d]+)))" } |
  ForEach-Object { @{ id = $matches.0; major = [int]$matches.major; minor = [int]$matches.minor ?? 0; version = $matches.version } } |
  Sort-Object major, minor |
  Select-Object -last 1

$ndkVersion = android sdk list --all |
  Where-Object { $_ -match "ndk/(?<version>(?<major>[\d]+)(\.(?<minor>[\d]+))?(\.(?<patch>[\d]+)))" } |
  ForEach-Object { @{ id = $matches.0; major = [int]$matches.major; minor = [int]$matches.minor ?? 0, [int]$matches.patch ?? 0; version = $matches.version } } |
  Sort-Object major, minor, patch |
  Select-Object -last 1

android sdk install $androidVersion.id
android sdk install $ndkVersion.id
