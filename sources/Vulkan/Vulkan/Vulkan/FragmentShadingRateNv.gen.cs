// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "NV", 0)]
[NativeName("VkFragmentShadingRateNV")]
[SupportedApiProfile("vulkan")]
public enum FragmentShadingRateNv : uint
{
    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_PIXEL_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_fragment_shading_rate_enums"],
        ImpliesSets = ["VK_KHR_fragment_shading_rate"]
    )]
    Rate1InvocationPerPixelnv = 0,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_1X2_PIXELS_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_fragment_shading_rate_enums"],
        ImpliesSets = ["VK_KHR_fragment_shading_rate"]
    )]
    Rate1InvocationPer1X2Pixelsnv = 1,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_2X1_PIXELS_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_fragment_shading_rate_enums"],
        ImpliesSets = ["VK_KHR_fragment_shading_rate"]
    )]
    Rate1InvocationPer2X1Pixelsnv = 4,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_2X2_PIXELS_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_fragment_shading_rate_enums"],
        ImpliesSets = ["VK_KHR_fragment_shading_rate"]
    )]
    Rate1InvocationPer2X2Pixelsnv = 5,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_2X4_PIXELS_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_fragment_shading_rate_enums"],
        ImpliesSets = ["VK_KHR_fragment_shading_rate"]
    )]
    Rate1InvocationPer2X4Pixelsnv = 6,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_4X2_PIXELS_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_fragment_shading_rate_enums"],
        ImpliesSets = ["VK_KHR_fragment_shading_rate"]
    )]
    Rate1InvocationPer4X2Pixelsnv = 9,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_4X4_PIXELS_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_fragment_shading_rate_enums"],
        ImpliesSets = ["VK_KHR_fragment_shading_rate"]
    )]
    Rate1InvocationPer4X4Pixelsnv = 10,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_FRAGMENT_SHADING_RATE_2_INVOCATIONS_PER_PIXEL_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_fragment_shading_rate_enums"],
        ImpliesSets = ["VK_KHR_fragment_shading_rate"]
    )]
    Rate2InvocationsPerPixelnv = 11,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_FRAGMENT_SHADING_RATE_4_INVOCATIONS_PER_PIXEL_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_fragment_shading_rate_enums"],
        ImpliesSets = ["VK_KHR_fragment_shading_rate"]
    )]
    Rate4InvocationsPerPixelnv = 12,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_FRAGMENT_SHADING_RATE_8_INVOCATIONS_PER_PIXEL_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_fragment_shading_rate_enums"],
        ImpliesSets = ["VK_KHR_fragment_shading_rate"]
    )]
    Rate8InvocationsPerPixelnv = 13,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_FRAGMENT_SHADING_RATE_16_INVOCATIONS_PER_PIXEL_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_fragment_shading_rate_enums"],
        ImpliesSets = ["VK_KHR_fragment_shading_rate"]
    )]
    Rate16InvocationsPerPixelnv = 14,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_FRAGMENT_SHADING_RATE_NO_INVOCATIONS_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_fragment_shading_rate_enums"],
        ImpliesSets = ["VK_KHR_fragment_shading_rate"]
    )]
    RateNoInvocationsnv = 15,
}
