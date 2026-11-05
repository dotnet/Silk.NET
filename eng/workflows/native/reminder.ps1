#!/usr/bin/env pwsh
$ErrorActionPreference = "Stop"
$PSNativeCommandUseErrorActionPreference = $true
Set-StrictMode -Version Latest

# Inputs
$previousCommentId = $env:PREVIOUS_COMMENT_ID

$affectedJobs = @()
try {
  $affectedJobs = @(-split (ConvertFrom-Json $env:AFFECTED_JOBS) | Where-Object { $_ })
}
catch {}

# PR Comment
$mustComment = $false
$comment = "## Silk.NET native build reminder"

if ($previousCommentId -eq "0") {
  $previousCommentId = ""
}

if ($previousCommentId) {
  $mustComment = $true
}

if ($affectedJobs.Count -gt 0) {
  $mustComment = $true
  $comment += "`n`nSome of the native builds are likely affected by this PR. \`nPlease rebuild these by posting a comment with ``/native $affectedJobs``. \`nYou must have push permissions to run the command.`n`nIf you believe this to be in error, then please write a comment explaining why and ignore this reminder."
} else {
  $comment += "`n`nNo native builds are likely to have been affected by this PR."
}

if ($mustComment) {
  Write-Output "comment<<EOF"
  Write-Output $comment
  Write-Output "EOF"
}
