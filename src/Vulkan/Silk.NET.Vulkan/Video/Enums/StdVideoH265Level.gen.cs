// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Video
{
    [NativeName("Name", "StdVideoH265Level")]
    public enum StdVideoH265Level : int
    {
        [NativeName("Name", "std_video_h265_level_1_0")]
        StdVideoH265Level10 = 0x0,
        [NativeName("Name", "std_video_h265_level_2_0")]
        StdVideoH265Level20 = 0x1,
        [NativeName("Name", "std_video_h265_level_2_1")]
        StdVideoH265Level21 = 0x2,
        [NativeName("Name", "std_video_h265_level_3_0")]
        StdVideoH265Level30 = 0x3,
        [NativeName("Name", "std_video_h265_level_3_1")]
        StdVideoH265Level31 = 0x4,
        [NativeName("Name", "std_video_h265_level_4_0")]
        StdVideoH265Level40 = 0x5,
        [NativeName("Name", "std_video_h265_level_4_1")]
        StdVideoH265Level41 = 0x6,
        [NativeName("Name", "std_video_h265_level_5_0")]
        StdVideoH265Level50 = 0x7,
        [NativeName("Name", "std_video_h265_level_5_1")]
        StdVideoH265Level51 = 0x8,
        [NativeName("Name", "std_video_h265_level_5_2")]
        StdVideoH265Level52 = 0x9,
        [NativeName("Name", "std_video_h265_level_6_0")]
        StdVideoH265Level60 = 0xA,
        [NativeName("Name", "std_video_h265_level_6_1")]
        StdVideoH265Level61 = 0xB,
        [NativeName("Name", "std_video_h265_level_6_2")]
        StdVideoH265Level62 = 0xC,
        [NativeName("Name", "std_video_h265_level_invalid")]
        StdVideoH265LevelInvalid = 0x7FFFFFFF,
    }
}
