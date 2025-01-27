// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_TIER")]
    public enum VideoEncoderAV1Tier : int
    {
        [Obsolete("Deprecated in favour of \"Main\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_TIER_MAIN")]
        VideoEncoderAV1TierMain = 0x0,
        [Obsolete("Deprecated in favour of \"High\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_TIER_HIGH")]
        VideoEncoderAV1TierHigh = 0x1,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_TIER_MAIN")]
        Main = 0x0,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_TIER_HIGH")]
        High = 0x1,
    }
}
