// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DirectWrite
{
    [NativeName("Name", "DWRITE_PANOSE_PROPORTION")]
    public enum PanoseProportion : int
    {
        [NativeName("Name", "DWRITE_PANOSE_PROPORTION_ANY")]
        Any = 0x0,
        [NativeName("Name", "DWRITE_PANOSE_PROPORTION_NO_FIT")]
        NoFit = 0x1,
        [NativeName("Name", "DWRITE_PANOSE_PROPORTION_OLD_STYLE")]
        OldStyle = 0x2,
        [NativeName("Name", "DWRITE_PANOSE_PROPORTION_MODERN")]
        Modern = 0x3,
        [NativeName("Name", "DWRITE_PANOSE_PROPORTION_EVEN_WIDTH")]
        EvenWidth = 0x4,
        [NativeName("Name", "DWRITE_PANOSE_PROPORTION_EXPANDED")]
        Expanded = 0x5,
        [NativeName("Name", "DWRITE_PANOSE_PROPORTION_CONDENSED")]
        Condensed = 0x6,
        [NativeName("Name", "DWRITE_PANOSE_PROPORTION_VERY_EXPANDED")]
        VeryExpanded = 0x7,
        [NativeName("Name", "DWRITE_PANOSE_PROPORTION_VERY_CONDENSED")]
        VeryCondensed = 0x8,
        [NativeName("Name", "DWRITE_PANOSE_PROPORTION_MONOSPACED")]
        Monospaced = 0x9,
    }
}
