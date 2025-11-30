// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "KHR", 0)]
[NativeName("VkColorSpaceKHR")]
[SupportedApiProfile("vulkan")]
public enum ColorSpaceKHR : uint
{
    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_COLOR_SPACE_SRGB_NONLINEAR_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_surface"])]
    SrgbNonlinearkhr = 0,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_COLOR_SPACE_DISPLAY_P3_NONLINEAR_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_swapchain_colorspace"],
        ImpliesSets = ["VK_KHR_surface"]
    )]
    DisplayP3Nonlinearext = 1000104001,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_COLOR_SPACE_EXTENDED_SRGB_LINEAR_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_swapchain_colorspace"],
        ImpliesSets = ["VK_KHR_surface"]
    )]
    ExtendedSrgbLinearext = 1000104002,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_COLOR_SPACE_DISPLAY_P3_LINEAR_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_swapchain_colorspace"],
        ImpliesSets = ["VK_KHR_surface"]
    )]
    DisplayP3Linearext = 1000104003,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_COLOR_SPACE_DCI_P3_NONLINEAR_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_swapchain_colorspace"],
        ImpliesSets = ["VK_KHR_surface"]
    )]
    DciP3Nonlinearext = 1000104004,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_COLOR_SPACE_BT709_LINEAR_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_swapchain_colorspace"],
        ImpliesSets = ["VK_KHR_surface"]
    )]
    Bt709Linearext = 1000104005,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_COLOR_SPACE_BT709_NONLINEAR_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_swapchain_colorspace"],
        ImpliesSets = ["VK_KHR_surface"]
    )]
    Bt709Nonlinearext = 1000104006,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_COLOR_SPACE_BT2020_LINEAR_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_swapchain_colorspace"],
        ImpliesSets = ["VK_KHR_surface"]
    )]
    Bt2020Linearext = 1000104007,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_COLOR_SPACE_HDR10_ST2084_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_swapchain_colorspace"],
        ImpliesSets = ["VK_KHR_surface"]
    )]
    Hdr10St2084Ext = 1000104008,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_COLOR_SPACE_DOLBYVISION_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_swapchain_colorspace"],
        ImpliesSets = ["VK_KHR_surface"]
    )]
    Dolbyvisionext = 1000104009,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_COLOR_SPACE_HDR10_HLG_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_swapchain_colorspace"],
        ImpliesSets = ["VK_KHR_surface"]
    )]
    Hdr10Hlgext = 1000104010,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_COLOR_SPACE_ADOBERGB_LINEAR_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_swapchain_colorspace"],
        ImpliesSets = ["VK_KHR_surface"]
    )]
    AdobergbLinearext = 1000104011,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_COLOR_SPACE_ADOBERGB_NONLINEAR_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_swapchain_colorspace"],
        ImpliesSets = ["VK_KHR_surface"]
    )]
    AdobergbNonlinearext = 1000104012,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_COLOR_SPACE_PASS_THROUGH_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_swapchain_colorspace"],
        ImpliesSets = ["VK_KHR_surface"]
    )]
    PassThroughext = 1000104013,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_COLOR_SPACE_EXTENDED_SRGB_NONLINEAR_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_swapchain_colorspace"],
        ImpliesSets = ["VK_KHR_surface"]
    )]
    ExtendedSrgbNonlinearext = 1000104014,

    [NameAffix("Suffix", "AMD", 0)]
    [NativeName("VK_COLOR_SPACE_DISPLAY_NATIVE_AMD")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_display_native_hdr"],
        ImpliesSets = [
            "VK_KHR_get_surface_capabilities2+VK_KHR_swapchain+VK_KHR_get_physical_device_properties2",
            "VK_KHR_get_surface_capabilities2+VK_KHR_swapchain+VK_VERSION_1_1",
        ]
    )]
    DisplayNativeamd = 1000213000,
}
