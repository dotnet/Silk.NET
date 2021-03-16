// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_VIDEO_PROCESS_FILTER")]
    public enum VideoProcessFilter : int
    {
        [NativeName("Name", "D3D12_VIDEO_PROCESS_FILTER_BRIGHTNESS")]
        VideoProcessFilterBrightness = 0x0,
        [NativeName("Name", "D3D12_VIDEO_PROCESS_FILTER_CONTRAST")]
        VideoProcessFilterContrast = 0x1,
        [NativeName("Name", "D3D12_VIDEO_PROCESS_FILTER_HUE")]
        VideoProcessFilterHue = 0x2,
        [NativeName("Name", "D3D12_VIDEO_PROCESS_FILTER_SATURATION")]
        VideoProcessFilterSaturation = 0x3,
        [NativeName("Name", "D3D12_VIDEO_PROCESS_FILTER_NOISE_REDUCTION")]
        VideoProcessFilterNoiseReduction = 0x4,
        [NativeName("Name", "D3D12_VIDEO_PROCESS_FILTER_EDGE_ENHANCEMENT")]
        VideoProcessFilterEdgeEnhancement = 0x5,
        [NativeName("Name", "D3D12_VIDEO_PROCESS_FILTER_ANAMORPHIC_SCALING")]
        VideoProcessFilterAnamorphicScaling = 0x6,
        [NativeName("Name", "D3D12_VIDEO_PROCESS_FILTER_STEREO_ADJUSTMENT")]
        VideoProcessFilterStereoAdjustment = 0x7,
    }
}
