// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_VIDEO_ENCODER_SUPPORT_FLAGS")]
    public enum VideoEncoderSupportFlags : int
    {
        [NativeName("Name", "D3D12_VIDEO_ENCODER_SUPPORT_FLAG_NONE")]
        VideoEncoderSupportFlagNone = 0x0,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_SUPPORT_FLAG_GENERAL_SUPPORT_OK")]
        VideoEncoderSupportFlagGeneralSupportOK = 0x1,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_SUPPORT_FLAG_RATE_CONTROL_RECONFIGURATION_AVAILABLE")]
        VideoEncoderSupportFlagRateControlReconfigurationAvailable = 0x2,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_SUPPORT_FLAG_RESOLUTION_RECONFIGURATION_AVAILABLE")]
        VideoEncoderSupportFlagResolutionReconfigurationAvailable = 0x4,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_SUPPORT_FLAG_RATE_CONTROL_VBV_SIZE_CONFIG_AVAILABLE")]
        VideoEncoderSupportFlagRateControlVbvSizeConfigAvailable = 0x8,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_SUPPORT_FLAG_RATE_CONTROL_FRAME_ANALYSIS_AVAILABLE")]
        VideoEncoderSupportFlagRateControlFrameAnalysisAvailable = 0x10,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_SUPPORT_FLAG_RECONSTRUCTED_FRAMES_REQUIRE_TEXTURE_ARRAYS")]
        VideoEncoderSupportFlagReconstructedFramesRequireTextureArrays = 0x20,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_SUPPORT_FLAG_RATE_CONTROL_DELTA_QP_AVAILABLE")]
        VideoEncoderSupportFlagRateControlDeltaQPAvailable = 0x40,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_SUPPORT_FLAG_SUBREGION_LAYOUT_RECONFIGURATION_AVAILABLE")]
        VideoEncoderSupportFlagSubregionLayoutReconfigurationAvailable = 0x80,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_SUPPORT_FLAG_RATE_CONTROL_ADJUSTABLE_QP_RANGE_AVAILABLE")]
        VideoEncoderSupportFlagRateControlAdjustableQPRangeAvailable = 0x100,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_SUPPORT_FLAG_RATE_CONTROL_INITIAL_QP_AVAILABLE")]
        VideoEncoderSupportFlagRateControlInitialQPAvailable = 0x200,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_SUPPORT_FLAG_RATE_CONTROL_MAX_FRAME_SIZE_AVAILABLE")]
        VideoEncoderSupportFlagRateControlMaxFrameSizeAvailable = 0x400,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_SUPPORT_FLAG_SEQUENCE_GOP_RECONFIGURATION_AVAILABLE")]
        VideoEncoderSupportFlagSequenceGopReconfigurationAvailable = 0x800,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_SUPPORT_FLAG_MOTION_ESTIMATION_PRECISION_MODE_LIMIT_AVAILABLE")]
        VideoEncoderSupportFlagMotionEstimationPrecisionModeLimitAvailable = 0x1000,
    }
}
