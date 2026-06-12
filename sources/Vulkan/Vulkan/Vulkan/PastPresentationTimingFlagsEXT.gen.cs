// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPastPresentationTimingFlagBitsEXT")]
[Flags]
[SupportedApiProfile("vulkan")]
public enum PastPresentationTimingFlagsEXT : uint
{
    None = 0x0,

    [NativeName("VK_PAST_PRESENTATION_TIMING_ALLOW_PARTIAL_RESULTS_BIT_EXT")]
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
    AllowPartialResultsBit = 0x1,

    [NativeName("VK_PAST_PRESENTATION_TIMING_ALLOW_OUT_OF_ORDER_RESULTS_BIT_EXT")]
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
    AllowOutOfOrderResultsBit = 0x2,
}
