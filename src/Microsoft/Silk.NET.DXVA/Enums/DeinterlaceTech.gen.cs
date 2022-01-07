// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXVA
{
    [Flags]
    [NativeName("Name", "_DXVA_DeinterlaceTech")]
    public enum DeinterlaceTech : int
    {
        [NativeName("Name", "DXVA_DeinterlaceTech_Unknown")]
        DeinterlaceTechUnknown = 0x0,
        [NativeName("Name", "DXVA_DeinterlaceTech_BOBLineReplicate")]
        DeinterlaceTechBoblineReplicate = 0x1,
        [NativeName("Name", "DXVA_DeinterlaceTech_BOBVerticalStretch")]
        DeinterlaceTechBobverticalStretch = 0x2,
        [NativeName("Name", "DXVA_DeinterlaceTech_BOBVerticalStretch4Tap")]
        DeinterlaceTechBobverticalStretch4Tap = 0x100,
        [NativeName("Name", "DXVA_DeinterlaceTech_MedianFiltering")]
        DeinterlaceTechMedianFiltering = 0x4,
        [NativeName("Name", "DXVA_DeinterlaceTech_EdgeFiltering")]
        DeinterlaceTechEdgeFiltering = 0x10,
        [NativeName("Name", "DXVA_DeinterlaceTech_FieldAdaptive")]
        DeinterlaceTechFieldAdaptive = 0x20,
        [NativeName("Name", "DXVA_DeinterlaceTech_PixelAdaptive")]
        DeinterlaceTechPixelAdaptive = 0x40,
        [NativeName("Name", "DXVA_DeinterlaceTech_MotionVectorSteered")]
        DeinterlaceTechMotionVectorSteered = 0x80,
    }
}
