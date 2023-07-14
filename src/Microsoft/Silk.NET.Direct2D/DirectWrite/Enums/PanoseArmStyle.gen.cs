// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DirectWrite
{
    [NativeName("Name", "DWRITE_PANOSE_ARM_STYLE")]
    public enum PanoseArmStyle : int
    {
        [NativeName("Name", "DWRITE_PANOSE_ARM_STYLE_ANY")]
        Any = 0x0,
        [NativeName("Name", "DWRITE_PANOSE_ARM_STYLE_NO_FIT")]
        NoFit = 0x1,
        [NativeName("Name", "DWRITE_PANOSE_ARM_STYLE_STRAIGHT_ARMS_HORIZONTAL")]
        StraightArmsHorizontal = 0x2,
        [NativeName("Name", "DWRITE_PANOSE_ARM_STYLE_STRAIGHT_ARMS_WEDGE")]
        StraightArmsWedge = 0x3,
        [NativeName("Name", "DWRITE_PANOSE_ARM_STYLE_STRAIGHT_ARMS_VERTICAL")]
        StraightArmsVertical = 0x4,
        [NativeName("Name", "DWRITE_PANOSE_ARM_STYLE_STRAIGHT_ARMS_SINGLE_SERIF")]
        StraightArmsSingleSerif = 0x5,
        [NativeName("Name", "DWRITE_PANOSE_ARM_STYLE_STRAIGHT_ARMS_DOUBLE_SERIF")]
        StraightArmsDoubleSerif = 0x6,
        [NativeName("Name", "DWRITE_PANOSE_ARM_STYLE_NONSTRAIGHT_ARMS_HORIZONTAL")]
        NonstraightArmsHorizontal = 0x7,
        [NativeName("Name", "DWRITE_PANOSE_ARM_STYLE_NONSTRAIGHT_ARMS_WEDGE")]
        NonstraightArmsWedge = 0x8,
        [NativeName("Name", "DWRITE_PANOSE_ARM_STYLE_NONSTRAIGHT_ARMS_VERTICAL")]
        NonstraightArmsVertical = 0x9,
        [NativeName("Name", "DWRITE_PANOSE_ARM_STYLE_NONSTRAIGHT_ARMS_SINGLE_SERIF")]
        NonstraightArmsSingleSerif = 0xA,
        [NativeName("Name", "DWRITE_PANOSE_ARM_STYLE_NONSTRAIGHT_ARMS_DOUBLE_SERIF")]
        NonstraightArmsDoubleSerif = 0xB,
        [NativeName("Name", "DWRITE_PANOSE_ARM_STYLE_STRAIGHT_ARMS_HORZ")]
        StraightArmsHorz = 0x2,
        [NativeName("Name", "DWRITE_PANOSE_ARM_STYLE_STRAIGHT_ARMS_VERT")]
        StraightArmsVert = 0x4,
        [NativeName("Name", "DWRITE_PANOSE_ARM_STYLE_BENT_ARMS_HORZ")]
        BentArmsHorz = 0x7,
        [NativeName("Name", "DWRITE_PANOSE_ARM_STYLE_BENT_ARMS_WEDGE")]
        BentArmsWedge = 0x8,
        [NativeName("Name", "DWRITE_PANOSE_ARM_STYLE_BENT_ARMS_VERT")]
        BentArmsVert = 0x9,
        [NativeName("Name", "DWRITE_PANOSE_ARM_STYLE_BENT_ARMS_SINGLE_SERIF")]
        BentArmsSingleSerif = 0xA,
        [NativeName("Name", "DWRITE_PANOSE_ARM_STYLE_BENT_ARMS_DOUBLE_SERIF")]
        BentArmsDoubleSerif = 0xB,
    }
}
