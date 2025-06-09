// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum VkColorSpaceKHR : uint
{
    [SupportedApiProfile("vulkan", ["VK_KHR_surface"])]
    VK_COLOR_SPACE_SRGB_NONLINEAR_KHR = 0,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_swapchain_colorspace"],
        ImpliesSets = ["VK_KHR_surface"]
    )]
    VK_COLOR_SPACE_DISPLAY_P3_NONLINEAR_EXT = 1000104001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_swapchain_colorspace"],
        ImpliesSets = ["VK_KHR_surface"]
    )]
    VK_COLOR_SPACE_EXTENDED_SRGB_LINEAR_EXT = 1000104002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_swapchain_colorspace"],
        ImpliesSets = ["VK_KHR_surface"]
    )]
    VK_COLOR_SPACE_DISPLAY_P3_LINEAR_EXT = 1000104003,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_swapchain_colorspace"],
        ImpliesSets = ["VK_KHR_surface"]
    )]
    VK_COLOR_SPACE_DCI_P3_NONLINEAR_EXT = 1000104004,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_swapchain_colorspace"],
        ImpliesSets = ["VK_KHR_surface"]
    )]
    VK_COLOR_SPACE_BT709_LINEAR_EXT = 1000104005,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_swapchain_colorspace"],
        ImpliesSets = ["VK_KHR_surface"]
    )]
    VK_COLOR_SPACE_BT709_NONLINEAR_EXT = 1000104006,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_swapchain_colorspace"],
        ImpliesSets = ["VK_KHR_surface"]
    )]
    VK_COLOR_SPACE_BT2020_LINEAR_EXT = 1000104007,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_swapchain_colorspace"],
        ImpliesSets = ["VK_KHR_surface"]
    )]
    VK_COLOR_SPACE_HDR10_ST2084_EXT = 1000104008,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_swapchain_colorspace"],
        ImpliesSets = ["VK_KHR_surface"]
    )]
    VK_COLOR_SPACE_DOLBYVISION_EXT = 1000104009,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_swapchain_colorspace"],
        ImpliesSets = ["VK_KHR_surface"]
    )]
    VK_COLOR_SPACE_HDR10_HLG_EXT = 1000104010,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_swapchain_colorspace"],
        ImpliesSets = ["VK_KHR_surface"]
    )]
    VK_COLOR_SPACE_ADOBERGB_LINEAR_EXT = 1000104011,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_swapchain_colorspace"],
        ImpliesSets = ["VK_KHR_surface"]
    )]
    VK_COLOR_SPACE_ADOBERGB_NONLINEAR_EXT = 1000104012,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_swapchain_colorspace"],
        ImpliesSets = ["VK_KHR_surface"]
    )]
    VK_COLOR_SPACE_PASS_THROUGH_EXT = 1000104013,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_swapchain_colorspace"],
        ImpliesSets = ["VK_KHR_surface"]
    )]
    VK_COLOR_SPACE_EXTENDED_SRGB_NONLINEAR_EXT = 1000104014,

    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_display_native_hdr"],
        ImpliesSets = [
            "VK_KHR_get_surface_capabilities2+VK_KHR_swapchain+VK_KHR_get_physical_device_properties2",
            "VK_KHR_get_surface_capabilities2+VK_KHR_swapchain+VK_VERSION_1_1",
        ]
    )]
    VK_COLOR_SPACE_DISPLAY_NATIVE_AMD = 1000213000,

    [SupportedApiProfile("vulkan", ["VK_KHR_surface"])]
    VK_COLORSPACE_SRGB_NONLINEAR_KHR = VK_COLOR_SPACE_SRGB_NONLINEAR_KHR,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_swapchain_colorspace"],
        ImpliesSets = ["VK_KHR_surface"]
    )]
    VK_COLOR_SPACE_DCI_P3_LINEAR_EXT = VK_COLOR_SPACE_DISPLAY_P3_LINEAR_EXT,

    [SupportedApiProfile("vulkan", ["VK_KHR_surface"])]
    VK_COLOR_SPACE_MAX_ENUM_KHR = 0x7FFFFFFF,
}
