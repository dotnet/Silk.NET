// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_VIDEO_DECODER_HISTOGRAM_COMPONENT_FLAGS")]
    public enum VideoDecoderHistogramComponentFlags
    {
        [NativeName("Name", "D3D11_VIDEO_DECODER_HISTOGRAM_COMPONENT_FLAG_NONE")]
        VideoDecoderHistogramComponentFlagNone = 0x0,
        [NativeName("Name", "D3D11_VIDEO_DECODER_HISTOGRAM_COMPONENT_FLAG_Y")]
        VideoDecoderHistogramComponentFlagY = 0x1,
        [NativeName("Name", "D3D11_VIDEO_DECODER_HISTOGRAM_COMPONENT_FLAG_U")]
        VideoDecoderHistogramComponentFlagU = 0x2,
        [NativeName("Name", "D3D11_VIDEO_DECODER_HISTOGRAM_COMPONENT_FLAG_V")]
        VideoDecoderHistogramComponentFlagV = 0x4,
        [NativeName("Name", "D3D11_VIDEO_DECODER_HISTOGRAM_COMPONENT_FLAG_R")]
        VideoDecoderHistogramComponentFlagR = 0x1,
        [NativeName("Name", "D3D11_VIDEO_DECODER_HISTOGRAM_COMPONENT_FLAG_G")]
        VideoDecoderHistogramComponentFlagG = 0x2,
        [NativeName("Name", "D3D11_VIDEO_DECODER_HISTOGRAM_COMPONENT_FLAG_B")]
        VideoDecoderHistogramComponentFlagB = 0x4,
        [NativeName("Name", "D3D11_VIDEO_DECODER_HISTOGRAM_COMPONENT_FLAG_A")]
        VideoDecoderHistogramComponentFlagA = 0x8,
    }
}
