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

Name splitting involves splitting an identifier into separate "tokens" and is handled by the `NameSplitter` class. These
tokens can refer to literal words (as identified by underscore/pascal case separations), but can also refer to groups of
numbers or capitalized letters.

Note: The codebase is inconsistent when referring to tokens, usually calling them "words" or "fragments" instead.

The goal of name splitting is to have a consistent representation of a name where each part of the name can be examined
individually. This is helpful when names differ by casing or by different types of separation.

For example, `VkAccessFlags`, `vkCreateBuffer`, and `VK_MAX_MEMORY_HEAPS` effectively have the same shared prefix.

For specifics on how this process works and the exact behaviors, it is best to refer to the `NameSplitter` source code
and the `NameSplitterTests` test cases.

### Name Splitting - Notable Decisions

#### Handling of Numbers

Numbers are always split out as their own individual token. This is because this is easier to work with and consistent
than special casing when numbers should "stick" to preceding or proceeding tokens.

For example:
- `2D` is split as `2_D`
- `R32` is split as `R_32`

In these two cases, both inputs can be considered one English word, so it can be argued that the output should be the
same as the input. However, this means the name splitting code should have preferences for when numbers should "stick"
one way or the other.

This gets even messier with names like `Image_2D_RGB16` or `Image2D_RGB16`. Although these exact names have not shown
up in native code, names like `SpvImageFormatR32ui` do in fact exist.

Because the goal of name splitting is to have a consistent tokenized representation of the name, it can be argued
that it is safer to go for a more naive approach that does not attempt to group numbers with letters together at all.
In this case, a more naive approach means simpler code. It also means less potential surprises since the output is more
resistant to subtle changes in the input.

## Name Prettification

As hinted to previous, name prettification is the process of transforming an identifier to follow the Framework
Design Guidelines and is handled by the `NamePrettifier` class.

This primarily involves pascal casing and the removal of underscore separators. Acronyms are also handled. By default,
acronyms of length 2 are preserved (matching the guidelines), while acronyms of greater lengths are pascal-cased.

For example, "UI" is prettified as "UI" while "GUI" is prettified as "Gui".
Similarly, "GL" is prettified as "GL" while "EGL" is prettified as "Egl".

Name prettification takes in a name "fragment" and outputs another fragment representing the prettified version of the
input. The input is first split using `NameSplitter` to get a tokenized representation of the name before being
processed.

For specifics on how this process works and the exact behaviors, it is best to refer to the `NamePrettifier` source code
and the `NamePrettifierTests` test cases.

### Name Prettification - Notable Decisions

#### Output of Fully Capitalized Names

By default, the `NamePrettifier` disallows outputs that are all caps.
For example, if `GL` is the output and `allowAllCaps` is the default of false, then `Gl` will be the actual output.

This is to prevent fully capitalized member names, so the codebase typically overrides this behavior when dealing with
type names. This means the `GL` class remains as `GL`.

#### Handling of Acronyms that contain Numbers

An acronym includes the capital letters and the numbers immediately following those letters.

For example:
- `2D` is split as `2_D`. There are 2 acronyms of length 1 here.
- `R32` is split as `R_32`. There is 1 acronym of length 3 here.

Where this behavior matters is in the following case:
- `RG` is split as `RG` and is prettified as `RG`, however the `NamePrettifier` also disallows outputs that are fully
  capitalized by default. This means `RG` is actually output as `Rg`.
- `RG32` is split as `RG_32`. Because this is an acronym of length 4, it is output as `Rg32`.

Notably, this means that `RG` and `RG32` are consistently output as `Rg-`.

In the code, this is implemented by merging number tokens with preceding letter tokens.

For example:
- `2_D` is merged as `2_D`.
- `RG_32` is merged as `RG32`.

This can be argued to be a hack, but simplifies acronym length calculations and continues to work with the code that
handles pascal casing, which simply uppercases the first character and lowercases the rest for each token.

#### Acronym Indeterminate Inputs

(TODO)

#### Handling of Consecutive Acronyms

(TODO)

#### Lowercase "x" between Numbers

(TODO)

## Name Affixes

(TODO: Explain the motivation behind this system. Explain that users configure how name affixes are processed while mods identify affixes (separation of concerns).)

### Referenced Affixes

(TODO: Explain why referenced affixes exist (compound names and types that are the logical extensions of other types) and when these are used in the generator. Explain how these are processed.)

### Affix Categories

(TODO: Exhaustively list each category being used in the generator. Explain which mods add the affix category. Provide examples on what the affixes look like. Provide recommendations on how each affix should be configured (i.e., should match the configuration used by `generator.json`).)

## Symbol-based Renamer

(TODO: Explain how the symbol-based renamer works and why `SymbolFinder.FindReferencesAsync` is not used.)
