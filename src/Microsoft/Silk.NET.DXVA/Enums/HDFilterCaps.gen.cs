// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXVA
{
    [Flags]
    [NativeName("Name", "_DXVAHD_FILTER_CAPS")]
    public enum HDFilterCaps : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"Brightness\"")]
        [NativeName("Name", "DXVAHD_FILTER_CAPS_BRIGHTNESS")]
        HDFilterCapsBrightness = 0x1,
        [Obsolete("Deprecated in favour of \"Contrast\"")]
        [NativeName("Name", "DXVAHD_FILTER_CAPS_CONTRAST")]
        HDFilterCapsContrast = 0x2,
        [Obsolete("Deprecated in favour of \"Hue\"")]
        [NativeName("Name", "DXVAHD_FILTER_CAPS_HUE")]
        HDFilterCapsHue = 0x4,
        [Obsolete("Deprecated in favour of \"Saturation\"")]
        [NativeName("Name", "DXVAHD_FILTER_CAPS_SATURATION")]
        HDFilterCapsSaturation = 0x8,
        [Obsolete("Deprecated in favour of \"NoiseReduction\"")]
        [NativeName("Name", "DXVAHD_FILTER_CAPS_NOISE_REDUCTION")]
        HDFilterCapsNoiseReduction = 0x10,
        [Obsolete("Deprecated in favour of \"EdgeEnhancement\"")]
        [NativeName("Name", "DXVAHD_FILTER_CAPS_EDGE_ENHANCEMENT")]
        HDFilterCapsEdgeEnhancement = 0x20,
        [Obsolete("Deprecated in favour of \"AnamorphicScaling\"")]
        [NativeName("Name", "DXVAHD_FILTER_CAPS_ANAMORPHIC_SCALING")]
        HDFilterCapsAnamorphicScaling = 0x40,
        [NativeName("Name", "DXVAHD_FILTER_CAPS_BRIGHTNESS")]
        Brightness = 0x1,
        [NativeName("Name", "DXVAHD_FILTER_CAPS_CONTRAST")]
        Contrast = 0x2,
        [NativeName("Name", "DXVAHD_FILTER_CAPS_HUE")]
        Hue = 0x4,
        [NativeName("Name", "DXVAHD_FILTER_CAPS_SATURATION")]
        Saturation = 0x8,
        [NativeName("Name", "DXVAHD_FILTER_CAPS_NOISE_REDUCTION")]
        NoiseReduction = 0x10,
        [NativeName("Name", "DXVAHD_FILTER_CAPS_EDGE_ENHANCEMENT")]
        EdgeEnhancement = 0x20,
        [NativeName("Name", "DXVAHD_FILTER_CAPS_ANAMORPHIC_SCALING")]
        AnamorphicScaling = 0x40,
    }
}
