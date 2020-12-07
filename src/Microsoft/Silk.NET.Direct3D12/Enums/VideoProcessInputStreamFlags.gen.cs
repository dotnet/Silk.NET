// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_VIDEO_PROCESS_INPUT_STREAM_FLAGS")]
    public enum VideoProcessInputStreamFlags
    {
        [NativeName("Name", "D3D12_VIDEO_PROCESS_INPUT_STREAM_FLAG_NONE")]
        VideoProcessInputStreamFlagNone = 0x0,
        [NativeName("Name", "D3D12_VIDEO_PROCESS_INPUT_STREAM_FLAG_FRAME_DISCONTINUITY")]
        VideoProcessInputStreamFlagFrameDiscontinuity = 0x1,
        [NativeName("Name", "D3D12_VIDEO_PROCESS_INPUT_STREAM_FLAG_FRAME_REPEAT")]
        VideoProcessInputStreamFlagFrameRepeat = 0x2,
    }
}
