#!/usr/bin/env pwsh
$ErrorActionPreference = "Stop"
$PSNativeCommandUseErrorActionPreference = $true
Set-StrictMode -Version Latest

Write-Output "----- Reminder comment - No affected, no existing comment (Should have no output) -----"
Write-Output "----- Native -----"
pwsh -Command { ./native/workflow-reminder.ps1 }
Write-Output "----- Bindings -----"
pwsh -Command { ./bindings/workflow-reminder.ps1 }

Write-Output "----- Reminder comment - Missing affected, with existing comment -----"
Write-Output "----- Native -----"
pwsh -Command { $env:PREVIOUS_COMMENT_ID="123"; ./native/workflow-reminder.ps1 }
Write-Output "----- Bindings -----"
pwsh -Command { $env:PREVIOUS_COMMENT_ID="123"; ./bindings/workflow-reminder.ps1 }

Write-Output "----- Reminder comment - No affected, with existing comment -----"
Write-Output "----- Native -----"
pwsh -Command { $env:PREVIOUS_COMMENT_ID="123"; $env:AFFECTED_JOBS="[]"; ./native/workflow-reminder.ps1 }
Write-Output "----- Bindings -----"
pwsh -Command { $env:PREVIOUS_COMMENT_ID="123"; $env:AFFECTED_JOBS="[]"; ./bindings/workflow-reminder.ps1 }

Write-Output "----- Reminder comment - Affected, with existing comment -----"
Write-Output "----- Native -----"
pwsh -Command { $env:PREVIOUS_COMMENT_ID="123"; $env:AFFECTED_JOBS="[`"OpenAL-Soft`"]"; ./native/workflow-reminder.ps1 }
Write-Output "----- Bindings -----"
pwsh -Command { $env:PREVIOUS_COMMENT_ID="123"; $env:AFFECTED_JOBS="[`"OpenAL`", `"OpenXR`"]"; ./bindings/workflow-reminder.ps1 }

Write-Output "----- Dependencies -----"
Write-Output "----- Native -----"
pwsh -Command { ./native/workflow-dependencies.ps1 }
Write-Output "----- Bindings -----"
pwsh -Command { ./bindings/workflow-dependencies.ps1 }

Write-Output "----- Parse - No input -----"
Write-Output "----- Native -----"
pwsh -Command { ./native/workflow-parse.ps1 }
Write-Output "----- Bindings -----"
pwsh -Command { ./bindings/workflow-parse.ps1 }

Write-Output "----- Parse - Wildcard -----"
Write-Output "----- Native -----"
pwsh -Command { $env:COMMENT_BODY="/native *"; ./native/workflow-parse.ps1 }
Write-Output "----- Bindings -----"
pwsh -Command { $env:COMMENT_BODY="/bindings *"; ./bindings/workflow-parse.ps1 }

Write-Output "----- Parse - Valid -----"
Write-Output "----- Native -----"
pwsh -Command { $env:COMMENT_BODY="/native OpenAL-Soft SDL"; ./native/workflow-parse.ps1 }
Write-Output "----- Bindings -----"
pwsh -Command { $env:COMMENT_BODY="/bindings Vulkan OpenXR opengl"; ./bindings/workflow-parse.ps1 }

Write-Output "----- Parse - Invalid -----"
Write-Output "----- Native -----"
pwsh -Command { $env:COMMENT_BODY="/native 123123123"; ./native/workflow-parse.ps1 }
Write-Output "----- Bindings -----"
pwsh -Command { $env:COMMENT_BODY="/bindings 123123123"; ./bindings/workflow-parse.ps1 }

Write-Output "----- Matrix - Valid -----"
Write-Output "----- Native -----"
pwsh -Command { $env:CHOSEN_JOBS="OpenAL-Soft SDL"; ./native/workflow-matrix.ps1 }
Write-Output "----- Bindings -----"
pwsh -Command { $env:CHOSEN_JOBS="Vulkan OpenXR opengl"; ./bindings/workflow-matrix.ps1 }

Write-Output "----- Matrix - Invalid -----"
Write-Output "----- Native -----"
pwsh -Command { $env:CHOSEN_JOBS="123123123"; ./native/workflow-matrix.ps1 }
Write-Output "----- Bindings -----"
pwsh -Command { $env:CHOSEN_JOBS="123123123"; ./bindings/workflow-matrix.ps1 }
