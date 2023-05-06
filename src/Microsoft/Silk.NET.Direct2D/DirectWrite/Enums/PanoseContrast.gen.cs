// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DirectWrite
{
    [NativeName("Name", "DWRITE_PANOSE_CONTRAST")]
    public enum PanoseContrast : int
    {
        [NativeName("Name", "DWRITE_PANOSE_CONTRAST_ANY")]
        Any = 0x0,
        [NativeName("Name", "DWRITE_PANOSE_CONTRAST_NO_FIT")]
        NoFit = 0x1,
        [NativeName("Name", "DWRITE_PANOSE_CONTRAST_NONE")]
        None = 0x2,
        [NativeName("Name", "DWRITE_PANOSE_CONTRAST_VERY_LOW")]
        VeryLow = 0x3,
        [NativeName("Name", "DWRITE_PANOSE_CONTRAST_LOW")]
        Low = 0x4,
        [NativeName("Name", "DWRITE_PANOSE_CONTRAST_MEDIUM_LOW")]
        MediumLow = 0x5,
        [NativeName("Name", "DWRITE_PANOSE_CONTRAST_MEDIUM")]
        Medium = 0x6,
        [NativeName("Name", "DWRITE_PANOSE_CONTRAST_MEDIUM_HIGH")]
        MediumHigh = 0x7,
        [NativeName("Name", "DWRITE_PANOSE_CONTRAST_HIGH")]
        High = 0x8,
        [NativeName("Name", "DWRITE_PANOSE_CONTRAST_VERY_HIGH")]
        VeryHigh = 0x9,
        [NativeName("Name", "DWRITE_PANOSE_CONTRAST_HORIZONTAL_LOW")]
        HorizontalLow = 0xA,
        [NativeName("Name", "DWRITE_PANOSE_CONTRAST_HORIZONTAL_MEDIUM")]
        HorizontalMedium = 0xB,
        [NativeName("Name", "DWRITE_PANOSE_CONTRAST_HORIZONTAL_HIGH")]
        HorizontalHigh = 0xC,
        [NativeName("Name", "DWRITE_PANOSE_CONTRAST_BROKEN")]
        Broken = 0xD,
    }
}
