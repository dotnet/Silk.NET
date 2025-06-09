// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum VkPresentModeKHR : uint
{
    [SupportedApiProfile("vulkan", ["VK_KHR_surface"])]
    VK_PRESENT_MODE_IMMEDIATE_KHR = 0,

    [SupportedApiProfile("vulkan", ["VK_KHR_surface"])]
    VK_PRESENT_MODE_MAILBOX_KHR = 1,

    [SupportedApiProfile("vulkan", ["VK_KHR_surface"])]
    VK_PRESENT_MODE_FIFO_KHR = 2,

    [SupportedApiProfile("vulkan", ["VK_KHR_surface"])]
    VK_PRESENT_MODE_FIFO_RELAXED_KHR = 3,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shared_presentable_image"],
        ImpliesSets = [
            "VK_KHR_swapchain+VK_KHR_get_surface_capabilities2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_swapchain+VK_KHR_get_surface_capabilities2+VK_VERSION_1_1",
        ]
    )]
    VK_PRESENT_MODE_SHARED_DEMAND_REFRESH_KHR = 1000111000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shared_presentable_image"],
        ImpliesSets = [
            "VK_KHR_swapchain+VK_KHR_get_surface_capabilities2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_swapchain+VK_KHR_get_surface_capabilities2+VK_VERSION_1_1",
        ]
    )]
    VK_PRESENT_MODE_SHARED_CONTINUOUS_REFRESH_KHR = 1000111001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_present_mode_fifo_latest_ready"],
        ImpliesSets = ["VK_KHR_swapchain"]
    )]
    VK_PRESENT_MODE_FIFO_LATEST_READY_EXT = 1000361000,

    [SupportedApiProfile("vulkan", ["VK_KHR_surface"])]
    VK_PRESENT_MODE_MAX_ENUM_KHR = 0x7FFFFFFF,
}
