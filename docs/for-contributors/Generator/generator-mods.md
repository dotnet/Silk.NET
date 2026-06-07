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
can access that data before their own `ExecuteAsync` method runs. The usage of this method is made even rarer since most
communication between mods should be done through the C# source code representing the generated bindings instead, or
ideally, no communication is done at all so that mods are kept completely standalone.

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

- **Name affix categories** - Lists the name affix categories that the mod adds. Alphabetically sorted. Please refer
  to the [Name Processing](name-processing.md) documentation to understand what these are and how to make use of them.
  That said, advice for how to handle each category is also provided alongside information about what the name affix
  represents.

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

Note that this mod is platform specific and will have different outputs depending on the platform. This is because
`ClangSharpPInvokeGenerator`, and by extension, `ClangScraper` makes use of system headers. Any platform specific
differences in the API for which bindings are being generated will also affect the output.

Platform-specific differences:

For the most part, these behaviors are expected, but potentially unwanted behaviors considering the goal of Silk is to
provide cross-platform bindings.

- `uint64_t` in C becomes `ulong` on Windows, `nuint` on Linux. This is filed as an issue in the ClangSharp repo:
  https://github.com/dotnet/ClangSharp/issues/574. Silk handles this by  remapping the `stdint.h` types in
  `remap-stdint.rsp`. APIs, such as OpenGL, that define their own integer types may require additional configuration.

- Enums use `uint` as their backing type on Linux instead of `int` like on Windows. Silk handles this by using
  `TransformEnums` to "coerce" the backing types to their Windows equivalents when possible.

Note: There may be other differences not yet documented here. In the case new differences are discovered, please
update this section. Library-specific differences should not be documented here.

To further avoid platform-specific differences, Silk prefers to generate its bindings on Windows. However, for sake of
development and iteration, the generator is typically set up so that platform-specific differences are minimalized.

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

Note: This mod is similar to `AddOpaqueStructs` in that it adds empty structs, but `ExtractHandles` has a much more
automated approach since it deals specifically with handle types that are referenced using pointers.

This code has been manually trimmed for the sake of example and comes from the state of the Vulkan bindings before
`ExtractHandles` executes. In this case, `VkInstance_T` will be identified as a missing handle type and an empty struct
will be added for it. On the other hand, `VkInstanceCreateInfo` and `VkAllocationCallbacks` will not be affected since
they already exist. Similarly, `VkResult` is not affected because it is not referenced through a pointer. This example
has a matching test case in the SilkTouch unit tests.
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

This mod handles a few responsibilities, the primary of which is to extract nested types out of their parent types and
into the containing namespace as non-nested types. The second is replacing function pointers with structs and delegate
types representing those function pointers. The third is moving C-style enum constants into their respective enums.

Arguably, the non-primary responsibilities of this mod should be split out into separate mods, but has not yet been done
so due to lack of time invested into doing so. There is also the slight performance hit of splitting out the operations
out since it will lead to three separate passes over the codebase, but this cost is negligible for most reasonably sized
native APIs.

Examples for how `ExtractNestedTyping` works can be found in the `ExtractNestedTypingTests` test cases.

Name affix categories:

- `FunctionPointerDelegateType` - This is a suffix that always has the value of `Delegate`. This is used for the
  delegate representation of a function pointer type to distinguish the delegate type from the struct type for extracted
  function pointers.

- `FunctionPointerParent` - This is a prefix used by the delegate representation of a function pointer type. This is
  used to ensure that the delegate type always uses the current name of its struct counterpart as part of its own name.

- `NestedStructParent` - This is a prefix that references the name of the type that the extracted type was previously
  nested in. This is used to ensure that the extracted type always uses the current name of its original "parent" type
  as part of its own name.

These affixes are usually left unconfigured in `PrettifyNames`.

Usage recommendations:

This mod must be used before `PrettifyNames` when using `PrettifyNames` and there are nested types in the generated
bindings. This is because `PrettifyNames` does not handle nesting when renaming identifiers. Other mods may have similar
restrictions. This restriction is generally because nesting increases complexity, and as such, mods are written with the
assumption that nested types are extracted beforehand.

### IdentifySharedPrefixes

Mod categories: Metadata, Naming

