// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_VIDEO_ENCODER_RATE_CONTROL_FRAME_ANALYSIS_SUPPORT_FLAGS")]
    public enum VideoEncoderRateControlFrameAnalysisSupportFlags : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_RATE_CONTROL_FRAME_ANALYSIS_SUPPORT_FLAG_NONE")]
        VideoEncoderRateControlFrameAnalysisSupportFlagNone = 0x0,
        [Obsolete("Deprecated in favour of \"IntracodedFrameSupported\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_RATE_CONTROL_FRAME_ANALYSIS_SUPPORT_FLAG_INTRACODED_FRAME_SUPPORTED")]
        VideoEncoderRateControlFrameAnalysisSupportFlagIntracodedFrameSupported = 0x1,
        [Obsolete("Deprecated in favour of \"UnidirInterFrameSupported\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_RATE_CONTROL_FRAME_ANALYSIS_SUPPORT_FLAG_UNIDIR_INTER_FRAME_SUPPORTED")]
        VideoEncoderRateControlFrameAnalysisSupportFlagUnidirInterFrameSupported = 0x2,
        [Obsolete("Deprecated in favour of \"BidirInterFrameSupported\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_RATE_CONTROL_FRAME_ANALYSIS_SUPPORT_FLAG_BIDIR_INTER_FRAME_SUPPORTED")]
        VideoEncoderRateControlFrameAnalysisSupportFlagBidirInterFrameSupported = 0x4,
        [Obsolete("Deprecated in favour of \"ExternalDpbDownscaling\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_RATE_CONTROL_FRAME_ANALYSIS_SUPPORT_FLAG_EXTERNAL_DPB_DOWNSCALING")]
        VideoEncoderRateControlFrameAnalysisSupportFlagExternalDpbDownscaling = 0x8,
        [Obsolete("Deprecated in favour of \"Dynamic1STPassSkip\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_RATE_CONTROL_FRAME_ANALYSIS_SUPPORT_FLAG_DYNAMIC_1ST_PASS_SKIP")]
        VideoEncoderRateControlFrameAnalysisSupportFlagDynamic1STPassSkip = 0x10,
        [Obsolete("Deprecated in favour of \"DynamicDownscaleFactorChangeKeyFrame\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_RATE_CONTROL_FRAME_ANALYSIS_SUPPORT_FLAG_DYNAMIC_DOWNSCALE_FACTOR_CHANGE_KEY_FRAME")]
        VideoEncoderRateControlFrameAnalysisSupportFlagDynamicDownscaleFactorChangeKeyFrame = 0x20,
        [Obsolete("Deprecated in favour of \"Supported\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_RATE_CONTROL_FRAME_ANALYSIS_SUPPORT_FLAG_SUPPORTED")]
        VideoEncoderRateControlFrameAnalysisSupportFlagSupported = 0x7,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_RATE_CONTROL_FRAME_ANALYSIS_SUPPORT_FLAG_NONE")]
        None = 0x0,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_RATE_CONTROL_FRAME_ANALYSIS_SUPPORT_FLAG_INTRACODED_FRAME_SUPPORTED")]
        IntracodedFrameSupported = 0x1,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_RATE_CONTROL_FRAME_ANALYSIS_SUPPORT_FLAG_UNIDIR_INTER_FRAME_SUPPORTED")]
        UnidirInterFrameSupported = 0x2,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_RATE_CONTROL_FRAME_ANALYSIS_SUPPORT_FLAG_BIDIR_INTER_FRAME_SUPPORTED")]
        BidirInterFrameSupported = 0x4,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_RATE_CONTROL_FRAME_ANALYSIS_SUPPORT_FLAG_EXTERNAL_DPB_DOWNSCALING")]
        ExternalDpbDownscaling = 0x8,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_RATE_CONTROL_FRAME_ANALYSIS_SUPPORT_FLAG_DYNAMIC_1ST_PASS_SKIP")]
        Dynamic1STPassSkip = 0x10,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_RATE_CONTROL_FRAME_ANALYSIS_SUPPORT_FLAG_DYNAMIC_DOWNSCALE_FACTOR_CHANGE_KEY_FRAME")]
        DynamicDownscaleFactorChangeKeyFrame = 0x20,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_RATE_CONTROL_FRAME_ANALYSIS_SUPPORT_FLAG_SUPPORTED")]
        Supported = 0x7,
    }
}
