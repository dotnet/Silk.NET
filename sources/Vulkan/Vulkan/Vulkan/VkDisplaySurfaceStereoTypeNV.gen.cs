// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "KhronosVendor", "NV")]
[NativeName("VkDisplaySurfaceStereoTypeNV")]
[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum VkDisplaySurfaceStereoTypeNV : uint
{
    [NameAffix("Suffix", "KhronosImpliedVendor", "NV")]
    [NativeName("VK_DISPLAY_SURFACE_STEREO_TYPE_NONE_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_display_stereo"],
        ImpliesSets = ["VK_KHR_display", "VK_KHR_get_display_properties2"]
    )]
    VkDisplaySurfaceStereoTypeNone = 0,

    [NameAffix("Suffix", "KhronosImpliedVendor", "NV")]
    [NativeName("VK_DISPLAY_SURFACE_STEREO_TYPE_ONBOARD_DIN_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_display_stereo"],
        ImpliesSets = ["VK_KHR_display", "VK_KHR_get_display_properties2"]
    )]
    VkDisplaySurfaceStereoTypeOnboardDin = 1,

    [NameAffix("Suffix", "KhronosImpliedVendor", "NV")]
    [NativeName("VK_DISPLAY_SURFACE_STEREO_TYPE_HDMI_3D_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_display_stereo"],
        ImpliesSets = ["VK_KHR_display", "VK_KHR_get_display_properties2"]
    )]
    VkDisplaySurfaceStereoTypeHdmi3D = 2,

    [NameAffix("Suffix", "KhronosImpliedVendor", "NV")]
    [NativeName("VK_DISPLAY_SURFACE_STEREO_TYPE_INBAND_DISPLAYPORT_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_display_stereo"],
        ImpliesSets = ["VK_KHR_display", "VK_KHR_get_display_properties2"]
    )]
    VkDisplaySurfaceStereoTypeInbandDisplayport = 3,

    [NameAffix("Suffix", "KhronosImpliedVendor", "NV")]
    [NativeName("VK_DISPLAY_SURFACE_STEREO_TYPE_MAX_ENUM_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_display_stereo"],
        ImpliesSets = ["VK_KHR_display", "VK_KHR_get_display_properties2"]
    )]
    VkDisplaySurfaceStereoTypeMaxEnum = 0x7FFFFFFF,
}
