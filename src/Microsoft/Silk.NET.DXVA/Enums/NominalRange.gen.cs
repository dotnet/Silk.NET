// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXVA
{
    [Flags]
    [NativeName("Name", "_DXVA_NominalRange")]
    public enum NominalRange : int
    {
        [Obsolete("Deprecated in favour of \"RangeShift\"")]
        [NativeName("Name", "DXVA_NominalRangeShift")]
        NominalRangeShift = 0xC,
        [Obsolete("Deprecated in favour of \"RangeMask\"")]
        [NativeName("Name", "DXVA_NominalRangeMask")]
        NominalRangeMask = 0x7000,
        [Obsolete("Deprecated in favour of \"RangeUnknown\"")]
        [NativeName("Name", "DXVA_NominalRange_Unknown")]
        NominalRangeUnknown = 0x0,
        [Obsolete("Deprecated in favour of \"RangeNormal\"")]
        [NativeName("Name", "DXVA_NominalRange_Normal")]
        NominalRangeNormal = 0x1,
        [Obsolete("Deprecated in favour of \"RangeWide\"")]
        [NativeName("Name", "DXVA_NominalRange_Wide")]
        NominalRangeWide = 0x2,
        [Obsolete("Deprecated in favour of \"Range0255\"")]
        [NativeName("Name", "DXVA_NominalRange_0_255")]
        NominalRange0255 = 0x1,
        [Obsolete("Deprecated in favour of \"Range16235\"")]
        [NativeName("Name", "DXVA_NominalRange_16_235")]
        NominalRange16235 = 0x2,
        [Obsolete("Deprecated in favour of \"Range48208\"")]
        [NativeName("Name", "DXVA_NominalRange_48_208")]
        NominalRange48208 = 0x3,
        [NativeName("Name", "DXVA_NominalRangeShift")]
        RangeShift = 0xC,
        [NativeName("Name", "DXVA_NominalRangeMask")]
        RangeMask = 0x7000,
        [NativeName("Name", "DXVA_NominalRange_Unknown")]
        RangeUnknown = 0x0,
        [NativeName("Name", "DXVA_NominalRange_Normal")]
        RangeNormal = 0x1,
        [NativeName("Name", "DXVA_NominalRange_Wide")]
        RangeWide = 0x2,
        [NativeName("Name", "DXVA_NominalRange_0_255")]
        Range0255 = 0x1,
        [NativeName("Name", "DXVA_NominalRange_16_235")]
        Range16235 = 0x2,
        [NativeName("Name", "DXVA_NominalRange_48_208")]
        Range48208 = 0x3,
    }
}
