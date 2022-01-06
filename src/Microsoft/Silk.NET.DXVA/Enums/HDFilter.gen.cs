// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXVA
{
    [Flags]
    [NativeName("Name", "_DXVAHD_FILTER")]
    public enum HDFilter : int
    {
        [NativeName("Name", "DXVAHD_FILTER_BRIGHTNESS")]
        HDFilterBrightness = 0x0,
        [NativeName("Name", "DXVAHD_FILTER_CONTRAST")]
        HDFilterContrast = 0x1,
        [NativeName("Name", "DXVAHD_FILTER_HUE")]
        HDFilterHue = 0x2,
        [NativeName("Name", "DXVAHD_FILTER_SATURATION")]
        HDFilterSaturation = 0x3,
        [NativeName("Name", "DXVAHD_FILTER_NOISE_REDUCTION")]
        HDFilterNoiseReduction = 0x4,
        [NativeName("Name", "DXVAHD_FILTER_EDGE_ENHANCEMENT")]
        HDFilterEdgeEnhancement = 0x5,
        [NativeName("Name", "DXVAHD_FILTER_ANAMORPHIC_SCALING")]
        HDFilterAnamorphicScaling = 0x6,
    }
}
