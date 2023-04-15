// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXVA
{
    [Flags]
    [NativeName("Name", "__MIDL___MIDL_itf_dxva2api_0000_0000_0003")]
    public enum MIDLMIDLItfDxva2api000000000003 : int
    {
        [Obsolete("Deprecated in favour of \"Unknown\"")]
        [NativeName("Name", "DXVA2_DeinterlaceTech_Unknown")]
        DXVA2DeinterlaceTechUnknown = 0x0,
        [Obsolete("Deprecated in favour of \"BobLineReplicate\"")]
        [NativeName("Name", "DXVA2_DeinterlaceTech_BOBLineReplicate")]
        DXVA2DeinterlaceTechBoblineReplicate = 0x1,
        [Obsolete("Deprecated in favour of \"BobVerticalStretch\"")]
        [NativeName("Name", "DXVA2_DeinterlaceTech_BOBVerticalStretch")]
        DXVA2DeinterlaceTechBobverticalStretch = 0x2,
        [Obsolete("Deprecated in favour of \"BobVerticalStretch4Tap\"")]
        [NativeName("Name", "DXVA2_DeinterlaceTech_BOBVerticalStretch4Tap")]
        DXVA2DeinterlaceTechBobverticalStretch4Tap = 0x4,
        [Obsolete("Deprecated in favour of \"MedianFiltering\"")]
        [NativeName("Name", "DXVA2_DeinterlaceTech_MedianFiltering")]
        DXVA2DeinterlaceTechMedianFiltering = 0x8,
        [Obsolete("Deprecated in favour of \"EdgeFiltering\"")]
        [NativeName("Name", "DXVA2_DeinterlaceTech_EdgeFiltering")]
        DXVA2DeinterlaceTechEdgeFiltering = 0x10,
        [Obsolete("Deprecated in favour of \"FieldAdaptive\"")]
        [NativeName("Name", "DXVA2_DeinterlaceTech_FieldAdaptive")]
        DXVA2DeinterlaceTechFieldAdaptive = 0x20,
        [Obsolete("Deprecated in favour of \"PixelAdaptive\"")]
        [NativeName("Name", "DXVA2_DeinterlaceTech_PixelAdaptive")]
        DXVA2DeinterlaceTechPixelAdaptive = 0x40,
        [Obsolete("Deprecated in favour of \"MotionVectorSteered\"")]
        [NativeName("Name", "DXVA2_DeinterlaceTech_MotionVectorSteered")]
        DXVA2DeinterlaceTechMotionVectorSteered = 0x80,
        [Obsolete("Deprecated in favour of \"InverseTelecine\"")]
        [NativeName("Name", "DXVA2_DeinterlaceTech_InverseTelecine")]
        DXVA2DeinterlaceTechInverseTelecine = 0x100,
        [Obsolete("Deprecated in favour of \"Mask\"")]
        [NativeName("Name", "DXVA2_DeinterlaceTech_Mask")]
        DXVA2DeinterlaceTechMask = 0x1FF,
        [NativeName("Name", "DXVA2_DeinterlaceTech_Unknown")]
        Unknown = 0x0,
        [NativeName("Name", "DXVA2_DeinterlaceTech_BOBLineReplicate")]
        BobLineReplicate = 0x1,
        [NativeName("Name", "DXVA2_DeinterlaceTech_BOBVerticalStretch")]
        BobVerticalStretch = 0x2,
        [NativeName("Name", "DXVA2_DeinterlaceTech_BOBVerticalStretch4Tap")]
        BobVerticalStretch4Tap = 0x4,
        [NativeName("Name", "DXVA2_DeinterlaceTech_MedianFiltering")]
        MedianFiltering = 0x8,
        [NativeName("Name", "DXVA2_DeinterlaceTech_EdgeFiltering")]
        EdgeFiltering = 0x10,
        [NativeName("Name", "DXVA2_DeinterlaceTech_FieldAdaptive")]
        FieldAdaptive = 0x20,
        [NativeName("Name", "DXVA2_DeinterlaceTech_PixelAdaptive")]
        PixelAdaptive = 0x40,
        [NativeName("Name", "DXVA2_DeinterlaceTech_MotionVectorSteered")]
        MotionVectorSteered = 0x80,
        [NativeName("Name", "DXVA2_DeinterlaceTech_InverseTelecine")]
        InverseTelecine = 0x100,
        [NativeName("Name", "DXVA2_DeinterlaceTech_Mask")]
        Mask = 0x1FF,
    }
}
