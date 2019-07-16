#!/bin/sh

if [ -z $1 ]; then
    export AddArgs="build/binder_scripts/build.json";
else
    export AddArgs=$1;
fi

dotnet run -p src/Core/BuildTools/BuildTools.csproj $AddArgs
