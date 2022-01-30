// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC_FLAGS")]
    public enum VideoEncoderCodecConfigurationSupportHevcFlags : int
    {
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC_FLAG_NONE")]
        VideoEncoderCodecConfigurationSupportHevcFlagNone = 0x0,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC_FLAG_BFRAME_LTR_COMBINED_SUPPORT")]
        VideoEncoderCodecConfigurationSupportHevcFlagBframeLtrCombinedSupport = 0x1,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC_FLAG_INTRA_SLICE_CONSTRAINED_ENCODING_SUPPORT")]
        VideoEncoderCodecConfigurationSupportHevcFlagIntraSliceConstrainedEncodingSupport = 0x2,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC_FLAG_CONSTRAINED_INTRAPREDICTION_SUPPORT")]
        VideoEncoderCodecConfigurationSupportHevcFlagConstrainedIntrapredictionSupport = 0x4,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC_FLAG_SAO_FILTER_SUPPORT")]
        VideoEncoderCodecConfigurationSupportHevcFlagSaoFilterSupport = 0x8,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC_FLAG_ASYMETRIC_MOTION_PARTITION_SUPPORT")]
        VideoEncoderCodecConfigurationSupportHevcFlagAsymetricMotionPartitionSupport = 0x10,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC_FLAG_ASYMETRIC_MOTION_PARTITION_REQUIRED")]
        VideoEncoderCodecConfigurationSupportHevcFlagAsymetricMotionPartitionRequired = 0x20,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC_FLAG_TRANSFORM_SKIP_SUPPORT")]
        VideoEncoderCodecConfigurationSupportHevcFlagTransformSkipSupport = 0x40,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC_FLAG_DISABLING_LOOP_FILTER_ACROSS_SLICES_SUPPORT")]
        VideoEncoderCodecConfigurationSupportHevcFlagDisablingLoopFilterAcrossSlicesSupport = 0x80,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC_FLAG_P_FRAMES_IMPLEMENTED_AS_LOW_DELAY_B_FRAMES")]
        VideoEncoderCodecConfigurationSupportHevcFlagPFramesImplementedAsLowDelayBFrames = 0x100,
    }
}
