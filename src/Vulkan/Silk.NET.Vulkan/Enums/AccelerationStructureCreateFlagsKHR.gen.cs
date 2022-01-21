// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkAccelerationStructureCreateFlagsKHR")]
    public enum AccelerationStructureCreateFlagsKHR : int
    {
        [NativeName("Name", "VK_ACCELERATION_STRUCTURE_CREATE_DEVICE_ADDRESS_CAPTURE_REPLAY_BIT_KHR")]
        AccelerationStructureCreateDeviceAddressCaptureReplayBitKhr = 1,
        [NativeName("Name", "VK_ACCELERATION_STRUCTURE_CREATE_MOTION_BIT_NV")]
        AccelerationStructureCreateMotionBitNV = 4,
    }
}
