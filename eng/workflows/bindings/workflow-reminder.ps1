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
$comment = "## Silk bindings regeneration reminder"

if ($previousCommentId -eq "0") {
  $previousCommentId = ""
}

if ($previousCommentId) {
  $mustComment = $true
}

if ($affectedJobs.Count -gt 0) {
  $mustComment = $true
  $comment += "`n`nSome of the bindings are likely to be affected by this PR. Please regenerate these by posting a comment with ``/bindings $affectedJobs``.`n`nIf you believe this is in error, then please write a comment explaining why and ignore this reminder."
} else {
  $comment += "`n`nNo bindings are likely to have been affected by this PR."
}

if ($mustComment) {
  Write-Output "comment<<EOF"
  Write-Output $comment
  Write-Output "EOF"
}
