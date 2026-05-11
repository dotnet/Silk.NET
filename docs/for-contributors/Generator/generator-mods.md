# Generator Mods

Silk's SilkTouch bindings generator is designed to be a linear pipeline where a set of mods sequentially transform C#
source code represented by Roslyn syntax nodes. This approach used by Silk 3 is in contrast to the approach in Silk 2,
where a monolithic generator output code represented by bespoke data structures. Silk 3 focuses on breaking down each
transformation step into its own mod to aid in maintainability and understanding of the codebase.

This document explains how mods are implemented and the mods provided by the generator.

## Implementation

### IMod Interface

SilkTouch mods implement the `IMod` interface, which contains the `InitializeAsync` and `ExecuteAsync` methods.

The primary work of a mod is done within the `ExecuteAsync` method. This method takes in a
`Microsoft.CodeAnalysis.Project` containing the C# source code representing the current state of the bindings. This is
the primary input *and* output of each mod. The output of each mod is passed directly into the next mod for further
transformation.

`InitializeAsync` is rarely used and is used to initialize data before any transformations have begun so that other mods
can access that data. This is especially so because most communication between mods should be done through the C# source
code representing the generated bindings instead.

### Mod Configuration

Mods are configured through the generator config JSON file. Silk's config file is named `generator.json` and is located
at the root of the Silk.NET repository. This config file can be used as reference for your own config files. In
addition, most mods have a configuration class located in their source code with additional documentation.

## Available Mods

This section provides a high level explanation of what each mod does. The list is sorted in alphabetical order.

In particular, config options and specific implementation details are omitted here as the source code documentation
provides the information in a more clear format with less chance of being outdated. However, high level design decisions
will be documented here.

Standardized sections:

- **Mod categories** - Assigns a category to the mod and is purely for documentation purposes. Alphabetically sorted.
  This allows for easy searching for related mods. The category is also used to provide recommendations and information
  relating to those categories.

- **Name affix categories** - Lists the name affix categories that the mod adds. Alphabetically sorted.

- **Usage recommendations** - Provides information such as situations the mod is useful for, how to configure it, and
  where to place it in the mod order. This information can include examples of how Silk's own bindings use it or whether
  the mod is mainly designed for Silk internal use.

General recommendations:

For the most part, mods should be configured to run in an order similar to the mod orders used by Silk's existing
bindings. The same goes for the configuration, but more care needs to be done regarding whether the configuration is
specific to that set of bindings.

### AddApiProfiles

Mod categories: Metadata

This mod adds `[SupportedApiProfile]` attributes throughout the generated bindings for the purpose of providing API
analyzers the ability to understand when a specific API can be used.

This mod is WIP:

- Ideally, the mod internally uses `[NativeName]` attributes to associate data with the API exposed by the bindings.
  Currently, the managed C# names are used, meaning that name prettification and other name modifications can lead to
  inaccurate `[SupportedApiProfile]` attributes.

Usage recommendations:

This mod should be positioned late in the mod order, after all APIs have been added to the generated bindings.
If the attribute is missing on a certain API and a later mod adds that API, investigate whether this mod can be moved
to be after that mod.

### AddIncludes

Mod categories: Creation

This mod interacts with `ClangScraper` by providing standard include directories and other user-specified include paths
to `ClangScraper`.

Usage recommendations:

This should be positioned at the start of the mod order.

### AddOpaqueStructs

Mod categories: Creation

This mod adds an empty struct for each name specified in its mod configuration.

Usage recommendations:

(TODO: To be added)

### AddVTables

Mod categories: Transformation

This mod transforms `[DllImport]` and `[Transformed]` methods to use Silk-style virtual tables. These vtables allow for
different styles of accessing native APIs, such as through an instance of an API object or through static methods.

Usage recommendations:

(TODO: To be added)

### BakeSourceSets

Mod categories: Transformation

This mod merges multiple sets of source code into one set of source code.

Usage recommendations:

(TODO: To be added)

### ChangeNamespace

Mod categories: Transformation

This mod moves types from one namespace to another.

Usage recommendations:

(TODO: To be added)

### ChangeNativeClass

Mod categories: Transformation

This mod moves members from one type to another.

Usage recommendations:

(TODO: To be added)

### ClangScraper

Mod categories: Creation

