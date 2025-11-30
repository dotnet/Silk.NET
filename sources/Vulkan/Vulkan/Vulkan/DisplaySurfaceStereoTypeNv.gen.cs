// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "NV", 0)]
[NativeName("VkDisplaySurfaceStereoTypeNV")]
[SupportedApiProfile("vulkan")]
public enum DisplaySurfaceStereoTypeNv : uint
{
    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_DISPLAY_SURFACE_STEREO_TYPE_NONE_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_display_stereo"],
        ImpliesSets = ["VK_KHR_display", "VK_KHR_get_display_properties2"]
    )]
    Nonenv = 0,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_DISPLAY_SURFACE_STEREO_TYPE_ONBOARD_DIN_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_display_stereo"],
        ImpliesSets = ["VK_KHR_display", "VK_KHR_get_display_properties2"]
    )]
    OnboardDinnv = 1,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_DISPLAY_SURFACE_STEREO_TYPE_HDMI_3D_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_display_stereo"],
        ImpliesSets = ["VK_KHR_display", "VK_KHR_get_display_properties2"]
    )]
    Hdmi3Dnv = 2,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_DISPLAY_SURFACE_STEREO_TYPE_INBAND_DISPLAYPORT_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_display_stereo"],
        ImpliesSets = ["VK_KHR_display", "VK_KHR_get_display_properties2"]
    )]
    InbandDisplayportnv = 3,
}
