// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "KHR", 0)]
[NativeName("VkVideoEncodeAV1PredictionModeKHR")]
[SupportedApiProfile("vulkan")]
public enum VideoEncodeAV1PredictionModeKHR : uint
{
    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_VIDEO_ENCODE_AV1_PREDICTION_MODE_INTRA_ONLY_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_av1"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    IntraOnlyKHR = 0,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_VIDEO_ENCODE_AV1_PREDICTION_MODE_SINGLE_REFERENCE_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_av1"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    SingleReferenceKHR = 1,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_VIDEO_ENCODE_AV1_PREDICTION_MODE_UNIDIRECTIONAL_COMPOUND_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_av1"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    UnidirectionalCompoundKHR = 2,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_VIDEO_ENCODE_AV1_PREDICTION_MODE_BIDIRECTIONAL_COMPOUND_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_av1"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    BidirectionalCompoundKHR = 3,
}
