// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXVA
{
    [Flags]
    [NativeName("Name", "__MIDL___MIDL_itf_dxva2api_0000_0000_0007")]
    public enum MIDLMIDLItfDxva2api000000000007 : int
    {
        [NativeName("Name", "DXVA2_ProcAmp_None")]
        DXVA2ProcAmpNone = 0x0,
        [NativeName("Name", "DXVA2_ProcAmp_Brightness")]
        DXVA2ProcAmpBrightness = 0x1,
        [NativeName("Name", "DXVA2_ProcAmp_Contrast")]
        DXVA2ProcAmpContrast = 0x2,
        [NativeName("Name", "DXVA2_ProcAmp_Hue")]
        DXVA2ProcAmpHue = 0x4,
        [NativeName("Name", "DXVA2_ProcAmp_Saturation")]
        DXVA2ProcAmpSaturation = 0x8,
        [NativeName("Name", "DXVA2_ProcAmp_Mask")]
        DXVA2ProcAmpMask = 0xF,
    }
}
