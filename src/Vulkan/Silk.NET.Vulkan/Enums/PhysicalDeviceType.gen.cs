// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkPhysicalDeviceType")]
    public enum PhysicalDeviceType : int
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
