// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "KHR", 0)]
[NativeName("VkPresentScalingFlagBitsKHR")]
[Flags]
[SupportedApiProfile("vulkan")]
public enum PresentScalingFlagsKHR : uint
{
    None = 0x0,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_PRESENT_SCALING_ONE_TO_ONE_BIT_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_surface_maintenance1"],
        ImpliesSets = [
            "VK_KHR_surface_maintenance1+VK_KHR_get_surface_capabilities2",
            "VK_KHR_surface_maintenance1+VK_KHR_surface",
        ]
    )]
    OneToOneBitKHR = 0x1,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_PRESENT_SCALING_ASPECT_RATIO_STRETCH_BIT_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_surface_maintenance1"],
        ImpliesSets = [
            "VK_KHR_surface_maintenance1+VK_KHR_get_surface_capabilities2",
            "VK_KHR_surface_maintenance1+VK_KHR_surface",
        ]
    )]
    AspectRatioStretchBitKHR = 0x2,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_PRESENT_SCALING_STRETCH_BIT_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_surface_maintenance1"],
        ImpliesSets = [
            "VK_KHR_surface_maintenance1+VK_KHR_get_surface_capabilities2",
            "VK_KHR_surface_maintenance1+VK_KHR_surface",
        ]
    )]
    StretchBitKHR = 0x4,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_PRESENT_SCALING_ONE_TO_ONE_BIT_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_surface_maintenance1"],
        ImpliesSets = [
            "VK_KHR_surface_maintenance1+VK_KHR_get_surface_capabilities2",
            "VK_KHR_surface_maintenance1+VK_KHR_surface",
        ]
    )]
    OneToOneBitEXT = OneToOneBitKHR,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_PRESENT_SCALING_ASPECT_RATIO_STRETCH_BIT_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_surface_maintenance1"],
        ImpliesSets = [
            "VK_KHR_surface_maintenance1+VK_KHR_get_surface_capabilities2",
            "VK_KHR_surface_maintenance1+VK_KHR_surface",
        ]
    )]
    AspectRatioStretchBitEXT = AspectRatioStretchBitKHR,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_PRESENT_SCALING_STRETCH_BIT_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_surface_maintenance1"],
        ImpliesSets = [
            "VK_KHR_surface_maintenance1+VK_KHR_get_surface_capabilities2",
            "VK_KHR_surface_maintenance1+VK_KHR_surface",
        ]
    )]
    StretchBitEXT = StretchBitKHR,
}
