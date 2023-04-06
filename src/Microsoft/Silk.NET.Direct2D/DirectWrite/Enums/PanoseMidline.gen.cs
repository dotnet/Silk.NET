// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DirectWrite
{
    [NativeName("Name", "DWRITE_PANOSE_MIDLINE")]
    public enum PanoseMidline : int
    {
        [NativeName("Name", "DWRITE_PANOSE_MIDLINE_ANY")]
        Any = 0x0,
        [NativeName("Name", "DWRITE_PANOSE_MIDLINE_NO_FIT")]
        NoFit = 0x1,
        [NativeName("Name", "DWRITE_PANOSE_MIDLINE_STANDARD_TRIMMED")]
        StandardTrimmed = 0x2,
        [NativeName("Name", "DWRITE_PANOSE_MIDLINE_STANDARD_POINTED")]
        StandardPointed = 0x3,
        [NativeName("Name", "DWRITE_PANOSE_MIDLINE_STANDARD_SERIFED")]
        StandardSerifed = 0x4,
        [NativeName("Name", "DWRITE_PANOSE_MIDLINE_HIGH_TRIMMED")]
        HighTrimmed = 0x5,
        [NativeName("Name", "DWRITE_PANOSE_MIDLINE_HIGH_POINTED")]
        HighPointed = 0x6,
        [NativeName("Name", "DWRITE_PANOSE_MIDLINE_HIGH_SERIFED")]
        HighSerifed = 0x7,
        [NativeName("Name", "DWRITE_PANOSE_MIDLINE_CONSTANT_TRIMMED")]
        ConstantTrimmed = 0x8,
        [NativeName("Name", "DWRITE_PANOSE_MIDLINE_CONSTANT_POINTED")]
        ConstantPointed = 0x9,
        [NativeName("Name", "DWRITE_PANOSE_MIDLINE_CONSTANT_SERIFED")]
        ConstantSerifed = 0xA,
        [NativeName("Name", "DWRITE_PANOSE_MIDLINE_LOW_TRIMMED")]
        LowTrimmed = 0xB,
        [NativeName("Name", "DWRITE_PANOSE_MIDLINE_LOW_POINTED")]
        LowPointed = 0xC,
        [NativeName("Name", "DWRITE_PANOSE_MIDLINE_LOW_SERIFED")]
        LowSerifed = 0xD,
    }
}
