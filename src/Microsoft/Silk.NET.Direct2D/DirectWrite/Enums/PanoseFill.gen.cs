// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DirectWrite
{
    [NativeName("Name", "DWRITE_PANOSE_FILL")]
    public enum PanoseFill : int
    {
        [NativeName("Name", "DWRITE_PANOSE_FILL_ANY")]
        Any = 0x0,
        [NativeName("Name", "DWRITE_PANOSE_FILL_NO_FIT")]
        NoFit = 0x1,
        [NativeName("Name", "DWRITE_PANOSE_FILL_STANDARD_SOLID_FILL")]
        StandardSolidFill = 0x2,
        [NativeName("Name", "DWRITE_PANOSE_FILL_NO_FILL")]
        NoFill = 0x3,
        [NativeName("Name", "DWRITE_PANOSE_FILL_PATTERNED_FILL")]
        PatternedFill = 0x4,
        [NativeName("Name", "DWRITE_PANOSE_FILL_COMPLEX_FILL")]
        ComplexFill = 0x5,
        [NativeName("Name", "DWRITE_PANOSE_FILL_SHAPED_FILL")]
        ShapedFill = 0x6,
        [NativeName("Name", "DWRITE_PANOSE_FILL_DRAWN_DISTRESSED")]
        DrawnDistressed = 0x7,
    }
}
