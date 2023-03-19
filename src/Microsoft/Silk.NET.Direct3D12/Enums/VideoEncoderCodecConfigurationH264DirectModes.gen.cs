// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_DIRECT_MODES")]
    public enum VideoEncoderCodecConfigurationH264DirectModes : int
    {
        [Obsolete("Deprecated in favour of \"Disabled\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_DIRECT_MODES_DISABLED")]
        VideoEncoderCodecConfigurationH264DirectModesDisabled = 0x0,
        [Obsolete("Deprecated in favour of \"Temporal\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_DIRECT_MODES_TEMPORAL")]
        VideoEncoderCodecConfigurationH264DirectModesTemporal = 0x1,
        [Obsolete("Deprecated in favour of \"Spatial\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_DIRECT_MODES_SPATIAL")]
        VideoEncoderCodecConfigurationH264DirectModesSpatial = 0x2,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_DIRECT_MODES_DISABLED")]
        Disabled = 0x0,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_DIRECT_MODES_TEMPORAL")]
        Temporal = 0x1,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264_DIRECT_MODES_SPATIAL")]
        Spatial = 0x2,
    }
}
