// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public enum VkVideoEncodeAV1PredictionModeKHR
{
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_av1"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VK_VIDEO_ENCODE_AV1_PREDICTION_MODE_INTRA_ONLY_KHR = 0,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_av1"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VK_VIDEO_ENCODE_AV1_PREDICTION_MODE_SINGLE_REFERENCE_KHR = 1,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_av1"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VK_VIDEO_ENCODE_AV1_PREDICTION_MODE_UNIDIRECTIONAL_COMPOUND_KHR = 2,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_av1"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VK_VIDEO_ENCODE_AV1_PREDICTION_MODE_BIDIRECTIONAL_COMPOUND_KHR = 3,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_av1"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VK_VIDEO_ENCODE_AV1_PREDICTION_MODE_MAX_ENUM_KHR = 0x7FFFFFFF,
}
