#!/usr/bin/env pwsh
$ErrorActionPreference = "Stop"
$PSNativeCommandUseErrorActionPreference = $true
Set-StrictMode -Version Latest

$output = ./test-internal *>&1
($output | Out-String) > "test-snapshot.txt"
