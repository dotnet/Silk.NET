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
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "DXVA2_ProcAmp_None")]
        DXVA2ProcAmpNone = 0x0,
        [Obsolete("Deprecated in favour of \"Brightness\"")]
        [NativeName("Name", "DXVA2_ProcAmp_Brightness")]
        DXVA2ProcAmpBrightness = 0x1,
        [Obsolete("Deprecated in favour of \"Contrast\"")]
        [NativeName("Name", "DXVA2_ProcAmp_Contrast")]
        DXVA2ProcAmpContrast = 0x2,
        [Obsolete("Deprecated in favour of \"Hue\"")]
        [NativeName("Name", "DXVA2_ProcAmp_Hue")]
        DXVA2ProcAmpHue = 0x4,
        [Obsolete("Deprecated in favour of \"Saturation\"")]
        [NativeName("Name", "DXVA2_ProcAmp_Saturation")]
        DXVA2ProcAmpSaturation = 0x8,
        [Obsolete("Deprecated in favour of \"Mask\"")]
        [NativeName("Name", "DXVA2_ProcAmp_Mask")]
        DXVA2ProcAmpMask = 0xF,
        [NativeName("Name", "DXVA2_ProcAmp_None")]
        None = 0x0,
        [NativeName("Name", "DXVA2_ProcAmp_Brightness")]
        Brightness = 0x1,
        [NativeName("Name", "DXVA2_ProcAmp_Contrast")]
        Contrast = 0x2,
        [NativeName("Name", "DXVA2_ProcAmp_Hue")]
        Hue = 0x4,
        [NativeName("Name", "DXVA2_ProcAmp_Saturation")]
        Saturation = 0x8,
        [NativeName("Name", "DXVA2_ProcAmp_Mask")]
        Mask = 0xF,
    }
}
