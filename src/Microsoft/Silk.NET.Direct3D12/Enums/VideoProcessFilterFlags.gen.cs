// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_VIDEO_PROCESS_FILTER_FLAGS")]
    public enum VideoProcessFilterFlags
    {
        [NativeName("Name", "D3D12_VIDEO_PROCESS_FILTER_FLAG_NONE")]
        VideoProcessFilterFlagNone = 0x0,
        [NativeName("Name", "D3D12_VIDEO_PROCESS_FILTER_FLAG_BRIGHTNESS")]
        VideoProcessFilterFlagBrightness = 0x1,
        [NativeName("Name", "D3D12_VIDEO_PROCESS_FILTER_FLAG_CONTRAST")]
        VideoProcessFilterFlagContrast = 0x2,
        [NativeName("Name", "D3D12_VIDEO_PROCESS_FILTER_FLAG_HUE")]
        VideoProcessFilterFlagHue = 0x4,
        [NativeName("Name", "D3D12_VIDEO_PROCESS_FILTER_FLAG_SATURATION")]
        VideoProcessFilterFlagSaturation = 0x8,
        [NativeName("Name", "D3D12_VIDEO_PROCESS_FILTER_FLAG_NOISE_REDUCTION")]
        VideoProcessFilterFlagNoiseReduction = 0x10,
        [NativeName("Name", "D3D12_VIDEO_PROCESS_FILTER_FLAG_EDGE_ENHANCEMENT")]
        VideoProcessFilterFlagEdgeEnhancement = 0x20,
        [NativeName("Name", "D3D12_VIDEO_PROCESS_FILTER_FLAG_ANAMORPHIC_SCALING")]
        VideoProcessFilterFlagAnamorphicScaling = 0x40,
        [NativeName("Name", "D3D12_VIDEO_PROCESS_FILTER_FLAG_STEREO_ADJUSTMENT")]
        VideoProcessFilterFlagStereoAdjustment = 0x80,
    }
}
