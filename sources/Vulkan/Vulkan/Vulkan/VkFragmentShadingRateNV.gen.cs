// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "KhronosVendor", "NV")]
[NativeName("VkFragmentShadingRateNV")]
[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum VkFragmentShadingRateNV : uint
{
    [NameAffix("Suffix", "KhronosImpliedVendor", "NV")]
    [NativeName("VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_PIXEL_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_fragment_shading_rate_enums"],
        ImpliesSets = ["VK_KHR_fragment_shading_rate"]
    )]
    VkFragmentShadingRate1InvocationPerPixel = 0,

    [NameAffix("Suffix", "KhronosImpliedVendor", "NV")]
    [NativeName("VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_1X2_PIXELS_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_fragment_shading_rate_enums"],
        ImpliesSets = ["VK_KHR_fragment_shading_rate"]
    )]
    VkFragmentShadingRate1InvocationPer1x2Pixels = 1,

    [NameAffix("Suffix", "KhronosImpliedVendor", "NV")]
    [NativeName("VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_2X1_PIXELS_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_fragment_shading_rate_enums"],
        ImpliesSets = ["VK_KHR_fragment_shading_rate"]
    )]
    VkFragmentShadingRate1InvocationPer2x1Pixels = 4,

    [NameAffix("Suffix", "KhronosImpliedVendor", "NV")]
    [NativeName("VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_2X2_PIXELS_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_fragment_shading_rate_enums"],
        ImpliesSets = ["VK_KHR_fragment_shading_rate"]
    )]
    VkFragmentShadingRate1InvocationPer2x2Pixels = 5,

    [NameAffix("Suffix", "KhronosImpliedVendor", "NV")]
    [NativeName("VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_2X4_PIXELS_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_fragment_shading_rate_enums"],
        ImpliesSets = ["VK_KHR_fragment_shading_rate"]
    )]
    VkFragmentShadingRate1InvocationPer2x4Pixels = 6,

    [NameAffix("Suffix", "KhronosImpliedVendor", "NV")]
    [NativeName("VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_4X2_PIXELS_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_fragment_shading_rate_enums"],
        ImpliesSets = ["VK_KHR_fragment_shading_rate"]
    )]
    VkFragmentShadingRate1InvocationPer4x2Pixels = 9,

    [NameAffix("Suffix", "KhronosImpliedVendor", "NV")]
    [NativeName("VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_4X4_PIXELS_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_fragment_shading_rate_enums"],
        ImpliesSets = ["VK_KHR_fragment_shading_rate"]
    )]
    VkFragmentShadingRate1InvocationPer4x4Pixels = 10,

    [NameAffix("Suffix", "KhronosImpliedVendor", "NV")]
    [NativeName("VK_FRAGMENT_SHADING_RATE_2_INVOCATIONS_PER_PIXEL_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_fragment_shading_rate_enums"],
        ImpliesSets = ["VK_KHR_fragment_shading_rate"]
    )]
    VkFragmentShadingRate2InvocationsPerPixel = 11,

    [NameAffix("Suffix", "KhronosImpliedVendor", "NV")]
    [NativeName("VK_FRAGMENT_SHADING_RATE_4_INVOCATIONS_PER_PIXEL_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_fragment_shading_rate_enums"],
        ImpliesSets = ["VK_KHR_fragment_shading_rate"]
    )]
    VkFragmentShadingRate4InvocationsPerPixel = 12,

    [NameAffix("Suffix", "KhronosImpliedVendor", "NV")]
    [NativeName("VK_FRAGMENT_SHADING_RATE_8_INVOCATIONS_PER_PIXEL_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_fragment_shading_rate_enums"],
        ImpliesSets = ["VK_KHR_fragment_shading_rate"]
    )]
    VkFragmentShadingRate8InvocationsPerPixel = 13,

    [NameAffix("Suffix", "KhronosImpliedVendor", "NV")]
    [NativeName("VK_FRAGMENT_SHADING_RATE_16_INVOCATIONS_PER_PIXEL_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_fragment_shading_rate_enums"],
        ImpliesSets = ["VK_KHR_fragment_shading_rate"]
    )]
    VkFragmentShadingRate16InvocationsPerPixel = 14,

    [NameAffix("Suffix", "KhronosImpliedVendor", "NV")]
    [NativeName("VK_FRAGMENT_SHADING_RATE_NO_INVOCATIONS_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_fragment_shading_rate_enums"],
        ImpliesSets = ["VK_KHR_fragment_shading_rate"]
    )]
    VkFragmentShadingRateNoInvocations = 15,

    [NameAffix("Suffix", "KhronosImpliedVendor", "NV")]
    [NativeName("VK_FRAGMENT_SHADING_RATE_MAX_ENUM_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_fragment_shading_rate_enums"],
        ImpliesSets = ["VK_KHR_fragment_shading_rate"]
    )]
    VkFragmentShadingRateMaxEnum = 0x7FFFFFFF,
}
