// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "KHR", 0)]
[NativeName("VkVideoEncodeH265RateControlFlagBitsKHR")]
[Flags]
[SupportedApiProfile("vulkan")]
public enum VideoEncodeH265RateControlFlagsKHR : uint
{
    None = 0x0,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_VIDEO_ENCODE_H265_RATE_CONTROL_ATTEMPT_HRD_COMPLIANCE_BIT_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h265"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    AttemptHrdComplianceBitkhr = 0x1,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_VIDEO_ENCODE_H265_RATE_CONTROL_REGULAR_GOP_BIT_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h265"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    RegularGopBitkhr = 0x2,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_VIDEO_ENCODE_H265_RATE_CONTROL_REFERENCE_PATTERN_FLAT_BIT_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h265"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    ReferencePatternFlatBitkhr = 0x4,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_VIDEO_ENCODE_H265_RATE_CONTROL_REFERENCE_PATTERN_DYADIC_BIT_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h265"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    ReferencePatternDyadicBitkhr = 0x8,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_VIDEO_ENCODE_H265_RATE_CONTROL_TEMPORAL_SUB_LAYER_PATTERN_DYADIC_BIT_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h265"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    TemporalSubLayerPatternDyadicBitkhr = 0x10,
}
