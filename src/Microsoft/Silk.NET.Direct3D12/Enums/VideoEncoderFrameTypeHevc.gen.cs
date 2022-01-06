// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_VIDEO_ENCODER_FRAME_TYPE_HEVC")]
    public enum VideoEncoderFrameTypeHevc : int
    {
        [NativeName("Name", "D3D12_VIDEO_ENCODER_FRAME_TYPE_HEVC_I_FRAME")]
        VideoEncoderFrameTypeHevcIFrame = 0x0,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_FRAME_TYPE_HEVC_P_FRAME")]
        VideoEncoderFrameTypeHevcPFrame = 0x1,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_FRAME_TYPE_HEVC_B_FRAME")]
        VideoEncoderFrameTypeHevcBFrame = 0x2,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_FRAME_TYPE_HEVC_IDR_FRAME")]
        VideoEncoderFrameTypeHevcIdrFrame = 0x3,
    }
}
