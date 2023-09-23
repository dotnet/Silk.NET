// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WindowsCodecs
{
    [Flags]
    [NativeName("Name", "WICNamedWhitePoint")]
    public enum NamedWhitePoint : int
    {
        [NativeName("Name", "")]
        None = 0,
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
