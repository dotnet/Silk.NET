// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXVA
{
    [Flags]
    [NativeName("Name", "_DXVA2_NominalRange")]
    public enum DXVA2NominalRange : int
    {
        [NativeName("Name", "DXVA2_NominalRangeMask")]
        DXVA2NominalRangeMask = 0x7,
        [NativeName("Name", "DXVA2_NominalRange_Unknown")]
        DXVA2NominalRangeUnknown = 0x0,
        [NativeName("Name", "DXVA2_NominalRange_Normal")]
        DXVA2NominalRangeNormal = 0x1,
        [NativeName("Name", "DXVA2_NominalRange_Wide")]
        DXVA2NominalRangeWide = 0x2,
        [NativeName("Name", "DXVA2_NominalRange_0_255")]
        DXVA2NominalRange0255 = 0x1,
        [NativeName("Name", "DXVA2_NominalRange_16_235")]
        DXVA2NominalRange16235 = 0x2,
        [NativeName("Name", "DXVA2_NominalRange_48_208")]
        DXVA2NominalRange48208 = 0x3,
    }
}
