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
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_H264_FLAG_NONE")]
        VideoEncoderCodecConfigurationSupportH264FlagNone = 0x0,
        [Obsolete("Deprecated in favour of \"CabacEncodingSupport\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_H264_FLAG_CABAC_ENCODING_SUPPORT")]
        VideoEncoderCodecConfigurationSupportH264FlagCabacEncodingSupport = 0x1,
        [Obsolete("Deprecated in favour of \"IntraSliceConstrainedEncodingSupport\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_H264_FLAG_INTRA_SLICE_CONSTRAINED_ENCODING_SUPPORT")]
        VideoEncoderCodecConfigurationSupportH264FlagIntraSliceConstrainedEncodingSupport = 0x2,
        [Obsolete("Deprecated in favour of \"BframeLtrCombinedSupport\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_H264_FLAG_BFRAME_LTR_COMBINED_SUPPORT")]
        VideoEncoderCodecConfigurationSupportH264FlagBframeLtrCombinedSupport = 0x4,
        [Obsolete("Deprecated in favour of \"Adaptive8x8TransformEncodingSupport\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_H264_FLAG_ADAPTIVE_8x8_TRANSFORM_ENCODING_SUPPORT")]
        VideoEncoderCodecConfigurationSupportH264FlagAdaptive8x8TransformEncodingSupport = 0x8,
        [Obsolete("Deprecated in favour of \"DirectSpatialEncodingSupport\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_H264_FLAG_DIRECT_SPATIAL_ENCODING_SUPPORT")]
        VideoEncoderCodecConfigurationSupportH264FlagDirectSpatialEncodingSupport = 0x10,
        [Obsolete("Deprecated in favour of \"DirectTemporalEncodingSupport\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_H264_FLAG_DIRECT_TEMPORAL_ENCODING_SUPPORT")]
        VideoEncoderCodecConfigurationSupportH264FlagDirectTemporalEncodingSupport = 0x20,
        [Obsolete("Deprecated in favour of \"ConstrainedIntrapredictionSupport\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_H264_FLAG_CONSTRAINED_INTRAPREDICTION_SUPPORT")]
        VideoEncoderCodecConfigurationSupportH264FlagConstrainedIntrapredictionSupport = 0x40,
        [Obsolete("Deprecated in favour of \"NumRefIdxActiveOverrideFlagSliceSupport\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_H264_FLAG_NUM_REF_IDX_ACTIVE_OVERRIDE_FLAG_SLICE_SUPPORT")]
        VideoEncoderCodecConfigurationSupportH264FlagNumRefIdxActiveOverrideFlagSliceSupport = 0x80,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_H264_FLAG_NONE")]
        None = 0x0,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_H264_FLAG_CABAC_ENCODING_SUPPORT")]
        CabacEncodingSupport = 0x1,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_H264_FLAG_INTRA_SLICE_CONSTRAINED_ENCODING_SUPPORT")]
        IntraSliceConstrainedEncodingSupport = 0x2,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_H264_FLAG_BFRAME_LTR_COMBINED_SUPPORT")]
        BframeLtrCombinedSupport = 0x4,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_H264_FLAG_ADAPTIVE_8x8_TRANSFORM_ENCODING_SUPPORT")]
        Adaptive8x8TransformEncodingSupport = 0x8,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_H264_FLAG_DIRECT_SPATIAL_ENCODING_SUPPORT")]
        DirectSpatialEncodingSupport = 0x10,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_H264_FLAG_DIRECT_TEMPORAL_ENCODING_SUPPORT")]
        DirectTemporalEncodingSupport = 0x20,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_H264_FLAG_CONSTRAINED_INTRAPREDICTION_SUPPORT")]
        ConstrainedIntrapredictionSupport = 0x40,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_H264_FLAG_NUM_REF_IDX_ACTIVE_OVERRIDE_FLAG_SLICE_SUPPORT")]
        NumRefIdxActiveOverrideFlagSliceSupport = 0x80,
    }
}
