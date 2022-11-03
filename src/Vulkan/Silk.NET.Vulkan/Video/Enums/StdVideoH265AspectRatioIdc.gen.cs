// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Video
{
    [NativeName("Name", "StdVideoH265AspectRatioIdc")]
    public enum StdVideoH265AspectRatioIdc : int
    {
        [Obsolete("Deprecated in favour of \"IdcUnspecified\"")]
        [NativeName("Name", "STD_VIDEO_H265_ASPECT_RATIO_IDC_UNSPECIFIED")]
        StdVideoH265AspectRatioIdcUnspecified = 0x0,
        [Obsolete("Deprecated in favour of \"IdcSquare\"")]
        [NativeName("Name", "STD_VIDEO_H265_ASPECT_RATIO_IDC_SQUARE")]
        StdVideoH265AspectRatioIdcSquare = 0x1,
        [Obsolete("Deprecated in favour of \"Idc1211\"")]
        [NativeName("Name", "STD_VIDEO_H265_ASPECT_RATIO_IDC_12_11")]
        StdVideoH265AspectRatioIdc1211 = 0x2,
        [Obsolete("Deprecated in favour of \"Idc1011\"")]
        [NativeName("Name", "STD_VIDEO_H265_ASPECT_RATIO_IDC_10_11")]
        StdVideoH265AspectRatioIdc1011 = 0x3,
        [Obsolete("Deprecated in favour of \"Idc1611\"")]
        [NativeName("Name", "STD_VIDEO_H265_ASPECT_RATIO_IDC_16_11")]
        StdVideoH265AspectRatioIdc1611 = 0x4,
        [Obsolete("Deprecated in favour of \"Idc4033\"")]
        [NativeName("Name", "STD_VIDEO_H265_ASPECT_RATIO_IDC_40_33")]
        StdVideoH265AspectRatioIdc4033 = 0x5,
        [Obsolete("Deprecated in favour of \"Idc2411\"")]
        [NativeName("Name", "STD_VIDEO_H265_ASPECT_RATIO_IDC_24_11")]
        StdVideoH265AspectRatioIdc2411 = 0x6,
        [Obsolete("Deprecated in favour of \"Idc2011\"")]
        [NativeName("Name", "STD_VIDEO_H265_ASPECT_RATIO_IDC_20_11")]
        StdVideoH265AspectRatioIdc2011 = 0x7,
        [Obsolete("Deprecated in favour of \"Idc3211\"")]
        [NativeName("Name", "STD_VIDEO_H265_ASPECT_RATIO_IDC_32_11")]
        StdVideoH265AspectRatioIdc3211 = 0x8,
        [Obsolete("Deprecated in favour of \"Idc8033\"")]
        [NativeName("Name", "STD_VIDEO_H265_ASPECT_RATIO_IDC_80_33")]
        StdVideoH265AspectRatioIdc8033 = 0x9,
        [Obsolete("Deprecated in favour of \"Idc1811\"")]
        [NativeName("Name", "STD_VIDEO_H265_ASPECT_RATIO_IDC_18_11")]
        StdVideoH265AspectRatioIdc1811 = 0xA,
        [Obsolete("Deprecated in favour of \"Idc1511\"")]
        [NativeName("Name", "STD_VIDEO_H265_ASPECT_RATIO_IDC_15_11")]
        StdVideoH265AspectRatioIdc1511 = 0xB,
        [Obsolete("Deprecated in favour of \"Idc6433\"")]
        [NativeName("Name", "STD_VIDEO_H265_ASPECT_RATIO_IDC_64_33")]
        StdVideoH265AspectRatioIdc6433 = 0xC,
        [Obsolete("Deprecated in favour of \"Idc16099\"")]
        [NativeName("Name", "STD_VIDEO_H265_ASPECT_RATIO_IDC_160_99")]
        StdVideoH265AspectRatioIdc16099 = 0xD,
        [Obsolete("Deprecated in favour of \"Idc43\"")]
        [NativeName("Name", "STD_VIDEO_H265_ASPECT_RATIO_IDC_4_3")]
        StdVideoH265AspectRatioIdc43 = 0xE,
        [Obsolete("Deprecated in favour of \"Idc32\"")]
        [NativeName("Name", "STD_VIDEO_H265_ASPECT_RATIO_IDC_3_2")]
        StdVideoH265AspectRatioIdc32 = 0xF,
        [Obsolete("Deprecated in favour of \"Idc21\"")]
        [NativeName("Name", "STD_VIDEO_H265_ASPECT_RATIO_IDC_2_1")]
        StdVideoH265AspectRatioIdc21 = 0x10,
        [Obsolete("Deprecated in favour of \"IdcExtendedSar\"")]
        [NativeName("Name", "STD_VIDEO_H265_ASPECT_RATIO_IDC_EXTENDED_SAR")]
        StdVideoH265AspectRatioIdcExtendedSar = 0xFF,
        [Obsolete("Deprecated in favour of \"IdcInvalid\"")]
        [NativeName("Name", "STD_VIDEO_H265_ASPECT_RATIO_IDC_INVALID")]
        StdVideoH265AspectRatioIdcInvalid = 0x7FFFFFFF,
        [Obsolete("Deprecated in favour of \"IdcMaxEnum\"")]
        [NativeName("Name", "STD_VIDEO_H265_ASPECT_RATIO_IDC_MAX_ENUM")]
        StdVideoH265AspectRatioIdcMaxEnum = 0x7FFFFFFF,
        [NativeName("Name", "STD_VIDEO_H265_ASPECT_RATIO_IDC_UNSPECIFIED")]
        IdcUnspecified = 0x0,
        [NativeName("Name", "STD_VIDEO_H265_ASPECT_RATIO_IDC_SQUARE")]
        IdcSquare = 0x1,
        [NativeName("Name", "STD_VIDEO_H265_ASPECT_RATIO_IDC_12_11")]
        Idc1211 = 0x2,
        [NativeName("Name", "STD_VIDEO_H265_ASPECT_RATIO_IDC_10_11")]
        Idc1011 = 0x3,
        [NativeName("Name", "STD_VIDEO_H265_ASPECT_RATIO_IDC_16_11")]
        Idc1611 = 0x4,
        [NativeName("Name", "STD_VIDEO_H265_ASPECT_RATIO_IDC_40_33")]
        Idc4033 = 0x5,
        [NativeName("Name", "STD_VIDEO_H265_ASPECT_RATIO_IDC_24_11")]
        Idc2411 = 0x6,
        [NativeName("Name", "STD_VIDEO_H265_ASPECT_RATIO_IDC_20_11")]
        Idc2011 = 0x7,
        [NativeName("Name", "STD_VIDEO_H265_ASPECT_RATIO_IDC_32_11")]
        Idc3211 = 0x8,
        [NativeName("Name", "STD_VIDEO_H265_ASPECT_RATIO_IDC_80_33")]
        Idc8033 = 0x9,
        [NativeName("Name", "STD_VIDEO_H265_ASPECT_RATIO_IDC_18_11")]
        Idc1811 = 0xA,
        [NativeName("Name", "STD_VIDEO_H265_ASPECT_RATIO_IDC_15_11")]
        Idc1511 = 0xB,
        [NativeName("Name", "STD_VIDEO_H265_ASPECT_RATIO_IDC_64_33")]
        Idc6433 = 0xC,
        [NativeName("Name", "STD_VIDEO_H265_ASPECT_RATIO_IDC_160_99")]
        Idc16099 = 0xD,
        [NativeName("Name", "STD_VIDEO_H265_ASPECT_RATIO_IDC_4_3")]
        Idc43 = 0xE,
        [NativeName("Name", "STD_VIDEO_H265_ASPECT_RATIO_IDC_3_2")]
        Idc32 = 0xF,
        [NativeName("Name", "STD_VIDEO_H265_ASPECT_RATIO_IDC_2_1")]
        Idc21 = 0x10,
        [NativeName("Name", "STD_VIDEO_H265_ASPECT_RATIO_IDC_EXTENDED_SAR")]
        IdcExtendedSar = 0xFF,
        [NativeName("Name", "STD_VIDEO_H265_ASPECT_RATIO_IDC_INVALID")]
        IdcInvalid = 0x7FFFFFFF,
        [NativeName("Name", "STD_VIDEO_H265_ASPECT_RATIO_IDC_MAX_ENUM")]
        IdcMaxEnum = 0x7FFFFFFF,
    }
}
