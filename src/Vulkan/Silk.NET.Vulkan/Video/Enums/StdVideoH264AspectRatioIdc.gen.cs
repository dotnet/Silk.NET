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
        [NativeName("Name", "std_video_h264_aspect_ratio_idc_unspecified")]
        StdVideoH264AspectRatioIdcUnspecified = 0x0,
        [NativeName("Name", "std_video_h264_aspect_ratio_idc_square")]
        StdVideoH264AspectRatioIdcSquare = 0x1,
        [NativeName("Name", "std_video_h264_aspect_ratio_idc_12_11")]
        StdVideoH264AspectRatioIdc1211 = 0x2,
        [NativeName("Name", "std_video_h264_aspect_ratio_idc_10_11")]
        StdVideoH264AspectRatioIdc1011 = 0x3,
        [NativeName("Name", "std_video_h264_aspect_ratio_idc_16_11")]
        StdVideoH264AspectRatioIdc1611 = 0x4,
        [NativeName("Name", "std_video_h264_aspect_ratio_idc_40_33")]
        StdVideoH264AspectRatioIdc4033 = 0x5,
        [NativeName("Name", "std_video_h264_aspect_ratio_idc_24_11")]
        StdVideoH264AspectRatioIdc2411 = 0x6,
        [NativeName("Name", "std_video_h264_aspect_ratio_idc_20_11")]
        StdVideoH264AspectRatioIdc2011 = 0x7,
        [NativeName("Name", "std_video_h264_aspect_ratio_idc_32_11")]
        StdVideoH264AspectRatioIdc3211 = 0x8,
        [NativeName("Name", "std_video_h264_aspect_ratio_idc_80_33")]
        StdVideoH264AspectRatioIdc8033 = 0x9,
        [NativeName("Name", "std_video_h264_aspect_ratio_idc_18_11")]
        StdVideoH264AspectRatioIdc1811 = 0xA,
        [NativeName("Name", "std_video_h264_aspect_ratio_idc_15_11")]
        StdVideoH264AspectRatioIdc1511 = 0xB,
        [NativeName("Name", "std_video_h264_aspect_ratio_idc_64_33")]
        StdVideoH264AspectRatioIdc6433 = 0xC,
        [NativeName("Name", "std_video_h264_aspect_ratio_idc_160_99")]
        StdVideoH264AspectRatioIdc16099 = 0xD,
        [NativeName("Name", "std_video_h264_aspect_ratio_idc_4_3")]
        StdVideoH264AspectRatioIdc43 = 0xE,
        [NativeName("Name", "std_video_h264_aspect_ratio_idc_3_2")]
        StdVideoH264AspectRatioIdc32 = 0xF,
        [NativeName("Name", "std_video_h264_aspect_ratio_idc_2_1")]
        StdVideoH264AspectRatioIdc21 = 0x10,
        [NativeName("Name", "std_video_h264_aspect_ratio_idc_extended_sar")]
        StdVideoH264AspectRatioIdcExtendedSar = 0xFF,
        [NativeName("Name", "std_video_h264_aspect_ratio_idc_invalid")]
        StdVideoH264AspectRatioIdcInvalid = 0x7FFFFFFF,
    }
}
