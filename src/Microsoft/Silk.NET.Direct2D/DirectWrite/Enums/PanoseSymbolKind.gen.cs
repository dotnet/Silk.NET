// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DirectWrite
{
    [NativeName("Name", "DWRITE_PANOSE_SYMBOL_KIND")]
    public enum PanoseSymbolKind : int
    {
        [NativeName("Name", "DWRITE_PANOSE_SYMBOL_KIND_ANY")]
        Any = 0x0,
        [NativeName("Name", "DWRITE_PANOSE_SYMBOL_KIND_NO_FIT")]
        NoFit = 0x1,
        [NativeName("Name", "DWRITE_PANOSE_SYMBOL_KIND_MONTAGES")]
        Montages = 0x2,
        [NativeName("Name", "DWRITE_PANOSE_SYMBOL_KIND_PICTURES")]
        Pictures = 0x3,
        [NativeName("Name", "DWRITE_PANOSE_SYMBOL_KIND_SHAPES")]
        Shapes = 0x4,
        [NativeName("Name", "DWRITE_PANOSE_SYMBOL_KIND_SCIENTIFIC")]
        Scientific = 0x5,
        [NativeName("Name", "DWRITE_PANOSE_SYMBOL_KIND_MUSIC")]
        Music = 0x6,
        [NativeName("Name", "DWRITE_PANOSE_SYMBOL_KIND_EXPERT")]
        Expert = 0x7,
        [NativeName("Name", "DWRITE_PANOSE_SYMBOL_KIND_PATTERNS")]
        Patterns = 0x8,
        [NativeName("Name", "DWRITE_PANOSE_SYMBOL_KIND_BOARDERS")]
        Boarders = 0x9,
        [NativeName("Name", "DWRITE_PANOSE_SYMBOL_KIND_ICONS")]
        Icons = 0xA,
        [NativeName("Name", "DWRITE_PANOSE_SYMBOL_KIND_LOGOS")]
        Logos = 0xB,
        [NativeName("Name", "DWRITE_PANOSE_SYMBOL_KIND_INDUSTRY_SPECIFIC")]
        IndustrySpecific = 0xC,
    }
}
