// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WindowsCodecs
{
    [NativeName("Name", "WICPngChrmProperties")]
    public enum PngChrmProperties : int
    {
        [NativeName("Name", "WICPngChrmWhitePointX")]
        WhitePointX = 0x1,
        [NativeName("Name", "WICPngChrmWhitePointY")]
        WhitePointY = 0x2,
        [NativeName("Name", "WICPngChrmRedX")]
        RedX = 0x3,
        [NativeName("Name", "WICPngChrmRedY")]
        RedY = 0x4,
        [NativeName("Name", "WICPngChrmGreenX")]
        GreenX = 0x5,
        [NativeName("Name", "WICPngChrmGreenY")]
        GreenY = 0x6,
        [NativeName("Name", "WICPngChrmBlueX")]
        BlueX = 0x7,
        [NativeName("Name", "WICPngChrmBlueY")]
        BlueY = 0x8,
        [NativeName("Name", "WICPngChrmProperties_FORCE_DWORD")]
        PropertiesForceDword = 0x7FFFFFFF,
    }
}