This mod is designed to handle C-style namespace prefixes where all types, functions, and constants in a library share
a common prefix. This includes casing convention differences. For example, constants often use screaming case while
type and function names use camel case or pascal case. This can be seen in Vulkan, where functions are prefixed with
`vk`, such as in `vkCreateInstance` and `vkCmdBindPipeline`, and constants are prefixed with `VK_`, such as in
`VK_MAX_MEMORY_HEAPS` and `VK_TRUE`.

Furthermore, identification of shared prefixes is done per scope and only in cases where C-style namespace prefixes
might be used. For example, a struct type typically does not use namespace prefixes because the struct itself acts as
a way to disambiguate names contained inside of it. However, C-style enum values are often defined as global constants
using macros such as `#define SDL_BLENDMODE_BLEND_PREMULTIPLIED 0x00000010u`. After these constants are moved to their
corresponding enum types by `ExtractNestedTyping`, `IdentifySharedPrefixes` then handles the identification of the
prefix shared by the enum type's members. In the case of `SDL_BlendMode`, all of the members of `SDL_BlendMode` share
`SDL_BLENDMODE_` as their common prefix.

Note: Despite `VK_` and `SDL_BLENDMODE_` being the "true" shared prefix, `IdentifySharedPrefixes` annotates the
identifier with `VK` and `SDL_BLENDMODE` as the shared prefix, without the trailing underscore. While the inclusion of
the underscore can be debated and can subtly affect the bindings output by the generator in edge cases, this is the
current behavior of `IdentifySharedPrefixes`.

Implementation-wise, this mod's functionality was notably originally part of `PrettifyNames`. In the original form,
`PrettifyNames` handled both the identification of and removal of shared prefixes. This has now been split out to
simplify `PrettifyNames` and to provide better control over how shared prefixes are processed.

Examples for how `IdentifySharedPrefixes` works can be found in the `IdentifySharedPrefixesTests` test cases.

