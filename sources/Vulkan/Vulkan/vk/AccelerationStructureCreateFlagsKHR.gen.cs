// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkAccelerationStructureCreateFlagsKHR")]
[Flags]
public enum AccelerationStructureCreateFlagsKHR : uint
{
    None = 0x0,

    [NativeName("VK_ACCELERATION_STRUCTURE_CREATE_DEVICE_ADDRESS_CAPTURE_REPLAY_BIT_KHR")]
    DeviceAddressCaptureReplayBit = 0x1,

    [NativeName("VK_ACCELERATION_STRUCTURE_CREATE_DESCRIPTOR_BUFFER_CAPTURE_REPLAY_BIT_EXT")]
    DescriptorBufferCaptureReplayBitEXT = 0x8,

    [NativeName("VK_ACCELERATION_STRUCTURE_CREATE_MOTION_BIT_NV")]
    MotionBitNV = 0x4,
}
