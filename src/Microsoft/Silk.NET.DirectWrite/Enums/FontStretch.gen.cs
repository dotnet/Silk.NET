// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DirectWrite
{
    [NativeName("Name", "DWRITE_FONT_STRETCH")]
    public enum FontStretch : int
    {
        [NativeName("Name", "DWRITE_FONT_STRETCH_UNDEFINED")]
        Undefined = 0x0,
        [NativeName("Name", "DWRITE_FONT_STRETCH_ULTRA_CONDENSED")]
        UltraCondensed = 0x1,
        [NativeName("Name", "DWRITE_FONT_STRETCH_EXTRA_CONDENSED")]
        ExtraCondensed = 0x2,
        [NativeName("Name", "DWRITE_FONT_STRETCH_CONDENSED")]
        Condensed = 0x3,
        [NativeName("Name", "DWRITE_FONT_STRETCH_SEMI_CONDENSED")]
        SemiCondensed = 0x4,
        [NativeName("Name", "DWRITE_FONT_STRETCH_NORMAL")]
        Normal = 0x5,
        [NativeName("Name", "DWRITE_FONT_STRETCH_MEDIUM")]
        Medium = 0x5,
        [NativeName("Name", "DWRITE_FONT_STRETCH_SEMI_EXPANDED")]
        SemiExpanded = 0x6,
        [NativeName("Name", "DWRITE_FONT_STRETCH_EXPANDED")]
        Expanded = 0x7,
        [NativeName("Name", "DWRITE_FONT_STRETCH_EXTRA_EXPANDED")]
        ExtraExpanded = 0x8,
        [NativeName("Name", "DWRITE_FONT_STRETCH_ULTRA_EXPANDED")]
        UltraExpanded = 0x9,
    }
}
