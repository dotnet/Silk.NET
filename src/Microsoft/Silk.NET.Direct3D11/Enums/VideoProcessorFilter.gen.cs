// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_VIDEO_PROCESSOR_FILTER")]
    public enum VideoProcessorFilter : int
    {
        [Obsolete("Deprecated in favour of \"Brightness\"")]
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_FILTER_BRIGHTNESS")]
        VideoProcessorFilterBrightness = 0x0,
        [Obsolete("Deprecated in favour of \"Contrast\"")]
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_FILTER_CONTRAST")]
        VideoProcessorFilterContrast = 0x1,
        [Obsolete("Deprecated in favour of \"Hue\"")]
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_FILTER_HUE")]
        VideoProcessorFilterHue = 0x2,
        [Obsolete("Deprecated in favour of \"Saturation\"")]
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_FILTER_SATURATION")]
        VideoProcessorFilterSaturation = 0x3,
        [Obsolete("Deprecated in favour of \"NoiseReduction\"")]
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_FILTER_NOISE_REDUCTION")]
        VideoProcessorFilterNoiseReduction = 0x4,
        [Obsolete("Deprecated in favour of \"EdgeEnhancement\"")]
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_FILTER_EDGE_ENHANCEMENT")]
        VideoProcessorFilterEdgeEnhancement = 0x5,
        [Obsolete("Deprecated in favour of \"AnamorphicScaling\"")]
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_FILTER_ANAMORPHIC_SCALING")]
        VideoProcessorFilterAnamorphicScaling = 0x6,
        [Obsolete("Deprecated in favour of \"StereoAdjustment\"")]
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_FILTER_STEREO_ADJUSTMENT")]
        VideoProcessorFilterStereoAdjustment = 0x7,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_FILTER_BRIGHTNESS")]
        Brightness = 0x0,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_FILTER_CONTRAST")]
        Contrast = 0x1,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_FILTER_HUE")]
        Hue = 0x2,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_FILTER_SATURATION")]
        Saturation = 0x3,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_FILTER_NOISE_REDUCTION")]
        NoiseReduction = 0x4,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_FILTER_EDGE_ENHANCEMENT")]
        EdgeEnhancement = 0x5,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_FILTER_ANAMORPHIC_SCALING")]
        AnamorphicScaling = 0x6,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_FILTER_STEREO_ADJUSTMENT")]
        StereoAdjustment = 0x7,
    }
}
