// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DirectWrite
{
    [NativeName("Name", "DWRITE_PANOSE_SERIF_STYLE")]
    public enum PanoseSerifStyle : int
    {
        [NativeName("Name", "DWRITE_PANOSE_SERIF_STYLE_ANY")]
        Any = 0x0,
        [NativeName("Name", "DWRITE_PANOSE_SERIF_STYLE_NO_FIT")]
        NoFit = 0x1,
        [NativeName("Name", "DWRITE_PANOSE_SERIF_STYLE_COVE")]
        Cove = 0x2,
        [NativeName("Name", "DWRITE_PANOSE_SERIF_STYLE_OBTUSE_COVE")]
        ObtuseCove = 0x3,
        [NativeName("Name", "DWRITE_PANOSE_SERIF_STYLE_SQUARE_COVE")]
        SquareCove = 0x4,
        [NativeName("Name", "DWRITE_PANOSE_SERIF_STYLE_OBTUSE_SQUARE_COVE")]
        ObtuseSquareCove = 0x5,
        [NativeName("Name", "DWRITE_PANOSE_SERIF_STYLE_SQUARE")]
        Square = 0x6,
        [NativeName("Name", "DWRITE_PANOSE_SERIF_STYLE_THIN")]
        Thin = 0x7,
        [NativeName("Name", "DWRITE_PANOSE_SERIF_STYLE_OVAL")]
        Oval = 0x8,
        [NativeName("Name", "DWRITE_PANOSE_SERIF_STYLE_EXAGGERATED")]
        Exaggerated = 0x9,
        [NativeName("Name", "DWRITE_PANOSE_SERIF_STYLE_TRIANGLE")]
        Triangle = 0xA,
        [NativeName("Name", "DWRITE_PANOSE_SERIF_STYLE_NORMAL_SANS")]
        NormalSans = 0xB,
        [NativeName("Name", "DWRITE_PANOSE_SERIF_STYLE_OBTUSE_SANS")]
        ObtuseSans = 0xC,
        [NativeName("Name", "DWRITE_PANOSE_SERIF_STYLE_PERPENDICULAR_SANS")]
        PerpendicularSans = 0xD,
        [NativeName("Name", "DWRITE_PANOSE_SERIF_STYLE_FLARED")]
        Flared = 0xE,
        [NativeName("Name", "DWRITE_PANOSE_SERIF_STYLE_ROUNDED")]
        Rounded = 0xF,
        [NativeName("Name", "DWRITE_PANOSE_SERIF_STYLE_SCRIPT")]
        Script = 0x10,
        [NativeName("Name", "DWRITE_PANOSE_SERIF_STYLE_PERP_SANS")]
        PerpSans = 0xD,
        [NativeName("Name", "DWRITE_PANOSE_SERIF_STYLE_BONE")]
        Bone = 0x8,
    }
}
