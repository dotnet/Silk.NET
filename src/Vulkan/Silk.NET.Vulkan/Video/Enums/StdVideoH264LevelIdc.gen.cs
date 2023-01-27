// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Video
{
    [NativeName("Name", "StdVideoH264LevelIdc")]
    public enum StdVideoH264LevelIdc : int
    {
        [Obsolete("Deprecated in favour of \"Idc10\"")]
        [NativeName("Name", "STD_VIDEO_H264_LEVEL_IDC_1_0")]
        StdVideoH264LevelIdc10 = 0x0,
        [Obsolete("Deprecated in favour of \"Idc11\"")]
        [NativeName("Name", "STD_VIDEO_H264_LEVEL_IDC_1_1")]
        StdVideoH264LevelIdc11 = 0x1,
        [Obsolete("Deprecated in favour of \"Idc12\"")]
        [NativeName("Name", "STD_VIDEO_H264_LEVEL_IDC_1_2")]
        StdVideoH264LevelIdc12 = 0x2,
        [Obsolete("Deprecated in favour of \"Idc13\"")]
        [NativeName("Name", "STD_VIDEO_H264_LEVEL_IDC_1_3")]
        StdVideoH264LevelIdc13 = 0x3,
        [Obsolete("Deprecated in favour of \"Idc20\"")]
        [NativeName("Name", "STD_VIDEO_H264_LEVEL_IDC_2_0")]
        StdVideoH264LevelIdc20 = 0x4,
        [Obsolete("Deprecated in favour of \"Idc21\"")]
        [NativeName("Name", "STD_VIDEO_H264_LEVEL_IDC_2_1")]
        StdVideoH264LevelIdc21 = 0x5,
        [Obsolete("Deprecated in favour of \"Idc22\"")]
        [NativeName("Name", "STD_VIDEO_H264_LEVEL_IDC_2_2")]
        StdVideoH264LevelIdc22 = 0x6,
        [Obsolete("Deprecated in favour of \"Idc30\"")]
        [NativeName("Name", "STD_VIDEO_H264_LEVEL_IDC_3_0")]
        StdVideoH264LevelIdc30 = 0x7,
        [Obsolete("Deprecated in favour of \"Idc31\"")]
        [NativeName("Name", "STD_VIDEO_H264_LEVEL_IDC_3_1")]
        StdVideoH264LevelIdc31 = 0x8,
        [Obsolete("Deprecated in favour of \"Idc32\"")]
        [NativeName("Name", "STD_VIDEO_H264_LEVEL_IDC_3_2")]
        StdVideoH264LevelIdc32 = 0x9,
        [Obsolete("Deprecated in favour of \"Idc40\"")]
        [NativeName("Name", "STD_VIDEO_H264_LEVEL_IDC_4_0")]
        StdVideoH264LevelIdc40 = 0xA,
        [Obsolete("Deprecated in favour of \"Idc41\"")]
        [NativeName("Name", "STD_VIDEO_H264_LEVEL_IDC_4_1")]
        StdVideoH264LevelIdc41 = 0xB,
        [Obsolete("Deprecated in favour of \"Idc42\"")]
        [NativeName("Name", "STD_VIDEO_H264_LEVEL_IDC_4_2")]
        StdVideoH264LevelIdc42 = 0xC,
        [Obsolete("Deprecated in favour of \"Idc50\"")]
        [NativeName("Name", "STD_VIDEO_H264_LEVEL_IDC_5_0")]
        StdVideoH264LevelIdc50 = 0xD,
        [Obsolete("Deprecated in favour of \"Idc51\"")]
        [NativeName("Name", "STD_VIDEO_H264_LEVEL_IDC_5_1")]
        StdVideoH264LevelIdc51 = 0xE,
        [Obsolete("Deprecated in favour of \"Idc52\"")]
        [NativeName("Name", "STD_VIDEO_H264_LEVEL_IDC_5_2")]
        StdVideoH264LevelIdc52 = 0xF,
        [Obsolete("Deprecated in favour of \"Idc60\"")]
        [NativeName("Name", "STD_VIDEO_H264_LEVEL_IDC_6_0")]
        StdVideoH264LevelIdc60 = 0x10,
        [Obsolete("Deprecated in favour of \"Idc61\"")]
        [NativeName("Name", "STD_VIDEO_H264_LEVEL_IDC_6_1")]
        StdVideoH264LevelIdc61 = 0x11,
        [Obsolete("Deprecated in favour of \"Idc62\"")]
        [NativeName("Name", "STD_VIDEO_H264_LEVEL_IDC_6_2")]
        StdVideoH264LevelIdc62 = 0x12,
        [Obsolete("Deprecated in favour of \"IdcInvalid\"")]
        [NativeName("Name", "STD_VIDEO_H264_LEVEL_IDC_INVALID")]
        StdVideoH264LevelIdcInvalid = 0x7FFFFFFF,
        [Obsolete("Deprecated in favour of \"IdcMaxEnum\"")]
        [NativeName("Name", "STD_VIDEO_H264_LEVEL_IDC_MAX_ENUM")]
        StdVideoH264LevelIdcMaxEnum = 0x7FFFFFFF,
        [NativeName("Name", "STD_VIDEO_H264_LEVEL_IDC_1_0")]
        Idc10 = 0x0,
        [NativeName("Name", "STD_VIDEO_H264_LEVEL_IDC_1_1")]
        Idc11 = 0x1,
        [NativeName("Name", "STD_VIDEO_H264_LEVEL_IDC_1_2")]
        Idc12 = 0x2,
        [NativeName("Name", "STD_VIDEO_H264_LEVEL_IDC_1_3")]
        Idc13 = 0x3,
        [NativeName("Name", "STD_VIDEO_H264_LEVEL_IDC_2_0")]
        Idc20 = 0x4,
        [NativeName("Name", "STD_VIDEO_H264_LEVEL_IDC_2_1")]
        Idc21 = 0x5,
        [NativeName("Name", "STD_VIDEO_H264_LEVEL_IDC_2_2")]
        Idc22 = 0x6,
        [NativeName("Name", "STD_VIDEO_H264_LEVEL_IDC_3_0")]
        Idc30 = 0x7,
        [NativeName("Name", "STD_VIDEO_H264_LEVEL_IDC_3_1")]
        Idc31 = 0x8,
        [NativeName("Name", "STD_VIDEO_H264_LEVEL_IDC_3_2")]
        Idc32 = 0x9,
        [NativeName("Name", "STD_VIDEO_H264_LEVEL_IDC_4_0")]
        Idc40 = 0xA,
        [NativeName("Name", "STD_VIDEO_H264_LEVEL_IDC_4_1")]
        Idc41 = 0xB,
        [NativeName("Name", "STD_VIDEO_H264_LEVEL_IDC_4_2")]
        Idc42 = 0xC,
        [NativeName("Name", "STD_VIDEO_H264_LEVEL_IDC_5_0")]
        Idc50 = 0xD,
        [NativeName("Name", "STD_VIDEO_H264_LEVEL_IDC_5_1")]
        Idc51 = 0xE,
        [NativeName("Name", "STD_VIDEO_H264_LEVEL_IDC_5_2")]
        Idc52 = 0xF,
        [NativeName("Name", "STD_VIDEO_H264_LEVEL_IDC_6_0")]
        Idc60 = 0x10,
        [NativeName("Name", "STD_VIDEO_H264_LEVEL_IDC_6_1")]
        Idc61 = 0x11,
        [NativeName("Name", "STD_VIDEO_H264_LEVEL_IDC_6_2")]
        Idc62 = 0x12,
        [NativeName("Name", "STD_VIDEO_H264_LEVEL_IDC_INVALID")]
        IdcInvalid = 0x7FFFFFFF,
        [NativeName("Name", "STD_VIDEO_H264_LEVEL_IDC_MAX_ENUM")]
        IdcMaxEnum = 0x7FFFFFFF,
    }
}
