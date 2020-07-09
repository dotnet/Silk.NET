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
    [NativeName("Name", "VkDeviceGroupPresentModeFlagsKHR")]
    public enum DeviceGroupPresentModeFlagsKHR
    {
        [NativeName("Name", "VK_DEVICE_GROUP_PRESENT_MODE_LOCAL_BIT_KHR")]
        DeviceGroupPresentModeLocalBitKhr = 1,
        [NativeName("Name", "VK_DEVICE_GROUP_PRESENT_MODE_REMOTE_BIT_KHR")]
        DeviceGroupPresentModeRemoteBitKhr = 2,
        [NativeName("Name", "VK_DEVICE_GROUP_PRESENT_MODE_SUM_BIT_KHR")]
        DeviceGroupPresentModeSumBitKhr = 4,
        [NativeName("Name", "VK_DEVICE_GROUP_PRESENT_MODE_LOCAL_MULTI_DEVICE_BIT_KHR")]
        DeviceGroupPresentModeLocalMultiDeviceBitKhr = 8,
    }
}
