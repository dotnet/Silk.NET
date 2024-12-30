
## Requirements
At this time, you need Android SDK for API level 34 and 35 installed to successfully build all projects. This can be installed using `sudo dotnet workload install android` or equivalent.

## Building the solution
Silk.NET 3.0 aims to be compatible with regular `dotnet build` workflows. You can run this command on the solution, or run the Build command in your favorite IDE.

## Regenerating bindings
Bindings can be regenerated using `nuke regenerate-bindings` but this is **not reccommended** as it rebuilds all.

Execute `dotnet run --project sources/SilkTouch/SilkTouch/Silk.NET.SilkTouch.csproj -- generator.json -l Debug -s Microsoft` for a specific generator.json to rebuild a specific binding.
The Silk Touch program has more information, reachable using `dotnet run --project sources/SilkTouch/SilkTouch/Silk.NET.SilkTouch.csproj -- --help`.
