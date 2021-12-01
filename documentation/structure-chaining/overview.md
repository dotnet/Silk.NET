# Overview

## Table of Contents

- [Overview](#overview)
    - [Table of Contents](#table-of-contents)
    - [Background](#background)
    - [Managed Chains](#managed-chaining) _(main article [here](managed-chaining.md))_
    - [Structure Chaining](#structure-chaining) _(main article [here](structure-chaining.md))_
    - [Raw Chaining](#raw-chaining) _(main article [here](raw_chaining.md))_
- [Vulkan Chaining](vulkan.md)
    - [BaseInStructure](vulkan.md#baseinstructure)
    - [IChainable](vulkan.md#ichainable)
    - [IStructureType](vulkan.md#istructuredtype)
    - [IExtendsChain&lt;TChain&gt;](vulkan.md#iextendschainlttchaingt)
    - [IChainStart](vulkan.md#ichainstart)
    - ['Any' Overloads](vulkan.md#any-overloads)
- [Managed Chains](managed-chaining.md) _(recommended)_
- [Structure Chaining](structure-chaining.md)
- [Raw Chaining](raw_chaining.md)
    - [Overview](raw_chaining.md#overview)
    - [Best Practices](raw_chaining.md#best-practices)
    - [Performance](#performance)

## Background

Several of the APIs exposed by Silk.NET pass data using
a [Singly Linked List](https://en.wikipedia.org/wiki/Linked_list) of structures. We refer to these lists as 'chains'.
This is achieved by have a standardised pointer (`void*`) that can be used to point to the next item, with
the `nullptr` (i.e. `0`) used to indicate the end of the list.

However, pointers are particularly problematic in managed programming as the runtime is often free to move objects on
the heap around during Garbage Collection. As such, C# requires you to explicitly mark code that works with pointers
as `unsafe`, to let the compiler know that you are aware of the dangers. The Runtime usually manages pointers for you
under the hood, repointing them if it moves any objects around and, as such, many developers do not use them frequently
enough to be aware of the pitfalls, and the potential bugs that can occur can be subtle and hard to trace.

Silk.NET always exposes the lowest level API possible, allowing you to directly manipulate these chains via directly
setting the pointers as appropriate. However, it also exposes 2 new methods of maintaining these chains more easily and
safely.

Currently, these new methods are only available in the `Silk.NET.Vulkan` package when using the Vulkan API, however, if
popular, they will be considered for more of the exposed APIs in future.

## Chaining methodologies

There are 3, chaining methodologies supported by Silk.Net.

### Managed Chaining

[_(Covered in more detail here)_](managed-chaining.md)

This is the _recommended_ approach.  `Chain` is a lightweight C# object that manages the memory of chain, and ensure
internal pointers remain valid throughout it's lifetime. For example:

```csharp
using (var features2 = Chain.Create
(
    default(PhysicalDeviceFeatures2),
    default(PhysicalDeviceDescriptorIndexingFeatures),
    default(PhysicalDeviceAccelerationStructureFeaturesKHR)
)) {
    vk.GetPhysicalDeviceFeatures2(device, features2);
    var depthBounds = features2.Head.Features.DepthBounds;
    var runtimeDescriptorArray = features2.Item1.RuntimeDescriptorArray;
    var accelerationStructure = features2.Item2.AccelerationStructure;
}
```

### Structure Chaining

[_(Covered in more detail here)_](structure-chaining.md)

If you are creating a chain once, and then throwing it away, it can be done so safely, so long as the structures you
create never leave the stack. Silk.NET provides fluent extension methods that allow you to manipulate `IChainable`
structures directly, performing the pointer logic for you, and providing compile-time type validation. Although,
avoiding the heap entirely, there are some scenarios where this may still be slower than
using [Managed Chains](managed-chains.md), and so this approach should only be considered when looking to optimise hot
paths. For example:

```csharp
PhysicalDeviceFeatures2
    .Chain(out var features2)
    .AddNext(out PhysicalDeviceDescriptorIndexingFeatures indexingFeatures)
    .AddNext(out PhysicalDeviceAccelerationStructureFeaturesKHR accelerationStructureFeaturesKhr);
vk.GetPhysicalDeviceFeatures2(device, &features2);
var depthBounds = features2.Features.DepthBounds;
var runtimeDescriptorArray = indexingFeatures.RuntimeDescriptorArray;
var accelerationStructure = accelerationStructureFeaturesKhr.AccelerationStructure;
```

### Raw Chaining

[_(Covered in more detail here)_](raw_chaining.md)

Where you are looking to optimise a hot path, and every cycle counts, direct modification of chains is always available.
Again though, you should benchmark against the above two methodologies to ensure you are gaining the benefit you hope
for. For example:

```csharp
var accelerationStructureFeaturesKhr = new PhysicalDeviceAccelerationStructureFeaturesKHR
    {SType = StructureType.PhysicalDeviceAccelerationStructureFeaturesKhr};
var indexingFeatures = new PhysicalDeviceDescriptorIndexingFeatures
{
    SType = StructureType.PhysicalDeviceDescriptorIndexingFeatures,
    PNext = &accelerationStructureFeaturesKhr
};
var features2 = new PhysicalDeviceFeatures2
{
    SType = StructureType.PhysicalDeviceFeatures2,
    PNext = &indexingFeatures
};
vk.GetPhysicalDeviceFeatures2(device, &features2);
var depthBounds = features2.Features.DepthBounds;
var runtimeDescriptorArray = indexingFeatures.RuntimeDescriptorArray;
var accelerationStructure = accelerationStructureFeaturesKhr.AccelerationStructure;
```