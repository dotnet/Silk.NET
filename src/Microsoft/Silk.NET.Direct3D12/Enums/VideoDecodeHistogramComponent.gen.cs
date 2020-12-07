// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT")]
    public enum VideoDecodeHistogramComponent
    {
        [NativeName("Name", "D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_Y")]
        VideoDecodeHistogramComponentY = 0x0,
        [NativeName("Name", "D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_U")]
        VideoDecodeHistogramComponentU = 0x1,
        [NativeName("Name", "D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_V")]
        VideoDecodeHistogramComponentV = 0x2,
        [NativeName("Name", "D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_R")]
        VideoDecodeHistogramComponentR = 0x0,
        [NativeName("Name", "D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_G")]
        VideoDecodeHistogramComponentG = 0x1,
        [NativeName("Name", "D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_B")]
        VideoDecodeHistogramComponentB = 0x2,
        [NativeName("Name", "D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_A")]
        VideoDecodeHistogramComponentA = 0x3,
    }
}
