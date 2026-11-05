#!/usr/bin/env pwsh
$ErrorActionPreference = "Stop"
$PSNativeCommandUseErrorActionPreference = $true
Set-StrictMode -Version Latest

$output = ./test-internal.ps1 *>&1
($output | Out-String) > "test-snapshot.txt"
