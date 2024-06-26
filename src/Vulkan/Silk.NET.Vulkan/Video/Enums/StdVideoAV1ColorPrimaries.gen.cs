// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Video
{
    [NativeName("Name", "StdVideoAV1ColorPrimaries")]
    public enum StdVideoAV1ColorPrimaries : int
    {
        [Obsolete("Deprecated in favour of \"BT709\"")]
        [NativeName("Name", "STD_VIDEO_AV1_COLOR_PRIMARIES_BT_709")]
        StdVideoAV1ColorPrimariesBT709 = 0x1,
        [Obsolete("Deprecated in favour of \"BTUnspecified\"")]
        [NativeName("Name", "STD_VIDEO_AV1_COLOR_PRIMARIES_BT_UNSPECIFIED")]
        StdVideoAV1ColorPrimariesBTUnspecified = 0x2,
        [Obsolete("Deprecated in favour of \"BT470M\"")]
        [NativeName("Name", "STD_VIDEO_AV1_COLOR_PRIMARIES_BT_470_M")]
        StdVideoAV1ColorPrimariesBT470M = 0x4,
        [Obsolete("Deprecated in favour of \"BT470BG\"")]
        [NativeName("Name", "STD_VIDEO_AV1_COLOR_PRIMARIES_BT_470_B_G")]
        StdVideoAV1ColorPrimariesBT470BG = 0x5,
        [Obsolete("Deprecated in favour of \"BT601\"")]
        [NativeName("Name", "STD_VIDEO_AV1_COLOR_PRIMARIES_BT_601")]
        StdVideoAV1ColorPrimariesBT601 = 0x6,
        [Obsolete("Deprecated in favour of \"Smpte240\"")]
        [NativeName("Name", "STD_VIDEO_AV1_COLOR_PRIMARIES_SMPTE_240")]
        StdVideoAV1ColorPrimariesSmpte240 = 0x7,
        [Obsolete("Deprecated in favour of \"GenericFilm\"")]
        [NativeName("Name", "STD_VIDEO_AV1_COLOR_PRIMARIES_GENERIC_FILM")]
        StdVideoAV1ColorPrimariesGenericFilm = 0x8,
        [Obsolete("Deprecated in favour of \"BT2020\"")]
        [NativeName("Name", "STD_VIDEO_AV1_COLOR_PRIMARIES_BT_2020")]
        StdVideoAV1ColorPrimariesBT2020 = 0x9,
        [Obsolete("Deprecated in favour of \"Xyz\"")]
        [NativeName("Name", "STD_VIDEO_AV1_COLOR_PRIMARIES_XYZ")]
        StdVideoAV1ColorPrimariesXyz = 0xA,
        [Obsolete("Deprecated in favour of \"Smpte431\"")]
        [NativeName("Name", "STD_VIDEO_AV1_COLOR_PRIMARIES_SMPTE_431")]
        StdVideoAV1ColorPrimariesSmpte431 = 0xB,
        [Obsolete("Deprecated in favour of \"Smpte432\"")]
        [NativeName("Name", "STD_VIDEO_AV1_COLOR_PRIMARIES_SMPTE_432")]
        StdVideoAV1ColorPrimariesSmpte432 = 0xC,
        [Obsolete("Deprecated in favour of \"Ebu3213\"")]
        [NativeName("Name", "STD_VIDEO_AV1_COLOR_PRIMARIES_EBU_3213")]
        StdVideoAV1ColorPrimariesEbu3213 = 0x16,
        [Obsolete("Deprecated in favour of \"Invalid\"")]
        [NativeName("Name", "STD_VIDEO_AV1_COLOR_PRIMARIES_INVALID")]
        StdVideoAV1ColorPrimariesInvalid = 0x7FFFFFFF,
        [Obsolete("Deprecated in favour of \"MaxEnum\"")]
        [NativeName("Name", "STD_VIDEO_AV1_COLOR_PRIMARIES_MAX_ENUM")]
        StdVideoAV1ColorPrimariesMaxEnum = 0x7FFFFFFF,
        [NativeName("Name", "STD_VIDEO_AV1_COLOR_PRIMARIES_BT_709")]
        BT709 = 0x1,
        [NativeName("Name", "STD_VIDEO_AV1_COLOR_PRIMARIES_BT_UNSPECIFIED")]
        BTUnspecified = 0x2,
        [NativeName("Name", "STD_VIDEO_AV1_COLOR_PRIMARIES_BT_470_M")]
        BT470M = 0x4,
        [NativeName("Name", "STD_VIDEO_AV1_COLOR_PRIMARIES_BT_470_B_G")]
        BT470BG = 0x5,
        [NativeName("Name", "STD_VIDEO_AV1_COLOR_PRIMARIES_BT_601")]
        BT601 = 0x6,
        [NativeName("Name", "STD_VIDEO_AV1_COLOR_PRIMARIES_SMPTE_240")]
        Smpte240 = 0x7,
        [NativeName("Name", "STD_VIDEO_AV1_COLOR_PRIMARIES_GENERIC_FILM")]
        GenericFilm = 0x8,
        [NativeName("Name", "STD_VIDEO_AV1_COLOR_PRIMARIES_BT_2020")]
        BT2020 = 0x9,
        [NativeName("Name", "STD_VIDEO_AV1_COLOR_PRIMARIES_XYZ")]
        Xyz = 0xA,
        [NativeName("Name", "STD_VIDEO_AV1_COLOR_PRIMARIES_SMPTE_431")]
        Smpte431 = 0xB,
        [NativeName("Name", "STD_VIDEO_AV1_COLOR_PRIMARIES_SMPTE_432")]
        Smpte432 = 0xC,
        [NativeName("Name", "STD_VIDEO_AV1_COLOR_PRIMARIES_EBU_3213")]
        Ebu3213 = 0x16,
        [NativeName("Name", "STD_VIDEO_AV1_COLOR_PRIMARIES_INVALID")]
        Invalid = 0x7FFFFFFF,
        [NativeName("Name", "STD_VIDEO_AV1_COLOR_PRIMARIES_MAX_ENUM")]
        MaxEnum = 0x7FFFFFFF,
    }
}
