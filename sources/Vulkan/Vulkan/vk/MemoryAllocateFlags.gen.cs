// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkMemoryAllocateFlags")]
[Flags]
public enum MemoryAllocateFlags : uint
{
    None = 0x0,

    [NativeName("VK_MEMORY_ALLOCATE_DEVICE_MASK_BIT")]
    DeviceMaskBit = 0x1,

    [NativeName("VK_MEMORY_ALLOCATE_DEVICE_ADDRESS_BIT")]
    DeviceAddressBit = 0x2,

    [NativeName("VK_MEMORY_ALLOCATE_DEVICE_ADDRESS_CAPTURE_REPLAY_BIT")]
    DeviceAddressCaptureReplayBit = 0x4,

    [NativeName("VK_MEMORY_ALLOCATE_ZERO_INITIALIZE_BIT_EXT")]
    ZeroInitializeBitEXT = 0x8,

    [NativeName("VK_MEMORY_ALLOCATE_DEVICE_MASK_BIT_KHR")]
    DeviceMaskBitKHR = DeviceMaskBit,

    [NativeName("VK_MEMORY_ALLOCATE_DEVICE_ADDRESS_BIT_KHR")]
    DeviceAddressBitKHR = DeviceAddressBit,

    [NativeName("VK_MEMORY_ALLOCATE_DEVICE_ADDRESS_CAPTURE_REPLAY_BIT_KHR")]
    DeviceAddressCaptureReplayBitKHR = DeviceAddressCaptureReplayBit,
}
