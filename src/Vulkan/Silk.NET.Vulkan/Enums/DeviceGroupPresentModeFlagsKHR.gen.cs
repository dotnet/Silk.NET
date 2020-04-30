// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

namespace Silk.NET.Vulkan
{
    [Flags()]
    public enum DeviceGroupPresentModeFlagsKHR
    {
        DeviceGroupPresentModeLocalBitKhr = 1,
        DeviceGroupPresentModeRemoteBitKhr = 2,
        DeviceGroupPresentModeSumBitKhr = 4,
        DeviceGroupPresentModeLocalMultiDeviceBitKhr = 8,
    }
}
