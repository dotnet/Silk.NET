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
        [Obsolete("Deprecated in favour of \"Y\"")]
        [NativeName("Name", "D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_Y")]
        VideoDecodeHistogramComponentY = 0x0,
        [Obsolete("Deprecated in favour of \"U\"")]
        [NativeName("Name", "D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_U")]
        VideoDecodeHistogramComponentU = 0x1,
        [Obsolete("Deprecated in favour of \"V\"")]
        [NativeName("Name", "D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_V")]
        VideoDecodeHistogramComponentV = 0x2,
        [Obsolete("Deprecated in favour of \"R\"")]
        [NativeName("Name", "D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_R")]
        VideoDecodeHistogramComponentR = 0x0,
        [Obsolete("Deprecated in favour of \"G\"")]
        [NativeName("Name", "D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_G")]
        VideoDecodeHistogramComponentG = 0x1,
        [Obsolete("Deprecated in favour of \"B\"")]
        [NativeName("Name", "D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_B")]
        VideoDecodeHistogramComponentB = 0x2,
        [Obsolete("Deprecated in favour of \"A\"")]
        [NativeName("Name", "D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_A")]
        VideoDecodeHistogramComponentA = 0x3,
        [NativeName("Name", "D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_Y")]
        Y = 0x0,
        [NativeName("Name", "D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_U")]
        U = 0x1,
        [NativeName("Name", "D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_V")]
        V = 0x2,
        [NativeName("Name", "D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_R")]
        R = 0x0,
        [NativeName("Name", "D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_G")]
        G = 0x1,
        [NativeName("Name", "D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_B")]
        B = 0x2,
        [NativeName("Name", "D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_A")]
        A = 0x3,
    }
}
