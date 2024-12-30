

## Regenerating bindings
Bindings can be regenerated using `nuke regenerate-bindings` but this is **not reccommended** as it rebuilds all.

Execute `dotnet run --project sources/SilkTouch/SilkTouch/Silk.NET.SilkTouch.csproj -- generator.json -l Debug -s Microsoft` for a specific generator.json to rebuild a specific binding.
The Silk Touch program has more information, reachable using `dotnet run --project sources/SilkTouch/SilkTouch/Silk.NET.SilkTouch.csproj -- --help`.
