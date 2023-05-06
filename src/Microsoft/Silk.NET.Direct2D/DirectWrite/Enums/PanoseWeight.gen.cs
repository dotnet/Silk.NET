// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DirectWrite
{
    [NativeName("Name", "DWRITE_PANOSE_WEIGHT")]
    public enum PanoseWeight : int
    {
        [NativeName("Name", "DWRITE_PANOSE_WEIGHT_ANY")]
        Any = 0x0,
        [NativeName("Name", "DWRITE_PANOSE_WEIGHT_NO_FIT")]
        NoFit = 0x1,
        [NativeName("Name", "DWRITE_PANOSE_WEIGHT_VERY_LIGHT")]
        VeryLight = 0x2,
        [NativeName("Name", "DWRITE_PANOSE_WEIGHT_LIGHT")]
        Light = 0x3,
        [NativeName("Name", "DWRITE_PANOSE_WEIGHT_THIN")]
        Thin = 0x4,
        [NativeName("Name", "DWRITE_PANOSE_WEIGHT_BOOK")]
        Book = 0x5,
        [NativeName("Name", "DWRITE_PANOSE_WEIGHT_MEDIUM")]
        Medium = 0x6,
        [NativeName("Name", "DWRITE_PANOSE_WEIGHT_DEMI")]
        Demi = 0x7,
        [NativeName("Name", "DWRITE_PANOSE_WEIGHT_BOLD")]
        Bold = 0x8,
        [NativeName("Name", "DWRITE_PANOSE_WEIGHT_HEAVY")]
        Heavy = 0x9,
        [NativeName("Name", "DWRITE_PANOSE_WEIGHT_BLACK")]
        Black = 0xA,
        [NativeName("Name", "DWRITE_PANOSE_WEIGHT_EXTRA_BLACK")]
        ExtraBlack = 0xB,
        [NativeName("Name", "DWRITE_PANOSE_WEIGHT_NORD")]
        Nord = 0xB,
    }
}
