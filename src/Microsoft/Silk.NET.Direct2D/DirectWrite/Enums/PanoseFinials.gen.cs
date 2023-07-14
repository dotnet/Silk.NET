// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DirectWrite
{
    [NativeName("Name", "DWRITE_PANOSE_FINIALS")]
    public enum PanoseFinials : int
    {
        [NativeName("Name", "DWRITE_PANOSE_FINIALS_ANY")]
        Any = 0x0,
        [NativeName("Name", "DWRITE_PANOSE_FINIALS_NO_FIT")]
        NoFit = 0x1,
        [NativeName("Name", "DWRITE_PANOSE_FINIALS_NONE_NO_LOOPS")]
        NoneNoLoops = 0x2,
        [NativeName("Name", "DWRITE_PANOSE_FINIALS_NONE_CLOSED_LOOPS")]
        NoneClosedLoops = 0x3,
        [NativeName("Name", "DWRITE_PANOSE_FINIALS_NONE_OPEN_LOOPS")]
        NoneOpenLoops = 0x4,
        [NativeName("Name", "DWRITE_PANOSE_FINIALS_SHARP_NO_LOOPS")]
        SharpNoLoops = 0x5,
        [NativeName("Name", "DWRITE_PANOSE_FINIALS_SHARP_CLOSED_LOOPS")]
        SharpClosedLoops = 0x6,
        [NativeName("Name", "DWRITE_PANOSE_FINIALS_SHARP_OPEN_LOOPS")]
        SharpOpenLoops = 0x7,
        [NativeName("Name", "DWRITE_PANOSE_FINIALS_TAPERED_NO_LOOPS")]
        TaperedNoLoops = 0x8,
        [NativeName("Name", "DWRITE_PANOSE_FINIALS_TAPERED_CLOSED_LOOPS")]
        TaperedClosedLoops = 0x9,
        [NativeName("Name", "DWRITE_PANOSE_FINIALS_TAPERED_OPEN_LOOPS")]
        TaperedOpenLoops = 0xA,
        [NativeName("Name", "DWRITE_PANOSE_FINIALS_ROUND_NO_LOOPS")]
        RoundNoLoops = 0xB,
        [NativeName("Name", "DWRITE_PANOSE_FINIALS_ROUND_CLOSED_LOOPS")]
        RoundClosedLoops = 0xC,
        [NativeName("Name", "DWRITE_PANOSE_FINIALS_ROUND_OPEN_LOOPS")]
        RoundOpenLoops = 0xD,
    }
}
