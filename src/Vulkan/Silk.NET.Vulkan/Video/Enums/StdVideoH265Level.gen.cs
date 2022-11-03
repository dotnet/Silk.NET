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
        [Obsolete("Deprecated in favour of \"Level10\"")]
        [NativeName("Name", "STD_VIDEO_H265_LEVEL_1_0")]
        StdVideoH265Level10 = 0x0,
        [Obsolete("Deprecated in favour of \"Level20\"")]
        [NativeName("Name", "STD_VIDEO_H265_LEVEL_2_0")]
        StdVideoH265Level20 = 0x1,
        [Obsolete("Deprecated in favour of \"Level21\"")]
        [NativeName("Name", "STD_VIDEO_H265_LEVEL_2_1")]
        StdVideoH265Level21 = 0x2,
        [Obsolete("Deprecated in favour of \"Level30\"")]
        [NativeName("Name", "STD_VIDEO_H265_LEVEL_3_0")]
        StdVideoH265Level30 = 0x3,
        [Obsolete("Deprecated in favour of \"Level31\"")]
        [NativeName("Name", "STD_VIDEO_H265_LEVEL_3_1")]
        StdVideoH265Level31 = 0x4,
        [Obsolete("Deprecated in favour of \"Level40\"")]
        [NativeName("Name", "STD_VIDEO_H265_LEVEL_4_0")]
        StdVideoH265Level40 = 0x5,
        [Obsolete("Deprecated in favour of \"Level41\"")]
        [NativeName("Name", "STD_VIDEO_H265_LEVEL_4_1")]
        StdVideoH265Level41 = 0x6,
        [Obsolete("Deprecated in favour of \"Level50\"")]
        [NativeName("Name", "STD_VIDEO_H265_LEVEL_5_0")]
        StdVideoH265Level50 = 0x7,
        [Obsolete("Deprecated in favour of \"Level51\"")]
        [NativeName("Name", "STD_VIDEO_H265_LEVEL_5_1")]
        StdVideoH265Level51 = 0x8,
        [Obsolete("Deprecated in favour of \"Level52\"")]
        [NativeName("Name", "STD_VIDEO_H265_LEVEL_5_2")]
        StdVideoH265Level52 = 0x9,
        [Obsolete("Deprecated in favour of \"Level60\"")]
        [NativeName("Name", "STD_VIDEO_H265_LEVEL_6_0")]
        StdVideoH265Level60 = 0xA,
        [Obsolete("Deprecated in favour of \"Level61\"")]
        [NativeName("Name", "STD_VIDEO_H265_LEVEL_6_1")]
        StdVideoH265Level61 = 0xB,
        [Obsolete("Deprecated in favour of \"Level62\"")]
        [NativeName("Name", "STD_VIDEO_H265_LEVEL_6_2")]
        StdVideoH265Level62 = 0xC,
        [Obsolete("Deprecated in favour of \"LevelInvalid\"")]
        [NativeName("Name", "STD_VIDEO_H265_LEVEL_INVALID")]
        StdVideoH265LevelInvalid = 0x7FFFFFFF,
        [Obsolete("Deprecated in favour of \"LevelMaxEnum\"")]
        [NativeName("Name", "STD_VIDEO_H265_LEVEL_MAX_ENUM")]
        StdVideoH265LevelMaxEnum = 0x7FFFFFFF,
        [NativeName("Name", "STD_VIDEO_H265_LEVEL_1_0")]
        Level10 = 0x0,
        [NativeName("Name", "STD_VIDEO_H265_LEVEL_2_0")]
        Level20 = 0x1,
        [NativeName("Name", "STD_VIDEO_H265_LEVEL_2_1")]
        Level21 = 0x2,
        [NativeName("Name", "STD_VIDEO_H265_LEVEL_3_0")]
        Level30 = 0x3,
        [NativeName("Name", "STD_VIDEO_H265_LEVEL_3_1")]
        Level31 = 0x4,
        [NativeName("Name", "STD_VIDEO_H265_LEVEL_4_0")]
        Level40 = 0x5,
        [NativeName("Name", "STD_VIDEO_H265_LEVEL_4_1")]
        Level41 = 0x6,
        [NativeName("Name", "STD_VIDEO_H265_LEVEL_5_0")]
        Level50 = 0x7,
        [NativeName("Name", "STD_VIDEO_H265_LEVEL_5_1")]
        Level51 = 0x8,
        [NativeName("Name", "STD_VIDEO_H265_LEVEL_5_2")]
        Level52 = 0x9,
        [NativeName("Name", "STD_VIDEO_H265_LEVEL_6_0")]
        Level60 = 0xA,
        [NativeName("Name", "STD_VIDEO_H265_LEVEL_6_1")]
        Level61 = 0xB,
        [NativeName("Name", "STD_VIDEO_H265_LEVEL_6_2")]
        Level62 = 0xC,
        [NativeName("Name", "STD_VIDEO_H265_LEVEL_INVALID")]
        LevelInvalid = 0x7FFFFFFF,
        [NativeName("Name", "STD_VIDEO_H265_LEVEL_MAX_ENUM")]
        LevelMaxEnum = 0x7FFFFFFF,
    }
}
