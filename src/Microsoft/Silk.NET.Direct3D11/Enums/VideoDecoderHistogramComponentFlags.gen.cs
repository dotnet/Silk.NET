// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_VIDEO_DECODER_HISTOGRAM_COMPONENT_FLAGS")]
    public enum VideoDecoderHistogramComponentFlags : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "D3D11_VIDEO_DECODER_HISTOGRAM_COMPONENT_FLAG_NONE")]
        VideoDecoderHistogramComponentFlagNone = 0x0,
        [Obsolete("Deprecated in favour of \"Y\"")]
        [NativeName("Name", "D3D11_VIDEO_DECODER_HISTOGRAM_COMPONENT_FLAG_Y")]
        VideoDecoderHistogramComponentFlagY = 0x1,
        [Obsolete("Deprecated in favour of \"U\"")]
        [NativeName("Name", "D3D11_VIDEO_DECODER_HISTOGRAM_COMPONENT_FLAG_U")]
        VideoDecoderHistogramComponentFlagU = 0x2,
        [Obsolete("Deprecated in favour of \"V\"")]
        [NativeName("Name", "D3D11_VIDEO_DECODER_HISTOGRAM_COMPONENT_FLAG_V")]
        VideoDecoderHistogramComponentFlagV = 0x4,
        [Obsolete("Deprecated in favour of \"R\"")]
        [NativeName("Name", "D3D11_VIDEO_DECODER_HISTOGRAM_COMPONENT_FLAG_R")]
        VideoDecoderHistogramComponentFlagR = 0x1,
        [Obsolete("Deprecated in favour of \"G\"")]
        [NativeName("Name", "D3D11_VIDEO_DECODER_HISTOGRAM_COMPONENT_FLAG_G")]
        VideoDecoderHistogramComponentFlagG = 0x2,
        [Obsolete("Deprecated in favour of \"B\"")]
        [NativeName("Name", "D3D11_VIDEO_DECODER_HISTOGRAM_COMPONENT_FLAG_B")]
        VideoDecoderHistogramComponentFlagB = 0x4,
        [Obsolete("Deprecated in favour of \"A\"")]
        [NativeName("Name", "D3D11_VIDEO_DECODER_HISTOGRAM_COMPONENT_FLAG_A")]
        VideoDecoderHistogramComponentFlagA = 0x8,
        [NativeName("Name", "D3D11_VIDEO_DECODER_HISTOGRAM_COMPONENT_FLAG_NONE")]
        None = 0x0,
        [NativeName("Name", "D3D11_VIDEO_DECODER_HISTOGRAM_COMPONENT_FLAG_Y")]
        Y = 0x1,
        [NativeName("Name", "D3D11_VIDEO_DECODER_HISTOGRAM_COMPONENT_FLAG_U")]
        U = 0x2,
        [NativeName("Name", "D3D11_VIDEO_DECODER_HISTOGRAM_COMPONENT_FLAG_V")]
        V = 0x4,
        [NativeName("Name", "D3D11_VIDEO_DECODER_HISTOGRAM_COMPONENT_FLAG_R")]
        R = 0x1,
        [NativeName("Name", "D3D11_VIDEO_DECODER_HISTOGRAM_COMPONENT_FLAG_G")]
        G = 0x2,
        [NativeName("Name", "D3D11_VIDEO_DECODER_HISTOGRAM_COMPONENT_FLAG_B")]
        B = 0x4,
        [NativeName("Name", "D3D11_VIDEO_DECODER_HISTOGRAM_COMPONENT_FLAG_A")]
        A = 0x8,
    }
}
