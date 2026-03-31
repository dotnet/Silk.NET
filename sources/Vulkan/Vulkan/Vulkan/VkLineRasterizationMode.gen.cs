// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkLineRasterizationMode")]
[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum VkLineRasterizationMode : uint
{
    [NativeName("VK_LINE_RASTERIZATION_MODE_DEFAULT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_4"],
        MinVersion = "1.4"
    )]
    VkLineRasterizationModeDefault = 0,

    [NativeName("VK_LINE_RASTERIZATION_MODE_RECTANGULAR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_4"],
        MinVersion = "1.4"
    )]
    VkLineRasterizationModeRectangular = 1,

    [NativeName("VK_LINE_RASTERIZATION_MODE_BRESENHAM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_4"],
        MinVersion = "1.4"
    )]
    VkLineRasterizationModeBresenham = 2,

    [NativeName("VK_LINE_RASTERIZATION_MODE_RECTANGULAR_SMOOTH")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_4"],
        MinVersion = "1.4"
    )]
    VkLineRasterizationModeRectangularSmooth = 3,

    [NativeName("VK_LINE_RASTERIZATION_MODE_DEFAULT_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_line_rasterization"],
        ImpliesSets = [
            "VK_EXT_line_rasterization+VK_KHR_get_physical_device_properties2",
            "VK_EXT_line_rasterization+VK_VERSION_1_1",
        ]
    )]
    VkLineRasterizationModeDefaultEXT = VkLineRasterizationModeDefault,

    [NativeName("VK_LINE_RASTERIZATION_MODE_RECTANGULAR_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_line_rasterization"],
        ImpliesSets = [
            "VK_EXT_line_rasterization+VK_KHR_get_physical_device_properties2",
            "VK_EXT_line_rasterization+VK_VERSION_1_1",
        ]
    )]
    VkLineRasterizationModeRectangularEXT = VkLineRasterizationModeRectangular,

    [NativeName("VK_LINE_RASTERIZATION_MODE_BRESENHAM_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_line_rasterization"],
        ImpliesSets = [
            "VK_EXT_line_rasterization+VK_KHR_get_physical_device_properties2",
            "VK_EXT_line_rasterization+VK_VERSION_1_1",
        ]
    )]
    VkLineRasterizationModeBresenhamEXT = VkLineRasterizationModeBresenham,

    [NativeName("VK_LINE_RASTERIZATION_MODE_RECTANGULAR_SMOOTH_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_line_rasterization"],
        ImpliesSets = [
            "VK_EXT_line_rasterization+VK_KHR_get_physical_device_properties2",
            "VK_EXT_line_rasterization+VK_VERSION_1_1",
        ]
    )]
    VkLineRasterizationModeRectangularSmoothEXT = VkLineRasterizationModeRectangularSmooth,

    [NativeName("VK_LINE_RASTERIZATION_MODE_DEFAULT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_line_rasterization"],
        ImpliesSets = [
            "VK_KHR_line_rasterization+VK_KHR_get_physical_device_properties2",
            "VK_KHR_line_rasterization+VK_VERSION_1_1",
        ]
    )]
    VkLineRasterizationModeDefaultKHR = VkLineRasterizationModeDefault,

    [NativeName("VK_LINE_RASTERIZATION_MODE_RECTANGULAR_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_line_rasterization"],
        ImpliesSets = [
            "VK_KHR_line_rasterization+VK_KHR_get_physical_device_properties2",
            "VK_KHR_line_rasterization+VK_VERSION_1_1",
        ]
    )]
    VkLineRasterizationModeRectangularKHR = VkLineRasterizationModeRectangular,

    [NativeName("VK_LINE_RASTERIZATION_MODE_BRESENHAM_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_line_rasterization"],
        ImpliesSets = [
            "VK_KHR_line_rasterization+VK_KHR_get_physical_device_properties2",
            "VK_KHR_line_rasterization+VK_VERSION_1_1",
        ]
    )]
    VkLineRasterizationModeBresenhamKHR = VkLineRasterizationModeBresenham,

    [NativeName("VK_LINE_RASTERIZATION_MODE_RECTANGULAR_SMOOTH_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_line_rasterization"],
        ImpliesSets = [
            "VK_KHR_line_rasterization+VK_KHR_get_physical_device_properties2",
            "VK_KHR_line_rasterization+VK_VERSION_1_1",
        ]
    )]
    VkLineRasterizationModeRectangularSmoothKHR = VkLineRasterizationModeRectangularSmooth,

    [NativeName("VK_LINE_RASTERIZATION_MODE_MAX_ENUM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_4"],
        MinVersion = "1.4"
    )]
    VkLineRasterizationModeMaxEnum = 0x7FFFFFFF,
}
