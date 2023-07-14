// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DirectWrite
{
    [NativeName("Name", "DWRITE_PANOSE_ASPECT_RATIO")]
    public enum PanoseAspectRatio : int
    {
        [NativeName("Name", "DWRITE_PANOSE_ASPECT_RATIO_ANY")]
        Any = 0x0,
        [NativeName("Name", "DWRITE_PANOSE_ASPECT_RATIO_NO_FIT")]
        NoFit = 0x1,
        [NativeName("Name", "DWRITE_PANOSE_ASPECT_RATIO_VERY_CONDENSED")]
        VeryCondensed = 0x2,
        [NativeName("Name", "DWRITE_PANOSE_ASPECT_RATIO_CONDENSED")]
        Condensed = 0x3,
        [NativeName("Name", "DWRITE_PANOSE_ASPECT_RATIO_NORMAL")]
        Normal = 0x4,
        [NativeName("Name", "DWRITE_PANOSE_ASPECT_RATIO_EXPANDED")]
        Expanded = 0x5,
        [NativeName("Name", "DWRITE_PANOSE_ASPECT_RATIO_VERY_EXPANDED")]
        VeryExpanded = 0x6,
    }
}
