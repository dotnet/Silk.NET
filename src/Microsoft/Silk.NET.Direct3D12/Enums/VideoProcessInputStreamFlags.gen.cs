// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_VIDEO_PROCESS_INPUT_STREAM_FLAGS")]
    public enum VideoProcessInputStreamFlags : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "D3D12_VIDEO_PROCESS_INPUT_STREAM_FLAG_NONE")]
        VideoProcessInputStreamFlagNone = 0x0,
        [Obsolete("Deprecated in favour of \"FrameDiscontinuity\"")]
        [NativeName("Name", "D3D12_VIDEO_PROCESS_INPUT_STREAM_FLAG_FRAME_DISCONTINUITY")]
        VideoProcessInputStreamFlagFrameDiscontinuity = 0x1,
        [Obsolete("Deprecated in favour of \"FrameRepeat\"")]
        [NativeName("Name", "D3D12_VIDEO_PROCESS_INPUT_STREAM_FLAG_FRAME_REPEAT")]
        VideoProcessInputStreamFlagFrameRepeat = 0x2,
        [NativeName("Name", "D3D12_VIDEO_PROCESS_INPUT_STREAM_FLAG_NONE")]
        None = 0x0,
        [NativeName("Name", "D3D12_VIDEO_PROCESS_INPUT_STREAM_FLAG_FRAME_DISCONTINUITY")]
        FrameDiscontinuity = 0x1,
        [NativeName("Name", "D3D12_VIDEO_PROCESS_INPUT_STREAM_FLAG_FRAME_REPEAT")]
        FrameRepeat = 0x2,
    }
}
