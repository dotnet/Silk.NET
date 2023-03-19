// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_TUSIZE")]
    public enum VideoEncoderCodecConfigurationHevcTusize : int
    {
        [Obsolete("Deprecated in favour of \"Tusize4x4\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_TUSIZE_4x4")]
        VideoEncoderCodecConfigurationHevcTusize4x4 = 0x0,
        [Obsolete("Deprecated in favour of \"Tusize8x8\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_TUSIZE_8x8")]
        VideoEncoderCodecConfigurationHevcTusize8x8 = 0x1,
        [Obsolete("Deprecated in favour of \"Tusize16x16\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_TUSIZE_16x16")]
        VideoEncoderCodecConfigurationHevcTusize16x16 = 0x2,
        [Obsolete("Deprecated in favour of \"Tusize32x32\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_TUSIZE_32x32")]
        VideoEncoderCodecConfigurationHevcTusize32x32 = 0x3,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_TUSIZE_4x4")]
        Tusize4x4 = 0x0,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_TUSIZE_8x8")]
        Tusize8x8 = 0x1,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_TUSIZE_16x16")]
        Tusize16x16 = 0x2,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_TUSIZE_32x32")]
        Tusize32x32 = 0x3,
    }
}
