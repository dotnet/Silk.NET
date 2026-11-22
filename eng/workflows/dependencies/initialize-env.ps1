#!/usr/bin/env pwsh
$ErrorActionPreference = "Stop"
$PSNativeCommandUseErrorActionPreference = $true
Set-StrictMode -Version Latest

# This is intended to be used within the Debian container
$env:ANDROID_NDK_HOME = (Resolve-Path $env:ANDROID_HOME/ndk/*).Path
