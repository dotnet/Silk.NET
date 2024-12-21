// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_PROFILE")]
    public enum VideoEncoderAV1Profile : int
    {
        [Obsolete("Deprecated in favour of \"Main\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_PROFILE_MAIN")]
        VideoEncoderAV1ProfileMain = 0x0,
        [Obsolete("Deprecated in favour of \"High\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_PROFILE_HIGH")]
        VideoEncoderAV1ProfileHigh = 0x1,
        [Obsolete("Deprecated in favour of \"Professional\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_PROFILE_PROFESSIONAL")]
        VideoEncoderAV1ProfileProfessional = 0x2,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_PROFILE_MAIN")]
        Main = 0x0,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_PROFILE_HIGH")]
        High = 0x1,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_PROFILE_PROFESSIONAL")]
        Professional = 0x2,
    }
}
