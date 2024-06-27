[CmdletBinding()]
Param(
    [Parameter(Position=0,Mandatory=$false,ValueFromRemainingArguments=$true)]
    [string[]]$BuildArguments
)

Write-Output "PowerShell $($PSVersionTable.PSEdition) version $($PSVersionTable.PSVersion)"
Write-Output "Starting run..."

Set-StrictMode -Version 2.0; $ErrorActionPreference = "Stop"; $ConfirmPreference = "None"; trap { Write-Error $_ -ErrorAction Continue; exit 1 }
$PSScriptRoot = Split-Path $MyInvocation.MyCommand.Path -Parent

###########################################################################
# EXECUTION
###########################################################################

function ExecSafe([scriptblock] $cmd) {
    & $cmd
    if ($LASTEXITCODE) { exit $LASTEXITCODE }
}

#verify if node.js and NPM is installed
if (!(Get-Command "node" -ErrorAction SilentlyContinue) -or !(Get-Command "npm" -ErrorAction SilentlyContinue)) {

    Write-Host "Node.js or NPM not installed correctly!" -ForegroundColor Red
    Write-Host "To continue, please install the Node.js Application:"
    Write-Host "'https://nodejs.org/en/download'" -ForegroundColor Yellow

    Exit 1

}

$env:NPM_EXE = (Get-Command "npm").Path

# Verify if docusaurus is installed
ExecSafe { & npm run docusaurus -v | Out-Null }

if (!$?) {

    Write-Host "Docusaurus package not found"
    Write-Host "Installing Packages. It may take a while..."
    # Install packages
    ExecSafe { & $env:NPM_EXE install }
    Write-Host "Packages Installed."

}

Write-Host "Running website at debug (local) mode..."
ExecSafe { & $env:NPM_EXE run docusaurus start }
