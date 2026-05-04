# Name Processing and Prettification

A primary goal of Silk.NET is to provide a first-class .NET experience for the bindings that it provides.

One such way that Silk.NET achieves this is by transforming native identifiers into identifiers that follow the
Microsoft Framework Design guidelines.
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

## PrettifyNames

As seen above, `PrettifyNames` is the mod central to name processing.

The goal of this mod is to take all of the names from the generated bindings and transform them in bulk.
This keeps other mods performant and simple, as renaming identifiers is a costly operation
that involves searching the entire project for references to that identifier.
Despite this, `PrettifyNames` also has the goal of remaining dumb and does this
by relying on the generator config for all major decisions.

(TODO: Explain how other mods and the user are supposed to interact with PrettifyNames)

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
