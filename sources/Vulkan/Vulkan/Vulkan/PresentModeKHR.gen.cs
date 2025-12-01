// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPresentModeKHR")]
[SupportedApiProfile("vulkan")]
public enum PresentModeKHR : uint
{
    [NativeName("VK_PRESENT_MODE_IMMEDIATE_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_surface"])]
    ImmediateKHR = 0,

    [NativeName("VK_PRESENT_MODE_MAILBOX_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_surface"])]
    MailboxKHR = 1,

    [NativeName("VK_PRESENT_MODE_FIFO_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_surface"])]
    FifoKHR = 2,

    [NativeName("VK_PRESENT_MODE_FIFO_RELAXED_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_surface"])]
    FifoRelaxedKHR = 3,

    [NativeName("VK_PRESENT_MODE_SHARED_DEMAND_REFRESH_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shared_presentable_image"],
        ImpliesSets = [
            "VK_KHR_swapchain+VK_KHR_get_surface_capabilities2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_swapchain+VK_KHR_get_surface_capabilities2+VK_VERSION_1_1",
        ]
    )]
    SharedDemandRefreshKHR = 1000111000,

    [NativeName("VK_PRESENT_MODE_SHARED_CONTINUOUS_REFRESH_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shared_presentable_image"],
        ImpliesSets = [
            "VK_KHR_swapchain+VK_KHR_get_surface_capabilities2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_swapchain+VK_KHR_get_surface_capabilities2+VK_VERSION_1_1",
        ]
    )]
    SharedContinuousRefreshKHR = 1000111001,

    [NativeName("VK_PRESENT_MODE_FIFO_LATEST_READY_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_present_mode_fifo_latest_ready"],
        ImpliesSets = ["VK_KHR_swapchain"]
    )]
    FifoLatestReadyKHR = 1000361000,

    [NativeName("VK_PRESENT_MODE_FIFO_LATEST_READY_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_present_mode_fifo_latest_ready"],
        ImpliesSets = ["VK_KHR_swapchain"]
    )]
    FifoLatestReadyEXT = FifoLatestReadyKHR,
}
