// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_VIDEO_PROCESSOR_ROTATION")]
    public enum VideoProcessorRotation : int
    {
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_ROTATION_IDENTITY")]
        VideoProcessorRotationIdentity = 0x0,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_ROTATION_90")]
        VideoProcessorRotation90 = 0x1,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_ROTATION_180")]
        VideoProcessorRotation180 = 0x2,
        [NativeName("Name", "D3D11_VIDEO_PROCESSOR_ROTATION_270")]
        VideoProcessorRotation270 = 0x3,
    }
}
