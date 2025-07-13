// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum FragmentShadingRateNV : uint
{
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_fragment_shading_rate_enums"],
        ImpliesSets = ["VK_KHR_fragment_shading_rate"]
    )]
    Rate1InvocationPerPixelNV = 0,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_fragment_shading_rate_enums"],
        ImpliesSets = ["VK_KHR_fragment_shading_rate"]
    )]
    Rate1InvocationPer1X2PixelsNV = 1,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_fragment_shading_rate_enums"],
        ImpliesSets = ["VK_KHR_fragment_shading_rate"]
    )]
    Rate1InvocationPer2X1PixelsNV = 4,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_fragment_shading_rate_enums"],
        ImpliesSets = ["VK_KHR_fragment_shading_rate"]
    )]
    Rate1InvocationPer2X2PixelsNV = 5,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_fragment_shading_rate_enums"],
        ImpliesSets = ["VK_KHR_fragment_shading_rate"]
    )]
    Rate1InvocationPer2X4PixelsNV = 6,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_fragment_shading_rate_enums"],
        ImpliesSets = ["VK_KHR_fragment_shading_rate"]
    )]
    Rate1InvocationPer4X2PixelsNV = 9,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_fragment_shading_rate_enums"],
        ImpliesSets = ["VK_KHR_fragment_shading_rate"]
    )]
    Rate1InvocationPer4X4PixelsNV = 10,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_fragment_shading_rate_enums"],
        ImpliesSets = ["VK_KHR_fragment_shading_rate"]
    )]
    Rate2InvocationsPerPixelNV = 11,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_fragment_shading_rate_enums"],
        ImpliesSets = ["VK_KHR_fragment_shading_rate"]
    )]
    Rate4InvocationsPerPixelNV = 12,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_fragment_shading_rate_enums"],
        ImpliesSets = ["VK_KHR_fragment_shading_rate"]
    )]
    Rate8InvocationsPerPixelNV = 13,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_fragment_shading_rate_enums"],
        ImpliesSets = ["VK_KHR_fragment_shading_rate"]
    )]
    Rate16InvocationsPerPixelNV = 14,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_fragment_shading_rate_enums"],
        ImpliesSets = ["VK_KHR_fragment_shading_rate"]
    )]
    RateNoInvocationsNV = 15,
}
