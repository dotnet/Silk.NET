// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkMemoryAllocateFlags")]
    public enum MemoryAllocateFlags : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"MaskBit\"")]
        [NativeName("Name", "VK_MEMORY_ALLOCATE_DEVICE_MASK_BIT")]
        MemoryAllocateDeviceMaskBit = 1,
        [Obsolete("Deprecated in favour of \"AddressBitKhr\"")]
        [NativeName("Name", "VK_MEMORY_ALLOCATE_DEVICE_ADDRESS_BIT_KHR")]
        MemoryAllocateDeviceAddressBitKhr = 2,
        [Obsolete("Deprecated in favour of \"AddressCaptureReplayBitKhr\"")]
        [NativeName("Name", "VK_MEMORY_ALLOCATE_DEVICE_ADDRESS_CAPTURE_REPLAY_BIT_KHR")]
        MemoryAllocateDeviceAddressCaptureReplayBitKhr = 4,
        [Obsolete("Deprecated in favour of \"AddressBit\"")]
        [NativeName("Name", "VK_MEMORY_ALLOCATE_DEVICE_ADDRESS_BIT")]
        MemoryAllocateDeviceAddressBit = 2,
        [Obsolete("Deprecated in favour of \"AddressCaptureReplayBit\"")]
        [NativeName("Name", "VK_MEMORY_ALLOCATE_DEVICE_ADDRESS_CAPTURE_REPLAY_BIT")]
        MemoryAllocateDeviceAddressCaptureReplayBit = 4,
        [NativeName("Name", "VK_MEMORY_ALLOCATE_DEVICE_MASK_BIT")]
        MaskBit = 1,
        [NativeName("Name", "VK_MEMORY_ALLOCATE_DEVICE_ADDRESS_BIT_KHR")]
        AddressBitKhr = 2,
        [NativeName("Name", "VK_MEMORY_ALLOCATE_DEVICE_ADDRESS_CAPTURE_REPLAY_BIT_KHR")]
        AddressCaptureReplayBitKhr = 4,
        [NativeName("Name", "VK_MEMORY_ALLOCATE_DEVICE_ADDRESS_BIT")]
        AddressBit = 2,
        [NativeName("Name", "VK_MEMORY_ALLOCATE_DEVICE_ADDRESS_CAPTURE_REPLAY_BIT")]
        AddressCaptureReplayBit = 4,
    }
}
