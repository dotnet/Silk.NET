// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Video
{
    [NativeName("Name", "StdVideoAV1Level")]
    public enum StdVideoAV1Level : int
    {
        [Obsolete("Deprecated in favour of \"Level20\"")]
        [NativeName("Name", "STD_VIDEO_AV1_LEVEL_2_0")]
        StdVideoAV1Level20 = 0x0,
        [Obsolete("Deprecated in favour of \"Level21\"")]
        [NativeName("Name", "STD_VIDEO_AV1_LEVEL_2_1")]
        StdVideoAV1Level21 = 0x1,
        [Obsolete("Deprecated in favour of \"Level22\"")]
        [NativeName("Name", "STD_VIDEO_AV1_LEVEL_2_2")]
        StdVideoAV1Level22 = 0x2,
        [Obsolete("Deprecated in favour of \"Level23\"")]
        [NativeName("Name", "STD_VIDEO_AV1_LEVEL_2_3")]
        StdVideoAV1Level23 = 0x3,
        [Obsolete("Deprecated in favour of \"Level30\"")]
        [NativeName("Name", "STD_VIDEO_AV1_LEVEL_3_0")]
        StdVideoAV1Level30 = 0x4,
        [Obsolete("Deprecated in favour of \"Level31\"")]
        [NativeName("Name", "STD_VIDEO_AV1_LEVEL_3_1")]
        StdVideoAV1Level31 = 0x5,
        [Obsolete("Deprecated in favour of \"Level32\"")]
        [NativeName("Name", "STD_VIDEO_AV1_LEVEL_3_2")]
        StdVideoAV1Level32 = 0x6,
        [Obsolete("Deprecated in favour of \"Level33\"")]
        [NativeName("Name", "STD_VIDEO_AV1_LEVEL_3_3")]
        StdVideoAV1Level33 = 0x7,
        [Obsolete("Deprecated in favour of \"Level40\"")]
        [NativeName("Name", "STD_VIDEO_AV1_LEVEL_4_0")]
        StdVideoAV1Level40 = 0x8,
        [Obsolete("Deprecated in favour of \"Level41\"")]
        [NativeName("Name", "STD_VIDEO_AV1_LEVEL_4_1")]
        StdVideoAV1Level41 = 0x9,
        [Obsolete("Deprecated in favour of \"Level42\"")]
        [NativeName("Name", "STD_VIDEO_AV1_LEVEL_4_2")]
        StdVideoAV1Level42 = 0xA,
        [Obsolete("Deprecated in favour of \"Level43\"")]
        [NativeName("Name", "STD_VIDEO_AV1_LEVEL_4_3")]
        StdVideoAV1Level43 = 0xB,
        [Obsolete("Deprecated in favour of \"Level50\"")]
        [NativeName("Name", "STD_VIDEO_AV1_LEVEL_5_0")]
        StdVideoAV1Level50 = 0xC,
        [Obsolete("Deprecated in favour of \"Level51\"")]
        [NativeName("Name", "STD_VIDEO_AV1_LEVEL_5_1")]
        StdVideoAV1Level51 = 0xD,
        [Obsolete("Deprecated in favour of \"Level52\"")]
        [NativeName("Name", "STD_VIDEO_AV1_LEVEL_5_2")]
        StdVideoAV1Level52 = 0xE,
        [Obsolete("Deprecated in favour of \"Level53\"")]
        [NativeName("Name", "STD_VIDEO_AV1_LEVEL_5_3")]
        StdVideoAV1Level53 = 0xF,
        [Obsolete("Deprecated in favour of \"Level60\"")]
        [NativeName("Name", "STD_VIDEO_AV1_LEVEL_6_0")]
        StdVideoAV1Level60 = 0x10,
        [Obsolete("Deprecated in favour of \"Level61\"")]
        [NativeName("Name", "STD_VIDEO_AV1_LEVEL_6_1")]
        StdVideoAV1Level61 = 0x11,
        [Obsolete("Deprecated in favour of \"Level62\"")]
        [NativeName("Name", "STD_VIDEO_AV1_LEVEL_6_2")]
        StdVideoAV1Level62 = 0x12,
        [Obsolete("Deprecated in favour of \"Level63\"")]
        [NativeName("Name", "STD_VIDEO_AV1_LEVEL_6_3")]
        StdVideoAV1Level63 = 0x13,
        [Obsolete("Deprecated in favour of \"Level70\"")]
        [NativeName("Name", "STD_VIDEO_AV1_LEVEL_7_0")]
        StdVideoAV1Level70 = 0x14,
        [Obsolete("Deprecated in favour of \"Level71\"")]
        [NativeName("Name", "STD_VIDEO_AV1_LEVEL_7_1")]
        StdVideoAV1Level71 = 0x15,
        [Obsolete("Deprecated in favour of \"Level72\"")]
        [NativeName("Name", "STD_VIDEO_AV1_LEVEL_7_2")]
        StdVideoAV1Level72 = 0x16,
        [Obsolete("Deprecated in favour of \"Level73\"")]
        [NativeName("Name", "STD_VIDEO_AV1_LEVEL_7_3")]
        StdVideoAV1Level73 = 0x17,
        [Obsolete("Deprecated in favour of \"LevelInvalid\"")]
        [NativeName("Name", "STD_VIDEO_AV1_LEVEL_INVALID")]
        StdVideoAV1LevelInvalid = 0x7FFFFFFF,
        [Obsolete("Deprecated in favour of \"LevelMaxEnum\"")]
        [NativeName("Name", "STD_VIDEO_AV1_LEVEL_MAX_ENUM")]
        StdVideoAV1LevelMaxEnum = 0x7FFFFFFF,
        [NativeName("Name", "STD_VIDEO_AV1_LEVEL_2_0")]
        Level20 = 0x0,
        [NativeName("Name", "STD_VIDEO_AV1_LEVEL_2_1")]
        Level21 = 0x1,
        [NativeName("Name", "STD_VIDEO_AV1_LEVEL_2_2")]
        Level22 = 0x2,
        [NativeName("Name", "STD_VIDEO_AV1_LEVEL_2_3")]
        Level23 = 0x3,
        [NativeName("Name", "STD_VIDEO_AV1_LEVEL_3_0")]
        Level30 = 0x4,
        [NativeName("Name", "STD_VIDEO_AV1_LEVEL_3_1")]
        Level31 = 0x5,
        [NativeName("Name", "STD_VIDEO_AV1_LEVEL_3_2")]
        Level32 = 0x6,
        [NativeName("Name", "STD_VIDEO_AV1_LEVEL_3_3")]
        Level33 = 0x7,
        [NativeName("Name", "STD_VIDEO_AV1_LEVEL_4_0")]
        Level40 = 0x8,
        [NativeName("Name", "STD_VIDEO_AV1_LEVEL_4_1")]
        Level41 = 0x9,
        [NativeName("Name", "STD_VIDEO_AV1_LEVEL_4_2")]
        Level42 = 0xA,
        [NativeName("Name", "STD_VIDEO_AV1_LEVEL_4_3")]
        Level43 = 0xB,
        [NativeName("Name", "STD_VIDEO_AV1_LEVEL_5_0")]
        Level50 = 0xC,
        [NativeName("Name", "STD_VIDEO_AV1_LEVEL_5_1")]
        Level51 = 0xD,
        [NativeName("Name", "STD_VIDEO_AV1_LEVEL_5_2")]
        Level52 = 0xE,
        [NativeName("Name", "STD_VIDEO_AV1_LEVEL_5_3")]
        Level53 = 0xF,
        [NativeName("Name", "STD_VIDEO_AV1_LEVEL_6_0")]
        Level60 = 0x10,
        [NativeName("Name", "STD_VIDEO_AV1_LEVEL_6_1")]
        Level61 = 0x11,
        [NativeName("Name", "STD_VIDEO_AV1_LEVEL_6_2")]
        Level62 = 0x12,
        [NativeName("Name", "STD_VIDEO_AV1_LEVEL_6_3")]
        Level63 = 0x13,
        [NativeName("Name", "STD_VIDEO_AV1_LEVEL_7_0")]
        Level70 = 0x14,
        [NativeName("Name", "STD_VIDEO_AV1_LEVEL_7_1")]
        Level71 = 0x15,
        [NativeName("Name", "STD_VIDEO_AV1_LEVEL_7_2")]
        Level72 = 0x16,
        [NativeName("Name", "STD_VIDEO_AV1_LEVEL_7_3")]
        Level73 = 0x17,
        [NativeName("Name", "STD_VIDEO_AV1_LEVEL_INVALID")]
        LevelInvalid = 0x7FFFFFFF,
        [NativeName("Name", "STD_VIDEO_AV1_LEVEL_MAX_ENUM")]
        LevelMaxEnum = 0x7FFFFFFF,
    }
}
