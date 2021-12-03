---
{
"TableOfContents": {
"Name": "Silk.NET Structure Chaining",
"Url": "structure-chaining.html",
"Metadata": {
"AuthorGitHub": "thargy",
"DateTimeWritten": "09/12/2021 16:00",
"PreviewImage": "images/blog/dec-2021/structure-chaining.png"
} } }
---

# Silk.NET Structure Chaining

With the release of Silk.NET 2.11 we've enhanced the usability of `Silk.NET.Vulkan` by addressing one of its pain
points, specifically building the [Singly Linked Lists](https://en.wikipedia.org/wiki/Linked_list) (or chains) of
structures that are frequently used to pass information to, and from, the API.

Up until now, it was not unusual to have to write quite a lot of unsafe code to work with the Vulkan API. For example, to
query device features you would need to create a chain of empty structures to be populated by the API:

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
```

Not only is this quite a bit of boiler plate (and it gets worse when you actually want to pass data to the API), it is
really easy for developers, who are not always comfortable with `unsafe` code, memory management and pointers, to
introduce subtle bugs by passing in pointers to structures they have previously generated and are now residing on the
.NET heap. Such structures can be moved by the Garbage Collector at the most unexpected times!

Thanks to Structure Chaining, we now have 2 new ways to write the above code. The most
useful [Managed Chaining](https://github.com/dotnet/Silk.NET/blob/main/documentation/structure-chaining/managed-chaining.md),
makes it much easier, _and safer_, to work with Vulkan Structure Chains. For example, the above code can now be written
as:

```csharp
using var features2 = Chain.Create<PhysicalDeviceFeatures2, PhysicalDeviceDescriptorIndexingFeatures,
    PhysicalDeviceAccelerationStructureFeaturesKHR>();
vk.GetPhysicalDeviceFeatures2(device, features2);
```

The new `Chain` classes manage the lifetime of the structures for you and they can be safely stored on the
heap, like any object. They also efficiently handle the `SType` and `PNext` fields, ensuring they are always correct. It is
also easy to modify and manipulate the chains. What is less obvious from the above example is that we are now able to
validate that `PhysicalDeviceFeatures2` can be used as the _start_ of a chain, and that
both `PhysicalDeviceDescriptorIndexingFeatures` and `PhysicalDeviceAccelerationStructureFeaturesKHR` are valid
structures to appear in such a chain. That validation occurs at compile time, meaning that most modern IDEs will give
you error 'squiggles' as soon as you try and use an invalid structure (according to the Vulkan Specification)!

That 'magic' is possible due to a set of new interfaces we've added to Vulkan Structures to indicate when they can be
used in chains, and, when the Vulkan Specification explicitly states it, what chains they can be used in. All without
effecting runtime performance.

Full documentation is
available [here](https://github.com/dotnet/Silk.NET/blob/main/documentation/structure-chaining/overview.md), and we
can't wait for you to start using the new features!  If they prove popular, we plan on expanding the functionality to
other APIs supported by Silk.NET.
