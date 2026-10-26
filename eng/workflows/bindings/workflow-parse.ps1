#!/usr/bin/env pwsh
$ErrorActionPreference = "Stop"
$PSNativeCommandUseErrorActionPreference = $true
Set-StrictMode -Version Latest

$command = $args[0]

$jobs = @()
foreach ($line in $command -split "`r?`n") {
  $words = @(-split $line)
  if ($words.Count -gt 0 -and $words[0] -eq "/bindings") {
    $jobs += @($words | Select-Object -Skip 1)
  }
}

$jobs = @($jobs | Sort-Object -Unique)
Write-Output "jobs=$jobs"
