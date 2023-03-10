// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [Flags]
    [NativeName("Name", "D3D11_VIDEO_DECODER_HISTOGRAM_COMPONENT")]
    public enum VideoDecoderHistogramComponent : int
    {
        [Obsolete("Deprecated in favour of \"Y\"")]
        [NativeName("Name", "D3D11_VIDEO_DECODER_HISTOGRAM_COMPONENT_Y")]
        VideoDecoderHistogramComponentY = 0x0,
        [Obsolete("Deprecated in favour of \"U\"")]
        [NativeName("Name", "D3D11_VIDEO_DECODER_HISTOGRAM_COMPONENT_U")]
        VideoDecoderHistogramComponentU = 0x1,
        [Obsolete("Deprecated in favour of \"V\"")]
        [NativeName("Name", "D3D11_VIDEO_DECODER_HISTOGRAM_COMPONENT_V")]
        VideoDecoderHistogramComponentV = 0x2,
        [Obsolete("Deprecated in favour of \"R\"")]
        [NativeName("Name", "D3D11_VIDEO_DECODER_HISTOGRAM_COMPONENT_R")]
        VideoDecoderHistogramComponentR = 0x0,
        [Obsolete("Deprecated in favour of \"G\"")]
        [NativeName("Name", "D3D11_VIDEO_DECODER_HISTOGRAM_COMPONENT_G")]
        VideoDecoderHistogramComponentG = 0x1,
        [Obsolete("Deprecated in favour of \"B\"")]
        [NativeName("Name", "D3D11_VIDEO_DECODER_HISTOGRAM_COMPONENT_B")]
        VideoDecoderHistogramComponentB = 0x2,
        [Obsolete("Deprecated in favour of \"A\"")]
        [NativeName("Name", "D3D11_VIDEO_DECODER_HISTOGRAM_COMPONENT_A")]
        VideoDecoderHistogramComponentA = 0x3,
        [NativeName("Name", "D3D11_VIDEO_DECODER_HISTOGRAM_COMPONENT_Y")]
        Y = 0x0,
        [NativeName("Name", "D3D11_VIDEO_DECODER_HISTOGRAM_COMPONENT_U")]
        U = 0x1,
        [NativeName("Name", "D3D11_VIDEO_DECODER_HISTOGRAM_COMPONENT_V")]
        V = 0x2,
        [NativeName("Name", "D3D11_VIDEO_DECODER_HISTOGRAM_COMPONENT_R")]
        R = 0x0,
        [NativeName("Name", "D3D11_VIDEO_DECODER_HISTOGRAM_COMPONENT_G")]
        G = 0x1,
        [NativeName("Name", "D3D11_VIDEO_DECODER_HISTOGRAM_COMPONENT_B")]
        B = 0x2,
        [NativeName("Name", "D3D11_VIDEO_DECODER_HISTOGRAM_COMPONENT_A")]
        A = 0x3,
    }
}
