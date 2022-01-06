// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAGS")]
    public enum VideoDecodeHistogramComponentFlags : int
    {
        [NativeName("Name", "D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAG_NONE")]
        VideoDecodeHistogramComponentFlagNone = 0x0,
        [NativeName("Name", "D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAG_Y")]
        VideoDecodeHistogramComponentFlagY = 0x1,
        [NativeName("Name", "D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAG_U")]
        VideoDecodeHistogramComponentFlagU = 0x2,
        [NativeName("Name", "D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAG_V")]
        VideoDecodeHistogramComponentFlagV = 0x4,
        [NativeName("Name", "D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAG_R")]
        VideoDecodeHistogramComponentFlagR = 0x1,
        [NativeName("Name", "D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAG_G")]
        VideoDecodeHistogramComponentFlagG = 0x2,
        [NativeName("Name", "D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAG_B")]
        VideoDecodeHistogramComponentFlagB = 0x4,
        [NativeName("Name", "D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAG_A")]
        VideoDecodeHistogramComponentFlagA = 0x8,
    }
}
