// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_H264_FLAGS")]
    public enum VideoEncoderCodecConfigurationSupportH264Flags : int
    {
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_H264_FLAG_NONE")]
        VideoEncoderCodecConfigurationSupportH264FlagNone = 0x0,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_H264_FLAG_CABAC_ENCODING_SUPPORT")]
        VideoEncoderCodecConfigurationSupportH264FlagCabacEncodingSupport = 0x1,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_H264_FLAG_INTRA_SLICE_CONSTRAINED_ENCODING_SUPPORT")]
        VideoEncoderCodecConfigurationSupportH264FlagIntraSliceConstrainedEncodingSupport = 0x2,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_H264_FLAG_BFRAME_LTR_COMBINED_SUPPORT")]
        VideoEncoderCodecConfigurationSupportH264FlagBframeLtrCombinedSupport = 0x4,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_H264_FLAG_ADAPTIVE_8x8_TRANSFORM_ENCODING_SUPPORT")]
        VideoEncoderCodecConfigurationSupportH264FlagAdaptive8x8TransformEncodingSupport = 0x8,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_H264_FLAG_DIRECT_SPATIAL_ENCODING_SUPPORT")]
        VideoEncoderCodecConfigurationSupportH264FlagDirectSpatialEncodingSupport = 0x10,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_H264_FLAG_DIRECT_TEMPORAL_ENCODING_SUPPORT")]
        VideoEncoderCodecConfigurationSupportH264FlagDirectTemporalEncodingSupport = 0x20,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_H264_FLAG_CONSTRAINED_INTRAPREDICTION_SUPPORT")]
        VideoEncoderCodecConfigurationSupportH264FlagConstrainedIntrapredictionSupport = 0x40,
    }
}
