// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPresentTimingsInfoEXT")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct PresentTimingsInfoEXT
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
    public StructureType SType = StructureType.PresentTimingsInfoEXT;

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

    [NativeName("swapchainCount")]
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
    public uint SwapchainCount;

    [NativeName("pTimingInfos")]
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
    public PresentTimingInfoEXT* PTimingInfos;

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
    public PresentTimingsInfoEXT() { }
}
