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

### CreateNext

The most common use case is to create an empty structure to be populated by the Vulkan API, this can now be done like so:

```csharp
PhysicalDeviceFeatures2
    // The Chain method, is a convenient static, to provide a consistent syntax.
    .Chain(out var features2)
    // CreateNext will create an empty struct, with the correct SType (as well as ensuring the
    // caller SType is coerced correctly.
    .CreateNext(out PhysicalDeviceDescriptorIndexingFeatures indexingFeatures)
    .CreateNext(out PhysicalDeviceAccelerationStructureFeaturesKHR accelerationStructureFeaturesKhr);
```

We start by using the static `Chain` method, this is a convenience method that is not required, but it provides a more readable style.

Each method `out`puts a struct into the local stackframe for querying once populated.  Despite generics and interface being used, boxing doesn't not occur.

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

*NOTE* you can mix and match `CreateNext` and `SetNext` in the same chain.

### Without Chain

The use of the `Chain` method is entirely optional, for example if we wish to 

```csharp
// We don't have to use the Chain() pattern, as we can start with an existing struct
var createInfo = new DeviceCreateInfo
{
    Flags = 1U
};
// However, note that CreateNext will still coerce the SType of createInfo.
createInfo.CreateNext(out PhysicalDeviceFeatures2 features2);
```

## Changes required

* Add the `IChainable` and `IChainable<TNext>` interfaces.
* Add the `ChainExtensions` extension methods `SetNext` and `CreateNext`.
* Add the small instance `void SetNext(void*)` method to each structure (this is required).
* Add the small static `Chain` method to each structure (note, this is optional sugar, allowing for 'single statement' building).
* Add `IChainable<StructType>` interfaces to every chainable struct to indicate each valid structure accepted by `PNext`, eg.:
```csharp
public struct DeviceCreateInfo :
    IChainable<PhysicalDeviceFeatures2>,
    IChainable<PhysicalDeviceDescriptorIndexingFeatures>,
    IChainable<PhysicalDeviceAccelerationStructureFeaturesKHR> ...
```

