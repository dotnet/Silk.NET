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
        [Obsolete("Deprecated in favour of \"Level10\"")]
        [NativeName("Name", "STD_VIDEO_H264_LEVEL_1_0")]
        StdVideoH264Level10 = 0x0,
        [Obsolete("Deprecated in favour of \"Level11\"")]
        [NativeName("Name", "STD_VIDEO_H264_LEVEL_1_1")]
        StdVideoH264Level11 = 0x1,
        [Obsolete("Deprecated in favour of \"Level12\"")]
        [NativeName("Name", "STD_VIDEO_H264_LEVEL_1_2")]
        StdVideoH264Level12 = 0x2,
        [Obsolete("Deprecated in favour of \"Level13\"")]
        [NativeName("Name", "STD_VIDEO_H264_LEVEL_1_3")]
        StdVideoH264Level13 = 0x3,
        [Obsolete("Deprecated in favour of \"Level20\"")]
        [NativeName("Name", "STD_VIDEO_H264_LEVEL_2_0")]
        StdVideoH264Level20 = 0x4,
        [Obsolete("Deprecated in favour of \"Level21\"")]
        [NativeName("Name", "STD_VIDEO_H264_LEVEL_2_1")]
        StdVideoH264Level21 = 0x5,
        [Obsolete("Deprecated in favour of \"Level22\"")]
        [NativeName("Name", "STD_VIDEO_H264_LEVEL_2_2")]
        StdVideoH264Level22 = 0x6,
        [Obsolete("Deprecated in favour of \"Level30\"")]
        [NativeName("Name", "STD_VIDEO_H264_LEVEL_3_0")]
        StdVideoH264Level30 = 0x7,
        [Obsolete("Deprecated in favour of \"Level31\"")]
        [NativeName("Name", "STD_VIDEO_H264_LEVEL_3_1")]
        StdVideoH264Level31 = 0x8,
        [Obsolete("Deprecated in favour of \"Level32\"")]
        [NativeName("Name", "STD_VIDEO_H264_LEVEL_3_2")]
        StdVideoH264Level32 = 0x9,
        [Obsolete("Deprecated in favour of \"Level40\"")]
        [NativeName("Name", "STD_VIDEO_H264_LEVEL_4_0")]
        StdVideoH264Level40 = 0xA,
        [Obsolete("Deprecated in favour of \"Level41\"")]
        [NativeName("Name", "STD_VIDEO_H264_LEVEL_4_1")]
        StdVideoH264Level41 = 0xB,
        [Obsolete("Deprecated in favour of \"Level42\"")]
        [NativeName("Name", "STD_VIDEO_H264_LEVEL_4_2")]
        StdVideoH264Level42 = 0xC,
        [Obsolete("Deprecated in favour of \"Level50\"")]
        [NativeName("Name", "STD_VIDEO_H264_LEVEL_5_0")]
        StdVideoH264Level50 = 0xD,
        [Obsolete("Deprecated in favour of \"Level51\"")]
        [NativeName("Name", "STD_VIDEO_H264_LEVEL_5_1")]
        StdVideoH264Level51 = 0xE,
        [Obsolete("Deprecated in favour of \"Level52\"")]
        [NativeName("Name", "STD_VIDEO_H264_LEVEL_5_2")]
        StdVideoH264Level52 = 0xF,
        [Obsolete("Deprecated in favour of \"Level60\"")]
        [NativeName("Name", "STD_VIDEO_H264_LEVEL_6_0")]
        StdVideoH264Level60 = 0x10,
        [Obsolete("Deprecated in favour of \"Level61\"")]
        [NativeName("Name", "STD_VIDEO_H264_LEVEL_6_1")]
        StdVideoH264Level61 = 0x11,
        [Obsolete("Deprecated in favour of \"Level62\"")]
        [NativeName("Name", "STD_VIDEO_H264_LEVEL_6_2")]
        StdVideoH264Level62 = 0x12,
        [Obsolete("Deprecated in favour of \"LevelInvalid\"")]
        [NativeName("Name", "STD_VIDEO_H264_LEVEL_INVALID")]
        StdVideoH264LevelInvalid = 0x7FFFFFFF,
        [Obsolete("Deprecated in favour of \"LevelMaxEnum\"")]
        [NativeName("Name", "STD_VIDEO_H264_LEVEL_MAX_ENUM")]
        StdVideoH264LevelMaxEnum = 0x7FFFFFFF,
        [NativeName("Name", "STD_VIDEO_H264_LEVEL_1_0")]
        Level10 = 0x0,
        [NativeName("Name", "STD_VIDEO_H264_LEVEL_1_1")]
        Level11 = 0x1,
        [NativeName("Name", "STD_VIDEO_H264_LEVEL_1_2")]
        Level12 = 0x2,
        [NativeName("Name", "STD_VIDEO_H264_LEVEL_1_3")]
        Level13 = 0x3,
        [NativeName("Name", "STD_VIDEO_H264_LEVEL_2_0")]
        Level20 = 0x4,
        [NativeName("Name", "STD_VIDEO_H264_LEVEL_2_1")]
        Level21 = 0x5,
        [NativeName("Name", "STD_VIDEO_H264_LEVEL_2_2")]
        Level22 = 0x6,
        [NativeName("Name", "STD_VIDEO_H264_LEVEL_3_0")]
        Level30 = 0x7,
        [NativeName("Name", "STD_VIDEO_H264_LEVEL_3_1")]
        Level31 = 0x8,
        [NativeName("Name", "STD_VIDEO_H264_LEVEL_3_2")]
        Level32 = 0x9,
        [NativeName("Name", "STD_VIDEO_H264_LEVEL_4_0")]
        Level40 = 0xA,
        [NativeName("Name", "STD_VIDEO_H264_LEVEL_4_1")]
        Level41 = 0xB,
        [NativeName("Name", "STD_VIDEO_H264_LEVEL_4_2")]
        Level42 = 0xC,
        [NativeName("Name", "STD_VIDEO_H264_LEVEL_5_0")]
        Level50 = 0xD,
        [NativeName("Name", "STD_VIDEO_H264_LEVEL_5_1")]
        Level51 = 0xE,
        [NativeName("Name", "STD_VIDEO_H264_LEVEL_5_2")]
        Level52 = 0xF,
        [NativeName("Name", "STD_VIDEO_H264_LEVEL_6_0")]
        Level60 = 0x10,
        [NativeName("Name", "STD_VIDEO_H264_LEVEL_6_1")]
        Level61 = 0x11,
        [NativeName("Name", "STD_VIDEO_H264_LEVEL_6_2")]
        Level62 = 0x12,
        [NativeName("Name", "STD_VIDEO_H264_LEVEL_INVALID")]
        LevelInvalid = 0x7FFFFFFF,
        [NativeName("Name", "STD_VIDEO_H264_LEVEL_MAX_ENUM")]
        LevelMaxEnum = 0x7FFFFFFF,
    }
}
