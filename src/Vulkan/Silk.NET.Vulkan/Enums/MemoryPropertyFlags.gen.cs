// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkMemoryPropertyFlags")]
    public enum MemoryPropertyFlags : int
    {
        [NativeName("Name", "VK_MEMORY_PROPERTY_DEVICE_LOCAL_BIT")]
        MemoryPropertyDeviceLocalBit = 1,
        [NativeName("Name", "VK_MEMORY_PROPERTY_HOST_VISIBLE_BIT")]
        MemoryPropertyHostVisibleBit = 2,
        [NativeName("Name", "VK_MEMORY_PROPERTY_HOST_COHERENT_BIT")]
        MemoryPropertyHostCoherentBit = 4,
        [NativeName("Name", "VK_MEMORY_PROPERTY_HOST_CACHED_BIT")]
        MemoryPropertyHostCachedBit = 8,
        [NativeName("Name", "VK_MEMORY_PROPERTY_LAZILY_ALLOCATED_BIT")]
        MemoryPropertyLazilyAllocatedBit = 16,
        [NativeName("Name", "VK_MEMORY_PROPERTY_DEVICE_COHERENT_BIT_AMD")]
        MemoryPropertyDeviceCoherentBitAmd = 64,
        [NativeName("Name", "VK_MEMORY_PROPERTY_DEVICE_UNCACHED_BIT_AMD")]
        MemoryPropertyDeviceUncachedBitAmd = 128,
        [NativeName("Name", "VK_MEMORY_PROPERTY_RDMA_CAPABLE_BIT_NV")]
        MemoryPropertyRdmaCapableBitNV = 256,
        [NativeName("Name", "VK_MEMORY_PROPERTY_PROTECTED_BIT")]
        MemoryPropertyProtectedBit = 32,
    }
}
