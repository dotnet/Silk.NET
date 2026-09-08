// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;

namespace Silk.NET.Vulkan;

[NativeName("VkSwapchainTimingPropertiesEXT")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct SwapchainTimingPropertiesEXT
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
    public StructureType SType = StructureType.SwapchainTimingPropertiesEXT;

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

    [NativeName("refreshDuration")]
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
    public ulong RefreshDuration;

    [NativeName("refreshInterval")]
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
    public ulong RefreshInterval;

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
    public SwapchainTimingPropertiesEXT() { }
}
