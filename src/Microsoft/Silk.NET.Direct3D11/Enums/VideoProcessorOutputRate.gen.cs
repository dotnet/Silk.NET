// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_VIDEO_PROCESSOR_OUTPUT_RATE")]
    public enum VideoProcessorOutputRate : int
    {
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_OUTPUT_RATE_NORMAL")]
        VideoProcessorOutputRateNormal = 0x0,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_OUTPUT_RATE_HALF")]
        VideoProcessorOutputRateHalf = 0x1,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_OUTPUT_RATE_CUSTOM")]
        VideoProcessorOutputRateCustom = 0x2,
    }
}
