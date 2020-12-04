// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkPhysicalDeviceType")]
    public enum PhysicalDeviceType
    {
        [NativeName("Name", "VK_PHYSICAL_DEVICE_TYPE_OTHER")]
        Other = 0,
        [NativeName("Name", "VK_PHYSICAL_DEVICE_TYPE_INTEGRATED_GPU")]
        IntegratedGpu = 1,
        [NativeName("Name", "VK_PHYSICAL_DEVICE_TYPE_DISCRETE_GPU")]
        DiscreteGpu = 2,
        [NativeName("Name", "VK_PHYSICAL_DEVICE_TYPE_VIRTUAL_GPU")]
        VirtualGpu = 3,
        [NativeName("Name", "VK_PHYSICAL_DEVICE_TYPE_CPU")]
        Cpu = 4,
    }
}
