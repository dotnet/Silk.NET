// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WindowsCodecs
{
    [Flags]
    [NativeName("Name", "WICNamedWhitePoint")]
    public enum WICNamedWhitePoint : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"WhitePointDefault\"")]
        [NativeName("Name", "WICWhitePointDefault")]
        WicwhitePointDefault = 0x1,
        [Obsolete("Deprecated in favour of \"WhitePointDaylight\"")]
        [NativeName("Name", "WICWhitePointDaylight")]
        WicwhitePointDaylight = 0x2,
        [Obsolete("Deprecated in favour of \"WhitePointCloudy\"")]
        [NativeName("Name", "WICWhitePointCloudy")]
        WicwhitePointCloudy = 0x4,
        [Obsolete("Deprecated in favour of \"WhitePointShade\"")]
        [NativeName("Name", "WICWhitePointShade")]
        WicwhitePointShade = 0x8,
        [Obsolete("Deprecated in favour of \"WhitePointTungsten\"")]
        [NativeName("Name", "WICWhitePointTungsten")]
        WicwhitePointTungsten = 0x10,
        [Obsolete("Deprecated in favour of \"WhitePointFluorescent\"")]
        [NativeName("Name", "WICWhitePointFluorescent")]
        WicwhitePointFluorescent = 0x20,
        [Obsolete("Deprecated in favour of \"WhitePointFlash\"")]
        [NativeName("Name", "WICWhitePointFlash")]
        WicwhitePointFlash = 0x40,
        [Obsolete("Deprecated in favour of \"WhitePointUnderwater\"")]
        [NativeName("Name", "WICWhitePointUnderwater")]
        WicwhitePointUnderwater = 0x80,
        [Obsolete("Deprecated in favour of \"WhitePointCustom\"")]
        [NativeName("Name", "WICWhitePointCustom")]
        WicwhitePointCustom = 0x100,
        [Obsolete("Deprecated in favour of \"WhitePointAutoWhiteBalance\"")]
        [NativeName("Name", "WICWhitePointAutoWhiteBalance")]
        WicwhitePointAutoWhiteBalance = 0x200,
        [Obsolete("Deprecated in favour of \"WhitePointAsShot\"")]
        [NativeName("Name", "WICWhitePointAsShot")]
        WicwhitePointAsShot = 0x1,
        [Obsolete("Deprecated in favour of \"AmedwhitepointForceDword\"")]
        [NativeName("Name", "WICNAMEDWHITEPOINT_FORCE_DWORD")]
        WicnamedwhitepointForceDword = 0x7FFFFFFF,
        [NativeName("Name", "WICWhitePointDefault")]
        WhitePointDefault = 0x1,
        [NativeName("Name", "WICWhitePointDaylight")]
        WhitePointDaylight = 0x2,
        [NativeName("Name", "WICWhitePointCloudy")]
        WhitePointCloudy = 0x4,
        [NativeName("Name", "WICWhitePointShade")]
        WhitePointShade = 0x8,
        [NativeName("Name", "WICWhitePointTungsten")]
        WhitePointTungsten = 0x10,
        [NativeName("Name", "WICWhitePointFluorescent")]
        WhitePointFluorescent = 0x20,
        [NativeName("Name", "WICWhitePointFlash")]
        WhitePointFlash = 0x40,
        [NativeName("Name", "WICWhitePointUnderwater")]
        WhitePointUnderwater = 0x80,
        [NativeName("Name", "WICWhitePointCustom")]
        WhitePointCustom = 0x100,
        [NativeName("Name", "WICWhitePointAutoWhiteBalance")]
        WhitePointAutoWhiteBalance = 0x200,
        [NativeName("Name", "WICWhitePointAsShot")]
        WhitePointAsShot = 0x1,
        [NativeName("Name", "WICNAMEDWHITEPOINT_FORCE_DWORD")]
        AmedwhitepointForceDword = 0x7FFFFFFF,
    }
}
