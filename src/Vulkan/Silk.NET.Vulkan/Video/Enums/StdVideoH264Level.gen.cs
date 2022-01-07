// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Video
{
    [NativeName("Name", "StdVideoH264Level")]
    public enum StdVideoH264Level : int
    {
        [NativeName("Name", "STD_VIDEO_H264_LEVEL_1_0")]
        StdVideoH264Level10 = 0x0,
        [NativeName("Name", "STD_VIDEO_H264_LEVEL_1_1")]
        StdVideoH264Level11 = 0x1,
        [NativeName("Name", "STD_VIDEO_H264_LEVEL_1_2")]
        StdVideoH264Level12 = 0x2,
        [NativeName("Name", "STD_VIDEO_H264_LEVEL_1_3")]
        StdVideoH264Level13 = 0x3,
        [NativeName("Name", "STD_VIDEO_H264_LEVEL_2_0")]
        StdVideoH264Level20 = 0x4,
        [NativeName("Name", "STD_VIDEO_H264_LEVEL_2_1")]
        StdVideoH264Level21 = 0x5,
        [NativeName("Name", "STD_VIDEO_H264_LEVEL_2_2")]
        StdVideoH264Level22 = 0x6,
        [NativeName("Name", "STD_VIDEO_H264_LEVEL_3_0")]
        StdVideoH264Level30 = 0x7,
        [NativeName("Name", "STD_VIDEO_H264_LEVEL_3_1")]
        StdVideoH264Level31 = 0x8,
        [NativeName("Name", "STD_VIDEO_H264_LEVEL_3_2")]
        StdVideoH264Level32 = 0x9,
        [NativeName("Name", "STD_VIDEO_H264_LEVEL_4_0")]
        StdVideoH264Level40 = 0xA,
        [NativeName("Name", "STD_VIDEO_H264_LEVEL_4_1")]
        StdVideoH264Level41 = 0xB,
        [NativeName("Name", "STD_VIDEO_H264_LEVEL_4_2")]
        StdVideoH264Level42 = 0xC,
        [NativeName("Name", "STD_VIDEO_H264_LEVEL_5_0")]
        StdVideoH264Level50 = 0xD,
        [NativeName("Name", "STD_VIDEO_H264_LEVEL_5_1")]
        StdVideoH264Level51 = 0xE,
        [NativeName("Name", "STD_VIDEO_H264_LEVEL_5_2")]
        StdVideoH264Level52 = 0xF,
        [NativeName("Name", "STD_VIDEO_H264_LEVEL_6_0")]
        StdVideoH264Level60 = 0x10,
        [NativeName("Name", "STD_VIDEO_H264_LEVEL_6_1")]
        StdVideoH264Level61 = 0x11,
        [NativeName("Name", "STD_VIDEO_H264_LEVEL_6_2")]
        StdVideoH264Level62 = 0x12,
        [NativeName("Name", "STD_VIDEO_H264_LEVEL_INVALID")]
        StdVideoH264LevelInvalid = 0x7FFFFFFF,
        [NativeName("Name", "STD_VIDEO_H264_LEVEL_MAX_ENUM")]
        StdVideoH264LevelMaxEnum = 0x7FFFFFFF,
    }
}
