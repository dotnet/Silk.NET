#!/bin/sh

if [ -z "$@" ]; then
    export AddArgs="generator.json";
else
    export AddArgs="$@"
fi

dotnet run --configuration Release -p src/Core/BuildTools/BuildTools.csproj $AddArgs
