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
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAG_NONE")]
        VideoEncoderRateControlFlagNone = 0x0,
        [Obsolete("Deprecated in favour of \"EnableDeltaQP\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAG_ENABLE_DELTA_QP")]
        VideoEncoderRateControlFlagEnableDeltaQP = 0x1,
        [Obsolete("Deprecated in favour of \"EnableFrameAnalysis\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAG_ENABLE_FRAME_ANALYSIS")]
        VideoEncoderRateControlFlagEnableFrameAnalysis = 0x2,
        [Obsolete("Deprecated in favour of \"EnableQPRange\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAG_ENABLE_QP_RANGE")]
        VideoEncoderRateControlFlagEnableQPRange = 0x4,
        [Obsolete("Deprecated in favour of \"EnableInitialQP\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAG_ENABLE_INITIAL_QP")]
        VideoEncoderRateControlFlagEnableInitialQP = 0x8,
        [Obsolete("Deprecated in favour of \"EnableMaxFrameSize\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAG_ENABLE_MAX_FRAME_SIZE")]
        VideoEncoderRateControlFlagEnableMaxFrameSize = 0x10,
        [Obsolete("Deprecated in favour of \"EnableVbvSizes\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAG_ENABLE_VBV_SIZES")]
        VideoEncoderRateControlFlagEnableVbvSizes = 0x20,
        [Obsolete("Deprecated in favour of \"EnableExtension1Support\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAG_ENABLE_EXTENSION1_SUPPORT")]
        VideoEncoderRateControlFlagEnableExtension1Support = 0x40,
        [Obsolete("Deprecated in favour of \"EnableQualityVSSpeed\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAG_ENABLE_QUALITY_VS_SPEED")]
        VideoEncoderRateControlFlagEnableQualityVSSpeed = 0x80,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAG_NONE")]
        None = 0x0,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAG_ENABLE_DELTA_QP")]
        EnableDeltaQP = 0x1,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAG_ENABLE_FRAME_ANALYSIS")]
        EnableFrameAnalysis = 0x2,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAG_ENABLE_QP_RANGE")]
        EnableQPRange = 0x4,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAG_ENABLE_INITIAL_QP")]
        EnableInitialQP = 0x8,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAG_ENABLE_MAX_FRAME_SIZE")]
        EnableMaxFrameSize = 0x10,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAG_ENABLE_VBV_SIZES")]
        EnableVbvSizes = 0x20,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAG_ENABLE_EXTENSION1_SUPPORT")]
        EnableExtension1Support = 0x40,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAG_ENABLE_QUALITY_VS_SPEED")]
        EnableQualityVSSpeed = 0x80,
    }
}
