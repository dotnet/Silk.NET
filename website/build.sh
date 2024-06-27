#!/usr/bin/env bash

bash --version 2>&1 | head -n 1

set -eo pipefail
SCRIPT_DIR=$(cd "$( dirname "${BASH_SOURCE[0]}" )" && pwd)

###########################################################################
# EXECUTION
###########################################################################

# Function to execute commands safely
ExecSafe() {
    "$@"
    if [ $? -ne 0 ]; then exit $? fi
}

# Verify if Node.js and NPM are installed
if ! command -v node > /dev/null || ! command -v npm > /dev/null; then

    echo -e "\e[31mNode.js or NPM not installed correctly!\e[0m"
    echo "To continue, please install the Node.js Application:"
    echo -e "\e[33m'https://nodejs.org/en/download'\e[0m"
    exit 1

fi

NPM_EXE=$(command -v npm)

# Verify if Docusaurus is installed
ExecSafe $NPM_EXE run docusaurus -v > /dev/null

if [ $? -ne 0 ]; then
    echo "Docusaurus package not found"
    echo "Installing packages. It may take a while..."
    # Install packages
    ExecSafe $NPM_EXE install
    echo "Packages Installed."
fi

echo "Running website in debug (local) mode..."
ExecSafe $NPM_EXE run docusaurus start
