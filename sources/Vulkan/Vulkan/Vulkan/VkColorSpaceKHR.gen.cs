// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "KhronosVendor", "KHR")]
[NativeName("VkColorSpaceKHR")]
[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum VkColorSpaceKHR : uint
{
    [NameAffix("Suffix", "KhronosImpliedVendor", "KHR")]
    [NativeName("VK_COLOR_SPACE_SRGB_NONLINEAR_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_surface"])]
    VkColorSpaceSrgbNonlinear = 0,

    [NativeName("VK_COLOR_SPACE_DISPLAY_P3_NONLINEAR_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_swapchain_colorspace"],
        ImpliesSets = ["VK_KHR_surface"]
    )]
    VkColorSpaceDisplayP3NonlinearEXT = 1000104001,

    [NativeName("VK_COLOR_SPACE_EXTENDED_SRGB_LINEAR_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_swapchain_colorspace"],
        ImpliesSets = ["VK_KHR_surface"]
    )]
    VkColorSpaceExtendedSrgbLinearEXT = 1000104002,

    [NativeName("VK_COLOR_SPACE_DISPLAY_P3_LINEAR_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_swapchain_colorspace"],
        ImpliesSets = ["VK_KHR_surface"]
    )]
    VkColorSpaceDisplayP3LinearEXT = 1000104003,

    [NativeName("VK_COLOR_SPACE_DCI_P3_NONLINEAR_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_swapchain_colorspace"],
        ImpliesSets = ["VK_KHR_surface"]
    )]
    VkColorSpaceDciP3NonlinearEXT = 1000104004,

    [NativeName("VK_COLOR_SPACE_BT709_LINEAR_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_swapchain_colorspace"],
        ImpliesSets = ["VK_KHR_surface"]
    )]
    VkColorSpaceBt709LinearEXT = 1000104005,

    [NativeName("VK_COLOR_SPACE_BT709_NONLINEAR_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_swapchain_colorspace"],
        ImpliesSets = ["VK_KHR_surface"]
    )]
    VkColorSpaceBt709NonlinearEXT = 1000104006,

    [NativeName("VK_COLOR_SPACE_BT2020_LINEAR_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_swapchain_colorspace"],
        ImpliesSets = ["VK_KHR_surface"]
    )]
    VkColorSpaceBt2020LinearEXT = 1000104007,

    [NativeName("VK_COLOR_SPACE_HDR10_ST2084_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_swapchain_colorspace"],
        ImpliesSets = ["VK_KHR_surface"]
    )]
    VkColorSpaceHdr10St2084EXT = 1000104008,

    [NativeName("VK_COLOR_SPACE_DOLBYVISION_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_swapchain_colorspace"],
        ImpliesSets = ["VK_KHR_surface"]
    )]
    VkColorSpaceDolbyvisionEXT = 1000104009,

    [NativeName("VK_COLOR_SPACE_HDR10_HLG_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_swapchain_colorspace"],
        ImpliesSets = ["VK_KHR_surface"]
    )]
    VkColorSpaceHdr10HlgEXT = 1000104010,

    [NativeName("VK_COLOR_SPACE_ADOBERGB_LINEAR_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_swapchain_colorspace"],
        ImpliesSets = ["VK_KHR_surface"]
    )]
    VkColorSpaceAdobergbLinearEXT = 1000104011,

    [NativeName("VK_COLOR_SPACE_ADOBERGB_NONLINEAR_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_swapchain_colorspace"],
        ImpliesSets = ["VK_KHR_surface"]
    )]
    VkColorSpaceAdobergbNonlinearEXT = 1000104012,

    [NativeName("VK_COLOR_SPACE_PASS_THROUGH_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_swapchain_colorspace"],
        ImpliesSets = ["VK_KHR_surface"]
    )]
    VkColorSpacePassThroughEXT = 1000104013,

    [NativeName("VK_COLOR_SPACE_EXTENDED_SRGB_NONLINEAR_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_swapchain_colorspace"],
        ImpliesSets = ["VK_KHR_surface"]
    )]
    VkColorSpaceExtendedSrgbNonlinearEXT = 1000104014,

    [NativeName("VK_COLOR_SPACE_DISPLAY_NATIVE_AMD")]
    [NameAffix("Suffix", "KhronosVendor", "AMD")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_display_native_hdr"],
        ImpliesSets = [
            "VK_KHR_get_surface_capabilities2+VK_KHR_swapchain+VK_KHR_get_physical_device_properties2",
            "VK_KHR_get_surface_capabilities2+VK_KHR_swapchain+VK_VERSION_1_1",
        ]
    )]
    VkColorSpaceDisplayNativeAMD = 1000213000,

    [NameAffix("Suffix", "KhronosImpliedVendor", "KHR")]
    [NativeName("VK_COLOR_SPACE_MAX_ENUM_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_surface"])]
    VkColorSpaceMaxEnum = 0x7FFFFFFF,
}
