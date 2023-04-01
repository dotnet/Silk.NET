// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DirectWrite
{
    [NativeName("Name", "DWRITE_PANOSE_SYMBOL_ASPECT_RATIO")]
    public enum PanoseSymbolAspectRatio : int
    {
        [NativeName("Name", "DWRITE_PANOSE_SYMBOL_ASPECT_RATIO_ANY")]
        Any = 0x0,
        [NativeName("Name", "DWRITE_PANOSE_SYMBOL_ASPECT_RATIO_NO_FIT")]
        NoFit = 0x1,
        [NativeName("Name", "DWRITE_PANOSE_SYMBOL_ASPECT_RATIO_NO_WIDTH")]
        NoWidth = 0x2,
        [NativeName("Name", "DWRITE_PANOSE_SYMBOL_ASPECT_RATIO_EXCEPTIONALLY_WIDE")]
        ExceptionallyWide = 0x3,
        [NativeName("Name", "DWRITE_PANOSE_SYMBOL_ASPECT_RATIO_SUPER_WIDE")]
        SuperWide = 0x4,
        [NativeName("Name", "DWRITE_PANOSE_SYMBOL_ASPECT_RATIO_VERY_WIDE")]
        VeryWide = 0x5,
        [NativeName("Name", "DWRITE_PANOSE_SYMBOL_ASPECT_RATIO_WIDE")]
        Wide = 0x6,
        [NativeName("Name", "DWRITE_PANOSE_SYMBOL_ASPECT_RATIO_NORMAL")]
        Normal = 0x7,
        [NativeName("Name", "DWRITE_PANOSE_SYMBOL_ASPECT_RATIO_NARROW")]
        Narrow = 0x8,
        [NativeName("Name", "DWRITE_PANOSE_SYMBOL_ASPECT_RATIO_VERY_NARROW")]
        VeryNarrow = 0x9,
    }
}
