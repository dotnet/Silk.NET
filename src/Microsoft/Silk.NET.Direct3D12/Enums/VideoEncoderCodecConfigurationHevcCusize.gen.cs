// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_CUSIZE")]
    public enum VideoEncoderCodecConfigurationHevcCusize : int
    {
        [Obsolete("Deprecated in favour of \"Cusize8x8\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_CUSIZE_8x8")]
        VideoEncoderCodecConfigurationHevcCusize8x8 = 0x0,
        [Obsolete("Deprecated in favour of \"Cusize16x16\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_CUSIZE_16x16")]
        VideoEncoderCodecConfigurationHevcCusize16x16 = 0x1,
        [Obsolete("Deprecated in favour of \"Cusize32x32\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_CUSIZE_32x32")]
        VideoEncoderCodecConfigurationHevcCusize32x32 = 0x2,
        [Obsolete("Deprecated in favour of \"Cusize64x64\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_CUSIZE_64x64")]
        VideoEncoderCodecConfigurationHevcCusize64x64 = 0x3,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_CUSIZE_8x8")]
        Cusize8x8 = 0x0,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_CUSIZE_16x16")]
        Cusize16x16 = 0x1,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_CUSIZE_32x32")]
        Cusize32x32 = 0x2,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_CUSIZE_64x64")]
        Cusize64x64 = 0x3,
    }
}
