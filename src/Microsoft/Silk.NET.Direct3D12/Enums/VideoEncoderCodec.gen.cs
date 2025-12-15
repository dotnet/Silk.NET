// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC")]
    public enum VideoEncoderCodec : int
    {
        [Obsolete("Deprecated in favour of \"H264\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_H264")]
        VideoEncoderCodecH264 = 0x0,
        [Obsolete("Deprecated in favour of \"Hevc\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_HEVC")]
        VideoEncoderCodecHevc = 0x1,
        [Obsolete("Deprecated in favour of \"AV1\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_AV1")]
        VideoEncoderCodecAV1 = 0x2,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_H264")]
        H264 = 0x0,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_HEVC")]
        Hevc = 0x1,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_CODEC_AV1")]
        AV1 = 0x2,
    }
}
