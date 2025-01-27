// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_FRAME_TYPE")]
    public enum VideoEncoderAV1FrameType : int
    {
        [Obsolete("Deprecated in favour of \"KeyFrame\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_FRAME_TYPE_KEY_FRAME")]
        VideoEncoderAV1FrameTypeKeyFrame = 0x0,
        [Obsolete("Deprecated in favour of \"InterFrame\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_FRAME_TYPE_INTER_FRAME")]
        VideoEncoderAV1FrameTypeInterFrame = 0x1,
        [Obsolete("Deprecated in favour of \"IntraOnlyFrame\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_FRAME_TYPE_INTRA_ONLY_FRAME")]
        VideoEncoderAV1FrameTypeIntraOnlyFrame = 0x2,
        [Obsolete("Deprecated in favour of \"SwitchFrame\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_FRAME_TYPE_SWITCH_FRAME")]
        VideoEncoderAV1FrameTypeSwitchFrame = 0x3,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_FRAME_TYPE_KEY_FRAME")]
        KeyFrame = 0x0,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_FRAME_TYPE_INTER_FRAME")]
        InterFrame = 0x1,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_FRAME_TYPE_INTRA_ONLY_FRAME")]
        IntraOnlyFrame = 0x2,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_FRAME_TYPE_SWITCH_FRAME")]
        SwitchFrame = 0x3,
    }
}
