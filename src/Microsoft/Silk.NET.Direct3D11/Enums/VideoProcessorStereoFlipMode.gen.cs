// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_VIDEO_PROCESSOR_STEREO_FLIP_MODE")]
    public enum VideoProcessorStereoFlipMode
    {
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_STEREO_FLIP_NONE")]
        VideoProcessorStereoFlipNone = 0x0,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_STEREO_FLIP_FRAME0")]
        VideoProcessorStereoFlipFrame0 = 0x1,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_STEREO_FLIP_FRAME1")]
        VideoProcessorStereoFlipFrame1 = 0x2,
    }
}
