// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_VIDEO_ENCODER_PROFILE_HEVC")]
    public enum VideoEncoderProfileHevc : int
    {
        [NativeName("Name", "D3D12_VIDEO_ENCODER_PROFILE_HEVC_MAIN")]
        VideoEncoderProfileHevcMain = 0x0,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_PROFILE_HEVC_MAIN10")]
        VideoEncoderProfileHevcMain10 = 0x1,
    }
}
