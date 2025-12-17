// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_VIDEO_ENCODER_FRAME_MOTION_SEARCH_MODE")]
    public enum VideoEncoderFrameMotionSearchMode : int
    {
        [Obsolete("Deprecated in favour of \"FullSearch\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_FRAME_MOTION_SEARCH_MODE_FULL_SEARCH")]
        VideoEncoderFrameMotionSearchModeFullSearch = 0x0,
        [Obsolete("Deprecated in favour of \"StartHint\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_FRAME_MOTION_SEARCH_MODE_START_HINT")]
        VideoEncoderFrameMotionSearchModeStartHint = 0x1,
        [Obsolete("Deprecated in favour of \"StartHintLimitedDistance\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_FRAME_MOTION_SEARCH_MODE_START_HINT_LIMITED_DISTANCE")]
        VideoEncoderFrameMotionSearchModeStartHintLimitedDistance = 0x2,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_FRAME_MOTION_SEARCH_MODE_FULL_SEARCH")]
        FullSearch = 0x0,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_FRAME_MOTION_SEARCH_MODE_START_HINT")]
        StartHint = 0x1,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_FRAME_MOTION_SEARCH_MODE_START_HINT_LIMITED_DISTANCE")]
        StartHintLimitedDistance = 0x2,
    }
}
