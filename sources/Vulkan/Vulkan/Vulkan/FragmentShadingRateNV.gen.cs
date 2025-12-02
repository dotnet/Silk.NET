// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkFragmentShadingRateNV")]
[SupportedApiProfile("vulkan")]
public enum FragmentShadingRateNV : uint
{
    [NativeName("VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_PIXEL_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_fragment_shading_rate_enums"],
        ImpliesSets = ["VK_KHR_fragment_shading_rate"]
    )]
    Rate1InvocationPerPixelNV = 0,

    [NativeName("VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_1X2_PIXELS_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_fragment_shading_rate_enums"],
        ImpliesSets = ["VK_KHR_fragment_shading_rate"]
    )]
    Rate1InvocationPer1X2PixelsNV = 1,

    [NativeName("VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_2X1_PIXELS_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_fragment_shading_rate_enums"],
        ImpliesSets = ["VK_KHR_fragment_shading_rate"]
    )]
    Rate1InvocationPer2X1PixelsNV = 4,

    [NativeName("VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_2X2_PIXELS_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_fragment_shading_rate_enums"],
        ImpliesSets = ["VK_KHR_fragment_shading_rate"]
    )]
    Rate1InvocationPer2X2PixelsNV = 5,

    [NativeName("VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_2X4_PIXELS_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_fragment_shading_rate_enums"],
        ImpliesSets = ["VK_KHR_fragment_shading_rate"]
    )]
    Rate1InvocationPer2X4PixelsNV = 6,

    [NativeName("VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_4X2_PIXELS_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_fragment_shading_rate_enums"],
        ImpliesSets = ["VK_KHR_fragment_shading_rate"]
    )]
    Rate1InvocationPer4X2PixelsNV = 9,

    [NativeName("VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_4X4_PIXELS_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_fragment_shading_rate_enums"],
        ImpliesSets = ["VK_KHR_fragment_shading_rate"]
    )]
    Rate1InvocationPer4X4PixelsNV = 10,

    [NativeName("VK_FRAGMENT_SHADING_RATE_2_INVOCATIONS_PER_PIXEL_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_fragment_shading_rate_enums"],
        ImpliesSets = ["VK_KHR_fragment_shading_rate"]
    )]
    Rate2InvocationsPerPixelNV = 11,

    [NativeName("VK_FRAGMENT_SHADING_RATE_4_INVOCATIONS_PER_PIXEL_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_fragment_shading_rate_enums"],
        ImpliesSets = ["VK_KHR_fragment_shading_rate"]
    )]
    Rate4InvocationsPerPixelNV = 12,

    [NativeName("VK_FRAGMENT_SHADING_RATE_8_INVOCATIONS_PER_PIXEL_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_fragment_shading_rate_enums"],
        ImpliesSets = ["VK_KHR_fragment_shading_rate"]
    )]
    Rate8InvocationsPerPixelNV = 13,

    [NativeName("VK_FRAGMENT_SHADING_RATE_16_INVOCATIONS_PER_PIXEL_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_fragment_shading_rate_enums"],
        ImpliesSets = ["VK_KHR_fragment_shading_rate"]
    )]
    Rate16InvocationsPerPixelNV = 14,

    [NativeName("VK_FRAGMENT_SHADING_RATE_NO_INVOCATIONS_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_fragment_shading_rate_enums"],
        ImpliesSets = ["VK_KHR_fragment_shading_rate"]
    )]
    RateNoInvocationsNV = 15,
}
