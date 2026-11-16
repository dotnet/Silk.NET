#!/usr/bin/env pwsh
$ErrorActionPreference = "Stop"
$PSNativeCommandUseErrorActionPreference = $true
Set-StrictMode -Version Latest

apt-get install -y default-jdk-headless

curl -fsSL https://dl.google.com/android/cli/latest/linux_x86_64/install.sh | bash
$env:PATH += ":/root/.local/bin"

android sdk list --all

# Note the spaces at the start/end of the regexes
# SDL's build-release.py doesn't support dotted versions (eg: android-37.2), so $androidVersion ignores them for now
$androidVersion = android sdk list --all |
  Where-Object { $_ -match " (?<id>platforms/android-(?<version>(?<major>[\d]+))) " } |
  ForEach-Object { @{ id = $matches.id; major = [int]$matches.major; version = $matches.version } } |
  Sort-Object major |
  Select-Object -last 1

$ndkVersion = android sdk list --all |
  Where-Object { $_ -match " (?<id>ndk/(?<version>(?<major>[\d]+)(\.(?<minor>[\d]+))?(\.(?<patch>[\d]+)))) " } |
  ForEach-Object { @{ id = $matches.id; major = [int]$matches.major; minor = [int]$matches.minor ?? 0; [int]$matches.patch ?? 0; version = $matches.version } } |
  Sort-Object major, minor, patch |
  Select-Object -last 1

android sdk install $androidVersion.id
android sdk install $ndkVersion.id
