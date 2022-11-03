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
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"DeviceLocalBit\"")]
        [NativeName("Name", "VK_MEMORY_PROPERTY_DEVICE_LOCAL_BIT")]
        MemoryPropertyDeviceLocalBit = 1,
        [Obsolete("Deprecated in favour of \"HostVisibleBit\"")]
        [NativeName("Name", "VK_MEMORY_PROPERTY_HOST_VISIBLE_BIT")]
        MemoryPropertyHostVisibleBit = 2,
        [Obsolete("Deprecated in favour of \"HostCoherentBit\"")]
        [NativeName("Name", "VK_MEMORY_PROPERTY_HOST_COHERENT_BIT")]
        MemoryPropertyHostCoherentBit = 4,
        [Obsolete("Deprecated in favour of \"HostCachedBit\"")]
        [NativeName("Name", "VK_MEMORY_PROPERTY_HOST_CACHED_BIT")]
        MemoryPropertyHostCachedBit = 8,
        [Obsolete("Deprecated in favour of \"LazilyAllocatedBit\"")]
        [NativeName("Name", "VK_MEMORY_PROPERTY_LAZILY_ALLOCATED_BIT")]
        MemoryPropertyLazilyAllocatedBit = 16,
        [Obsolete("Deprecated in favour of \"DeviceCoherentBitAmd\"")]
        [NativeName("Name", "VK_MEMORY_PROPERTY_DEVICE_COHERENT_BIT_AMD")]
        MemoryPropertyDeviceCoherentBitAmd = 64,
        [Obsolete("Deprecated in favour of \"DeviceUncachedBitAmd\"")]
        [NativeName("Name", "VK_MEMORY_PROPERTY_DEVICE_UNCACHED_BIT_AMD")]
        MemoryPropertyDeviceUncachedBitAmd = 128,
        [Obsolete("Deprecated in favour of \"RdmaCapableBitNV\"")]
        [NativeName("Name", "VK_MEMORY_PROPERTY_RDMA_CAPABLE_BIT_NV")]
        MemoryPropertyRdmaCapableBitNV = 256,
        [Obsolete("Deprecated in favour of \"ProtectedBit\"")]
        [NativeName("Name", "VK_MEMORY_PROPERTY_PROTECTED_BIT")]
        MemoryPropertyProtectedBit = 32,
        [NativeName("Name", "VK_MEMORY_PROPERTY_DEVICE_LOCAL_BIT")]
        DeviceLocalBit = 1,
        [NativeName("Name", "VK_MEMORY_PROPERTY_HOST_VISIBLE_BIT")]
        HostVisibleBit = 2,
        [NativeName("Name", "VK_MEMORY_PROPERTY_HOST_COHERENT_BIT")]
        HostCoherentBit = 4,
        [NativeName("Name", "VK_MEMORY_PROPERTY_HOST_CACHED_BIT")]
        HostCachedBit = 8,
        [NativeName("Name", "VK_MEMORY_PROPERTY_LAZILY_ALLOCATED_BIT")]
        LazilyAllocatedBit = 16,
        [NativeName("Name", "VK_MEMORY_PROPERTY_DEVICE_COHERENT_BIT_AMD")]
        DeviceCoherentBitAmd = 64,
        [NativeName("Name", "VK_MEMORY_PROPERTY_DEVICE_UNCACHED_BIT_AMD")]
        DeviceUncachedBitAmd = 128,
        [NativeName("Name", "VK_MEMORY_PROPERTY_RDMA_CAPABLE_BIT_NV")]
        RdmaCapableBitNV = 256,
        [NativeName("Name", "VK_MEMORY_PROPERTY_PROTECTED_BIT")]
        ProtectedBit = 32,
    }
}
