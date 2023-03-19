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
        [NativeName("Name", "D3D12_VIDEO_ENCODER_PROFILE_HEVC_MAIN")]
        Main = 0x0,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_PROFILE_HEVC_MAIN10")]
        Main10 = 0x1,
    }
}
