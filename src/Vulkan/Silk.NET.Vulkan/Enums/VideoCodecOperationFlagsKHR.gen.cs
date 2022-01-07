// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkVideoCodecOperationFlagsKHR")]
    public enum VideoCodecOperationFlagsKHR : int
    {
        [NativeName("Name", "VK_VIDEO_CODEC_OPERATION_INVALID_BIT_KHR")]
        VideoCodecOperationInvalidBitKhr = 0,
        [NativeName("Name", "VK_VIDEO_CODEC_OPERATION_ENCODE_H264_BIT_EXT")]
        VideoCodecOperationEncodeH264BitExt = 65536,
        [NativeName("Name", "VK_VIDEO_CODEC_OPERATION_ENCODE_H265_BIT_EXT")]
        VideoCodecOperationEncodeH265BitExt = 131072,
        [NativeName("Name", "VK_VIDEO_CODEC_OPERATION_DECODE_H264_BIT_EXT")]
        VideoCodecOperationDecodeH264BitExt = 1,
        [NativeName("Name", "VK_VIDEO_CODEC_OPERATION_DECODE_H265_BIT_EXT")]
        VideoCodecOperationDecodeH265BitExt = 2,
    }
}
