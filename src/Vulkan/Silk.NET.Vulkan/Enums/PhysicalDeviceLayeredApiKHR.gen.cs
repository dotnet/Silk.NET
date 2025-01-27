// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkPhysicalDeviceLayeredApiKHR")]
    public enum PhysicalDeviceLayeredApiKHR : int
    {
        [Obsolete("Deprecated in favour of \"VulkanKhr\"")]
        [NativeName("Name", "VK_PHYSICAL_DEVICE_LAYERED_API_VULKAN_KHR")]
        PhysicalDeviceLayeredApiVulkanKhr = 0,
        [Obsolete("Deprecated in favour of \"D3D12Khr\"")]
        [NativeName("Name", "VK_PHYSICAL_DEVICE_LAYERED_API_D3D12_KHR")]
        PhysicalDeviceLayeredApiD3D12Khr = 1,
        [Obsolete("Deprecated in favour of \"MetalKhr\"")]
        [NativeName("Name", "VK_PHYSICAL_DEVICE_LAYERED_API_METAL_KHR")]
        PhysicalDeviceLayeredApiMetalKhr = 2,
        [Obsolete("Deprecated in favour of \"OpenglKhr\"")]
        [NativeName("Name", "VK_PHYSICAL_DEVICE_LAYERED_API_OPENGL_KHR")]
        PhysicalDeviceLayeredApiOpenglKhr = 3,
        [Obsolete("Deprecated in favour of \"OpenglesKhr\"")]
        [NativeName("Name", "VK_PHYSICAL_DEVICE_LAYERED_API_OPENGLES_KHR")]
        PhysicalDeviceLayeredApiOpenglesKhr = 4,
        [NativeName("Name", "VK_PHYSICAL_DEVICE_LAYERED_API_VULKAN_KHR")]
        VulkanKhr = 0,
        [NativeName("Name", "VK_PHYSICAL_DEVICE_LAYERED_API_D3D12_KHR")]
        D3D12Khr = 1,
        [NativeName("Name", "VK_PHYSICAL_DEVICE_LAYERED_API_METAL_KHR")]
        MetalKhr = 2,
        [NativeName("Name", "VK_PHYSICAL_DEVICE_LAYERED_API_OPENGL_KHR")]
        OpenglKhr = 3,
        [NativeName("Name", "VK_PHYSICAL_DEVICE_LAYERED_API_OPENGLES_KHR")]
        OpenglesKhr = 4,
    }
}
