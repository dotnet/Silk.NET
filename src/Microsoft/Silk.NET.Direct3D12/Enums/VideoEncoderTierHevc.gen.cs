// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_VIDEO_ENCODER_TIER_HEVC")]
    public enum VideoEncoderTierHevc : int
    {
        [Obsolete("Deprecated in favour of \"Main\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_TIER_HEVC_MAIN")]
        VideoEncoderTierHevcMain = 0x0,
        [Obsolete("Deprecated in favour of \"High\"")]
        [NativeName("Name", "D3D12_VIDEO_ENCODER_TIER_HEVC_HIGH")]
        VideoEncoderTierHevcHigh = 0x1,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_TIER_HEVC_MAIN")]
        Main = 0x0,
        [NativeName("Name", "D3D12_VIDEO_ENCODER_TIER_HEVC_HIGH")]
        High = 0x1,
    }
}
