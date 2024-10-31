// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_FRAME_TYPE_FLAGS")]
    public enum VideoEncoderAV1FrameTypeFlags : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_FRAME_TYPE_FLAG_NONE")]
        VideoEncoderAV1FrameTypeFlagNone = 0x0,
        [Obsolete("Deprecated in favour of \"KeyFrame\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_FRAME_TYPE_FLAG_KEY_FRAME")]
        VideoEncoderAV1FrameTypeFlagKeyFrame = 0x1,
        [Obsolete("Deprecated in favour of \"InterFrame\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_FRAME_TYPE_FLAG_INTER_FRAME")]
        VideoEncoderAV1FrameTypeFlagInterFrame = 0x2,
        [Obsolete("Deprecated in favour of \"IntraOnlyFrame\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_FRAME_TYPE_FLAG_INTRA_ONLY_FRAME")]
        VideoEncoderAV1FrameTypeFlagIntraOnlyFrame = 0x4,
        [Obsolete("Deprecated in favour of \"SwitchFrame\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_FRAME_TYPE_FLAG_SWITCH_FRAME")]
        VideoEncoderAV1FrameTypeFlagSwitchFrame = 0x8,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_FRAME_TYPE_FLAG_NONE")]
        None = 0x0,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_FRAME_TYPE_FLAG_KEY_FRAME")]
        KeyFrame = 0x1,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_FRAME_TYPE_FLAG_INTER_FRAME")]
        InterFrame = 0x2,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_FRAME_TYPE_FLAG_INTRA_ONLY_FRAME")]
        IntraOnlyFrame = 0x4,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_FRAME_TYPE_FLAG_SWITCH_FRAME")]
        SwitchFrame = 0x8,
    }
}
