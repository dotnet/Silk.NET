// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum ColorSpaceKHR
{
    [SupportedApiProfile("vulkan", ["VK_KHR_surface"])]
    SrgbNonlinearKHR = 0,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_swapchain_colorspace"],
        ImpliesSets = ["VK_KHR_surface"]
    )]
    DisplayP3NonlinearEXT = 1000104001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_swapchain_colorspace"],
        ImpliesSets = ["VK_KHR_surface"]
    )]
    ExtendedSrgbLinearEXT = 1000104002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_swapchain_colorspace"],
        ImpliesSets = ["VK_KHR_surface"]
    )]
    DisplayP3LinearEXT = 1000104003,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_swapchain_colorspace"],
        ImpliesSets = ["VK_KHR_surface"]
    )]
    DciP3NonlinearEXT = 1000104004,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_swapchain_colorspace"],
        ImpliesSets = ["VK_KHR_surface"]
    )]
    Bt709LinearEXT = 1000104005,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_swapchain_colorspace"],
        ImpliesSets = ["VK_KHR_surface"]
    )]
    Bt709NonlinearEXT = 1000104006,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_swapchain_colorspace"],
        ImpliesSets = ["VK_KHR_surface"]
    )]
    Bt2020LinearEXT = 1000104007,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_swapchain_colorspace"],
        ImpliesSets = ["VK_KHR_surface"]
    )]
    Hdr10St2084EXT = 1000104008,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_swapchain_colorspace"],
        ImpliesSets = ["VK_KHR_surface"]
    )]
    DolbyvisionEXT = 1000104009,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_swapchain_colorspace"],
        ImpliesSets = ["VK_KHR_surface"]
    )]
    Hdr10HlgEXT = 1000104010,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_swapchain_colorspace"],
        ImpliesSets = ["VK_KHR_surface"]
    )]
    AdobergbLinearEXT = 1000104011,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_swapchain_colorspace"],
        ImpliesSets = ["VK_KHR_surface"]
    )]
    AdobergbNonlinearEXT = 1000104012,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_swapchain_colorspace"],
        ImpliesSets = ["VK_KHR_surface"]
    )]
    PassThroughEXT = 1000104013,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_swapchain_colorspace"],
        ImpliesSets = ["VK_KHR_surface"]
    )]
    ExtendedSrgbNonlinearEXT = 1000104014,

    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_display_native_hdr"],
        ImpliesSets = [
            "VK_KHR_get_surface_capabilities2+VK_KHR_swapchain+VK_KHR_get_physical_device_properties2",
            "VK_KHR_get_surface_capabilities2+VK_KHR_swapchain+VK_VERSION_1_1",
        ]
    )]
    DisplayNativeAMD = 1000213000,
}
