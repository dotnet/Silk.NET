// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public enum VkPresentScalingFlagsEXT
{
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_surface_maintenance1"],
        ImpliesSets = ["VK_KHR_get_surface_capabilities2", "VK_KHR_surface"]
    )]
    VK_PRESENT_SCALING_ONE_TO_ONE_BIT_EXT = 0x00000001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_surface_maintenance1"],
        ImpliesSets = ["VK_KHR_get_surface_capabilities2", "VK_KHR_surface"]
    )]
    VK_PRESENT_SCALING_ASPECT_RATIO_STRETCH_BIT_EXT = 0x00000002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_surface_maintenance1"],
        ImpliesSets = ["VK_KHR_get_surface_capabilities2", "VK_KHR_surface"]
    )]
    VK_PRESENT_SCALING_STRETCH_BIT_EXT = 0x00000004,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_surface_maintenance1"],
        ImpliesSets = ["VK_KHR_get_surface_capabilities2", "VK_KHR_surface"]
    )]
    VK_PRESENT_SCALING_FLAG_BITS_MAX_ENUM_EXT = 0x7FFFFFFF,
}
