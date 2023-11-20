# SilkTouch

SilkTouch is the Silk.NET project's C# native interoperability code generation stack. It contains useful generators which together generate the majority of the library's codebase.

It does this by centering all parts around a [common symbol layer](./symbol-layer/README.md), which allows other parts to be used in any configuration deemed useful, parts don't have a way other then the symbol layer to exchange data, enforcing interoperability.

Learn more about each individual cornerstone of the SilkTouch Stack:

-   [Symbol Layer](./symbol-layer/README.md)
-   [Emitter](emitter.md)
-   [Scraper](scraper.md)

TODO: Add a link to the original proposal once the proposals folder has been reorganised according to the Software Development Plan.
