// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXVA
{
    [Flags]
    [NativeName("Name", "_DXVA_ProcAmpControlProp")]
    public enum ProcAmpControlProp : int
    {
        [NativeName("Name", "DXVA_ProcAmp_None")]
        ProcAmpNone = 0x0,
        [NativeName("Name", "DXVA_ProcAmp_Brightness")]
        ProcAmpBrightness = 0x1,
        [NativeName("Name", "DXVA_ProcAmp_Contrast")]
        ProcAmpContrast = 0x2,
        [NativeName("Name", "DXVA_ProcAmp_Hue")]
        ProcAmpHue = 0x4,
        [NativeName("Name", "DXVA_ProcAmp_Saturation")]
        ProcAmpSaturation = 0x8,
    }
}
