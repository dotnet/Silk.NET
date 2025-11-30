// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "EXT", 0)]
[NativeName("VkDisplayPowerStateEXT")]
[SupportedApiProfile("vulkan")]
public enum DisplayPowerStateExt : uint
{
    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DISPLAY_POWER_STATE_OFF_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_display_control"],
        ImpliesSets = ["VK_EXT_display_surface_counter", "VK_KHR_swapchain"]
    )]
    Offext = 0,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DISPLAY_POWER_STATE_SUSPEND_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_display_control"],
        ImpliesSets = ["VK_EXT_display_surface_counter", "VK_KHR_swapchain"]
    )]
    Suspendext = 1,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DISPLAY_POWER_STATE_ON_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_display_control"],
        ImpliesSets = ["VK_EXT_display_surface_counter", "VK_KHR_swapchain"]
    )]
    Onext = 2,
}
