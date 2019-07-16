if "%1"=="" ( set "AddArgs=build/binder_scripts/build.json" ) else ( set "AddArgs=" )
dotnet run --configuration Release -p src/Core/BuildTools/BuildTools.csproj %AddArgs%%*
