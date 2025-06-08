// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public enum VkFragmentShadingRateNV
{
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_fragment_shading_rate_enums"],
        ImpliesSets = ["VK_KHR_fragment_shading_rate"]
    )]
    VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_PIXEL_NV = 0,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_fragment_shading_rate_enums"],
        ImpliesSets = ["VK_KHR_fragment_shading_rate"]
    )]
    VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_1X2_PIXELS_NV = 1,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_fragment_shading_rate_enums"],
        ImpliesSets = ["VK_KHR_fragment_shading_rate"]
    )]
    VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_2X1_PIXELS_NV = 4,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_fragment_shading_rate_enums"],
        ImpliesSets = ["VK_KHR_fragment_shading_rate"]
    )]
    VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_2X2_PIXELS_NV = 5,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_fragment_shading_rate_enums"],
        ImpliesSets = ["VK_KHR_fragment_shading_rate"]
    )]
    VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_2X4_PIXELS_NV = 6,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_fragment_shading_rate_enums"],
        ImpliesSets = ["VK_KHR_fragment_shading_rate"]
    )]
    VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_4X2_PIXELS_NV = 9,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_fragment_shading_rate_enums"],
        ImpliesSets = ["VK_KHR_fragment_shading_rate"]
    )]
    VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_4X4_PIXELS_NV = 10,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_fragment_shading_rate_enums"],
        ImpliesSets = ["VK_KHR_fragment_shading_rate"]
    )]
    VK_FRAGMENT_SHADING_RATE_2_INVOCATIONS_PER_PIXEL_NV = 11,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_fragment_shading_rate_enums"],
        ImpliesSets = ["VK_KHR_fragment_shading_rate"]
    )]
    VK_FRAGMENT_SHADING_RATE_4_INVOCATIONS_PER_PIXEL_NV = 12,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_fragment_shading_rate_enums"],
        ImpliesSets = ["VK_KHR_fragment_shading_rate"]
    )]
    VK_FRAGMENT_SHADING_RATE_8_INVOCATIONS_PER_PIXEL_NV = 13,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_fragment_shading_rate_enums"],
        ImpliesSets = ["VK_KHR_fragment_shading_rate"]
    )]
    VK_FRAGMENT_SHADING_RATE_16_INVOCATIONS_PER_PIXEL_NV = 14,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_fragment_shading_rate_enums"],
        ImpliesSets = ["VK_KHR_fragment_shading_rate"]
    )]
    VK_FRAGMENT_SHADING_RATE_NO_INVOCATIONS_NV = 15,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_fragment_shading_rate_enums"],
        ImpliesSets = ["VK_KHR_fragment_shading_rate"]
    )]
    VK_FRAGMENT_SHADING_RATE_MAX_ENUM_NV = 0x7FFFFFFF,
}
