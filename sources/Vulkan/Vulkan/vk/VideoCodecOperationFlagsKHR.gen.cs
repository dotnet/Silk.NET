// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkVideoCodecOperationFlagsKHR")]
[Flags]
public enum VideoCodecOperationFlagsKHR : uint
{
    [NativeName("VK_VIDEO_CODEC_OPERATION_NONE_KHR")]
    None = 0x0,

    [NativeName("VK_VIDEO_CODEC_OPERATION_ENCODE_H264_BIT_KHR")]
    EncodeH264Bit = 0x10000,

    [NativeName("VK_VIDEO_CODEC_OPERATION_ENCODE_H265_BIT_KHR")]
    EncodeH265Bit = 0x20000,

    [NativeName("VK_VIDEO_CODEC_OPERATION_DECODE_H264_BIT_KHR")]
    DecodeH264Bit = 0x1,

    [NativeName("VK_VIDEO_CODEC_OPERATION_DECODE_H265_BIT_KHR")]
    DecodeH265Bit = 0x2,

    [NativeName("VK_VIDEO_CODEC_OPERATION_DECODE_AV1_BIT_KHR")]
    DecodeAv1Bit = 0x4,

    [NativeName("VK_VIDEO_CODEC_OPERATION_ENCODE_AV1_BIT_KHR")]
    EncodeAv1Bit = 0x40000,

    [NativeName("VK_VIDEO_CODEC_OPERATION_DECODE_VP9_BIT_KHR")]
    DecodeVp9Bit = 0x8,
}
