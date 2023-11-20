# Testing

SilkTouch Generators should be extensively Tested.

## Unit Tests

See also [symbol creation instructions](./symbol-layer/symbols/README.md) for details on symbol unit tests.

### Traits

All Unit & Integration tests should be flagged with the appropriate Category (Emitter, Scraper, Symbols, Integration) using `Trait("Category", "MyCategory")`.
Additionally the following Traits should be applied where appropriate:

-   `Target Language` this should be applied wherever a specific target language is tested (valid Values: `C#`)
-   `Source Language` this should be applied wherever a specific source language is tested (valid Values: `C++`)
-   `Feature` this should be applied wherever a specific feature is covered, ie `Structs`, `Fields`, `Namespaces`, etc. These at the same time are used as Feature Flags (toggled in Silk.NET.SilkTouch.TestFramework). Tests with features that are not yet implemeneted may be created and simply turned off via these feature flags. (valid Values: not tracked. check `tests/Silk.NET.SilkTouch.TestFramework/SilkTouchTestFramework.cs`)

### Symbol Layer

Unit Tests need to be written for all symbols AND the Symbol Visitor. They should cover that the symbol visitor visits these symbols and their children correctly and any functionality the symbols themselves might implement

### Scraper

Tests should be written covering XML -> Symbol conversion. No C(++) -> XML tests are needed as this is the job of clang (sharp).

### Emitter

Tests should be written covering Symbol -> C# conversion.

## Integration Tests

Integration Tests should exist to cover most if not all areas of the generator. These are simply a sanity check & samples of what the generator can do. Unit Tests are still required.
