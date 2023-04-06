// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DirectWrite
{
    [NativeName("Name", "DWRITE_PANOSE_XASCENT")]
    public enum PanoseXascent : int
    {
        [NativeName("Name", "DWRITE_PANOSE_XASCENT_ANY")]
        Any = 0x0,
        [NativeName("Name", "DWRITE_PANOSE_XASCENT_NO_FIT")]
        NoFit = 0x1,
        [NativeName("Name", "DWRITE_PANOSE_XASCENT_VERY_LOW")]
        VeryLow = 0x2,
        [NativeName("Name", "DWRITE_PANOSE_XASCENT_LOW")]
        Low = 0x3,
        [NativeName("Name", "DWRITE_PANOSE_XASCENT_MEDIUM")]
        Medium = 0x4,
        [NativeName("Name", "DWRITE_PANOSE_XASCENT_HIGH")]
        High = 0x5,
        [NativeName("Name", "DWRITE_PANOSE_XASCENT_VERY_HIGH")]
        VeryHigh = 0x6,
    }
}
