// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkSwapchainCalibratedTimestampInfoEXT")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct SwapchainCalibratedTimestampInfoEXT
{
    [NativeName("sType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_present_timing"],
        ImpliesSets = [
            "VK_KHR_calibrated_timestamps",
            "VK_KHR_get_surface_capabilities2",
            "VK_KHR_present_id2",
            "VK_KHR_swapchain",
        ]
    )]
    public StructureType SType = StructureType.SwapchainCalibratedTimestampInfoEXT;

    [NativeName("pNext")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_present_timing"],
        ImpliesSets = [
            "VK_KHR_calibrated_timestamps",
            "VK_KHR_get_surface_capabilities2",
            "VK_KHR_present_id2",
            "VK_KHR_swapchain",
        ]
    )]
    public void* PNext;

    [NativeName("swapchain")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_present_timing"],
        ImpliesSets = [
            "VK_KHR_calibrated_timestamps",
            "VK_KHR_get_surface_capabilities2",
            "VK_KHR_present_id2",
            "VK_KHR_swapchain",
        ]
    )]
    public SwapchainHandleKHR Swapchain;

    [NativeName("presentStage")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_present_timing"],
        ImpliesSets = [
            "VK_KHR_calibrated_timestamps",
            "VK_KHR_get_surface_capabilities2",
            "VK_KHR_present_id2",
            "VK_KHR_swapchain",
        ]
    )]
    public PresentStageFlagsEXT PresentStage;

    [NativeName("timeDomainId")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_present_timing"],
        ImpliesSets = [
            "VK_KHR_calibrated_timestamps",
            "VK_KHR_get_surface_capabilities2",
            "VK_KHR_present_id2",
            "VK_KHR_swapchain",
        ]
    )]
    public ulong TimeDomainId;

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_present_timing"],
        ImpliesSets = [
            "VK_KHR_calibrated_timestamps",
            "VK_KHR_get_surface_capabilities2",
            "VK_KHR_present_id2",
            "VK_KHR_swapchain",
        ]
    )]
    public SwapchainCalibratedTimestampInfoEXT() { }
}
