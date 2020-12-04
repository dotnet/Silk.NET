// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_VIDEO_PROCESSOR_NOMINAL_RANGE")]
    public enum VideoProcessorNominalRange
    {
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_NOMINAL_RANGE_UNDEFINED")]
        VideoProcessorNominalRangeUndefined = 0x0,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_NOMINAL_RANGE_16_235")]
        VideoProcessorNominalRange16235 = 0x1,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_NOMINAL_RANGE_0_255")]
        VideoProcessorNominalRange0255 = 0x2,
    }
}
