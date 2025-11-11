// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
[Flags]
public enum SwapchainCreateFlagsKHR : uint
{
    None = 0,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_swapchain", "VK_VERSION_1_1"],
        ImpliesSets = ["VK_KHR_surface"],
        RequireAll = true
    )]
    SplitInstanceBindRegionsBitKHR = 0x00000001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_swapchain", "VK_VERSION_1_1"],
        ImpliesSets = ["VK_KHR_surface"],
        RequireAll = true
    )]
    ProtectedBitKHR = 0x00000002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_swapchain_mutable_format"],
        ImpliesSets = [
            "VK_KHR_swapchain+VK_KHR_maintenance2+VK_KHR_image_format_list",
            "VK_KHR_swapchain+VK_KHR_maintenance2+VK_VERSION_1_2",
            "VK_KHR_swapchain+VK_VERSION_1_1+VK_KHR_image_format_list",
            "VK_KHR_swapchain+VK_VERSION_1_1+VK_VERSION_1_2",
        ]
    )]
    MutableFormatBitKHR = 0x00000004,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_present_id2"],
        ImpliesSets = ["VK_KHR_get_surface_capabilities2", "VK_KHR_surface", "VK_KHR_swapchain"]
    )]
    PresentId2BitKHR = 0x00000040,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_present_wait2"],
        ImpliesSets = [
            "VK_KHR_get_surface_capabilities2",
            "VK_KHR_present_id2",
            "VK_KHR_surface",
            "VK_KHR_swapchain",
        ]
    )]
    PresentWait2BitKHR = 0x00000080,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_swapchain_maintenance1"],
        ImpliesSets = [
            "VK_KHR_swapchain_maintenance1+VK_KHR_get_physical_device_properties2",
            "VK_KHR_swapchain_maintenance1+VK_KHR_surface_maintenance1",
            "VK_KHR_swapchain_maintenance1+VK_KHR_swapchain",
        ]
    )]
    DeferredMemoryAllocationBitKHR = 0x00000008,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_swapchain_maintenance1"],
        ImpliesSets = [
            "VK_KHR_swapchain+VK_EXT_surface_maintenance1+VK_KHR_get_physical_device_properties2",
            "VK_KHR_swapchain+VK_EXT_surface_maintenance1+VK_VERSION_1_1",
        ]
    )]
    DeferredMemoryAllocationBitEXT = DeferredMemoryAllocationBitKHR,
}
