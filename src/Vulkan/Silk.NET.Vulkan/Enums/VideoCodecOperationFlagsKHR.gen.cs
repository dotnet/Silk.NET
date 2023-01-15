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
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"NoneKhr\"")]
        [NativeName("Name", "VK_VIDEO_CODEC_OPERATION_NONE_KHR")]
        VideoCodecOperationNoneKhr = 0,
        [Obsolete("Deprecated in favour of \"EncodeH264BitExt\"")]
        [NativeName("Name", "VK_VIDEO_CODEC_OPERATION_ENCODE_H264_BIT_EXT")]
        VideoCodecOperationEncodeH264BitExt = 65536,
        [Obsolete("Deprecated in favour of \"EncodeH265BitExt\"")]
        [NativeName("Name", "VK_VIDEO_CODEC_OPERATION_ENCODE_H265_BIT_EXT")]
        VideoCodecOperationEncodeH265BitExt = 131072,
        [Obsolete("Deprecated in favour of \"DecodeH264BitKhr\"")]
        [NativeName("Name", "VK_VIDEO_CODEC_OPERATION_DECODE_H264_BIT_KHR")]
        VideoCodecOperationDecodeH264BitKhr = 1,
        [Obsolete("Deprecated in favour of \"DecodeH265BitKhr\"")]
        [NativeName("Name", "VK_VIDEO_CODEC_OPERATION_DECODE_H265_BIT_KHR")]
        VideoCodecOperationDecodeH265BitKhr = 2,
        [NativeName("Name", "VK_VIDEO_CODEC_OPERATION_NONE_KHR")]
        NoneKhr = 0,
        [NativeName("Name", "VK_VIDEO_CODEC_OPERATION_ENCODE_H264_BIT_EXT")]
        EncodeH264BitExt = 65536,
        [NativeName("Name", "VK_VIDEO_CODEC_OPERATION_ENCODE_H265_BIT_EXT")]
        EncodeH265BitExt = 131072,
        [NativeName("Name", "VK_VIDEO_CODEC_OPERATION_DECODE_H264_BIT_KHR")]
        DecodeH264BitKhr = 1,
        [NativeName("Name", "VK_VIDEO_CODEC_OPERATION_DECODE_H265_BIT_KHR")]
        DecodeH265BitKhr = 2,
    }
}
