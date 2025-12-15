// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Video
{
    [NativeName("Name", "StdVideoVP9ColorSpace")]
    public enum StdVideoVP9ColorSpace : int
    {
        [Obsolete("Deprecated in favour of \"Unknown\"")]
        [NativeName("Name", "STD_VIDEO_VP9_COLOR_SPACE_UNKNOWN")]
        StdVideoVP9ColorSpaceUnknown = 0x0,
        [Obsolete("Deprecated in favour of \"BT601\"")]
        [NativeName("Name", "STD_VIDEO_VP9_COLOR_SPACE_BT_601")]
        StdVideoVP9ColorSpaceBT601 = 0x1,
        [Obsolete("Deprecated in favour of \"BT709\"")]
        [NativeName("Name", "STD_VIDEO_VP9_COLOR_SPACE_BT_709")]
        StdVideoVP9ColorSpaceBT709 = 0x2,
        [Obsolete("Deprecated in favour of \"Smpte170\"")]
        [NativeName("Name", "STD_VIDEO_VP9_COLOR_SPACE_SMPTE_170")]
        StdVideoVP9ColorSpaceSmpte170 = 0x3,
        [Obsolete("Deprecated in favour of \"Smpte240\"")]
        [NativeName("Name", "STD_VIDEO_VP9_COLOR_SPACE_SMPTE_240")]
        StdVideoVP9ColorSpaceSmpte240 = 0x4,
        [Obsolete("Deprecated in favour of \"BT2020\"")]
        [NativeName("Name", "STD_VIDEO_VP9_COLOR_SPACE_BT_2020")]
        StdVideoVP9ColorSpaceBT2020 = 0x5,
        [Obsolete("Deprecated in favour of \"Reserved\"")]
        [NativeName("Name", "STD_VIDEO_VP9_COLOR_SPACE_RESERVED")]
        StdVideoVP9ColorSpaceReserved = 0x6,
        [Obsolete("Deprecated in favour of \"Rgb\"")]
        [NativeName("Name", "STD_VIDEO_VP9_COLOR_SPACE_RGB")]
        StdVideoVP9ColorSpaceRgb = 0x7,
        [Obsolete("Deprecated in favour of \"Invalid\"")]
        [NativeName("Name", "STD_VIDEO_VP9_COLOR_SPACE_INVALID")]
        StdVideoVP9ColorSpaceInvalid = 0x7FFFFFFF,
        [Obsolete("Deprecated in favour of \"MaxEnum\"")]
        [NativeName("Name", "STD_VIDEO_VP9_COLOR_SPACE_MAX_ENUM")]
        StdVideoVP9ColorSpaceMaxEnum = 0x7FFFFFFF,
        [NativeName("Name", "STD_VIDEO_VP9_COLOR_SPACE_UNKNOWN")]
        Unknown = 0x0,
        [NativeName("Name", "STD_VIDEO_VP9_COLOR_SPACE_BT_601")]
        BT601 = 0x1,
        [NativeName("Name", "STD_VIDEO_VP9_COLOR_SPACE_BT_709")]
        BT709 = 0x2,
        [NativeName("Name", "STD_VIDEO_VP9_COLOR_SPACE_SMPTE_170")]
        Smpte170 = 0x3,
        [NativeName("Name", "STD_VIDEO_VP9_COLOR_SPACE_SMPTE_240")]
        Smpte240 = 0x4,
        [NativeName("Name", "STD_VIDEO_VP9_COLOR_SPACE_BT_2020")]
        BT2020 = 0x5,
        [NativeName("Name", "STD_VIDEO_VP9_COLOR_SPACE_RESERVED")]
        Reserved = 0x6,
        [NativeName("Name", "STD_VIDEO_VP9_COLOR_SPACE_RGB")]
        Rgb = 0x7,
        [NativeName("Name", "STD_VIDEO_VP9_COLOR_SPACE_INVALID")]
        Invalid = 0x7FFFFFFF,
        [NativeName("Name", "STD_VIDEO_VP9_COLOR_SPACE_MAX_ENUM")]
        MaxEnum = 0x7FFFFFFF,
    }
}
