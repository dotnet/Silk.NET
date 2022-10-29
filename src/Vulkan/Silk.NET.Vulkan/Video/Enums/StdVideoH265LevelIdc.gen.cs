// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Video
{
    [NativeName("Name", "StdVideoH265LevelIdc")]
    public enum StdVideoH265LevelIdc : int
    {
        [Obsolete("Deprecated in favour of \"Idc10\"")]
        [NativeName("Name", "STD_VIDEO_H265_LEVEL_IDC_1_0")]
        StdVideoH265LevelIdc10 = 0x0,
        [Obsolete("Deprecated in favour of \"Idc20\"")]
        [NativeName("Name", "STD_VIDEO_H265_LEVEL_IDC_2_0")]
        StdVideoH265LevelIdc20 = 0x1,
        [Obsolete("Deprecated in favour of \"Idc21\"")]
        [NativeName("Name", "STD_VIDEO_H265_LEVEL_IDC_2_1")]
        StdVideoH265LevelIdc21 = 0x2,
        [Obsolete("Deprecated in favour of \"Idc30\"")]
        [NativeName("Name", "STD_VIDEO_H265_LEVEL_IDC_3_0")]
        StdVideoH265LevelIdc30 = 0x3,
        [Obsolete("Deprecated in favour of \"Idc31\"")]
        [NativeName("Name", "STD_VIDEO_H265_LEVEL_IDC_3_1")]
        StdVideoH265LevelIdc31 = 0x4,
        [Obsolete("Deprecated in favour of \"Idc40\"")]
        [NativeName("Name", "STD_VIDEO_H265_LEVEL_IDC_4_0")]
        StdVideoH265LevelIdc40 = 0x5,
        [Obsolete("Deprecated in favour of \"Idc41\"")]
        [NativeName("Name", "STD_VIDEO_H265_LEVEL_IDC_4_1")]
        StdVideoH265LevelIdc41 = 0x6,
        [Obsolete("Deprecated in favour of \"Idc50\"")]
        [NativeName("Name", "STD_VIDEO_H265_LEVEL_IDC_5_0")]
        StdVideoH265LevelIdc50 = 0x7,
        [Obsolete("Deprecated in favour of \"Idc51\"")]
        [NativeName("Name", "STD_VIDEO_H265_LEVEL_IDC_5_1")]
        StdVideoH265LevelIdc51 = 0x8,
        [Obsolete("Deprecated in favour of \"Idc52\"")]
        [NativeName("Name", "STD_VIDEO_H265_LEVEL_IDC_5_2")]
        StdVideoH265LevelIdc52 = 0x9,
        [Obsolete("Deprecated in favour of \"Idc60\"")]
        [NativeName("Name", "STD_VIDEO_H265_LEVEL_IDC_6_0")]
        StdVideoH265LevelIdc60 = 0xA,
        [Obsolete("Deprecated in favour of \"Idc61\"")]
        [NativeName("Name", "STD_VIDEO_H265_LEVEL_IDC_6_1")]
        StdVideoH265LevelIdc61 = 0xB,
        [Obsolete("Deprecated in favour of \"Idc62\"")]
        [NativeName("Name", "STD_VIDEO_H265_LEVEL_IDC_6_2")]
        StdVideoH265LevelIdc62 = 0xC,
        [Obsolete("Deprecated in favour of \"IdcInvalid\"")]
        [NativeName("Name", "STD_VIDEO_H265_LEVEL_IDC_INVALID")]
        StdVideoH265LevelIdcInvalid = 0x7FFFFFFF,
        [Obsolete("Deprecated in favour of \"IdcMaxEnum\"")]
        [NativeName("Name", "STD_VIDEO_H265_LEVEL_IDC_MAX_ENUM")]
        StdVideoH265LevelIdcMaxEnum = 0x7FFFFFFF,
        [NativeName("Name", "STD_VIDEO_H265_LEVEL_IDC_1_0")]
        Idc10 = 0x0,
        [NativeName("Name", "STD_VIDEO_H265_LEVEL_IDC_2_0")]
        Idc20 = 0x1,
        [NativeName("Name", "STD_VIDEO_H265_LEVEL_IDC_2_1")]
        Idc21 = 0x2,
        [NativeName("Name", "STD_VIDEO_H265_LEVEL_IDC_3_0")]
        Idc30 = 0x3,
        [NativeName("Name", "STD_VIDEO_H265_LEVEL_IDC_3_1")]
        Idc31 = 0x4,
        [NativeName("Name", "STD_VIDEO_H265_LEVEL_IDC_4_0")]
        Idc40 = 0x5,
        [NativeName("Name", "STD_VIDEO_H265_LEVEL_IDC_4_1")]
        Idc41 = 0x6,
        [NativeName("Name", "STD_VIDEO_H265_LEVEL_IDC_5_0")]
        Idc50 = 0x7,
        [NativeName("Name", "STD_VIDEO_H265_LEVEL_IDC_5_1")]
        Idc51 = 0x8,
        [NativeName("Name", "STD_VIDEO_H265_LEVEL_IDC_5_2")]
        Idc52 = 0x9,
        [NativeName("Name", "STD_VIDEO_H265_LEVEL_IDC_6_0")]
        Idc60 = 0xA,
        [NativeName("Name", "STD_VIDEO_H265_LEVEL_IDC_6_1")]
        Idc61 = 0xB,
        [NativeName("Name", "STD_VIDEO_H265_LEVEL_IDC_6_2")]
        Idc62 = 0xC,
        [NativeName("Name", "STD_VIDEO_H265_LEVEL_IDC_INVALID")]
        IdcInvalid = 0x7FFFFFFF,
        [NativeName("Name", "STD_VIDEO_H265_LEVEL_IDC_MAX_ENUM")]
        IdcMaxEnum = 0x7FFFFFFF,
    }
}
