// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkFragmentShadingRateNV")]
public enum FragmentShadingRateNV : uint
{
    [NativeName("VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_PIXEL_NV")]
    Rate1InvocationPerPixel = 0,

    [NativeName("VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_1X2_PIXELS_NV")]
    Rate1InvocationPer1x2Pixels = 1,

    [NativeName("VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_2X1_PIXELS_NV")]
    Rate1InvocationPer2x1Pixels = 4,

    [NativeName("VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_2X2_PIXELS_NV")]
    Rate1InvocationPer2x2Pixels = 5,

    [NativeName("VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_2X4_PIXELS_NV")]
    Rate1InvocationPer2x4Pixels = 6,

    [NativeName("VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_4X2_PIXELS_NV")]
    Rate1InvocationPer4x2Pixels = 9,

    [NativeName("VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_4X4_PIXELS_NV")]
    Rate1InvocationPer4x4Pixels = 10,

    [NativeName("VK_FRAGMENT_SHADING_RATE_2_INVOCATIONS_PER_PIXEL_NV")]
    Rate2InvocationsPerPixel = 11,

    [NativeName("VK_FRAGMENT_SHADING_RATE_4_INVOCATIONS_PER_PIXEL_NV")]
    Rate4InvocationsPerPixel = 12,

    [NativeName("VK_FRAGMENT_SHADING_RATE_8_INVOCATIONS_PER_PIXEL_NV")]
    Rate8InvocationsPerPixel = 13,

    [NativeName("VK_FRAGMENT_SHADING_RATE_16_INVOCATIONS_PER_PIXEL_NV")]
    Rate16InvocationsPerPixel = 14,

    [NativeName("VK_FRAGMENT_SHADING_RATE_NO_INVOCATIONS_NV")]
    RateNoInvocations = 15,
}
