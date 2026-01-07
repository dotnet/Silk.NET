# Raw Chaining

[Table of Contents](overview.md#table-of-contents)
- [Overview](raw_chaining.md#overview)
- [Best Practices](raw_chaining.md#best-practices)
- [Performance](raw_chaining.md#performance)

## Overview

Raw chaining, refers to using the `IChainable` structures directly. The user is responsible for ensuring the `SType`
and `PNext` fields are set, and that any data pointed to by `PNext` does not move whilst it is being consumed by the
API.

## Best Practices

The easiest way to prevent pointers moving is to ensure that structures are created and used locally in the same
function. This ensures that they remain in the current stack frame, preventing the runtime from moving any data.
Sometimes, it is desirable to store structures for later use, in which case [Managed Chaining](managed-chaining.md) should
be considered.

Each structure defines a constructor which accepts the fields as parameters and specifies defaults, including the
correct
`SType`. As such it is possible, to setup the structures like so:

```csharp
var accelerationStructureFeaturesKhr = new PhysicalDeviceAccelerationStructureFeaturesKHR(pNext: null);
var indexingFeatures = new PhysicalDeviceDescriptorIndexingFeatures(pNext: &accelerationStructureFeaturesKhr);
var features2 = new PhysicalDeviceFeatures2(pNext: &indexingFeatures);
vk.GetPhysicalDeviceFeatures2(device, &features2);
var depthBounds = features2.Features.DepthBounds;
var runtimeDescriptorArray = indexingFeatures.RuntimeDescriptorArray;
var accelerationStructure = accelerationStructureFeaturesKhr.AccelerationStructure;
```

However, notice the 'gotcha' on the first line where we set `pNExt` to `null`, even though the default is
already `null`:

```csharp
var accelerationStructureFeaturesKhr = new PhysicalDeviceAccelerationStructureFeaturesKHR(pNext: null);
```

We _have_ to do that, as calling `new PhysicalDeviceAccelerationStructureFeaturesKHR()`, with no parameters is
equivalent to using `default`, in which case the `SType` is not set correctly.

As such it is safest to always be explicit, e.g.:

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

Alternatively, you can make use of `IChainable`, though that incurs a boxing overhead, at which point you should
consider whether raw chaining is the right approach. For example:

```csharp
var accelerationStructureFeaturesKhr = new PhysicalDeviceAccelerationStructureFeaturesKHR();
((IChainable) accelerationStructureFeaturesKhr).StructureType();
var indexingFeatures = new PhysicalDeviceDescriptorIndexingFeatures
    {PNext = &accelerationStructureFeaturesKhr};
((IChainable) indexingFeatures).StructureType();
var features2 = new PhysicalDeviceFeatures2 {PNext = &indexingFeatures};
((IChainable) features2).StructureType();
```

## Performance

In general Raw Chaining will almost always allow the greatest performance, however it may not be significantly better
than either of the other two methodologies, depending on the exact use case. In some cases it can be slower, for example
if the chain ends up be passed around and copy operations are triggerred inadvertently on larger structures. For this
reason, it is usually better to start with [Managed Chaining](managed-chaining.md), and optimise hot paths were
necessary, using benchmarking to validate results. Starting with one of the other two approaches will usually make it
easier to validate chain types, and improve compile time checking during development.
