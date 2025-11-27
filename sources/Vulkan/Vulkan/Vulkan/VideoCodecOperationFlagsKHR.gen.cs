// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkVideoCodecOperationFlagBitsKHR")]
[SupportedApiProfile("vulkan")]
[Flags]
public enum VideoCodecOperationFlagsKHR : uint
{
    [NativeName("VK_VIDEO_CODEC_OPERATION_NONE_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_queue"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_synchronization2", "VK_VERSION_1_3"]
    )]
    NoneKHR = 0x0,

    [NativeName("VK_VIDEO_CODEC_OPERATION_ENCODE_H264_BIT_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h264"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    EncodeH264BitKHR = 0x10000,

    [NativeName("VK_VIDEO_CODEC_OPERATION_ENCODE_H265_BIT_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h265"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    EncodeH265BitKHR = 0x20000,

    [NativeName("VK_VIDEO_CODEC_OPERATION_DECODE_H264_BIT_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_h264"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    DecodeH264BitKHR = 0x1,

    [NativeName("VK_VIDEO_CODEC_OPERATION_DECODE_H265_BIT_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_h265"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    DecodeH265BitKHR = 0x2,

    [NativeName("VK_VIDEO_CODEC_OPERATION_DECODE_AV1_BIT_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_av1"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    DecodeAv1BitKHR = 0x4,

    [NativeName("VK_VIDEO_CODEC_OPERATION_ENCODE_AV1_BIT_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_av1"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    EncodeAv1BitKHR = 0x40000,

    [NativeName("VK_VIDEO_CODEC_OPERATION_DECODE_VP9_BIT_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_decode_vp9"],
        ImpliesSets = ["VK_KHR_video_decode_queue"]
    )]
    DecodeVp9BitKHR = 0x8,
}
