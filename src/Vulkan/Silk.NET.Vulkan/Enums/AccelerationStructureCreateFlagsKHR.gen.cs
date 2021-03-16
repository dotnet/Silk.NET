// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags()]
    [NativeName("Name", "VkAccelerationStructureCreateFlagsKHR")]
    public enum AccelerationStructureCreateFlagsKHR : int
    {
        [NativeName("Name", "VK_ACCELERATION_STRUCTURE_CREATE_DEVICE_ADDRESS_CAPTURE_REPLAY_BIT_KHR")]
        AccelerationStructureCreateDeviceAddressCaptureReplayBitKhr = 1,
        [NativeName("Name", "VK_ACCELERATION_STRUCTURE_CREATE_RESERVED_BIT_2_NV")]
        AccelerationStructureCreateReservedBit2NV = 4,
    }
}
