// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DirectWrite
{
    [NativeName("Name", "DWRITE_FONT_AXIS_TAG")]
    public enum FontAxisTag : uint
    {
        [NativeName("Name", "DWRITE_FONT_AXIS_TAG_WEIGHT")]
        Weight = 0x74686777,
        [NativeName("Name", "DWRITE_FONT_AXIS_TAG_WIDTH")]
        Width = 0x68746477,
        [NativeName("Name", "DWRITE_FONT_AXIS_TAG_SLANT")]
        Slant = 0x746E6C73,
        [NativeName("Name", "DWRITE_FONT_AXIS_TAG_OPTICAL_SIZE")]
        OpticalSize = 0x7A73706F,
        [NativeName("Name", "DWRITE_FONT_AXIS_TAG_ITALIC")]
        Italic = 0x6C617469,
    }
}
