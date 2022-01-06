// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT")]
    public enum VideoDecodeHistogramComponent : int
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
