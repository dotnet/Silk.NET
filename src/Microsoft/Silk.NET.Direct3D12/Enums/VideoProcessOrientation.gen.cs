// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_VIDEO_PROCESS_ORIENTATION")]
    public enum VideoProcessOrientation : int
    {
        [NativeName("Name", "D3D12_VIDEO_PROCESS_ORIENTATION_DEFAULT")]
        VideoProcessOrientationDefault = 0x0,
        [NativeName("Name", "D3D12_VIDEO_PROCESS_ORIENTATION_FLIP_HORIZONTAL")]
        VideoProcessOrientationFlipHorizontal = 0x1,
        [NativeName("Name", "D3D12_VIDEO_PROCESS_ORIENTATION_CLOCKWISE_90")]
        VideoProcessOrientationClockwise90 = 0x2,
        [NativeName("Name", "D3D12_VIDEO_PROCESS_ORIENTATION_CLOCKWISE_90_FLIP_HORIZONTAL")]
        VideoProcessOrientationClockwise90FlipHorizontal = 0x3,
        [NativeName("Name", "D3D12_VIDEO_PROCESS_ORIENTATION_CLOCKWISE_180")]
        VideoProcessOrientationClockwise180 = 0x4,
        [NativeName("Name", "D3D12_VIDEO_PROCESS_ORIENTATION_FLIP_VERTICAL")]
        VideoProcessOrientationFlipVertical = 0x5,
        [NativeName("Name", "D3D12_VIDEO_PROCESS_ORIENTATION_CLOCKWISE_270")]
        VideoProcessOrientationClockwise270 = 0x6,
        [NativeName("Name", "D3D12_VIDEO_PROCESS_ORIENTATION_CLOCKWISE_270_FLIP_HORIZONTAL")]
        VideoProcessOrientationClockwise270FlipHorizontal = 0x7,
    }
}
