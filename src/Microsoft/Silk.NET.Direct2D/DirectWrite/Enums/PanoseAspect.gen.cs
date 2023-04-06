// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DirectWrite
{
    [NativeName("Name", "DWRITE_PANOSE_ASPECT")]
    public enum PanoseAspect : int
    {
        [NativeName("Name", "DWRITE_PANOSE_ASPECT_ANY")]
        Any = 0x0,
        [NativeName("Name", "DWRITE_PANOSE_ASPECT_NO_FIT")]
        NoFit = 0x1,
        [NativeName("Name", "DWRITE_PANOSE_ASPECT_SUPER_CONDENSED")]
        SuperCondensed = 0x2,
        [NativeName("Name", "DWRITE_PANOSE_ASPECT_VERY_CONDENSED")]
        VeryCondensed = 0x3,
        [NativeName("Name", "DWRITE_PANOSE_ASPECT_CONDENSED")]
        Condensed = 0x4,
        [NativeName("Name", "DWRITE_PANOSE_ASPECT_NORMAL")]
        Normal = 0x5,
        [NativeName("Name", "DWRITE_PANOSE_ASPECT_EXTENDED")]
        Extended = 0x6,
        [NativeName("Name", "DWRITE_PANOSE_ASPECT_VERY_EXTENDED")]
        VeryExtended = 0x7,
        [NativeName("Name", "DWRITE_PANOSE_ASPECT_SUPER_EXTENDED")]
        SuperExtended = 0x8,
        [NativeName("Name", "DWRITE_PANOSE_ASPECT_MONOSPACED")]
        Monospaced = 0x9,
    }
}
