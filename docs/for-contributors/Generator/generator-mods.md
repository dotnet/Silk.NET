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

- **Mod categories** - Assigns a category to the mod and is purely for documentation purposes. This allows for easy
  searching for related mods and is used in a later section to provide recommendations relating to those mod categories.

- **Name affix categories** - Lists the name affix categories that the mod adds.

### AddApiProfiles

### AddIncludes

### AddOpaqueStructs

### AddVTables

### BakeSourceSets

### ChangeNamespace

### ChangeNativeClass

### ClangScraper

### ExtractHandles

### ExtractNestedTyping

Name affix categories:

- `FunctionPointerDelegateType` - TODO (TODO: Indicate whether it is usually a suffix or prefix)

### IdentifySharedPrefixes

Name affix categories:

- `SharedPrefix` - TODO

### InterceptNativeFunctions

Name affix categories:

- `InterceptedFunction` - TODO

### MarkNativeNames

### MixKhronosData

Name affix categories:

- `KhronosFunctionDataType` - TODO
- `KhronosHandleType` - TODO
- `KhronosImpliedVendor` - TODO
- `KhronosNamespaceEnum` - TODO
- `KhronosNonExclusiveVendor` - TODO
- `KhronosVendor` - TODO

### PrettifyNames

### StripAttributes

### TransformEnums

### TransformFunctions

Name affix categories:

- `RawFunction` - TODO

### TransformHandles

Name affix categories:

- `HandleType` - TODO

### TransformProperties

(TODO: Add a section for each mod and explain what they do at a high level. Also provide examples of the transformations done. Also link to where more information can be obtained (source code, test cases))

## Mod Categories

(TODO)

## Name Affix Categories

(TODO: Don't keep this as its own section, but for each mod, explain the affix categories that the mod adds. Provide examples on what the affixes look like and how they should be configured in `generator.json`)