This is a critical mod used to generate the initial set of raw C# bindings for C APIs. The use of this mod is equivalent
to using `ClangSharpPInvokeGenerator`. The C# source code generated by this mod is typically the starting point for all
of the transformations done by the rest of the SilkTouch mods.

Usage recommendations:

This mod is configured differently from the rest of the mods. The JSON mod configuration follows the same pattern as the
rest of the mods, but the bulk of the configuration comes in the form of `.rsp` files. These `.rsp` files represent the
command line arguments passed to `ClangSharpPInvokeGenerator`. More information about how to use this mod and how to
configure the generator as a whole is found in the [Using the Generator](using-the-generator.md) documentation.

This mod should be positioned at the start of the mod order, after `AddIncludes`.

### ExtractHandles

Mod categories: Creation

This mod adds empty structs for missing types that are identified to be used as handle types. To be a handle type, the
type must only be ever referenced through a pointer. After the empty struct representing the handle type is extracted,
`TransformHandles` can then be used to transform the pointer to be wrapped within the handle struct.

Side note: This mod is similar to `AddOpaqueStructs` in that it adds empty structs, but `ExtractHandles` has a much more
automated approach since it deals specifically with handle types that are referenced using pointers.

This code has been manually trimmed for the sake of example and comes from the state of the Vulkan bindings before
`ExtractHandles` executes. In this case, `VkInstance_T` will be identified as a missing handle type and an empty struct
will be added for it. On the other hand, `VkInstanceCreateInfo` and `VkAllocationCallbacks` will not be affected since
they already exist. Similarly, `VkResult` is not affected because it is not referenced through a pointer.
```cs
public struct VkAllocationCallbacks;
public struct VkInstanceCreateInfo;

public class Vk
{
    public static extern VkResult vkCreateInstance(
        VkInstanceCreateInfo* pCreateInfo,
        VkAllocationCallbacks* pAllocator,
        VkInstance_T** pInstance
    );
}
```

The result of running `ExtractHandles` on the above code will lead to the creation of a new type:
```cs
public unsafe partial struct VkInstance_T
{
}
```

Usage recommendations:

This mod should be used if a set of bindings contains types referenced only through pointers and those pointers are
missing from the final set of generated bindings.

Furthermore, this mod should be used alongside `TransformHandles` so that the handles are transformed into a more
user-friendly version. `ExtractHandles` should be positioned before `TransformHandles` and any other mods that might use
its results in the mod order.

### ExtractNestedTyping

Mod categories: Creation

Name affix categories:

- `FunctionPointerDelegateType` - TODO (TODO: Indicate whether it is usually a suffix or prefix)

Usage recommendations:

### IdentifySharedPrefixes

Mod categories: Metadata, Naming

Name affix categories:

- `SharedPrefix` - TODO

Usage recommendations:

### InterceptNativeFunctions

Mod categories: Transformation

Name affix categories:

- `InterceptedFunction` - TODO

Usage recommendations:

### MarkNativeNames

Mod categories: Metadata, Naming

Usage recommendations:

### MixKhronosData

Mod categories: Creation, Metadata, Naming, Transformation

Name affix categories:

- `KhronosFunctionDataType` - TODO
- `KhronosHandleType` - TODO
- `KhronosImpliedVendor` - TODO
- `KhronosNamespaceEnum` - TODO
- `KhronosNonExclusiveVendor` - TODO
- `KhronosVendor` - TODO

Usage recommendations:

### PrettifyNames

Mod categories: Naming, Transformation

Usage recommendations:

### StripAttributes

Mod categories: Metadata

Usage recommendations:

### TransformEnums

Mod categories: Transformation

Usage recommendations:

### TransformFunctions

Mod categories: Transformation

Name affix categories:

- `RawFunction` - TODO

Usage recommendations:

### TransformHandles

Mod categories: Transformation

Name affix categories:

- `HandleType` - TODO

Usage recommendations:

### TransformProperties

Mod categories: Transformation

Usage recommendations:

## Mod Categories

### Creation

These mods focus on the creation of new APIs that strictly do not exist in any form in the current state of the
bindings.

Generally, these mods should be early in the mod order so that other mods have the chance to modify their outputs.

### Metadata

These mods deal with metadata, either by annotating the generated bindings or by providing metadata to other mods.

### Naming

These mods deal with the naming of type and member identifiers within the generated bindings.

### Transformation

These mods focus on the transformation of existing APIs. While these mods can create new APIs, these new APIs are based
on APIs that already exist in the generated bindings.
