// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DirectWrite
{
    [NativeName("Name", "DWRITE_COLOR_COMPOSITE_MODE")]
    public enum ColorCompositeMode : int
    {
        [NativeName("Name", "DWRITE_COLOR_COMPOSITE_CLEAR")]
        Clear = 0x0,
        [NativeName("Name", "DWRITE_COLOR_COMPOSITE_SRC")]
        Src = 0x1,
        [NativeName("Name", "DWRITE_COLOR_COMPOSITE_DEST")]
        Dest = 0x2,
        [NativeName("Name", "DWRITE_COLOR_COMPOSITE_SRC_OVER")]
        SrcOver = 0x3,
        [NativeName("Name", "DWRITE_COLOR_COMPOSITE_DEST_OVER")]
        DestOver = 0x4,
        [NativeName("Name", "DWRITE_COLOR_COMPOSITE_SRC_IN")]
        SrcIn = 0x5,
        [NativeName("Name", "DWRITE_COLOR_COMPOSITE_DEST_IN")]
        DestIn = 0x6,
        [NativeName("Name", "DWRITE_COLOR_COMPOSITE_SRC_OUT")]
        SrcOut = 0x7,
        [NativeName("Name", "DWRITE_COLOR_COMPOSITE_DEST_OUT")]
        DestOut = 0x8,
        [NativeName("Name", "DWRITE_COLOR_COMPOSITE_SRC_ATOP")]
        SrcAtop = 0x9,
        [NativeName("Name", "DWRITE_COLOR_COMPOSITE_DEST_ATOP")]
        DestAtop = 0xA,
        [NativeName("Name", "DWRITE_COLOR_COMPOSITE_XOR")]
        Xor = 0xB,
        [NativeName("Name", "DWRITE_COLOR_COMPOSITE_PLUS")]
        Plus = 0xC,
        [NativeName("Name", "DWRITE_COLOR_COMPOSITE_SCREEN")]
        Screen = 0xD,
        [NativeName("Name", "DWRITE_COLOR_COMPOSITE_OVERLAY")]
        Overlay = 0xE,
        [NativeName("Name", "DWRITE_COLOR_COMPOSITE_DARKEN")]
        Darken = 0xF,
        [NativeName("Name", "DWRITE_COLOR_COMPOSITE_LIGHTEN")]
        Lighten = 0x10,
        [NativeName("Name", "DWRITE_COLOR_COMPOSITE_COLOR_DODGE")]
        ColorDodge = 0x11,
        [NativeName("Name", "DWRITE_COLOR_COMPOSITE_COLOR_BURN")]
        ColorBurn = 0x12,
        [NativeName("Name", "DWRITE_COLOR_COMPOSITE_HARD_LIGHT")]
        HardLight = 0x13,
        [NativeName("Name", "DWRITE_COLOR_COMPOSITE_SOFT_LIGHT")]
        SoftLight = 0x14,
        [NativeName("Name", "DWRITE_COLOR_COMPOSITE_DIFFERENCE")]
        Difference = 0x15,
        [NativeName("Name", "DWRITE_COLOR_COMPOSITE_EXCLUSION")]
        Exclusion = 0x16,
        [NativeName("Name", "DWRITE_COLOR_COMPOSITE_MULTIPLY")]
        Multiply = 0x17,
        [NativeName("Name", "DWRITE_COLOR_COMPOSITE_HSL_HUE")]
        HslHue = 0x18,
        [NativeName("Name", "DWRITE_COLOR_COMPOSITE_HSL_SATURATION")]
        HslSaturation = 0x19,
        [NativeName("Name", "DWRITE_COLOR_COMPOSITE_HSL_COLOR")]
        HslColor = 0x1A,
        [NativeName("Name", "DWRITE_COLOR_COMPOSITE_HSL_LUMINOSITY")]
        HslLuminosity = 0x1B,
    }
}
