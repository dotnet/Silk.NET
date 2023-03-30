// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DirectWrite
{
    [NativeName("Name", "DWRITE_FONT_WEIGHT")]
    public enum FontWeight : int
    {
        [NativeName("Name", "DWRITE_FONT_WEIGHT_THIN")]
        Thin = 0x64,
        [NativeName("Name", "DWRITE_FONT_WEIGHT_EXTRA_LIGHT")]
        ExtraLight = 0xC8,
        [NativeName("Name", "DWRITE_FONT_WEIGHT_ULTRA_LIGHT")]
        UltraLight = 0xC8,
        [NativeName("Name", "DWRITE_FONT_WEIGHT_LIGHT")]
        Light = 0x12C,
        [NativeName("Name", "DWRITE_FONT_WEIGHT_SEMI_LIGHT")]
        SemiLight = 0x15E,
        [NativeName("Name", "DWRITE_FONT_WEIGHT_NORMAL")]
        Normal = 0x190,
        [NativeName("Name", "DWRITE_FONT_WEIGHT_REGULAR")]
        Regular = 0x190,
        [NativeName("Name", "DWRITE_FONT_WEIGHT_MEDIUM")]
        Medium = 0x1F4,
        [NativeName("Name", "DWRITE_FONT_WEIGHT_DEMI_BOLD")]
        DemiBold = 0x258,
        [NativeName("Name", "DWRITE_FONT_WEIGHT_SEMI_BOLD")]
        SemiBold = 0x258,
        [NativeName("Name", "DWRITE_FONT_WEIGHT_BOLD")]
        Bold = 0x2BC,
        [NativeName("Name", "DWRITE_FONT_WEIGHT_EXTRA_BOLD")]
        ExtraBold = 0x320,
        [NativeName("Name", "DWRITE_FONT_WEIGHT_ULTRA_BOLD")]
        UltraBold = 0x320,
        [NativeName("Name", "DWRITE_FONT_WEIGHT_BLACK")]
        Black = 0x384,
        [NativeName("Name", "DWRITE_FONT_WEIGHT_HEAVY")]
        Heavy = 0x384,
        [NativeName("Name", "DWRITE_FONT_WEIGHT_EXTRA_BLACK")]
        ExtraBlack = 0x3B6,
        [NativeName("Name", "DWRITE_FONT_WEIGHT_ULTRA_BLACK")]
        UltraBlack = 0x3B6,
    }
}
