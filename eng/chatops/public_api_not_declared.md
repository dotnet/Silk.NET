![Public API Not Declared](https://img.shields.io/badge/public%20api-not%20declared-red)

Thanks for your contribution adding to the Silk.NET API surface! Note that for manual projects we use the [Public API Analyzer](https://github.com/dotnet/roslyn-analyzers/blob/main/src/PublicApiAnalyzers/PublicApiAnalyzers.Help.md) wherein the entirety of the public API (for manual projects) are tracked in text files, in hope that this analyzer will warn us about breaking changes before we make them.

It looks like you either:
- haven't added all of your new APIs into this text file. Don't worry, it's a simple fix, you can do this automatically by running `nuke declareapi` and pushing the changed `PublicAPI.Unshipped.txt` files.
- have made a breaking change 😮 If this is intentional, make sure you talk to a maintainer!

This comment will automatically update once you've fixed this issue! For more information see:
- [Public API Analyzers Help](https://github.com/dotnet/roslyn-analyzers/blob/main/src/PublicApiAnalyzers/PublicApiAnalyzers.Help.md)
- [Public API Analyzers Diagnostic Descriptions](https://github.com/dotnet/roslyn-analyzers/blob/main/src/PublicApiAnalyzers/Microsoft.CodeAnalysis.PublicApiAnalyzers.md)
- [The GitHub Actions Run That Flagged This](https://github.com/dotnet/Silk.NET/actions/runs/{actionsRun})

(Note to maintainers: this comment won't stop you from merging so if you're fine with this just merge anyway)