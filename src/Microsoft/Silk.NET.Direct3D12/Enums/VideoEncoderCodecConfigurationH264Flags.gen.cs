// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_FLAGS")]
    public enum VideoEncoderCodecConfigurationH264Flags : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_FLAG_NONE")]
        VideoEncoderCodecConfigurationH264FlagNone = 0x0,
        [Obsolete("Deprecated in favour of \"UseConstrainedIntraprediction\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_FLAG_USE_CONSTRAINED_INTRAPREDICTION")]
        VideoEncoderCodecConfigurationH264FlagUseConstrainedIntraprediction = 0x1,
        [Obsolete("Deprecated in favour of \"UseAdaptive8x8Transform\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_FLAG_USE_ADAPTIVE_8x8_TRANSFORM")]
        VideoEncoderCodecConfigurationH264FlagUseAdaptive8x8Transform = 0x2,
        [Obsolete("Deprecated in favour of \"EnableCabacEncoding\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_FLAG_ENABLE_CABAC_ENCODING")]
        VideoEncoderCodecConfigurationH264FlagEnableCabacEncoding = 0x4,
        [Obsolete("Deprecated in favour of \"AllowRequestIntraConstrainedSlices\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_FLAG_ALLOW_REQUEST_INTRA_CONSTRAINED_SLICES")]
        VideoEncoderCodecConfigurationH264FlagAllowRequestIntraConstrainedSlices = 0x8,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_FLAG_NONE")]
        None = 0x0,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_FLAG_USE_CONSTRAINED_INTRAPREDICTION")]
        UseConstrainedIntraprediction = 0x1,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_FLAG_USE_ADAPTIVE_8x8_TRANSFORM")]
        UseAdaptive8x8Transform = 0x2,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_FLAG_ENABLE_CABAC_ENCODING")]
        EnableCabacEncoding = 0x4,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_FLAG_ALLOW_REQUEST_INTRA_CONSTRAINED_SLICES")]
        AllowRequestIntraConstrainedSlices = 0x8,
    }
}
