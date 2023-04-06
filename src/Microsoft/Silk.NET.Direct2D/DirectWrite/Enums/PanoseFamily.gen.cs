// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DirectWrite
{
    [NativeName("Name", "DWRITE_PANOSE_FAMILY")]
    public enum PanoseFamily : int
    {
        [NativeName("Name", "DWRITE_PANOSE_FAMILY_ANY")]
        Any = 0x0,
        [NativeName("Name", "DWRITE_PANOSE_FAMILY_NO_FIT")]
        NoFit = 0x1,
        [NativeName("Name", "DWRITE_PANOSE_FAMILY_TEXT_DISPLAY")]
        TextDisplay = 0x2,
        [NativeName("Name", "DWRITE_PANOSE_FAMILY_SCRIPT")]
        Script = 0x3,
        [NativeName("Name", "DWRITE_PANOSE_FAMILY_DECORATIVE")]
        Decorative = 0x4,
        [NativeName("Name", "DWRITE_PANOSE_FAMILY_SYMBOL")]
        Symbol = 0x5,
        [NativeName("Name", "DWRITE_PANOSE_FAMILY_PICTORIAL")]
        Pictorial = 0x5,
    }
}
