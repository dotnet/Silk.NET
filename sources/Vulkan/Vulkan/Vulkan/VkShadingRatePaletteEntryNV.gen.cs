// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "KhronosVendor", "NV")]
[NativeName("VkShadingRatePaletteEntryNV")]
[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum VkShadingRatePaletteEntryNV : uint
{
    [NameAffix("Suffix", "KhronosImpliedVendor", "NV")]
    [NativeName("VK_SHADING_RATE_PALETTE_ENTRY_NO_INVOCATIONS_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_shading_rate_image"],
        ImpliesSets = [
            "VK_NV_shading_rate_image+VK_KHR_get_physical_device_properties2",
            "VK_NV_shading_rate_image+VK_VERSION_1_1",
        ]
    )]
    VkShadingRatePaletteEntryNoInvocations = 0,

    [NameAffix("Suffix", "KhronosImpliedVendor", "NV")]
    [NativeName("VK_SHADING_RATE_PALETTE_ENTRY_16_INVOCATIONS_PER_PIXEL_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_shading_rate_image"],
        ImpliesSets = [
            "VK_NV_shading_rate_image+VK_KHR_get_physical_device_properties2",
            "VK_NV_shading_rate_image+VK_VERSION_1_1",
        ]
    )]
    VkShadingRatePaletteEntry16InvocationsPerPixel = 1,

    [NameAffix("Suffix", "KhronosImpliedVendor", "NV")]
    [NativeName("VK_SHADING_RATE_PALETTE_ENTRY_8_INVOCATIONS_PER_PIXEL_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_shading_rate_image"],
        ImpliesSets = [
            "VK_NV_shading_rate_image+VK_KHR_get_physical_device_properties2",
            "VK_NV_shading_rate_image+VK_VERSION_1_1",
        ]
    )]
    VkShadingRatePaletteEntry8InvocationsPerPixel = 2,

    [NameAffix("Suffix", "KhronosImpliedVendor", "NV")]
    [NativeName("VK_SHADING_RATE_PALETTE_ENTRY_4_INVOCATIONS_PER_PIXEL_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_shading_rate_image"],
        ImpliesSets = [
            "VK_NV_shading_rate_image+VK_KHR_get_physical_device_properties2",
            "VK_NV_shading_rate_image+VK_VERSION_1_1",
        ]
    )]
    VkShadingRatePaletteEntry4InvocationsPerPixel = 3,

    [NameAffix("Suffix", "KhronosImpliedVendor", "NV")]
    [NativeName("VK_SHADING_RATE_PALETTE_ENTRY_2_INVOCATIONS_PER_PIXEL_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_shading_rate_image"],
        ImpliesSets = [
            "VK_NV_shading_rate_image+VK_KHR_get_physical_device_properties2",
            "VK_NV_shading_rate_image+VK_VERSION_1_1",
        ]
    )]
    VkShadingRatePaletteEntry2InvocationsPerPixel = 4,

    [NameAffix("Suffix", "KhronosImpliedVendor", "NV")]
    [NativeName("VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_PIXEL_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_shading_rate_image"],
        ImpliesSets = [
            "VK_NV_shading_rate_image+VK_KHR_get_physical_device_properties2",
            "VK_NV_shading_rate_image+VK_VERSION_1_1",
        ]
    )]
    VkShadingRatePaletteEntry1InvocationPerPixel = 5,

    [NameAffix("Suffix", "KhronosImpliedVendor", "NV")]
    [NativeName("VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_2X1_PIXELS_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_shading_rate_image"],
        ImpliesSets = [
            "VK_NV_shading_rate_image+VK_KHR_get_physical_device_properties2",
            "VK_NV_shading_rate_image+VK_VERSION_1_1",
        ]
    )]
    VkShadingRatePaletteEntry1InvocationPer2x1Pixels = 6,

    [NameAffix("Suffix", "KhronosImpliedVendor", "NV")]
    [NativeName("VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_1X2_PIXELS_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_shading_rate_image"],
        ImpliesSets = [
            "VK_NV_shading_rate_image+VK_KHR_get_physical_device_properties2",
            "VK_NV_shading_rate_image+VK_VERSION_1_1",
        ]
    )]
    VkShadingRatePaletteEntry1InvocationPer1x2Pixels = 7,

    [NameAffix("Suffix", "KhronosImpliedVendor", "NV")]
    [NativeName("VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_2X2_PIXELS_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_shading_rate_image"],
        ImpliesSets = [
            "VK_NV_shading_rate_image+VK_KHR_get_physical_device_properties2",
            "VK_NV_shading_rate_image+VK_VERSION_1_1",
        ]
    )]
    VkShadingRatePaletteEntry1InvocationPer2x2Pixels = 8,

    [NameAffix("Suffix", "KhronosImpliedVendor", "NV")]
    [NativeName("VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_4X2_PIXELS_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_shading_rate_image"],
        ImpliesSets = [
            "VK_NV_shading_rate_image+VK_KHR_get_physical_device_properties2",
            "VK_NV_shading_rate_image+VK_VERSION_1_1",
        ]
    )]
    VkShadingRatePaletteEntry1InvocationPer4x2Pixels = 9,

    [NameAffix("Suffix", "KhronosImpliedVendor", "NV")]
    [NativeName("VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_2X4_PIXELS_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_shading_rate_image"],
        ImpliesSets = [
            "VK_NV_shading_rate_image+VK_KHR_get_physical_device_properties2",
            "VK_NV_shading_rate_image+VK_VERSION_1_1",
        ]
    )]
    VkShadingRatePaletteEntry1InvocationPer2x4Pixels = 10,

    [NameAffix("Suffix", "KhronosImpliedVendor", "NV")]
    [NativeName("VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_4X4_PIXELS_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_shading_rate_image"],
        ImpliesSets = [
            "VK_NV_shading_rate_image+VK_KHR_get_physical_device_properties2",
            "VK_NV_shading_rate_image+VK_VERSION_1_1",
        ]
    )]
    VkShadingRatePaletteEntry1InvocationPer4x4Pixels = 11,

    [NameAffix("Suffix", "KhronosImpliedVendor", "NV")]
    [NativeName("VK_SHADING_RATE_PALETTE_ENTRY_MAX_ENUM_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_shading_rate_image"],
        ImpliesSets = [
            "VK_NV_shading_rate_image+VK_KHR_get_physical_device_properties2",
            "VK_NV_shading_rate_image+VK_VERSION_1_1",
        ]
    )]
    VkShadingRatePaletteEntryMaxEnum = 0x7FFFFFFF,
}
