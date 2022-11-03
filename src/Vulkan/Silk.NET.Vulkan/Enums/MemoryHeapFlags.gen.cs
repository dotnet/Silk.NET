// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkMemoryHeapFlags")]
    public enum MemoryHeapFlags : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"DeviceLocalBit\"")]
        [NativeName("Name", "VK_MEMORY_HEAP_DEVICE_LOCAL_BIT")]
        MemoryHeapDeviceLocalBit = 1,
        [Obsolete("Deprecated in favour of \"MultiInstanceBitKhr\"")]
        [NativeName("Name", "VK_MEMORY_HEAP_MULTI_INSTANCE_BIT_KHR")]
        MemoryHeapMultiInstanceBitKhr = 2,
        [Obsolete("Deprecated in favour of \"Reserved2BitKhr\"")]
        [NativeName("Name", "VK_MEMORY_HEAP_RESERVED_2_BIT_KHR")]
        MemoryHeapReserved2BitKhr = 4,
        [Obsolete("Deprecated in favour of \"MultiInstanceBit\"")]
        [NativeName("Name", "VK_MEMORY_HEAP_MULTI_INSTANCE_BIT")]
        MemoryHeapMultiInstanceBit = 2,
        [NativeName("Name", "VK_MEMORY_HEAP_DEVICE_LOCAL_BIT")]
        DeviceLocalBit = 1,
        [NativeName("Name", "VK_MEMORY_HEAP_MULTI_INSTANCE_BIT_KHR")]
        MultiInstanceBitKhr = 2,
        [NativeName("Name", "VK_MEMORY_HEAP_RESERVED_2_BIT_KHR")]
        Reserved2BitKhr = 4,
        [NativeName("Name", "VK_MEMORY_HEAP_MULTI_INSTANCE_BIT")]
        MultiInstanceBit = 2,
    }
}
