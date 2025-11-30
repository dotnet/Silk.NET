// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "EXT", 0)]
[NativeName("VkDisplayEventTypeEXT")]
[SupportedApiProfile("vulkan")]
public enum DisplayEventTypeEXT : uint
{
    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DISPLAY_EVENT_TYPE_FIRST_PIXEL_OUT_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_display_control"],
        ImpliesSets = ["VK_EXT_display_surface_counter", "VK_KHR_swapchain"]
    )]
    FirstPixelOutEXT = 0,
}
