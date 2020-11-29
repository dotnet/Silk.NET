// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_VIDEO_PROCESSOR_FILTER")]
    public enum VideoProcessorFilter
    {
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_FILTER_BRIGHTNESS")]
        VideoProcessorFilterBrightness = 0x0,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_FILTER_CONTRAST")]
        VideoProcessorFilterContrast = 0x1,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_FILTER_HUE")]
        VideoProcessorFilterHue = 0x2,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_FILTER_SATURATION")]
        VideoProcessorFilterSaturation = 0x3,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_FILTER_NOISE_REDUCTION")]
        VideoProcessorFilterNoiseReduction = 0x4,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_FILTER_EDGE_ENHANCEMENT")]
        VideoProcessorFilterEdgeEnhancement = 0x5,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_FILTER_ANAMORPHIC_SCALING")]
        VideoProcessorFilterAnamorphicScaling = 0x6,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_FILTER_STEREO_ADJUSTMENT")]
        VideoProcessorFilterStereoAdjustment = 0x7,
    }
}
