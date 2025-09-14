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
        [Obsolete("Deprecated in favour of \"DeviceMaskBit\"")]
        [NativeName("Name", "VK_MEMORY_ALLOCATE_DEVICE_MASK_BIT")]
        MemoryAllocateDeviceMaskBit = 1,
        [Obsolete("Deprecated in favour of \"DeviceAddressBitKhr\"")]
        [NativeName("Name", "VK_MEMORY_ALLOCATE_DEVICE_ADDRESS_BIT_KHR")]
        MemoryAllocateDeviceAddressBitKhr = 2,
        [Obsolete("Deprecated in favour of \"DeviceAddressCaptureReplayBitKhr\"")]
        [NativeName("Name", "VK_MEMORY_ALLOCATE_DEVICE_ADDRESS_CAPTURE_REPLAY_BIT_KHR")]
        MemoryAllocateDeviceAddressCaptureReplayBitKhr = 4,
        [Obsolete("Deprecated in favour of \"ZeroInitializeBitExt\"")]
        [NativeName("Name", "VK_MEMORY_ALLOCATE_ZERO_INITIALIZE_BIT_EXT")]
        MemoryAllocateZeroInitializeBitExt = 8,
        [Obsolete("Deprecated in favour of \"DeviceAddressBit\"")]
        [NativeName("Name", "VK_MEMORY_ALLOCATE_DEVICE_ADDRESS_BIT")]
        MemoryAllocateDeviceAddressBit = 2,
        [Obsolete("Deprecated in favour of \"DeviceAddressCaptureReplayBit\"")]
        [NativeName("Name", "VK_MEMORY_ALLOCATE_DEVICE_ADDRESS_CAPTURE_REPLAY_BIT")]
        MemoryAllocateDeviceAddressCaptureReplayBit = 4,
        [NativeName("Name", "VK_MEMORY_ALLOCATE_DEVICE_MASK_BIT")]
        DeviceMaskBit = 1,
        [NativeName("Name", "VK_MEMORY_ALLOCATE_DEVICE_ADDRESS_BIT_KHR")]
        DeviceAddressBitKhr = 2,
        [NativeName("Name", "VK_MEMORY_ALLOCATE_DEVICE_ADDRESS_CAPTURE_REPLAY_BIT_KHR")]
        DeviceAddressCaptureReplayBitKhr = 4,
        [NativeName("Name", "VK_MEMORY_ALLOCATE_ZERO_INITIALIZE_BIT_EXT")]
        ZeroInitializeBitExt = 8,
        [NativeName("Name", "VK_MEMORY_ALLOCATE_DEVICE_ADDRESS_BIT")]
        DeviceAddressBit = 2,
        [NativeName("Name", "VK_MEMORY_ALLOCATE_DEVICE_ADDRESS_CAPTURE_REPLAY_BIT")]
        DeviceAddressCaptureReplayBit = 4,
    }
}
