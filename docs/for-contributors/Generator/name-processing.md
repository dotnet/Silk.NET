# Name Processing and Prettification

A primary goal of Silk.NET is to provide a first-class .NET experience for the bindings that it provides.

One such way that Silk.NET achieves this is by transforming native identifiers into identifiers that follow the
Microsoft Framework Design guidelines. This is the process referred to as "prettification".
Of these guidelines, most notable are the guidelines relating to capitalization.

Naming Guidelines: https://learn.microsoft.com/en-us/dotnet/standard/design-guidelines/naming-guidelines

Capitalization Conventions: https://learn.microsoft.com/en-us/dotnet/standard/design-guidelines/capitalization-conventions

## High-Level Overview

This section explains how names flow through the SilkTouch generator pipeline.
- For more information about the pipeline itself, please see the [Generator Mods](generator-mods.md) documentation.

`vkCreateSwapchainKHR` from Vulkan is used here as an example.

1. Names enter the pipeline from native sources (eg: C header files).
   - Eg: `vkCreateSwapchainKHR` as input from Vulkan during the `ClangScraper` mod.

2. Mods add metadata to each name as C# attributes.
   - `[NativeName("vkCreateSwapchainKHR")]` from `MarkNativeNames`
   - `[NameAffix("Suffix", "KhronosVendor", "KHR")]` from `MixKhronosData`
   - `[NameAffix("Prefix", "SharedPrefix", "vk")]` from `IdentifySharedPrefixes`

3. `PrettifyNames` uses the metadata to transform the names according to user-provided configuration.
   - The affixes are first stripped → `CreateSwapchain`
   - The base name is "prettified" (pascal-casing, removal of underscores) → `CreateSwapchain` (No change in this case)
   - Affixes are reapplied according to user configuration → `CreateSwapchainKHR`
      - We usually remove shared prefixes and preserve Khronos vendor suffixes verbatim
        (notably in contradiction with the Framework Design Guidelines).
        The reasons for this are explained below.

4. Mods strip most metadata from the generated bindings to keep the output clean.
   - We generally keep metadata useful for users, while removing internal generator metadata.
   - For example, `[NativeName]` is kept and `[NameAffix]` is removed during the `StripAttributes` mod.
   - Tip: Disabling the `StripAttributes` mod can be helpful for debugging unwanted outputs.

## Test cases

The behavior for the name processing pipeline is heavily unit tested.
Please refer to the unit tests for the corresponding section of the codebase to see detailed examples
of expected inputs and outputs.

## PrettifyNames

As seen above, `PrettifyNames` is the mod central to name processing.

The goal of this mod is to take all of the names from the generated bindings and transform them in bulk.
This keeps other mods performant and simple, as renaming identifiers is a costly operation
that involves searching the entire project for references to that identifier.

Despite this, `PrettifyNames` also has the goal of remaining dumb and straightforward.
It relies on the generator config for API-specific decisions (eg: removing/reordering affixes, overrides)
and other mods for API-specific annotations (eg: API-specific prefix/suffix conventions).
The rest of the processing (eg: prettification), while complex, is done uniformly.

This allows `PrettifyNames` to focus strictly on the common case, while edge cases are handled elsewhere.
This works fairly well in practice. Even though the configuration options are limited mostly to how affixes are
handled, affixes are usually where native APIs differ in their naming conventions. Other differences fall outside
the common case and are therefore handled by the generator user or by other mods.

Furthermore, to keep `PrettifyNames` simple and linear, each step takes the output of the previous step,
with no interweaving of logic.

`PrettifyNames` works as follows:

1. All current source code is scraped to gather name information.
2. The names are transformed by a series of name processors.
3. Symbols corresponding to all transformed names are gathered.
4. A symbol-based renamer is used to replace all references to those names with their new versions.
5. Document file names are renamed using the transformed names.

At time of writing, these are the name processors in use:
```cs
var nameProcessors = new INameProcessor[]
{
    new HandleOverridesProcessor(...), // Overrides are user configurable
    new StripAffixesProcessor(...),
    new PrettifyProcessor(...), // Acronym threshold is user configurable
    new ReapplyAffixesProcessor(...), // Affix reapplication is user configurable
    new PrefixIfStartsWithNumberProcessor(),
    new ResolveConflictsProcessor(...),
    new OutputFinalNamesProcessor(),
    new RemoveUnmodifiedFinalNamesProcessor(),
};
```

For specifics on how these processors and other steps work, it is best to refer to the `PrettifyNames` source code.

## Name Splitting

(TODO: Explain how name splitting works, relate it to tokenization. Explain decisions like why "2D" is split as "2_D")

## Name Prettification

(TODO: Explain how prettification works alongside name splitting. Explain how acronyms are handled. Explain why number fragments are merged to preceding letter fragments and how this affects acronyms and pascal casing.)

## Name Affixes

(TODO: Explain the motivation behind this system. Explain that users configure how name affixes are processed while mods identify affixes (separation of concerns).)

### Referenced Affixes

(TODO: Explain why referenced affixes exist (compound names and types that are the logical extensions of other types) and when these are used in the generator. Explain how these are processed.)

### Affix Categories

(TODO: Exhaustively list each category being used in the generator. Explain which mods add the affix category. Provide examples on what the affixes look like. Provide recommendations on how each affix should be configured (i.e., should match the configuration used by `generator.json`).)

## Symbol-based Renamer

(TODO: Explain how the symbol-based renamer works and why `SymbolFinder.FindReferencesAsync` is not used.)
