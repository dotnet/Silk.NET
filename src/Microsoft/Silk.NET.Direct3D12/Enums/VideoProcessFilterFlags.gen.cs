// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_VIDEO_PROCESS_FILTER_FLAGS")]
    public enum VideoProcessFilterFlags : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "D3D12_VIDEO_PROCESS_FILTER_FLAG_NONE")]
        VideoProcessFilterFlagNone = 0x0,
        [Obsolete("Deprecated in favour of \"Brightness\"")]
        [NativeName("Name", "D3D12_VIDEO_PROCESS_FILTER_FLAG_BRIGHTNESS")]
        VideoProcessFilterFlagBrightness = 0x1,
        [Obsolete("Deprecated in favour of \"Contrast\"")]
        [NativeName("Name", "D3D12_VIDEO_PROCESS_FILTER_FLAG_CONTRAST")]
        VideoProcessFilterFlagContrast = 0x2,
        [Obsolete("Deprecated in favour of \"Hue\"")]
        [NativeName("Name", "D3D12_VIDEO_PROCESS_FILTER_FLAG_HUE")]
        VideoProcessFilterFlagHue = 0x4,
        [Obsolete("Deprecated in favour of \"Saturation\"")]
        [NativeName("Name", "D3D12_VIDEO_PROCESS_FILTER_FLAG_SATURATION")]
        VideoProcessFilterFlagSaturation = 0x8,
        [Obsolete("Deprecated in favour of \"NoiseReduction\"")]
        [NativeName("Name", "D3D12_VIDEO_PROCESS_FILTER_FLAG_NOISE_REDUCTION")]
        VideoProcessFilterFlagNoiseReduction = 0x10,
        [Obsolete("Deprecated in favour of \"EdgeEnhancement\"")]
        [NativeName("Name", "D3D12_VIDEO_PROCESS_FILTER_FLAG_EDGE_ENHANCEMENT")]
        VideoProcessFilterFlagEdgeEnhancement = 0x20,
        [Obsolete("Deprecated in favour of \"AnamorphicScaling\"")]
        [NativeName("Name", "D3D12_VIDEO_PROCESS_FILTER_FLAG_ANAMORPHIC_SCALING")]
        VideoProcessFilterFlagAnamorphicScaling = 0x40,
        [Obsolete("Deprecated in favour of \"StereoAdjustment\"")]
        [NativeName("Name", "D3D12_VIDEO_PROCESS_FILTER_FLAG_STEREO_ADJUSTMENT")]
        VideoProcessFilterFlagStereoAdjustment = 0x80,
        [NativeName("Name", "D3D12_VIDEO_PROCESS_FILTER_FLAG_NONE")]
        None = 0x0,
        [NativeName("Name", "D3D12_VIDEO_PROCESS_FILTER_FLAG_BRIGHTNESS")]
        Brightness = 0x1,
        [NativeName("Name", "D3D12_VIDEO_PROCESS_FILTER_FLAG_CONTRAST")]
        Contrast = 0x2,
        [NativeName("Name", "D3D12_VIDEO_PROCESS_FILTER_FLAG_HUE")]
        Hue = 0x4,
        [NativeName("Name", "D3D12_VIDEO_PROCESS_FILTER_FLAG_SATURATION")]
        Saturation = 0x8,
        [NativeName("Name", "D3D12_VIDEO_PROCESS_FILTER_FLAG_NOISE_REDUCTION")]
        NoiseReduction = 0x10,
        [NativeName("Name", "D3D12_VIDEO_PROCESS_FILTER_FLAG_EDGE_ENHANCEMENT")]
        EdgeEnhancement = 0x20,
        [NativeName("Name", "D3D12_VIDEO_PROCESS_FILTER_FLAG_ANAMORPHIC_SCALING")]
        AnamorphicScaling = 0x40,
        [NativeName("Name", "D3D12_VIDEO_PROCESS_FILTER_FLAG_STEREO_ADJUSTMENT")]
        StereoAdjustment = 0x80,
    }
}
