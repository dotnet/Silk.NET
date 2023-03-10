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
        [NativeName("Name", "DXVA_NominalRangeShift")]
        NominalRangeShift = 0xC,
        [NativeName("Name", "DXVA_NominalRangeMask")]
        NominalRangeMask = 0x7000,
        [NativeName("Name", "DXVA_NominalRange_Unknown")]
        NominalRangeUnknown = 0x0,
        [NativeName("Name", "DXVA_NominalRange_Normal")]
        NominalRangeNormal = 0x1,
        [NativeName("Name", "DXVA_NominalRange_Wide")]
        NominalRangeWide = 0x2,
        [NativeName("Name", "DXVA_NominalRange_0_255")]
        NominalRange0255 = 0x1,
        [NativeName("Name", "DXVA_NominalRange_16_235")]
        NominalRange16235 = 0x2,
        [NativeName("Name", "DXVA_NominalRange_48_208")]
        NominalRange48208 = 0x3,
    }
}
