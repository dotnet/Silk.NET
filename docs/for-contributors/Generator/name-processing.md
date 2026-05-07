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

## PrettifyNames - Notable Decisions

Note: It may be helpful to come back to this section after reading about the rest of the name processing pipeline.

### Strip/Reapply Affixes Scope

Affixes are stripped and reapplied to create a "scope" where only the base name is visible.

For example, in the execution order above, `PrettifyProcessor` only affects the base name, but
`PrefixIfStartsWithNumberProcessor` works on the full name with affixes applied.

Currently, this distinction is not as prevalent as it was when shared prefix trimming was done during `PrettifyNames`.

Originally, this was implemented so that prefix identification ignores any affixes that have been declared. This
notably affects cases like the `I-` prefix in the Microsoft bindings (the C-style namespace prefix is after the `I-`)
and the vendor suffixes in the Khronos bindings (removing the suffixes before identifying shared prefixes prevents
problematic cases where prefix trimming trims everything except for the vendor suffix, since the vendor suffix was the
only non-shared part of the name; see `OcclusionQueryParameterNameNV` in OpenGL for example).

Shared prefix identification is now handled by `IdentifySharedPrefixes` by handling affix stripping/reapplication using
the utility methods provided by `NameAffixer`. `PrettifyNames` can be then configured to remove these shared prefixes,
thus matching the original behavior.

### Strip/Reapply Affixes Configuration

To keep things simple, only affix reapplication is configurable. This is because the user is expected to configure the
generator output, while mods are expected to handle the process of affix identification.

Affix reapplication is when common transformations to affixes are applied, such as removing them, reordering them, and
prettifying them.

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

These refer to inputs that are fully uppercased, making it hard to tell whether the input is a standalone acronym or
simply written in screaming case.

The current code handling this behavior was implemented back when the generator used a default long acronym threshold of
3 (and occasionally using 4*), which in turn was ported from the original Humanizer-based prettify implementation.
Therefore, the examples given in the code state a threshold of 4.

\*4 was used for Khronos APIs as a best effort to preserve vendor suffixes (eg: `KHR`, `EXT`, `NV`, `QCOM`). This is no
longer necessary because the name affix system is now used to preserve these suffixes.

This behavior notably is less noticeable with the long acronym threshold of 2, but still affects a few names, such as
the `GL` class. Without this, `GL` gets turned into `Gl` since the input is treated as screaming case.

To learn more about this behavior, please refer to the comments in `NamePrettifier`.

#### Handling of Consecutive Acronyms

Consecutive acronyms are pascal-cased, if they both are candidates for being uppercased.

For example, assuming a long acronym threshold of 4, `RGBA_ASTC` will be prettified as `RgbaAstc`, not `RGBAASTC`.
This is because the latter is much harder to read.

#### Lowercase "x" between Numbers

Consecutive numbers are separated by a lowercase "x". Furthermore, if a name already is in the format `2_X_2`, the "X"
will be lowercased.

The use of the "x" is to ensure that numbers remain separated, especially because prettified names never contain
underscores, which is usually how consecutive numbers are separated in native code.

The use of a *lowercase* x in particular is a stylistic choice and matches names like `System.Numerics.Matrix4x4`.

## Name Affixes

(TODO: Explain how these actually look in metadata/attribute form)

Name prefixes and suffixes are used commonly in both native code and in identifiers created by the SilkTouch generator.

For example, in `VkPresentInfoKHR` from Vulkan, `Vk-` is a namespace prefix commonly used in C code, while `-KHR` is a
Khronos-style suffix denoting that the type belongs to the `KHR` family of extensions.

In the generator, suffixes are usually used to denote names that are derived from other names or to prevent name
collisions. For example, `-Handle` is appended to handle types transformed by `TransformHandles`. This means that handle
types like `Buffer` are named as `BufferHandle` instead, thus reducing name collision risks with user-defined types.

Because of the prevalence of affixes in both native and generated code, the name affix system was added so that names
can be annotated with information about what affixes have been identified or added to the name. This allows mods to
target transformations to a specific, known part of a name.

Furthermore, because each category of affix can be identified by different mods, it keeps the complex affix
identification process localized to the mod that specializes in that area. For example, C-style namespace prefixes
are handled by `IdentifySharedPrefixes`.

### Referenced Affixes

(TODO: Explain how these actually look in metadata/attribute form)

Referenced affixes were added to handle compound names where part of the name is actually the name of another
identifier. This ensures that the "referenced" part of the name always matches the name being referenced, in other
words, changes to the referenced name is "synchronized" to the name referencing it (more on this later).

This occurs primarily in types added to the bindings by Silk. For example:

- **Nested types** - Nested types are extracted by `ExtractNestedType` to be non-nested types. These types have the name
  of their parent type plus their original name (for nested types that have proper names in the native code) or the name
  of their parent type plus the name of the field that uses them (eg: for `InlineArray` types).
   - Example: `GamepadBinding`, `GamepadBindingInput`, and `GamepadBindingInputAxis` in the SDL bindings. The latter are
     nested structs.
   - Example: `PerformanceCounterDescriptionARM` and `PerformanceCounterDescriptionARMName` in the Vulkan bindings. The
     latter is an inline array used by the field, `PerformanceCounterDescriptionARM.Name`.

- **Derived types** - Derived types refer to types that are generated based on another type (not to be confused with
  inheritance). At time of writing, this only refers to function pointer types for which Silk generates a function
  pointer struct and a corresponding delegate type. The delegate type has the `-Delegate` suffix appended to it.
   - Example: `DebugReportCallbackEXT` and `DebugReportCallbackEXTDelegate` in the Vulkan bindings.

In other words, referenced affixes are most helpful when dealing with types that are the logical extensions of other
types.

Most notably, handle type suffixes do not fall into the above categorization.

For example: `PipelineBinaryHandleKHR` in the Vulkan bindings is not an extension of `PipelineBinaryKHR`, it *is* the
type, just renamed to avoid naming collisions.

Going back to the idea of synchronizing changes, if `GamepadBinding` was to be renamed using an override, the referenced
affix system ensures that `GamepadBindingInput` and `GamepadBindingInputAxis` are renamed correspondingly.

Similarly, it ensures that if an affix is configured to be moved to the end of the referenced name, the affix only moves
to the end of the name it was originally declared on. This can be seen in `PerformanceCounterDescriptionARMName` and
`PipelineBinaryHandleKHR`. `ARM` is a Khronos vendor suffix for `PerformanceCounterDescriptionARM`, so it only moves to
the end of that name; however, `KHR` is a vendor suffix for `PipelineBinaryHandleKHR` as a whole.

Side note: Another benefit of referenced affixes is that it ensures that derived types show up when typing the base
type's name in the IDE. For example, if vendor suffixes always moved to the end of the name,
`PerformanceCounterDescriptionARMName` would become `PerformanceCounterDescriptionNameARM` and would not show up when
autocompleting `PerformanceCounterDescriptionARM`.

### Affix Categories

(TODO: Exhaustively list each category being used in the generator. Explain which mods add the affix category. Provide examples on what the affixes look like. Provide recommendations on how each affix should be configured (i.e., should match the configuration used by `generator.json`).)

(TODO: This overrides the previous todo. Don't list the affix categories. Just explain them. List them out in the generator-mods.md doc instead.)

(TODO: Edit. Just explain them as part of the syntax section for Name Affixes above.)

## Symbol-based Renamer

(TODO: Explain how the symbol-based renamer works and why `SymbolFinder.FindReferencesAsync` is not used.)
