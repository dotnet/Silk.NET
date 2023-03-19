// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXVA
{
    [NativeName("Name", "_DXVAHD_FILTER")]
    public enum HDFilter : int
    {
        [Obsolete("Deprecated in favour of \"Brightness\"")]
        [NativeName("Name", "DXVAHD_FILTER_BRIGHTNESS")]
        HDFilterBrightness = 0x0,
        [Obsolete("Deprecated in favour of \"Contrast\"")]
        [NativeName("Name", "DXVAHD_FILTER_CONTRAST")]
        HDFilterContrast = 0x1,
        [Obsolete("Deprecated in favour of \"Hue\"")]
        [NativeName("Name", "DXVAHD_FILTER_HUE")]
        HDFilterHue = 0x2,
        [Obsolete("Deprecated in favour of \"Saturation\"")]
        [NativeName("Name", "DXVAHD_FILTER_SATURATION")]
        HDFilterSaturation = 0x3,
        [Obsolete("Deprecated in favour of \"NoiseReduction\"")]
        [NativeName("Name", "DXVAHD_FILTER_NOISE_REDUCTION")]
        HDFilterNoiseReduction = 0x4,
        [Obsolete("Deprecated in favour of \"EdgeEnhancement\"")]
        [NativeName("Name", "DXVAHD_FILTER_EDGE_ENHANCEMENT")]
        HDFilterEdgeEnhancement = 0x5,
        [Obsolete("Deprecated in favour of \"AnamorphicScaling\"")]
        [NativeName("Name", "DXVAHD_FILTER_ANAMORPHIC_SCALING")]
        HDFilterAnamorphicScaling = 0x6,
        [NativeName("Name", "DXVAHD_FILTER_BRIGHTNESS")]
        Brightness = 0x0,
        [NativeName("Name", "DXVAHD_FILTER_CONTRAST")]
        Contrast = 0x1,
        [NativeName("Name", "DXVAHD_FILTER_HUE")]
        Hue = 0x2,
        [NativeName("Name", "DXVAHD_FILTER_SATURATION")]
        Saturation = 0x3,
        [NativeName("Name", "DXVAHD_FILTER_NOISE_REDUCTION")]
        NoiseReduction = 0x4,
        [NativeName("Name", "DXVAHD_FILTER_EDGE_ENHANCEMENT")]
        EdgeEnhancement = 0x5,
        [NativeName("Name", "DXVAHD_FILTER_ANAMORPHIC_SCALING")]
        AnamorphicScaling = 0x6,
    }
}
