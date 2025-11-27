// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkLineRasterizationMode")]
[SupportedApiProfile("vulkan")]
public enum LineRasterizationMode : uint
{
    [NativeName("VK_LINE_RASTERIZATION_MODE_DEFAULT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_4"],
        MinVersion = "1.4"
    )]
    Default = 0,

    [NativeName("VK_LINE_RASTERIZATION_MODE_RECTANGULAR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_4"],
        MinVersion = "1.4"
    )]
    Rectangular = 1,

    [NativeName("VK_LINE_RASTERIZATION_MODE_BRESENHAM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_4"],
        MinVersion = "1.4"
    )]
    Bresenham = 2,

    [NativeName("VK_LINE_RASTERIZATION_MODE_RECTANGULAR_SMOOTH")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_4"],
        MinVersion = "1.4"
    )]
    RectangularSmooth = 3,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_LINE_RASTERIZATION_MODE_DEFAULT_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_line_rasterization"],
        ImpliesSets = [
            "VK_EXT_line_rasterization+VK_KHR_get_physical_device_properties2",
            "VK_EXT_line_rasterization+VK_VERSION_1_1",
        ]
    )]
    DefaultEXT = Default,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_LINE_RASTERIZATION_MODE_RECTANGULAR_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_line_rasterization"],
        ImpliesSets = [
            "VK_EXT_line_rasterization+VK_KHR_get_physical_device_properties2",
            "VK_EXT_line_rasterization+VK_VERSION_1_1",
        ]
    )]
    RectangularEXT = Rectangular,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_LINE_RASTERIZATION_MODE_BRESENHAM_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_line_rasterization"],
        ImpliesSets = [
            "VK_EXT_line_rasterization+VK_KHR_get_physical_device_properties2",
            "VK_EXT_line_rasterization+VK_VERSION_1_1",
        ]
    )]
    BresenhamEXT = Bresenham,

    [NameSuffix("EXT", 0)]
    [NativeName("VK_LINE_RASTERIZATION_MODE_RECTANGULAR_SMOOTH_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_line_rasterization"],
        ImpliesSets = [
            "VK_EXT_line_rasterization+VK_KHR_get_physical_device_properties2",
            "VK_EXT_line_rasterization+VK_VERSION_1_1",
        ]
    )]
    RectangularSmoothEXT = RectangularSmooth,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_LINE_RASTERIZATION_MODE_DEFAULT_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_line_rasterization"],
        ImpliesSets = [
            "VK_KHR_line_rasterization+VK_KHR_get_physical_device_properties2",
            "VK_KHR_line_rasterization+VK_VERSION_1_1",
        ]
    )]
    DefaultKHR = Default,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_LINE_RASTERIZATION_MODE_RECTANGULAR_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_line_rasterization"],
        ImpliesSets = [
            "VK_KHR_line_rasterization+VK_KHR_get_physical_device_properties2",
            "VK_KHR_line_rasterization+VK_VERSION_1_1",
        ]
    )]
    RectangularKHR = Rectangular,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_LINE_RASTERIZATION_MODE_BRESENHAM_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_line_rasterization"],
        ImpliesSets = [
            "VK_KHR_line_rasterization+VK_KHR_get_physical_device_properties2",
            "VK_KHR_line_rasterization+VK_VERSION_1_1",
        ]
    )]
    BresenhamKHR = Bresenham,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_LINE_RASTERIZATION_MODE_RECTANGULAR_SMOOTH_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_line_rasterization"],
        ImpliesSets = [
            "VK_KHR_line_rasterization+VK_KHR_get_physical_device_properties2",
            "VK_KHR_line_rasterization+VK_VERSION_1_1",
        ]
    )]
    RectangularSmoothKHR = RectangularSmooth,
}
