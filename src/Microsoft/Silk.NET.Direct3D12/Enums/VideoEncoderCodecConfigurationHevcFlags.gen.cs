// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_FLAGS")]
    public enum VideoEncoderCodecConfigurationHevcFlags : int
    {
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_FLAG_NONE")]
        VideoEncoderCodecConfigurationHevcFlagNone = 0x0,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_FLAG_DISABLE_LOOP_FILTER_ACROSS_SLICES")]
        VideoEncoderCodecConfigurationHevcFlagDisableLoopFilterAcrossSlices = 0x1,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_FLAG_ALLOW_REQUEST_INTRA_CONSTRAINED_SLICES")]
        VideoEncoderCodecConfigurationHevcFlagAllowRequestIntraConstrainedSlices = 0x2,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_FLAG_ENABLE_SAO_FILTER")]
        VideoEncoderCodecConfigurationHevcFlagEnableSaoFilter = 0x4,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_FLAG_ENABLE_LONG_TERM_REFERENCES")]
        VideoEncoderCodecConfigurationHevcFlagEnableLongTermReferences = 0x8,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_FLAG_USE_ASYMETRIC_MOTION_PARTITION")]
        VideoEncoderCodecConfigurationHevcFlagUseAsymetricMotionPartition = 0x10,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_FLAG_ENABLE_TRANSFORM_SKIPPING")]
        VideoEncoderCodecConfigurationHevcFlagEnableTransformSkipping = 0x20,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_FLAG_USE_CONSTRAINED_INTRAPREDICTION")]
        VideoEncoderCodecConfigurationHevcFlagUseConstrainedIntraprediction = 0x40,
    }
}
