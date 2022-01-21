// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkMemoryAllocateFlagsKHR")]
    public enum MemoryAllocateFlagsKHR : int
    {
        [NativeName("Name", "VK_MEMORY_ALLOCATE_DEVICE_MASK_BIT")]
        MemoryAllocateDeviceMaskBit = 1,
    }
}
