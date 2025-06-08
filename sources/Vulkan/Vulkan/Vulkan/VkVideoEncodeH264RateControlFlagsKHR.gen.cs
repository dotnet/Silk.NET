// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public enum VkVideoEncodeH264RateControlFlagsKHR
{
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h264"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VK_VIDEO_ENCODE_H264_RATE_CONTROL_ATTEMPT_HRD_COMPLIANCE_BIT_KHR = 0x00000001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h264"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VK_VIDEO_ENCODE_H264_RATE_CONTROL_REGULAR_GOP_BIT_KHR = 0x00000002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h264"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VK_VIDEO_ENCODE_H264_RATE_CONTROL_REFERENCE_PATTERN_FLAT_BIT_KHR = 0x00000004,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h264"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VK_VIDEO_ENCODE_H264_RATE_CONTROL_REFERENCE_PATTERN_DYADIC_BIT_KHR = 0x00000008,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h264"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VK_VIDEO_ENCODE_H264_RATE_CONTROL_TEMPORAL_LAYER_PATTERN_DYADIC_BIT_KHR = 0x00000010,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h264"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VK_VIDEO_ENCODE_H264_RATE_CONTROL_FLAG_BITS_MAX_ENUM_KHR = 0x7FFFFFFF,
}
