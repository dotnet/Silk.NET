// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags()]
    public enum MemoryAllocateFlags
    {
        MemoryAllocateDeviceMaskBit = 1,
        MemoryAllocateDeviceAddressBitKhr = 2,
        MemoryAllocateDeviceAddressCaptureReplayBitKhr = 4,
        MemoryAllocateDeviceAddressBit = 2,
        MemoryAllocateDeviceAddressCaptureReplayBit = 4,
    }
}
