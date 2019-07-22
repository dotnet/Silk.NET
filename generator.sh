#!/bin/sh

if [ -z "$@" ]; then
    export AddArgs="build/binder_scripts/build.json";
else
    export AddArgs="$@"
fi

dotnet run --configuration Release -p src/Core/BuildTools/BuildTools.csproj $AddArgs
