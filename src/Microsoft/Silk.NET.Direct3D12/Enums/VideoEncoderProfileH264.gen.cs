// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_VIDEO_ENCODER_PROFILE_H264")]
    public enum VideoEncoderProfileH264 : int
    {
        [Obsolete("Deprecated in favour of \"Main\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_PROFILE_H264_MAIN")]
        VideoEncoderProfileH264Main = 0x0,
        [Obsolete("Deprecated in favour of \"High\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_PROFILE_H264_HIGH")]
        VideoEncoderProfileH264High = 0x1,
        [Obsolete("Deprecated in favour of \"High10\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_PROFILE_H264_HIGH_10")]
        VideoEncoderProfileH264High10 = 0x2,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_PROFILE_H264_MAIN")]
        Main = 0x0,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_PROFILE_H264_HIGH")]
        High = 0x1,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_PROFILE_H264_HIGH_10")]
        High10 = 0x2,
    }
}
