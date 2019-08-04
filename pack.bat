dotnet run --configuration Release -p src/Core/BuildTools/BuildTools.csproj build/binder_scripts/fullrun.json
dotnet pack --configuration Release -o build/output_packages
