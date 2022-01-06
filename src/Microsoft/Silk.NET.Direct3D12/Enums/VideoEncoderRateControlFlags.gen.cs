// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAGS")]
    public enum VideoEncoderRateControlFlags : int
    {
        [NativeName("Name", "D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAG_NONE")]
        VideoEncoderRateControlFlagNone = 0x0,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAG_ENABLE_DELTA_QP")]
        VideoEncoderRateControlFlagEnableDeltaQP = 0x1,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAG_ENABLE_FRAME_ANALYSIS")]
        VideoEncoderRateControlFlagEnableFrameAnalysis = 0x2,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAG_ENABLE_QP_RANGE")]
        VideoEncoderRateControlFlagEnableQPRange = 0x4,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAG_ENABLE_INITIAL_QP")]
        VideoEncoderRateControlFlagEnableInitialQP = 0x8,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAG_ENABLE_MAX_FRAME_SIZE")]
        VideoEncoderRateControlFlagEnableMaxFrameSize = 0x10,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAG_ENABLE_VBV_SIZES")]
        VideoEncoderRateControlFlagEnableVbvSizes = 0x20,
    }
}
