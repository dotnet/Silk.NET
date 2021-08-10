# SilkTouch

SilkTouch is the Silk.NET project's C# native interoperability code generation stack. It contains useful generators which together generate the majority of the library's codebase.

It does this by splitting the generation process into multiple phases, all anchored around the concept of a "shared infrastructure" - abstractions for SilkTouch generators which are agnostic of where they're running. Currently the only places SilkTouch can run is in a Roslyn Source Generator and using a `dotnet tool` Command Line Interface, but the idea is so long as no incompatibilities are introduced by each individual phase (such as being locked to .NET 6 instead of .NET Standard 2.0) the generator should be able to run in whatever form factor is desirable - the Shared Infrastructure will provide everything a generator could need for consuming a JSON configuration with C# input code and producing additional generated C# code as a result.

Learn more about each individual cornerstone of the SilkTouch Stack:
- [Shared Infrastructure](shared-infrastructure.md)
- [Emitter](emitter.md)
- [Overloader](overloader.md)
- [Scraper](scraper.md)

TODO: Add a link to the original proposal once the proposals folder has been reorganised according to the Software Development Plan.
