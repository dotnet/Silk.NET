// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "KHR", 0)]
[NativeName("VkVideoEncodeH264CapabilityFlagBitsKHR")]
[Flags]
[SupportedApiProfile("vulkan")]
public enum VideoEncodeH264CapabilityFlagsKHR : uint
{
    None = 0x0,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_VIDEO_ENCODE_H264_CAPABILITY_HRD_COMPLIANCE_BIT_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h264"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    HrdComplianceBitKHR = 0x1,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_VIDEO_ENCODE_H264_CAPABILITY_PREDICTION_WEIGHT_TABLE_GENERATED_BIT_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h264"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    PredictionWeightTableGeneratedBitKHR = 0x2,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_VIDEO_ENCODE_H264_CAPABILITY_ROW_UNALIGNED_SLICE_BIT_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h264"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    RowUnalignedSliceBitKHR = 0x4,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_VIDEO_ENCODE_H264_CAPABILITY_DIFFERENT_SLICE_TYPE_BIT_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h264"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    DifferentSliceTypeBitKHR = 0x8,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_VIDEO_ENCODE_H264_CAPABILITY_B_FRAME_IN_L0_LIST_BIT_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h264"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    BFrameInL0ListBitKHR = 0x10,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_VIDEO_ENCODE_H264_CAPABILITY_B_FRAME_IN_L1_LIST_BIT_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h264"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    BFrameInL1ListBitKHR = 0x20,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_VIDEO_ENCODE_H264_CAPABILITY_PER_PICTURE_TYPE_MIN_MAX_QP_BIT_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h264"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    PerPictureTypeMinMaxQpBitKHR = 0x40,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_VIDEO_ENCODE_H264_CAPABILITY_PER_SLICE_CONSTANT_QP_BIT_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h264"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    PerSliceConstantQpBitKHR = 0x80,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_VIDEO_ENCODE_H264_CAPABILITY_GENERATE_PREFIX_NALU_BIT_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h264"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    GeneratePrefixNaluBitKHR = 0x100,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_VIDEO_ENCODE_H264_CAPABILITY_B_PICTURE_INTRA_REFRESH_BIT_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h264", "VK_KHR_video_encode_intra_refresh"],
        ImpliesSets = ["VK_KHR_video_encode_queue"],
        RequireAll = true
    )]
    BPictureIntraRefreshBitKHR = 0x400,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_VIDEO_ENCODE_H264_CAPABILITY_MB_QP_DIFF_WRAPAROUND_BIT_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h264", "VK_KHR_video_encode_quantization_map"],
        ImpliesSets = [
            "VK_KHR_video_encode_queue+VK_KHR_format_feature_flags2",
            "VK_KHR_video_encode_queue+VK_VERSION_1_3",
        ],
        RequireAll = true
    )]
    MbQpDiffWraparoundBitKHR = 0x200,
}
