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
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_SUPPORT_FLAG_NONE")]
        VideoEncoderSupportFlagNone = 0x0,
        [Obsolete("Deprecated in favour of \"GeneralSupportOK\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_SUPPORT_FLAG_GENERAL_SUPPORT_OK")]
        VideoEncoderSupportFlagGeneralSupportOK = 0x1,
        [Obsolete("Deprecated in favour of \"RateControlReconfigurationAvailable\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_SUPPORT_FLAG_RATE_CONTROL_RECONFIGURATION_AVAILABLE")]
        VideoEncoderSupportFlagRateControlReconfigurationAvailable = 0x2,
        [Obsolete("Deprecated in favour of \"ResolutionReconfigurationAvailable\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_SUPPORT_FLAG_RESOLUTION_RECONFIGURATION_AVAILABLE")]
        VideoEncoderSupportFlagResolutionReconfigurationAvailable = 0x4,
        [Obsolete("Deprecated in favour of \"RateControlVbvSizeConfigAvailable\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_SUPPORT_FLAG_RATE_CONTROL_VBV_SIZE_CONFIG_AVAILABLE")]
        VideoEncoderSupportFlagRateControlVbvSizeConfigAvailable = 0x8,
        [Obsolete("Deprecated in favour of \"RateControlFrameAnalysisAvailable\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_SUPPORT_FLAG_RATE_CONTROL_FRAME_ANALYSIS_AVAILABLE")]
        VideoEncoderSupportFlagRateControlFrameAnalysisAvailable = 0x10,
        [Obsolete("Deprecated in favour of \"ReconstructedFramesRequireTextureArrays\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_SUPPORT_FLAG_RECONSTRUCTED_FRAMES_REQUIRE_TEXTURE_ARRAYS")]
        VideoEncoderSupportFlagReconstructedFramesRequireTextureArrays = 0x20,
        [Obsolete("Deprecated in favour of \"RateControlDeltaQPAvailable\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_SUPPORT_FLAG_RATE_CONTROL_DELTA_QP_AVAILABLE")]
        VideoEncoderSupportFlagRateControlDeltaQPAvailable = 0x40,
        [Obsolete("Deprecated in favour of \"SubregionLayoutReconfigurationAvailable\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_SUPPORT_FLAG_SUBREGION_LAYOUT_RECONFIGURATION_AVAILABLE")]
        VideoEncoderSupportFlagSubregionLayoutReconfigurationAvailable = 0x80,
        [Obsolete("Deprecated in favour of \"RateControlAdjustableQPRangeAvailable\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_SUPPORT_FLAG_RATE_CONTROL_ADJUSTABLE_QP_RANGE_AVAILABLE")]
        VideoEncoderSupportFlagRateControlAdjustableQPRangeAvailable = 0x100,
        [Obsolete("Deprecated in favour of \"RateControlInitialQPAvailable\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_SUPPORT_FLAG_RATE_CONTROL_INITIAL_QP_AVAILABLE")]
        VideoEncoderSupportFlagRateControlInitialQPAvailable = 0x200,
        [Obsolete("Deprecated in favour of \"RateControlMaxFrameSizeAvailable\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_SUPPORT_FLAG_RATE_CONTROL_MAX_FRAME_SIZE_AVAILABLE")]
        VideoEncoderSupportFlagRateControlMaxFrameSizeAvailable = 0x400,
        [Obsolete("Deprecated in favour of \"SequenceGopReconfigurationAvailable\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_SUPPORT_FLAG_SEQUENCE_GOP_RECONFIGURATION_AVAILABLE")]
        VideoEncoderSupportFlagSequenceGopReconfigurationAvailable = 0x800,
        [Obsolete("Deprecated in favour of \"MotionEstimationPrecisionModeLimitAvailable\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_SUPPORT_FLAG_MOTION_ESTIMATION_PRECISION_MODE_LIMIT_AVAILABLE")]
        VideoEncoderSupportFlagMotionEstimationPrecisionModeLimitAvailable = 0x1000,
        [Obsolete("Deprecated in favour of \"RateControlExtension1Support\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_SUPPORT_FLAG_RATE_CONTROL_EXTENSION1_SUPPORT")]
        VideoEncoderSupportFlagRateControlExtension1Support = 0x2000,
        [Obsolete("Deprecated in favour of \"RateControlQualityVSSpeedAvailable\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_SUPPORT_FLAG_RATE_CONTROL_QUALITY_VS_SPEED_AVAILABLE")]
        VideoEncoderSupportFlagRateControlQualityVSSpeedAvailable = 0x4000,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_SUPPORT_FLAG_NONE")]
        None = 0x0,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_SUPPORT_FLAG_GENERAL_SUPPORT_OK")]
        GeneralSupportOK = 0x1,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_SUPPORT_FLAG_RATE_CONTROL_RECONFIGURATION_AVAILABLE")]
        RateControlReconfigurationAvailable = 0x2,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_SUPPORT_FLAG_RESOLUTION_RECONFIGURATION_AVAILABLE")]
        ResolutionReconfigurationAvailable = 0x4,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_SUPPORT_FLAG_RATE_CONTROL_VBV_SIZE_CONFIG_AVAILABLE")]
        RateControlVbvSizeConfigAvailable = 0x8,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_SUPPORT_FLAG_RATE_CONTROL_FRAME_ANALYSIS_AVAILABLE")]
        RateControlFrameAnalysisAvailable = 0x10,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_SUPPORT_FLAG_RECONSTRUCTED_FRAMES_REQUIRE_TEXTURE_ARRAYS")]
        ReconstructedFramesRequireTextureArrays = 0x20,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_SUPPORT_FLAG_RATE_CONTROL_DELTA_QP_AVAILABLE")]
        RateControlDeltaQPAvailable = 0x40,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_SUPPORT_FLAG_SUBREGION_LAYOUT_RECONFIGURATION_AVAILABLE")]
        SubregionLayoutReconfigurationAvailable = 0x80,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_SUPPORT_FLAG_RATE_CONTROL_ADJUSTABLE_QP_RANGE_AVAILABLE")]
        RateControlAdjustableQPRangeAvailable = 0x100,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_SUPPORT_FLAG_RATE_CONTROL_INITIAL_QP_AVAILABLE")]
        RateControlInitialQPAvailable = 0x200,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_SUPPORT_FLAG_RATE_CONTROL_MAX_FRAME_SIZE_AVAILABLE")]
        RateControlMaxFrameSizeAvailable = 0x400,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_SUPPORT_FLAG_SEQUENCE_GOP_RECONFIGURATION_AVAILABLE")]
        SequenceGopReconfigurationAvailable = 0x800,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_SUPPORT_FLAG_MOTION_ESTIMATION_PRECISION_MODE_LIMIT_AVAILABLE")]
        MotionEstimationPrecisionModeLimitAvailable = 0x1000,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_SUPPORT_FLAG_RATE_CONTROL_EXTENSION1_SUPPORT")]
        RateControlExtension1Support = 0x2000,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_SUPPORT_FLAG_RATE_CONTROL_QUALITY_VS_SPEED_AVAILABLE")]
        RateControlQualityVSSpeedAvailable = 0x4000,
    }
}
