// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameSuffix("KHR", 0)]
[NativeName("VkVideoEncodeAV1RateControlGroupKHR")]
[SupportedApiProfile("vulkan")]
public enum VideoEncodeAV1RateControlGroupKHR : uint
{
    [NameSuffix("KHR", 0)]
    [NativeName("VK_VIDEO_ENCODE_AV1_RATE_CONTROL_GROUP_INTRA_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_av1"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    IntraKHR = 0,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_VIDEO_ENCODE_AV1_RATE_CONTROL_GROUP_PREDICTIVE_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_av1"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    PredictiveKHR = 1,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_VIDEO_ENCODE_AV1_RATE_CONTROL_GROUP_BIPREDICTIVE_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_av1"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    BipredictiveKHR = 2,
}
