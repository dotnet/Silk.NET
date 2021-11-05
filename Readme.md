# Prototype Struct Chaining

This repository implements a prototype solution for Struct Chaining in [Silk.Net](https://github.com/dotnet/Silk.NET)

## Design Goals

* **Backward compatibility** - the chaining system should not change the existing structs, but add functionality.
* **Minimal bloat** - the minimum amount of new generated code was sought.
* **Discoverability** - it should be as easy as possible for a new user to discover
* **Compile-time Validation** - it should prevent chaining invalid structures (as much as possible) during compilation
* **Type coercion** - it should set the SType of chained structures.
* **Compact usage** - it should reduce copy-pasta code.
* **Avoid the heap** - boxing should be avoided
* **Well Tested** - tests were added to ensure pointers are correctly set, and compilation failures occur.

All of these goals were met.

## Usage

The proposal provides for the following usage patterns:

### Chain Building

You can happily create the start of a chain as usual, and it's `SType` will be coerced when you start using it as a
chain:

```csharp
var createInfo = new DeviceCreateInfo
{
    Flags = 1U
};
// When you call any chaining method it will set the chain's SType automatically.
createinfo.AddNext...
```

-in many cases, we only want to create a default structure for population by the API. To do so, we use the
static `Chain`
method like so:

```csharp
PhysicalDeviceFeatures2.Chain(out var features2)
```

This has several advantages:

- The method is only available for structures that are valid at the start of a chain; providing compile-time validation.
- The structure's `SType` will be correctly set immediately.
- The syntax is fluent, and creates more readable code when used with the other chaining methods (see below).

### AddNext

The most common use case is to add an empty structure to the end of a chain for it to be populated by the Vulkan API,
this can now be done like so:

```csharp
PhysicalDeviceFeatures2
    .Chain(out var features2)
    // CreateNext will create an empty struct, with the correct SType (as well as ensuring the
    // chain's SType is set correctly).
    .AddNext(out PhysicalDeviceDescriptorIndexingFeatures indexingFeatures)
    .AddNext(out PhysicalDeviceAccelerationStructureFeaturesKHR accelerationStructureFeaturesKhr);
```

Each method `out` puts a struct into the local stackframe for querying once populated, and the pointers point to this
local variable. Despite generics and interfaces being used, the chain methods avoid the heap entirely.

### TryAddNext

You may only want to add a structure if it doesn't already exist in the chain, this can be done with `TryAddNext`, e.g.:

```csharp
PhysicalDeviceFeatures2
    .Chain(out var features2)
    .AddNext(out PhysicalDeviceDescriptorIndexingFeatures indexingFeatures)
    // As there is already a PhysicalDeviceDescriptorIndexingFeatures structure the following
    // will not add anything to the chain and `added` will be `false`.
    .TryAddNext(out PhysicalDeviceDescriptorIndexingFeatures indexingFeatures2, out bool added);
```

### SetNext

Sometimes we may wish to set the initial state of a structure, we can do this with `SetNext`:

```csharp
var indexingFeatures = new PhysicalDeviceDescriptorIndexingFeatures
{
    ShaderInputAttachmentArrayDynamicIndexing = true
};
var accelerationStructureFeaturesKhr = new PhysicalDeviceAccelerationStructureFeaturesKHR
{
    AccelerationStructure = true
};

PhysicalDeviceFeatures2
    .Chain(out var features2)
    // SetNext accepts an existing struct, note, it will coerce the SType and blank the PNext
    .SetNext(ref indexingFeatures)
    .SetNext(ref accelerationStructureFeaturesKhr);
```

*NOTE* you can mix and match `AddNext` and `SetNext` (and any chaining method) in the same method chain.

By default, `SetNext` will replace any item in the chain with a matching `SType`, this behaviour can be changed by
setting the optional
`alwaysAdd` parameter to `true`;

```csharp
var indexingFeatures = new PhysicalDeviceDescriptorIndexingFeatures
{
    ShaderInputAttachmentArrayDynamicIndexing = true
};
var indexingFeatures2 = new PhysicalDeviceDescriptorIndexingFeatures
{
    ShaderInputAttachmentArrayDynamicIndexing = false
};
var accelerationStructureFeaturesKhr = new PhysicalDeviceAccelerationStructureFeaturesKHR
{
    AccelerationStructure = true
};

PhysicalDeviceFeatures2
    .Chain(out var features2)
    .SetNext(ref indexingFeatures)
    // This will add the second 'indexingFeatures' struct, even though one is already present in the chain.
    .SetNext(ref indexingFeatures2, true);
```

### IndexOf

Sometimes it's useful to know if a structure you previously supplied is still in a chain, this can be done
with `IndexOf`, which returns a non-negative index (zero-indexed) if the structure is found, eg.:

```csharp
PhysicalDeviceFeatures2
    .Chain(out var features2)
    .AddNext(out PhysicalDeviceDescriptorIndexingFeatures indexingFeatures)
    .AddNext(out PhysicalDeviceAccelerationStructureFeaturesKHR accelerationStructureFeaturesKhr);

// Check indices
Assert.Equal(1, features2.IndexOf(ref indexingFeatures));
Assert.Equal(2, features2.IndexOf(ref accelerationStructureFeaturesKhr));
```

## Features

* All the chaining methods are only available on the structures that implement `IChainStart`, i.e. the structures that
  the Vulkan specification says can start a chain.
* All the chaining methods ensure the chain, and any supplied structures, have their `SType` correctly set.
* All the chaining methods will only accept a structure that is valid in the chain being extended, as per the Vulkan
  specification.
* The chaining methods do not box structures, or add anything to the heap.

## Changes required

* Add the new `IStructureType`, `IChainable`, `IChainStart`, `IExtendChain<TChain>` interfaces.
* Add the new `Chain` structure.
* Add the `ChainExtensions` extension methods `SetNext`, `AddNew`, `IndexOf`, `AddNext` and `TryAddNext`.
* Add the small instance `StructureType IStructuredType.StructureType()` method to `IChainable` structure.
* Add the `IChainStart` interface and the small static `Chain` method to any structure that can be used as the start of
  a chain.
* Add `IExtendsChain<ChainStart>` interfaces to any structures that can extend a chain.

Note that the [Vulkan XML](https://raw.githubusercontent.com/KhronosGroup/Vulkan-Headers/master/registry/vk.xml) does
include the `structextends` attribute on each structure that directly maps to the `IExtendsChain<T>` interfaces that
need to be added. However, to add the `IChainStart` interface (and it's associated method), these structures have to be
marked as a chain start whenever we see a structure extending them.

Although it is possible to not use a design that does not make use of `IChainStart` the following functionality is lost:

* The `Chain` method will appear on all chainable structures, even when they don't represent the start of a chain.
* All extension methods will appear on all chainable structures, even when they are not the start.
* Indexing, adding, etc. can't be guaranteed to be scanning from the start of the chain.

As adding `IChainStart` requires relatively simple logic I believe it's worth including.