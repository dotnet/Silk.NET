// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC_FLAGS1")]
    public enum VideoEncoderCodecConfigurationSupportHevcFlags1 : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC_FLAG1_NONE")]
        VideoEncoderCodecConfigurationSupportHevcFlag1None = 0x0,
        [Obsolete("Deprecated in favour of \"SeparateColourPlaneSupport\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC_FLAG1_SEPARATE_COLOUR_PLANE_SUPPORT")]
        VideoEncoderCodecConfigurationSupportHevcFlag1SeparateColourPlaneSupport = 0x1,
        [Obsolete("Deprecated in favour of \"SeparateColourPlaneRequired\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC_FLAG1_SEPARATE_COLOUR_PLANE_REQUIRED")]
        VideoEncoderCodecConfigurationSupportHevcFlag1SeparateColourPlaneRequired = 0x2,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC_FLAG1_NONE")]
        None = 0x0,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC_FLAG1_SEPARATE_COLOUR_PLANE_SUPPORT")]
        SeparateColourPlaneSupport = 0x1,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_HEVC_FLAG1_SEPARATE_COLOUR_PLANE_REQUIRED")]
        SeparateColourPlaneRequired = 0x2,
    }
}