The [Name Processing](name-processing.md) documentation also covers `IdentifySharedPrefixes` to a limited extent,
notably relating to how existing name affixes are treated in the
[IdentifySharedPrefixes and Name Affixes](name-processing.md#identifysharedprefixes-and-name-affixes) section.

Name affix categories:

- `SharedPrefix` - This is a prefix that represents the shared prefix that is identified for a group of names. Silk's
  bindings typically remove this prefix because these prefixes are typically used to prevent naming collisions in C
  libraries. C# has its own namespacing functionality, thus making this prefix irrelevant. This prefix can be kept or
  prettified if preferred over removing the prefix. The prefix can also be configured as a discriminator, which removes
  the prefix by default, but allows the prefix to be used in case of name conflicts.

Example name affix configurations for `PrettifyNames`:

```
"SharedPrefix": {
  "Remove": true
}
```

```
"SharedPrefix": {
  "IsDiscriminator": true
}
```

Usage recommendations:

This mod should be used when the transformation of C-style namespace prefixes or similar naming patterns is desired.
The most common case of this is the removal of such prefixes by using `IdentifySharedPrefixes` before `PrettifyNames`.
`PrettifyNames` can then be configured like above to remove or use shared prefixes as discriminators.

This mod also interacts with `ExtractNestedTyping`, which moves constants that are identified as likely being part of
an enum to the corresponding enum. As such, this `IdentifySharedPrefixes` should be positioned after
`ExtractNestedTyping` in the mod order.

### InterceptNativeFunctions

Mod categories: Transformation

This mod intercepts native functions and allows the generator user to provide a manual implementation in a non-generated
partial file.

This is done by identifying native functions by name and by their `[DllImport]` attribute. If the native function's name
is one of the functions to intercept, the original method is replaced with two new method:

1. A `private` version of the original that is suffixed with `-Internal`.
2. A `public` version with no method body, but using the `partial` keyword.

This second `partial` method is what allows generator users to provide their own implementation. Similar to overriding
`virtual` methods, the generator user is free to do anything within this implementation, but common use cases involve
wrapping the method before calling the original `-Internal` suffixed version of the method.

Examples for how `InterceptNativeFunctions` works can be found in the `InterceptNativeFunctionsTests` test cases.

Name affix categories:

- `InterceptedFunction` - This is a suffix that always has the value of `Internal`. This is used for the original
  version of the private, intercepted native function to distinguish it from the new, public version.

Usage recommendations:

Use this when there is a strong reason to directly replace the original native function rather than create a custom
overload or utility method.

For example, this is used in the Vulkan bindings to capture the created `Instance` and `Device` objects to be used in
native function loading. Specifically, `vkCreateInstance` and `vkCreateDevice` are intercepted so that the created
objects can be passed to `vkGetInstanceProcAddr` and `vkGetDeviceProcAddr` respectively. In this case, the reason for
intercepting these native functions is so that function pointers can be automatically loaded without user intervention.

### MarkNativeNames

Mod categories: Metadata, Naming

This mod naively adds `[NativeName]` attributes to most identifiers in the generated bindings and is designed to be
placed immediately after `ClangScraper`. Syntax nodes that are not output by `ClangScraper` are intentionally not
processed.

The name stored by the `[NativeName]` attribute matches the C# identifier at the time the mod runs. This assumes that
the name used by the C# source code matches the name used by the native source code, which is *usually* the case when
this mod is placed immediately after `ClangScraper`. However, there are cases where the names output by `ClangScraper`
do not correspond to native names. These cases are usually because there is no native name available, such as for
inline array types (named in the format `_name_e__FixedBuffer`) or backing fields used by bitfield structs (named
`_bitfield`).

Usage recommendations:

As mentioned, this mod is best used immediately after `ClangScraper` runs. This should mark all identifiers output
by `ClangScraper` itself.

However, do not assume that this mod is sufficient to mark all identifiers present in the final set of generated
bindings. When other mods introduce new identifiers, those mods will need to add `[NativeName]` attributes themselves,
or have another mod do it for them, in the case those identifiers represent a native API.

Because the name stored as the value for `[NativeName]` comes from the native API, it can be used as a stable identifier
for an API. This is in contrast to the current C# identifier being used, as that identifier is often transformed by mods
such as `[PrettifyNames]`.

### MixKhronosData

Mod categories: Creation, Metadata, Naming, Transformation

This is a monolithic mod that handles behavior specific to Khronos-style APIs such as OpenGL, OpenAL, Vulkan, and more.

Because this mod is intended more for internal use rather than public use, the documentation here will focus on
decisions made during the development of the mod and other internal details rather than the exact usage of the mod.
For information relating to how the mod should be used, please use Silk's `generator.json` configuration, source code,
and `MixKhronosDataTests` as a reference.

(TODO: Document major decisions relating to MixKhronosData. This is difficult because of the mod's long development
history. This should be done over time as further changes are made to the mod.)

To combat the monolithic nature of the mod, the mod is split into multiple phases. This refers to both the
`InitializeAsync` and `ExecuteAsync` phases, as well as the use of multiple rewriters. The mod also implements
multiple interfaces that integrate `MixKhronosData` into the behavior of other mods.

`InitializeAsync` is where `MixKhronosData` initializes its data by reading the Khronos-style XML specification file
containing data relating to the API that the generator is generating bindings for. A list of such specifications is
provided below. These XML specs roughly follow the same format, but have subtle or major differences depending on the
history of that API. For example, OpenGL is similar to OpenAL, but differs greatly from Vulkan and OpenXR who are
themselves similar. As such, it is best to have all of the specification files open for reference when working on
parsing. It may also be helpful to have the corresponding header files open.

`ExecuteAsync` is where `MixKhronosData` does multiple sequential transformation steps on the source code representing
the generated bindings. These steps are split into different rewriter phases in a way that focuses on balancing
performance with maintainability. Performance-wise, these rewriters should be combined as much as possible. This is
because repeated loops over the project source code has an associated time cost. However, for sake of maintainability,
it is much easier to understand how transformations are done when they are separated out into different phases.
Fortunately, as long as the transformations do not use the symbol representation (eg: `ISymbol`, `SemanticModel`) of
the source code, the transformation is fairly lightweight and only adds a few seconds to the total execution time of
the mod.

Khronos-style XML specifications:

- OpenAL: https://raw.githubusercontent.com/kcat/openal-soft/refs/heads/master/registry/xml/al.xml
- OpenCL: https://raw.githubusercontent.com/KhronosGroup/OpenCL-Docs/refs/heads/main/xml/cl.xml
- OpenGL: https://raw.githubusercontent.com/KhronosGroup/OpenGL-Registry/refs/heads/main/xml/gl.xml
- OpenGL Windows: https://raw.githubusercontent.com/KhronosGroup/OpenGL-Registry/main/xml/wgl.xml
- OpenGL X11: https://github.com/KhronosGroup/OpenGL-Registry/blob/main/xml/glx.xml
- OpenXR: https://raw.githubusercontent.com/KhronosGroup/OpenXR-SDK-Source/main/specification/registry/xr.xml
- Vulkan: https://raw.githubusercontent.com/KhronosGroup/Vulkan-Docs/refs/heads/main/xml/vk.xml

Be aware that these link to the latest version. Silk's repo may be using an older version of these XML files.

Name affix categories:

- `KhronosFunctionDataType` - `IdentifyFunctionDataTypes` must be set to true in the `MixKhronosData` configuration for
  this affix category to be identified. This is a suffix relevant to OpenGL-like APIs where functions like `glColor3`
  have variants such as `glColor3i`, `glColor3f`, and `glColor3b`. These suffixes indicate the data type that the
  function expects. In this case, integer, float, and byte, respectively. Silk's bindings configure these as
  discriminators so that they can be removed when removing them does not lead to method overload conflicts.

- `KhronosHandleType` - This is a suffix used on handle structs resulting from the typedefs used by Khronos in their
  headers. For example, Vulkan uses the following macro to define handle types:
  `#define VK_DEFINE_HANDLE(object) typedef struct object##_T* object;`, used as `VK_DEFINE_HANDLE(VkInstance)`.
  Although Vulkan uses the handle type as `VkInstance`, `ClangScraper` outputs the type as `VkInstance_T` due to the
  typedef. As such, `MixKhronosData` identifies this suffix so that `PrettifyNames` can be configured to remove this
  suffix later.

- `KhronosImpliedVendor` - `IdentifyEnumMemberImpliedVendors` must be set to true in the `MixKhronosData` configuration
  for this affix category to be identified. This is a suffix used on enum members instead of `KhronosVendor` when an
  enum member has the same vendor suffix as **the containing enum type. This suffix exists in native code because the
  enum member is usually defined as a standalone, global constant without any other context whether the enum member is
  part of an extension. In C#, this is not a problem because the enum type itself conveys that information. For example,
  in Vulkan, `VkPresentModeKHR` in Vulkan is a `KHR` suffixed enum type that contains `VK_PRESENT_MODE_IMMEDIATE_KHR` as
  a member. In C#, this `KHR` suffix on the member is redundant. As such, Silk's bindings are configured to remove this
  suffix.

- `KhronosNamespaceEnum` - This is a prefix added to the "namespace" enum of OpenGL-like APIs such as `GLEnum`,
  `ALEnum`, and `ALCEnum`. In this case, the value of the prefix would be `GL`, `AL`, and `ALC`, respectively. This is
  so that the casing of the prefix is preserved by `PrettifyNames`. As such, Silk's bindings leaves the affix category
  unconfigured in the `PrettifyNames` configuration so that `PrettifyNames` uses the default behavior of preserving the
  affix.

- `KhronosNonExclusiveVendor` - `IdentifyEnumTypeNonExclusiveVendors` must be set to true in the `MixKhronosData`
  configuration for this affix category to be identified. This is a suffix used on enum types instead of `KhronosVendor`
  when the enum type's vendor suffix does not match the vendor suffixes used by the enum members contained within that
  type. For example, `BufferUsageARB` has the `ARB` vendor suffix, but contains non-suffixed members such as
  `GL_STREAM_DRAW`. Similarly, `GetMultisamplePNameNV` contains `ProgrammableSampleLocationARB`, which is also a
  mismatch. This affix category is only intended to be used for OpenGL-like APIs where enum member promotion was not
  fully defined, leading to inconsistent vendor suffixing where a non-promoted enum type contains a promoted enum
  member. Modern APIs like Vulkan do not have this issue. In modern APIs, there can be "mismatches", but those are cases
  where promoted enum types contain non-promoted enum members, which is allowed. As such, Silk's bindings enables
  `IdentifyEnumTypeNonExclusiveVendors` and configures `KhronosNonExclusiveVendor` affixes to be removed only for
  OpenGL-like APIs. Furthermore, `IdentifyEnumTypeNonExclusiveVendors` also interacts with
  `IdentifyEnumMemberImpliedVendors`. Specifically, if an enum type is identified to have a non-exclusive vendor, that
  vendor will not be used to identify implied vendors, as it is assumed that the non-exclusive vendor will be removed.
  Also note that the behavior of `IdentifyEnumTypeNonExclusiveVendors` can be considered "too aggressive" since it
  triggers off of *any* mismatch. For example, if a vendor suffixed enum type contains something generic such as
  `GL_NONE`, the enum type vendor suffix will still be identified as a `KhronosNonExclusiveVendor`. This behavior was
  ported from the now removed `NameTrimmer`-based implementation and is kept for simplicity and consistency with the old
  implementation.

- `KhronosNonVendor` - This is a suffix added to any identifier that is identified to contain a suffix listed in the
  `NonVendorSuffixes` list of the `MixKhronosData` configuration. This is used in cases when a suffix might block the
  identification of other suffixes. For example, OpenAL has names such as `alAuxiliaryEffectSlotfDirect` where the
  `Direct` suffix is after the `KhronosFunctionDataType` suffix, thus blocking the `KhronosFunctionDataType` suffix
  from being identified. In this case, adding `Direct` as a non-vendor suffix fixes the issue. Because this is a
  "helper" affix, Silk's bindings leave this affix category unconfigured in the `PrettifyNames` configuration.

- `KhronosVendor` - This is a suffix added to any identifier that is identified to contain a Khronos vendor suffix such
  as `KHR`, `EXT`, or `NV`. The list of vendor suffixes used during identification is retrieved from the provided XML
  specification. Silk's bindings are configured to move `KhronosVendor` suffixes to the end of the name. This is to
  match Khronos's own naming convention. This primarily affects cases where Silk's generator added additional suffixes
  to the end of the name, such as with `HandleType` suffixes like in `DebugUtilsMessengerHandleEXT` in Vulkan.

Usage recommendations:

This mod should only be used when generating bindings for Khronos-style APIs. While the mod does not strictly require
the XML specification file, `MixKhronosData` has not been tested for use without the XML specification.

One key consideration when using `MixKhronosData` is identifying the conventions used by the API for which bindings are
being generated for. Older Khronos APIs are more similar to OpenGL while newer Khronos APIs are more similar to Vulkan.
These conventions determine which settings should be used in the `MixKhronosData` configuration. For exact configuration
details, please refer to the configurations used by Silk for the existing Khronos-style bindings as well as the source
code.

Note: Although `MixKhronosData` has not been used by Silk for generating bindings for APIs that do not have XML
specifications, we will likely experiment with using this mod for bindings that do not have XML specifications such as
SPIRV-Reflect in the near future. Whether we end up using this mod for these types of bindings depends on how much
benefit `MixKhronosData` provides for those bindings.

### PrettifyNames

Mod categories: Naming, Transformation

This is the mod central to name processing. `PrettifyNames` focuses on the bulk prettification of names and the
processing of name affixes declared by other mods.

Name processing as a whole and information about the high level implementation details of `PrettifyNames` is available
in the [Name Processing](name-processing.md) documentation.

Usage recommendations:

This mod should be positioned late in the mod order to ensure that all mods that introduce new identifiers and
`[NameAffix]` attributes have run.

The placement of this mod can also affect mods that rely on the C# identifiers of types and their members rather than
the names specified by that identifier's `[NativeName]` attribute. One notable mod of this type is `TransformEnums`.

When configuring how name affixes are processed in the `PrettifyNames` configuration, note that the name affix category
configuration is designed to be verbose on purpose. If a category is left unconfigured, it will simply use the default
configuration. Mods cannot provide default affix category configurations. This is to ensure that what you see in the
`PrettifyNames` configuration directly corresponds to the output.

Furthermore, when defining values for the `Order` and `DiscriminatorPriority` properties, prefer to use consecutive
values since there is no need to reserve space for intermediate values when new name affix categories are introduced.
This is because it is easy enough to update the other entries to use a higher/lower value for the set of bindings being
configured. New name affixes are also very unlikely to be introduced after the set of bindings have been created.

### StripAttributes

Mod categories: Metadata

This mod removes attributes that are listed in the `Remove` list of its config.

Usage recommendations:

This mod is intended to be used as a way to clean up intermediate metadata attributes and other attributes usually
useful during bindings generation or debugging, but not particularly useful to the end user of the generated bindings.

These are attributes removed in Silk's own bindings:

- `NameAffix` - Metadata attribute used to store name affix information. Introduced by various mods.

- `NativeTypeName` - Metadata attribute used to store native type information. Introduced by `ClangScraper`.

- `Transformed` - Metadata attribute used to denote that an API is a transformed variant of another API. Introduced by
  various mods.

Tip: When debugging the name processing pipeline, disabling the `StripAttributes` mod (or just removing the
`[NameAffix]` attribute from the list of attributes to be removed) can be helpful. Disabling the stripping of other
attributes can also be helpful for this or other purposes.

### TransformEnums

Mod categories: Transformation

This mod focuses on the transformation of enum types.

Usage recommendations:

This mod can be used to reduce the platform specific differences in the generated bindings. For example, enums use
signed backing types by default on Windows while enums default to unsigned backing types on Unix. This is controlled by
the `CoerceBackingTypes` configuration option.

This mod can also be used to transform `[Flags]` enums in various ways. A `None = 0` member can be added for `[Flags]`
enums that do not have an equivalent. Member values can also be rewritten to use hexadecimal for `[Flags]` enums and
decimal values for normal enums.

Finally, the last feature is that member can be according to a filter. This filter can filter the type name and the
member name by regex. The filter can also filter by member value. One common use case is for removing the "max value"
enum members used by native libraries to ensure that enum backing types are a specific width. For example, in Vulkan,
the value used is `0x7FFFFFFF`, equivalent to the maximum value of a 32-bit signed integer.

Note: Currently, `TransformEnums` requires the `[Flags]` attribute on enum types to be added by another mod.
`TransformEnums` does not yet have the functionality to identify enums on its own. This is a relatively high priority
task. However, also note that identification will be done using a heuristic and may not be perfectly accurate. If other
metadata is available for identifying `[Flags]` enums, consider using that instead for better results.

### TransformFunctions

Mod categories: Transformation

This mod focuses on the transformation of methods, such as by changing parameters types and adding new overloads.

(TODO: To be expanded)

Notably, the transformations include transforming methods to use the Silk DSL types (`Ptr`, `Ref`, `MaybeBool`, etc).

Name affix categories:

- `RawFunction` - This is a suffix added when method overloads conflict with each other. Specifically, if a transformed
  version of a method differs from the original method only by return type, the *original* has the `-Raw` suffix added
  along with the corresponding `[NameAffix]` attribute.

Usage recommendations:

(TODO: To be expanded)

While not a requirement, the `BoolTypes` property in the configuration should match the configuration used in
`TransformProperties` for consistency.

### TransformHandles

Mod categories: Transformation

This mod focuses on the transformation of opaque structs into more developer-friendly handle types.

This is done by finding references to empty structs. If all references to the empty struct are done through pointers,
that struct will be treated as a handle type and transformed.

Empty structs identified as handle types will be transformed in two ways:

1. The struct itself will be transformed to wrap the underlying pointer and have methods/operators added for ease of
   use.

2. All references to that struct will have their pointer dimension reduced. For example, `VkBuffer**` becomes
   `VkBuffer*` This is because the mentioned struct transformation means that the innermost pointer dimension is now
   stored inside the struct.

This mod currently only processes handle types that wrap pointer types. Integer types are not yet supported.

Name affix categories:

- `HandleType` - This is a suffix added to handle types transformed by `TransformedHandles`. Note that
  `TransformHandles` only adds the attribute and does not rename the actual handle type. This is so that the rename is
  deferred until `PrettifyNames` where all renames are done in bulk for performance reasons. This pattern is explained
  in the [Name Processing - Deferring Renames](name-processing.md#deferring-renames) documentation.

Usage recommendations:

This mod should be placed after `ExtractHandles` and `AddOpaqueStructs`. This is because `TransformHandles` relies on
the previously mentioned mods to add the empty struct types. `TransformHandles` itself does not add new structs, it only
transforms existing ones that it identifies as a handle type.

### TransformProperties

Mod categories: Transformation

This mod focuses on the transformation of fields and properties. Despite the name, fields are also handled because they
often need to be transformed alongside properties or have very similar transformations that it makes sense to colocate
these transformations in the same mod.

This mod currently handles the following transformations:

1. Transform string constant properties to use the `Utf8String` type. For example,
   `static ReadOnlySpan<byte> Thing => "thing"u8;` becomes
   `static Utf8String Thing => "thing"u8;`.

2. Transform fields and properties identified to be boolean-like to use the `MaybeBool` type. This is similar to the
   transformation done by `TransformFunctions`.

Usage recommendations:

(TODO: To be expanded)

While not a requirement, the `BoolTypes` property in the configuration should match the configuration used in
`TransformFunctions` for consistency.

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

Generally, these mods should be placed after any mods (such as ones in the Creation category) that introduce any APIs
that might get transformed by these Transformation mods.
