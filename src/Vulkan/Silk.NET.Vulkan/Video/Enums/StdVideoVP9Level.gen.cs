// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Video
{
    [NativeName("Name", "StdVideoVP9Level")]
    public enum StdVideoVP9Level : int
    {
        [Obsolete("Deprecated in favour of \"Level10\"")]
        [NativeName("Name", "STD_VIDEO_VP9_LEVEL_1_0")]
        StdVideoVP9Level10 = 0x0,
        [Obsolete("Deprecated in favour of \"Level11\"")]
        [NativeName("Name", "STD_VIDEO_VP9_LEVEL_1_1")]
        StdVideoVP9Level11 = 0x1,
        [Obsolete("Deprecated in favour of \"Level20\"")]
        [NativeName("Name", "STD_VIDEO_VP9_LEVEL_2_0")]
        StdVideoVP9Level20 = 0x2,
        [Obsolete("Deprecated in favour of \"Level21\"")]
        [NativeName("Name", "STD_VIDEO_VP9_LEVEL_2_1")]
        StdVideoVP9Level21 = 0x3,
        [Obsolete("Deprecated in favour of \"Level30\"")]
        [NativeName("Name", "STD_VIDEO_VP9_LEVEL_3_0")]
        StdVideoVP9Level30 = 0x4,
        [Obsolete("Deprecated in favour of \"Level31\"")]
        [NativeName("Name", "STD_VIDEO_VP9_LEVEL_3_1")]
        StdVideoVP9Level31 = 0x5,
        [Obsolete("Deprecated in favour of \"Level40\"")]
        [NativeName("Name", "STD_VIDEO_VP9_LEVEL_4_0")]
        StdVideoVP9Level40 = 0x6,
        [Obsolete("Deprecated in favour of \"Level41\"")]
        [NativeName("Name", "STD_VIDEO_VP9_LEVEL_4_1")]
        StdVideoVP9Level41 = 0x7,
        [Obsolete("Deprecated in favour of \"Level50\"")]
        [NativeName("Name", "STD_VIDEO_VP9_LEVEL_5_0")]
        StdVideoVP9Level50 = 0x8,
        [Obsolete("Deprecated in favour of \"Level51\"")]
        [NativeName("Name", "STD_VIDEO_VP9_LEVEL_5_1")]
        StdVideoVP9Level51 = 0x9,
        [Obsolete("Deprecated in favour of \"Level52\"")]
        [NativeName("Name", "STD_VIDEO_VP9_LEVEL_5_2")]
        StdVideoVP9Level52 = 0xA,
        [Obsolete("Deprecated in favour of \"Level60\"")]
        [NativeName("Name", "STD_VIDEO_VP9_LEVEL_6_0")]
        StdVideoVP9Level60 = 0xB,
        [Obsolete("Deprecated in favour of \"Level61\"")]
        [NativeName("Name", "STD_VIDEO_VP9_LEVEL_6_1")]
        StdVideoVP9Level61 = 0xC,
        [Obsolete("Deprecated in favour of \"Level62\"")]
        [NativeName("Name", "STD_VIDEO_VP9_LEVEL_6_2")]
        StdVideoVP9Level62 = 0xD,
        [Obsolete("Deprecated in favour of \"LevelInvalid\"")]
        [NativeName("Name", "STD_VIDEO_VP9_LEVEL_INVALID")]
        StdVideoVP9LevelInvalid = 0x7FFFFFFF,
        [Obsolete("Deprecated in favour of \"LevelMaxEnum\"")]
        [NativeName("Name", "STD_VIDEO_VP9_LEVEL_MAX_ENUM")]
        StdVideoVP9LevelMaxEnum = 0x7FFFFFFF,
        [NativeName("Name", "STD_VIDEO_VP9_LEVEL_1_0")]
        Level10 = 0x0,
        [NativeName("Name", "STD_VIDEO_VP9_LEVEL_1_1")]
        Level11 = 0x1,
        [NativeName("Name", "STD_VIDEO_VP9_LEVEL_2_0")]
        Level20 = 0x2,
        [NativeName("Name", "STD_VIDEO_VP9_LEVEL_2_1")]
        Level21 = 0x3,
        [NativeName("Name", "STD_VIDEO_VP9_LEVEL_3_0")]
        Level30 = 0x4,
        [NativeName("Name", "STD_VIDEO_VP9_LEVEL_3_1")]
        Level31 = 0x5,
        [NativeName("Name", "STD_VIDEO_VP9_LEVEL_4_0")]
        Level40 = 0x6,
        [NativeName("Name", "STD_VIDEO_VP9_LEVEL_4_1")]
        Level41 = 0x7,
        [NativeName("Name", "STD_VIDEO_VP9_LEVEL_5_0")]
        Level50 = 0x8,
        [NativeName("Name", "STD_VIDEO_VP9_LEVEL_5_1")]
        Level51 = 0x9,
        [NativeName("Name", "STD_VIDEO_VP9_LEVEL_5_2")]
        Level52 = 0xA,
        [NativeName("Name", "STD_VIDEO_VP9_LEVEL_6_0")]
        Level60 = 0xB,
        [NativeName("Name", "STD_VIDEO_VP9_LEVEL_6_1")]
        Level61 = 0xC,
        [NativeName("Name", "STD_VIDEO_VP9_LEVEL_6_2")]
        Level62 = 0xD,
        [NativeName("Name", "STD_VIDEO_VP9_LEVEL_INVALID")]
        LevelInvalid = 0x7FFFFFFF,
        [NativeName("Name", "STD_VIDEO_VP9_LEVEL_MAX_ENUM")]
        LevelMaxEnum = 0x7FFFFFFF,
    }
}
