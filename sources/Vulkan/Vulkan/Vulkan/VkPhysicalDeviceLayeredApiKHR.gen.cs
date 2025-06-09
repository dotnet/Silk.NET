// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum VkPhysicalDeviceLayeredApiKHR : uint
{
    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance7"], ImpliesSets = ["VK_VERSION_1_1"])]
    VK_PHYSICAL_DEVICE_LAYERED_API_VULKAN_KHR = 0,

    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance7"], ImpliesSets = ["VK_VERSION_1_1"])]
    VK_PHYSICAL_DEVICE_LAYERED_API_D3D12_KHR = 1,

    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance7"], ImpliesSets = ["VK_VERSION_1_1"])]
    VK_PHYSICAL_DEVICE_LAYERED_API_METAL_KHR = 2,

    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance7"], ImpliesSets = ["VK_VERSION_1_1"])]
    VK_PHYSICAL_DEVICE_LAYERED_API_OPENGL_KHR = 3,

    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance7"], ImpliesSets = ["VK_VERSION_1_1"])]
    VK_PHYSICAL_DEVICE_LAYERED_API_OPENGLES_KHR = 4,

    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance7"], ImpliesSets = ["VK_VERSION_1_1"])]
    VK_PHYSICAL_DEVICE_LAYERED_API_MAX_ENUM_KHR = 0x7FFFFFFF,
}
