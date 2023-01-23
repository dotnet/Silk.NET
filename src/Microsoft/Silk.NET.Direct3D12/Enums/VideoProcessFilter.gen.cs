// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_VIDEO_PROCESS_FILTER")]
    public enum VideoProcessFilter : int
    {
        [Obsolete("Deprecated in favour of \"Brightness\"")]
        [NativeName("Name", "D3D12_VIDEO_PROCESS_FILTER_BRIGHTNESS")]
        VideoProcessFilterBrightness = 0x0,
        [Obsolete("Deprecated in favour of \"Contrast\"")]
        [NativeName("Name", "D3D12_VIDEO_PROCESS_FILTER_CONTRAST")]
        VideoProcessFilterContrast = 0x1,
        [Obsolete("Deprecated in favour of \"Hue\"")]
        [NativeName("Name", "D3D12_VIDEO_PROCESS_FILTER_HUE")]
        VideoProcessFilterHue = 0x2,
        [Obsolete("Deprecated in favour of \"Saturation\"")]
        [NativeName("Name", "D3D12_VIDEO_PROCESS_FILTER_SATURATION")]
        VideoProcessFilterSaturation = 0x3,
        [Obsolete("Deprecated in favour of \"NoiseReduction\"")]
        [NativeName("Name", "D3D12_VIDEO_PROCESS_FILTER_NOISE_REDUCTION")]
        VideoProcessFilterNoiseReduction = 0x4,
        [Obsolete("Deprecated in favour of \"EdgeEnhancement\"")]
        [NativeName("Name", "D3D12_VIDEO_PROCESS_FILTER_EDGE_ENHANCEMENT")]
        VideoProcessFilterEdgeEnhancement = 0x5,
        [Obsolete("Deprecated in favour of \"AnamorphicScaling\"")]
        [NativeName("Name", "D3D12_VIDEO_PROCESS_FILTER_ANAMORPHIC_SCALING")]
        VideoProcessFilterAnamorphicScaling = 0x6,
        [Obsolete("Deprecated in favour of \"StereoAdjustment\"")]
        [NativeName("Name", "D3D12_VIDEO_PROCESS_FILTER_STEREO_ADJUSTMENT")]
        VideoProcessFilterStereoAdjustment = 0x7,
        [NativeName("Name", "D3D12_VIDEO_PROCESS_FILTER_BRIGHTNESS")]
        Brightness = 0x0,
        [NativeName("Name", "D3D12_VIDEO_PROCESS_FILTER_CONTRAST")]
        Contrast = 0x1,
        [NativeName("Name", "D3D12_VIDEO_PROCESS_FILTER_HUE")]
        Hue = 0x2,
        [NativeName("Name", "D3D12_VIDEO_PROCESS_FILTER_SATURATION")]
        Saturation = 0x3,
        [NativeName("Name", "D3D12_VIDEO_PROCESS_FILTER_NOISE_REDUCTION")]
        NoiseReduction = 0x4,
        [NativeName("Name", "D3D12_VIDEO_PROCESS_FILTER_EDGE_ENHANCEMENT")]
        EdgeEnhancement = 0x5,
        [NativeName("Name", "D3D12_VIDEO_PROCESS_FILTER_ANAMORPHIC_SCALING")]
        AnamorphicScaling = 0x6,
        [NativeName("Name", "D3D12_VIDEO_PROCESS_FILTER_STEREO_ADJUSTMENT")]
        StereoAdjustment = 0x7,
    }
}
