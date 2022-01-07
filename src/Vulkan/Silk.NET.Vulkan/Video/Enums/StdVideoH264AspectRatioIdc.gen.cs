// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Video
{
    [NativeName("Name", "StdVideoH264AspectRatioIdc")]
    public enum StdVideoH264AspectRatioIdc : int
    {
        [NativeName("Name", "STD_VIDEO_H264_ASPECT_RATIO_IDC_UNSPECIFIED")]
        StdVideoH264AspectRatioIdcUnspecified = 0x0,
        [NativeName("Name", "STD_VIDEO_H264_ASPECT_RATIO_IDC_SQUARE")]
        StdVideoH264AspectRatioIdcSquare = 0x1,
        [NativeName("Name", "STD_VIDEO_H264_ASPECT_RATIO_IDC_12_11")]
        StdVideoH264AspectRatioIdc1211 = 0x2,
        [NativeName("Name", "STD_VIDEO_H264_ASPECT_RATIO_IDC_10_11")]
        StdVideoH264AspectRatioIdc1011 = 0x3,
        [NativeName("Name", "STD_VIDEO_H264_ASPECT_RATIO_IDC_16_11")]
        StdVideoH264AspectRatioIdc1611 = 0x4,
        [NativeName("Name", "STD_VIDEO_H264_ASPECT_RATIO_IDC_40_33")]
        StdVideoH264AspectRatioIdc4033 = 0x5,
        [NativeName("Name", "STD_VIDEO_H264_ASPECT_RATIO_IDC_24_11")]
        StdVideoH264AspectRatioIdc2411 = 0x6,
        [NativeName("Name", "STD_VIDEO_H264_ASPECT_RATIO_IDC_20_11")]
        StdVideoH264AspectRatioIdc2011 = 0x7,
        [NativeName("Name", "STD_VIDEO_H264_ASPECT_RATIO_IDC_32_11")]
        StdVideoH264AspectRatioIdc3211 = 0x8,
        [NativeName("Name", "STD_VIDEO_H264_ASPECT_RATIO_IDC_80_33")]
        StdVideoH264AspectRatioIdc8033 = 0x9,
        [NativeName("Name", "STD_VIDEO_H264_ASPECT_RATIO_IDC_18_11")]
        StdVideoH264AspectRatioIdc1811 = 0xA,
        [NativeName("Name", "STD_VIDEO_H264_ASPECT_RATIO_IDC_15_11")]
        StdVideoH264AspectRatioIdc1511 = 0xB,
        [NativeName("Name", "STD_VIDEO_H264_ASPECT_RATIO_IDC_64_33")]
        StdVideoH264AspectRatioIdc6433 = 0xC,
        [NativeName("Name", "STD_VIDEO_H264_ASPECT_RATIO_IDC_160_99")]
        StdVideoH264AspectRatioIdc16099 = 0xD,
        [NativeName("Name", "STD_VIDEO_H264_ASPECT_RATIO_IDC_4_3")]
        StdVideoH264AspectRatioIdc43 = 0xE,
        [NativeName("Name", "STD_VIDEO_H264_ASPECT_RATIO_IDC_3_2")]
        StdVideoH264AspectRatioIdc32 = 0xF,
        [NativeName("Name", "STD_VIDEO_H264_ASPECT_RATIO_IDC_2_1")]
        StdVideoH264AspectRatioIdc21 = 0x10,
        [NativeName("Name", "STD_VIDEO_H264_ASPECT_RATIO_IDC_EXTENDED_SAR")]
        StdVideoH264AspectRatioIdcExtendedSar = 0xFF,
        [NativeName("Name", "STD_VIDEO_H264_ASPECT_RATIO_IDC_INVALID")]
        StdVideoH264AspectRatioIdcInvalid = 0x7FFFFFFF,
        [NativeName("Name", "STD_VIDEO_H264_ASPECT_RATIO_IDC_MAX_ENUM")]
        StdVideoH264AspectRatioIdcMaxEnum = 0x7FFFFFFF,
    }
}
