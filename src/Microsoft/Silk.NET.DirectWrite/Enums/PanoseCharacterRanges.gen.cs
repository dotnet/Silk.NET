// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DirectWrite
{
    [NativeName("Name", "DWRITE_PANOSE_CHARACTER_RANGES")]
    public enum PanoseCharacterRanges : int
    {
        [NativeName("Name", "DWRITE_PANOSE_CHARACTER_RANGES_ANY")]
        Any = 0x0,
        [NativeName("Name", "DWRITE_PANOSE_CHARACTER_RANGES_NO_FIT")]
        NoFit = 0x1,
        [NativeName("Name", "DWRITE_PANOSE_CHARACTER_RANGES_EXTENDED_COLLECTION")]
        ExtendedCollection = 0x2,
        [NativeName("Name", "DWRITE_PANOSE_CHARACTER_RANGES_LITERALS")]
        Literals = 0x3,
        [NativeName("Name", "DWRITE_PANOSE_CHARACTER_RANGES_NO_LOWER_CASE")]
        NoLowerCase = 0x4,
        [NativeName("Name", "DWRITE_PANOSE_CHARACTER_RANGES_SMALL_CAPS")]
        SmallCaps = 0x5,
    }
}
