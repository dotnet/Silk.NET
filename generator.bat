if "%1"=="" ( set "AddArgs=generator.json" ) else ( set "AddArgs=" )
dotnet run --configuration Release -p src/Core/Silk.NET.BuildTools/Silk.NET.BuildTools.csproj %AddArgs%%*
