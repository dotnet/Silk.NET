# $ErrorActionPreference = "Stop"
# $PSNativeCommandUseErrorActionPreference = $true
# Set-StrictMode -Version Latest
#
# # Input
# $apply = $args[0] -eq "--apply"
#
# # Config
# $buildsJsonPath = Join-Path $PSScriptRoot "../builds.json"
# $buildsJson = Get-Content -Path $buildsJsonPath -Raw | ConvertFrom-Json
#
# # Submodules
# $submodules = @($env:SUBMODULES | ConvertFrom-Json)
# if ($submodules.Count -gt 0) {
#   if ($apply) {
#     git submodule update --init --recursive --depth 1 $submodules
#   }
# }
