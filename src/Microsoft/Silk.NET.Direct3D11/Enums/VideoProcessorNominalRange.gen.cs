// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_VIDEO_PROCESSOR_NOMINAL_RANGE")]
    public enum VideoProcessorNominalRange : int
    {
        [Obsolete("Deprecated in favour of \"RangeUndefined\"")]
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_NOMINAL_RANGE_UNDEFINED")]
        VideoProcessorNominalRangeUndefined = 0x0,
        [Obsolete("Deprecated in favour of \"Range16235\"")]
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_NOMINAL_RANGE_16_235")]
        VideoProcessorNominalRange16235 = 0x1,
        [Obsolete("Deprecated in favour of \"Range0255\"")]
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_NOMINAL_RANGE_0_255")]
        VideoProcessorNominalRange0255 = 0x2,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_NOMINAL_RANGE_UNDEFINED")]
        RangeUndefined = 0x0,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_NOMINAL_RANGE_16_235")]
        Range16235 = 0x1,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_NOMINAL_RANGE_0_255")]
        Range0255 = 0x2,
    }
}
