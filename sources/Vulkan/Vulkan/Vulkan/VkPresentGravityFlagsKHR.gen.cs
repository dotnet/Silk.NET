// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "KhronosVendor", "KHR")]
[NativeName("VkPresentGravityFlagBitsKHR")]
[NativeTypeName("unsigned int")]
[Flags]
[SupportedApiProfile("vulkan")]
public enum VkPresentGravityFlagsKHR : uint
{
    [NameAffix("Suffix", "KhronosImpliedVendor", "KHR")]
    [NativeName("VK_PRESENT_GRAVITY_MIN_BIT_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_surface_maintenance1"],
        ImpliesSets = [
            "VK_KHR_surface_maintenance1+VK_KHR_get_surface_capabilities2",
            "VK_KHR_surface_maintenance1+VK_KHR_surface",
        ]
    )]
    VkPresentGravityMinBit = 0x00000001,

    [NameAffix("Suffix", "KhronosImpliedVendor", "KHR")]
    [NativeName("VK_PRESENT_GRAVITY_MAX_BIT_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_surface_maintenance1"],
        ImpliesSets = [
            "VK_KHR_surface_maintenance1+VK_KHR_get_surface_capabilities2",
            "VK_KHR_surface_maintenance1+VK_KHR_surface",
        ]
    )]
    VkPresentGravityMaxBit = 0x00000002,

    [NameAffix("Suffix", "KhronosImpliedVendor", "KHR")]
    [NativeName("VK_PRESENT_GRAVITY_CENTERED_BIT_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_surface_maintenance1"],
        ImpliesSets = [
            "VK_KHR_surface_maintenance1+VK_KHR_get_surface_capabilities2",
            "VK_KHR_surface_maintenance1+VK_KHR_surface",
        ]
    )]
    VkPresentGravityCenteredBit = 0x00000004,

    [NativeName("VK_PRESENT_GRAVITY_MIN_BIT_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_surface_maintenance1"],
        ImpliesSets = [
            "VK_KHR_surface_maintenance1+VK_KHR_get_surface_capabilities2",
            "VK_KHR_surface_maintenance1+VK_KHR_surface",
        ]
    )]
    VkPresentGravityMinBitEXT = VkPresentGravityMinBit,

    [NativeName("VK_PRESENT_GRAVITY_MAX_BIT_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_surface_maintenance1"],
        ImpliesSets = [
            "VK_KHR_surface_maintenance1+VK_KHR_get_surface_capabilities2",
            "VK_KHR_surface_maintenance1+VK_KHR_surface",
        ]
    )]
    VkPresentGravityMaxBitEXT = VkPresentGravityMaxBit,

    [NativeName("VK_PRESENT_GRAVITY_CENTERED_BIT_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_surface_maintenance1"],
        ImpliesSets = [
            "VK_KHR_surface_maintenance1+VK_KHR_get_surface_capabilities2",
            "VK_KHR_surface_maintenance1+VK_KHR_surface",
        ]
    )]
    VkPresentGravityCenteredBitEXT = VkPresentGravityCenteredBit,

    [NameAffix("Suffix", "KhronosImpliedVendor", "KHR")]
    [NativeName("VK_PRESENT_GRAVITY_FLAG_BITS_MAX_ENUM_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_surface_maintenance1"],
        ImpliesSets = [
            "VK_KHR_surface_maintenance1+VK_KHR_get_surface_capabilities2",
            "VK_KHR_surface_maintenance1+VK_KHR_surface",
        ]
    )]
    VkPresentGravityFlagBitsMaxEnum = 0x7FFFFFFF,
}
