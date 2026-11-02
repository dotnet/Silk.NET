#!/usr/bin/env pwsh
$ErrorActionPreference = "Stop"
$PSNativeCommandUseErrorActionPreference = $true
Set-StrictMode -Version Latest

Write-Output "----- Affected comment - No affected, no existing comment (Should have no output) -----"
pwsh -Command { ./native/workflow-affected-comment.ps1 }
Write-Output ""
pwsh -Command { ./bindings/workflow-affected-comment.ps1 }

Write-Output "----- Affected comment - No affected, with existing comment -----"
pwsh -Command { $env:PREVIOUS_COMMENT_ID="123"; ./native/workflow-affected-comment.ps1 }
Write-Output ""
pwsh -Command { $env:PREVIOUS_COMMENT_ID="123"; ./bindings/workflow-affected-comment.ps1 }

Write-Output "----- Affected comment -----"
pwsh -Command { $env:AFFECTED_JOBS="OpenAL-Soft"; ./native/workflow-affected-comment.ps1 }
Write-Output ""
pwsh -Command { $env:AFFECTED_JOBS="OpenAL"; ./bindings/workflow-affected-comment.ps1 }

Write-Output ""
Write-Output "----- Dependencies -----"
pwsh -Command { ./native/workflow-dependencies.ps1 }
Write-Output ""
pwsh -Command { ./bindings/workflow-dependencies.ps1 }

Write-Output ""
Write-Output "----- Parse - No input -----"
pwsh -Command { ./native/workflow-parse.ps1 }
Write-Output ""
pwsh -Command { ./bindings/workflow-parse.ps1 }

Write-Output ""
Write-Output "----- Parse - Wildcard -----"
pwsh -Command { $env:COMMENT_BODY="/native *"; ./native/workflow-parse.ps1 }
Write-Output ""
pwsh -Command { $env:COMMENT_BODY="/bindings *"; ./bindings/workflow-parse.ps1 }

Write-Output ""
Write-Output "----- Parse - Valid -----"
pwsh -Command { $env:COMMENT_BODY="/native OpenAL-Soft SDL"; ./native/workflow-parse.ps1 }
Write-Output ""
pwsh -Command { $env:COMMENT_BODY="/bindings Vulkan OpenXR opengl"; ./bindings/workflow-parse.ps1 }

Write-Output ""
Write-Output "----- Parse - Invalid -----"
pwsh -Command { $env:COMMENT_BODY="/native 123123123"; ./native/workflow-parse.ps1 }
Write-Output ""
pwsh -Command { $env:COMMENT_BODY="/bindings 123123123"; ./bindings/workflow-parse.ps1 }

Write-Output ""
Write-Output "----- Matrix - Valid -----"
pwsh -Command { $env:CHOSEN_JOBS="OpenAL-Soft SDL"; ./native/workflow-matrix.ps1 }
Write-Output ""
pwsh -Command { $env:CHOSEN_JOBS="Vulkan OpenXR opengl"; ./bindings/workflow-matrix.ps1 }

Write-Output ""
Write-Output "----- Matrix - Invalid -----"
pwsh -Command { $env:CHOSEN_JOBS="123123123"; ./native/workflow-matrix.ps1 }
Write-Output ""
pwsh -Command { $env:CHOSEN_JOBS="123123123"; ./bindings/workflow-matrix.ps1 }
