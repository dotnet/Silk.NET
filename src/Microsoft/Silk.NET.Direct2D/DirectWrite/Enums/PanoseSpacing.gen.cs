// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DirectWrite
{
    [NativeName("Name", "DWRITE_PANOSE_SPACING")]
    public enum PanoseSpacing : int
    {
        [NativeName("Name", "DWRITE_PANOSE_SPACING_ANY")]
        Any = 0x0,
        [NativeName("Name", "DWRITE_PANOSE_SPACING_NO_FIT")]
        NoFit = 0x1,
        [NativeName("Name", "DWRITE_PANOSE_SPACING_PROPORTIONAL_SPACED")]
        ProportionalSpaced = 0x2,
        [NativeName("Name", "DWRITE_PANOSE_SPACING_MONOSPACED")]
        Monospaced = 0x3,
    }
}
