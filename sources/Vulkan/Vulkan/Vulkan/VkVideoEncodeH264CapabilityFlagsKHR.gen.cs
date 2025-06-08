// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public enum VkVideoEncodeH264CapabilityFlagsKHR
{
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h264"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VK_VIDEO_ENCODE_H264_CAPABILITY_HRD_COMPLIANCE_BIT_KHR = 0x00000001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h264"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VK_VIDEO_ENCODE_H264_CAPABILITY_PREDICTION_WEIGHT_TABLE_GENERATED_BIT_KHR = 0x00000002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h264"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VK_VIDEO_ENCODE_H264_CAPABILITY_ROW_UNALIGNED_SLICE_BIT_KHR = 0x00000004,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h264"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VK_VIDEO_ENCODE_H264_CAPABILITY_DIFFERENT_SLICE_TYPE_BIT_KHR = 0x00000008,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h264"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VK_VIDEO_ENCODE_H264_CAPABILITY_B_FRAME_IN_L0_LIST_BIT_KHR = 0x00000010,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h264"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VK_VIDEO_ENCODE_H264_CAPABILITY_B_FRAME_IN_L1_LIST_BIT_KHR = 0x00000020,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h264"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VK_VIDEO_ENCODE_H264_CAPABILITY_PER_PICTURE_TYPE_MIN_MAX_QP_BIT_KHR = 0x00000040,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h264"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VK_VIDEO_ENCODE_H264_CAPABILITY_PER_SLICE_CONSTANT_QP_BIT_KHR = 0x00000080,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h264"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VK_VIDEO_ENCODE_H264_CAPABILITY_GENERATE_PREFIX_NALU_BIT_KHR = 0x00000100,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h264", "VK_KHR_video_encode_quantization_map"],
        ImpliesSets = [
            "VK_KHR_video_encode_queue+VK_KHR_format_feature_flags2",
            "VK_KHR_video_encode_queue+VK_VERSION_1_3",
        ],
        RequireAll = true
    )]
    VK_VIDEO_ENCODE_H264_CAPABILITY_MB_QP_DIFF_WRAPAROUND_BIT_KHR = 0x00000200,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h264"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    VK_VIDEO_ENCODE_H264_CAPABILITY_FLAG_BITS_MAX_ENUM_KHR = 0x7FFFFFFF,
}
