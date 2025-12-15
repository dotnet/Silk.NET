// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_VIDEO_ENCODER_PROFILE_HEVC")]
    public enum VideoEncoderProfileHevc : int
    {
        [Obsolete("Deprecated in favour of \"Main\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_PROFILE_HEVC_MAIN")]
        VideoEncoderProfileHevcMain = 0x0,
        [Obsolete("Deprecated in favour of \"Main10\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_PROFILE_HEVC_MAIN10")]
        VideoEncoderProfileHevcMain10 = 0x1,
        [Obsolete("Deprecated in favour of \"Main12\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_PROFILE_HEVC_MAIN12")]
        VideoEncoderProfileHevcMain12 = 0x2,
        [Obsolete("Deprecated in favour of \"Main10422\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_PROFILE_HEVC_MAIN10_422")]
        VideoEncoderProfileHevcMain10422 = 0x3,
        [Obsolete("Deprecated in favour of \"Main12422\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_PROFILE_HEVC_MAIN12_422")]
        VideoEncoderProfileHevcMain12422 = 0x4,
        [Obsolete("Deprecated in favour of \"Main444\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_PROFILE_HEVC_MAIN_444")]
        VideoEncoderProfileHevcMain444 = 0x5,
        [Obsolete("Deprecated in favour of \"Main10444\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_PROFILE_HEVC_MAIN10_444")]
        VideoEncoderProfileHevcMain10444 = 0x6,
        [Obsolete("Deprecated in favour of \"Main12444\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_PROFILE_HEVC_MAIN12_444")]
        VideoEncoderProfileHevcMain12444 = 0x7,
        [Obsolete("Deprecated in favour of \"Main16444\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_PROFILE_HEVC_MAIN16_444")]
        VideoEncoderProfileHevcMain16444 = 0x8,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_PROFILE_HEVC_MAIN")]
        Main = 0x0,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_PROFILE_HEVC_MAIN10")]
        Main10 = 0x1,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_PROFILE_HEVC_MAIN12")]
        Main12 = 0x2,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_PROFILE_HEVC_MAIN10_422")]
        Main10422 = 0x3,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_PROFILE_HEVC_MAIN12_422")]
        Main12422 = 0x4,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_PROFILE_HEVC_MAIN_444")]
        Main444 = 0x5,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_PROFILE_HEVC_MAIN10_444")]
        Main10444 = 0x6,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_PROFILE_HEVC_MAIN12_444")]
        Main12444 = 0x7,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_PROFILE_HEVC_MAIN16_444")]
        Main16444 = 0x8,
    }
}
