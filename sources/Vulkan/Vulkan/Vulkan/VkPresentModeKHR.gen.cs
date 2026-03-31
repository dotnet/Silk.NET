// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "KhronosVendor", "KHR")]
[NativeName("VkPresentModeKHR")]
[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum VkPresentModeKHR : uint
{
    [NameAffix("Suffix", "KhronosImpliedVendor", "KHR")]
    [NativeName("VK_PRESENT_MODE_IMMEDIATE_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_surface"])]
    VkPresentModeImmediate = 0,

    [NameAffix("Suffix", "KhronosImpliedVendor", "KHR")]
    [NativeName("VK_PRESENT_MODE_MAILBOX_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_surface"])]
    VkPresentModeMailbox = 1,

    [NameAffix("Suffix", "KhronosImpliedVendor", "KHR")]
    [NativeName("VK_PRESENT_MODE_FIFO_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_surface"])]
    VkPresentModeFifo = 2,

    [NameAffix("Suffix", "KhronosImpliedVendor", "KHR")]
    [NativeName("VK_PRESENT_MODE_FIFO_RELAXED_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_surface"])]
    VkPresentModeFifoRelaxed = 3,

    [NameAffix("Suffix", "KhronosImpliedVendor", "KHR")]
    [NativeName("VK_PRESENT_MODE_SHARED_DEMAND_REFRESH_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shared_presentable_image"],
        ImpliesSets = [
            "VK_KHR_swapchain+VK_KHR_get_surface_capabilities2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_swapchain+VK_KHR_get_surface_capabilities2+VK_VERSION_1_1",
        ]
    )]
    VkPresentModeSharedDemandRefresh = 1000111000,

    [NameAffix("Suffix", "KhronosImpliedVendor", "KHR")]
    [NativeName("VK_PRESENT_MODE_SHARED_CONTINUOUS_REFRESH_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shared_presentable_image"],
        ImpliesSets = [
            "VK_KHR_swapchain+VK_KHR_get_surface_capabilities2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_swapchain+VK_KHR_get_surface_capabilities2+VK_VERSION_1_1",
        ]
    )]
    VkPresentModeSharedContinuousRefresh = 1000111001,

    [NameAffix("Suffix", "KhronosImpliedVendor", "KHR")]
    [NativeName("VK_PRESENT_MODE_FIFO_LATEST_READY_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_present_mode_fifo_latest_ready"],
        ImpliesSets = ["VK_KHR_swapchain"]
    )]
    VkPresentModeFifoLatestReady = 1000361000,

    [NativeName("VK_PRESENT_MODE_FIFO_LATEST_READY_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_present_mode_fifo_latest_ready"],
        ImpliesSets = ["VK_KHR_swapchain"]
    )]
    VkPresentModeFifoLatestReadyEXT = VkPresentModeFifoLatestReady,

    [NameAffix("Suffix", "KhronosImpliedVendor", "KHR")]
    [NativeName("VK_PRESENT_MODE_MAX_ENUM_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_surface"])]
    VkPresentModeMaxEnum = 0x7FFFFFFF,
}
