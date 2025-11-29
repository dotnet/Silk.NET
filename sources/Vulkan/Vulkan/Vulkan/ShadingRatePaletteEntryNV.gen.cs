// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "NV", 0)]
[NativeName("VkShadingRatePaletteEntryNV")]
[SupportedApiProfile("vulkan")]
public enum ShadingRatePaletteEntryNV : uint
{
    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_SHADING_RATE_PALETTE_ENTRY_NO_INVOCATIONS_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_shading_rate_image"],
        ImpliesSets = [
            "VK_NV_shading_rate_image+VK_KHR_get_physical_device_properties2",
            "VK_NV_shading_rate_image+VK_VERSION_1_1",
        ]
    )]
    EntryNoInvocationsNV = 0,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_SHADING_RATE_PALETTE_ENTRY_16_INVOCATIONS_PER_PIXEL_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_shading_rate_image"],
        ImpliesSets = [
            "VK_NV_shading_rate_image+VK_KHR_get_physical_device_properties2",
            "VK_NV_shading_rate_image+VK_VERSION_1_1",
        ]
    )]
    Entry16InvocationsPerPixelNV = 1,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_SHADING_RATE_PALETTE_ENTRY_8_INVOCATIONS_PER_PIXEL_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_shading_rate_image"],
        ImpliesSets = [
            "VK_NV_shading_rate_image+VK_KHR_get_physical_device_properties2",
            "VK_NV_shading_rate_image+VK_VERSION_1_1",
        ]
    )]
    Entry8InvocationsPerPixelNV = 2,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_SHADING_RATE_PALETTE_ENTRY_4_INVOCATIONS_PER_PIXEL_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_shading_rate_image"],
        ImpliesSets = [
            "VK_NV_shading_rate_image+VK_KHR_get_physical_device_properties2",
            "VK_NV_shading_rate_image+VK_VERSION_1_1",
        ]
    )]
    Entry4InvocationsPerPixelNV = 3,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_SHADING_RATE_PALETTE_ENTRY_2_INVOCATIONS_PER_PIXEL_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_shading_rate_image"],
        ImpliesSets = [
            "VK_NV_shading_rate_image+VK_KHR_get_physical_device_properties2",
            "VK_NV_shading_rate_image+VK_VERSION_1_1",
        ]
    )]
    Entry2InvocationsPerPixelNV = 4,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_PIXEL_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_shading_rate_image"],
        ImpliesSets = [
            "VK_NV_shading_rate_image+VK_KHR_get_physical_device_properties2",
            "VK_NV_shading_rate_image+VK_VERSION_1_1",
        ]
    )]
    Entry1InvocationPerPixelNV = 5,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_2X1_PIXELS_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_shading_rate_image"],
        ImpliesSets = [
            "VK_NV_shading_rate_image+VK_KHR_get_physical_device_properties2",
            "VK_NV_shading_rate_image+VK_VERSION_1_1",
        ]
    )]
    Entry1InvocationPer2X1PixelsNV = 6,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_1X2_PIXELS_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_shading_rate_image"],
        ImpliesSets = [
            "VK_NV_shading_rate_image+VK_KHR_get_physical_device_properties2",
            "VK_NV_shading_rate_image+VK_VERSION_1_1",
        ]
    )]
    Entry1InvocationPer1X2PixelsNV = 7,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_2X2_PIXELS_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_shading_rate_image"],
        ImpliesSets = [
            "VK_NV_shading_rate_image+VK_KHR_get_physical_device_properties2",
            "VK_NV_shading_rate_image+VK_VERSION_1_1",
        ]
    )]
    Entry1InvocationPer2X2PixelsNV = 8,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_4X2_PIXELS_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_shading_rate_image"],
        ImpliesSets = [
            "VK_NV_shading_rate_image+VK_KHR_get_physical_device_properties2",
            "VK_NV_shading_rate_image+VK_VERSION_1_1",
        ]
    )]
    Entry1InvocationPer4X2PixelsNV = 9,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_2X4_PIXELS_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_shading_rate_image"],
        ImpliesSets = [
            "VK_NV_shading_rate_image+VK_KHR_get_physical_device_properties2",
            "VK_NV_shading_rate_image+VK_VERSION_1_1",
        ]
    )]
    Entry1InvocationPer2X4PixelsNV = 10,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_4X4_PIXELS_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_shading_rate_image"],
        ImpliesSets = [
            "VK_NV_shading_rate_image+VK_KHR_get_physical_device_properties2",
            "VK_NV_shading_rate_image+VK_VERSION_1_1",
        ]
    )]
    Entry1InvocationPer4X4PixelsNV = 11,
}
