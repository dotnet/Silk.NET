// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DirectWrite
{
    [NativeName("Name", "DWRITE_PANOSE_XHEIGHT")]
    public enum PanoseXheight : int
    {
        [NativeName("Name", "DWRITE_PANOSE_XHEIGHT_ANY")]
        Any = 0x0,
        [NativeName("Name", "DWRITE_PANOSE_XHEIGHT_NO_FIT")]
        NoFit = 0x1,
        [NativeName("Name", "DWRITE_PANOSE_XHEIGHT_CONSTANT_SMALL")]
        ConstantSmall = 0x2,
        [NativeName("Name", "DWRITE_PANOSE_XHEIGHT_CONSTANT_STANDARD")]
        ConstantStandard = 0x3,
        [NativeName("Name", "DWRITE_PANOSE_XHEIGHT_CONSTANT_LARGE")]
        ConstantLarge = 0x4,
        [NativeName("Name", "DWRITE_PANOSE_XHEIGHT_DUCKING_SMALL")]
        DuckingSmall = 0x5,
        [NativeName("Name", "DWRITE_PANOSE_XHEIGHT_DUCKING_STANDARD")]
        DuckingStandard = 0x6,
        [NativeName("Name", "DWRITE_PANOSE_XHEIGHT_DUCKING_LARGE")]
        DuckingLarge = 0x7,
        [NativeName("Name", "DWRITE_PANOSE_XHEIGHT_CONSTANT_STD")]
        ConstantStd = 0x3,
        [NativeName("Name", "DWRITE_PANOSE_XHEIGHT_DUCKING_STD")]
        DuckingStd = 0x6,
    }
}
