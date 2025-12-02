// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceLayeredApiKHR")]
[SupportedApiProfile("vulkan")]
public enum PhysicalDeviceLayeredApiKHR : uint
{
    [NativeName("VK_PHYSICAL_DEVICE_LAYERED_API_VULKAN_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance7"], ImpliesSets = ["VK_VERSION_1_1"])]
    VulkanKHR = 0,

    [NativeName("VK_PHYSICAL_DEVICE_LAYERED_API_D3D12_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance7"], ImpliesSets = ["VK_VERSION_1_1"])]
    D3D12KHR = 1,

    [NativeName("VK_PHYSICAL_DEVICE_LAYERED_API_METAL_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance7"], ImpliesSets = ["VK_VERSION_1_1"])]
    MetalKHR = 2,

    [NativeName("VK_PHYSICAL_DEVICE_LAYERED_API_OPENGL_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance7"], ImpliesSets = ["VK_VERSION_1_1"])]
    OpenglKHR = 3,

    [NativeName("VK_PHYSICAL_DEVICE_LAYERED_API_OPENGLES_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance7"], ImpliesSets = ["VK_VERSION_1_1"])]
    OpenglesKHR = 4,
}
