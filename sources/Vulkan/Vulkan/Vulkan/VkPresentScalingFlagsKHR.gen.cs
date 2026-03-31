// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "KhronosVendor", "KHR")]
[NativeName("VkPresentScalingFlagBitsKHR")]
[NativeTypeName("unsigned int")]
[Flags]
[SupportedApiProfile("vulkan")]
public enum VkPresentScalingFlagsKHR : uint
{
    [NameAffix("Suffix", "KhronosImpliedVendor", "KHR")]
    [NativeName("VK_PRESENT_SCALING_ONE_TO_ONE_BIT_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_surface_maintenance1"],
        ImpliesSets = [
            "VK_KHR_surface_maintenance1+VK_KHR_get_surface_capabilities2",
            "VK_KHR_surface_maintenance1+VK_KHR_surface",
        ]
    )]
    VkPresentScalingOneToOneBit = 0x00000001,

    [NameAffix("Suffix", "KhronosImpliedVendor", "KHR")]
    [NativeName("VK_PRESENT_SCALING_ASPECT_RATIO_STRETCH_BIT_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_surface_maintenance1"],
        ImpliesSets = [
            "VK_KHR_surface_maintenance1+VK_KHR_get_surface_capabilities2",
            "VK_KHR_surface_maintenance1+VK_KHR_surface",
        ]
    )]
    VkPresentScalingAspectRatioStretchBit = 0x00000002,

    [NameAffix("Suffix", "KhronosImpliedVendor", "KHR")]
    [NativeName("VK_PRESENT_SCALING_STRETCH_BIT_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_surface_maintenance1"],
        ImpliesSets = [
            "VK_KHR_surface_maintenance1+VK_KHR_get_surface_capabilities2",
            "VK_KHR_surface_maintenance1+VK_KHR_surface",
        ]
    )]
    VkPresentScalingStretchBit = 0x00000004,

    [NativeName("VK_PRESENT_SCALING_ONE_TO_ONE_BIT_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_surface_maintenance1"],
        ImpliesSets = [
            "VK_KHR_surface_maintenance1+VK_KHR_get_surface_capabilities2",
            "VK_KHR_surface_maintenance1+VK_KHR_surface",
        ]
    )]
    VkPresentScalingOneToOneBitEXT = VkPresentScalingOneToOneBit,

    [NativeName("VK_PRESENT_SCALING_ASPECT_RATIO_STRETCH_BIT_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_surface_maintenance1"],
        ImpliesSets = [
            "VK_KHR_surface_maintenance1+VK_KHR_get_surface_capabilities2",
            "VK_KHR_surface_maintenance1+VK_KHR_surface",
        ]
    )]
    VkPresentScalingAspectRatioStretchBitEXT = VkPresentScalingAspectRatioStretchBit,

    [NativeName("VK_PRESENT_SCALING_STRETCH_BIT_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_surface_maintenance1"],
        ImpliesSets = [
            "VK_KHR_surface_maintenance1+VK_KHR_get_surface_capabilities2",
            "VK_KHR_surface_maintenance1+VK_KHR_surface",
        ]
    )]
    VkPresentScalingStretchBitEXT = VkPresentScalingStretchBit,

    [NameAffix("Suffix", "KhronosImpliedVendor", "KHR")]
    [NativeName("VK_PRESENT_SCALING_FLAG_BITS_MAX_ENUM_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_surface_maintenance1"],
        ImpliesSets = [
            "VK_KHR_surface_maintenance1+VK_KHR_get_surface_capabilities2",
            "VK_KHR_surface_maintenance1+VK_KHR_surface",
        ]
    )]
    VkPresentScalingFlagBitsMaxEnum = 0x7FFFFFFF,
}
