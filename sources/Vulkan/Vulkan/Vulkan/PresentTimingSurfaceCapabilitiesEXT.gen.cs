// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPresentTimingSurfaceCapabilitiesEXT")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct PresentTimingSurfaceCapabilitiesEXT
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
    public StructureType SType = StructureType.PresentTimingSurfaceCapabilitiesEXT;

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

    [NativeName("presentTimingSupported")]
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
    public MaybeBool<uint> PresentTimingSupported;

    [NativeName("presentAtAbsoluteTimeSupported")]
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
    public MaybeBool<uint> PresentAtAbsoluteTimeSupported;

    [NativeName("presentAtRelativeTimeSupported")]
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
    public MaybeBool<uint> PresentAtRelativeTimeSupported;

    [NativeName("presentStageQueries")]
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
    public PresentStageFlagsEXT PresentStageQueries;

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
    public PresentTimingSurfaceCapabilitiesEXT() { }
}
