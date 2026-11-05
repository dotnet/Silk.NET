#!/usr/bin/env pwsh
$ErrorActionPreference = "Stop"
$PSNativeCommandUseErrorActionPreference = $true
Set-StrictMode -Version Latest

# Dependencies
Write-Output "----- Dependencies -----"
Write-Output "----- Native -----"
pwsh -OutputFormat Text -Command { ./native/dependencies.ps1 }
Write-Output "----- Bindings -----"
pwsh -OutputFormat Text -Command { ./bindings/dependencies.ps1 }

# Matrix
Write-Output "----- Matrix - Valid -----"
Write-Output "----- Native -----"
pwsh -OutputFormat Text -Command { $env:CHOSEN_JOBS="OpenAL-Soft SDL"; ./native/matrix.ps1 }
Write-Output "----- Bindings -----"
pwsh -OutputFormat Text -Command { $env:CHOSEN_JOBS="Vulkan OpenXR opengl"; ./bindings/matrix.ps1 }

Write-Output "----- Matrix - Invalid -----"
Write-Output "----- Native -----"
pwsh -OutputFormat Text -Command { $env:CHOSEN_JOBS="123123123"; ./native/matrix.ps1 }
Write-Output "----- Bindings -----"
pwsh -OutputFormat Text -Command { $env:CHOSEN_JOBS="123123123"; ./bindings/matrix.ps1 }

# Parse
Write-Output "----- Parse - No input -----"
Write-Output "----- Native -----"
pwsh -OutputFormat Text -Command { ./native/parse.ps1 }
Write-Output "----- Bindings -----"
pwsh -OutputFormat Text -Command { ./bindings/parse.ps1 }

Write-Output "----- Parse - Wildcard -----"
Write-Output "----- Native -----"
pwsh -OutputFormat Text -Command { $env:COMMENT_BODY="/native *"; ./native/parse.ps1 }
Write-Output "----- Bindings -----"
pwsh -OutputFormat Text -Command { $env:COMMENT_BODY="/bindings *"; ./bindings/parse.ps1 }

Write-Output "----- Parse - Valid -----"
Write-Output "----- Native -----"
pwsh -OutputFormat Text -Command { $env:COMMENT_BODY="/native OpenAL-Soft SDL"; ./native/parse.ps1 }
Write-Output "----- Bindings -----"
pwsh -OutputFormat Text -Command { $env:COMMENT_BODY="/bindings Vulkan OpenXR opengl"; ./bindings/parse.ps1 }

Write-Output "----- Parse - Invalid -----"
Write-Output "----- Native -----"
pwsh -OutputFormat Text -Command { $env:COMMENT_BODY="/native 123123123"; ./native/parse.ps1 }
Write-Output "----- Bindings -----"
pwsh -OutputFormat Text -Command { $env:COMMENT_BODY="/bindings 123123123"; ./bindings/parse.ps1 }

# Prerequisites
Write-Output "----- Prerequisites -----"
Write-Output "----- Native -----"
pwsh -OutputFormat Text -Command { $env:JOB="SDL"; ./native/prerequisites.ps1 }
Write-Output "----- Bindings -----"
pwsh -OutputFormat Text -Command { $env:JOB="SDL"; ./bindings/prerequisites.ps1 }

# Reminder
Write-Output "----- Reminder comment - No affected, no existing comment (Should have no output) -----"
Write-Output "----- Native -----"
pwsh -OutputFormat Text -Command { ./native/reminder.ps1 }
Write-Output "----- Bindings -----"
pwsh -OutputFormat Text -Command { ./bindings/reminder.ps1 }

Write-Output "----- Reminder comment - Missing affected, with existing comment -----"
Write-Output "----- Native -----"
pwsh -OutputFormat Text -Command { $env:PREVIOUS_COMMENT_ID="123"; ./native/reminder.ps1 }
Write-Output "----- Bindings -----"
pwsh -OutputFormat Text -Command { $env:PREVIOUS_COMMENT_ID="123"; ./bindings/reminder.ps1 }

Write-Output "----- Reminder comment - No affected, with existing comment -----"
Write-Output "----- Native -----"
pwsh -OutputFormat Text -Command { $env:PREVIOUS_COMMENT_ID="123"; $env:AFFECTED_JOBS="[]"; ./native/reminder.ps1 }
Write-Output "----- Bindings -----"
pwsh -OutputFormat Text -Command { $env:PREVIOUS_COMMENT_ID="123"; $env:AFFECTED_JOBS="[]"; ./bindings/reminder.ps1 }

Write-Output "----- Reminder comment - Affected, with existing comment -----"
Write-Output "----- Native -----"
pwsh -OutputFormat Text -Command { $env:PREVIOUS_COMMENT_ID="123"; $env:AFFECTED_JOBS="[`"OpenAL-Soft`"]"; ./native/reminder.ps1 }
Write-Output "----- Bindings -----"
pwsh -OutputFormat Text -Command { $env:PREVIOUS_COMMENT_ID="123"; $env:AFFECTED_JOBS="[`"OpenAL`", `"OpenXR`"]"; ./bindings/reminder.ps1 }
