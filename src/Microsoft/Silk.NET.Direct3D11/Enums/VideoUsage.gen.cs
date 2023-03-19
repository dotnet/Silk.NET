// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_VIDEO_USAGE")]
    public enum VideoUsage : int
    {
        [Obsolete("Deprecated in favour of \"PlaybackNormal\"")]
        [NativeName("Name", "D3D11_VIDEO_USAGE_PLAYBACK_NORMAL")]
        VideoUsagePlaybackNormal = 0x0,
        [Obsolete("Deprecated in favour of \"OptimalSpeed\"")]
        [NativeName("Name", "D3D11_VIDEO_USAGE_OPTIMAL_SPEED")]
        VideoUsageOptimalSpeed = 0x1,
        [Obsolete("Deprecated in favour of \"OptimalQuality\"")]
        [NativeName("Name", "D3D11_VIDEO_USAGE_OPTIMAL_QUALITY")]
        VideoUsageOptimalQuality = 0x2,
        [NativeName("Name", "D3D11_VIDEO_USAGE_PLAYBACK_NORMAL")]
        PlaybackNormal = 0x0,
        [NativeName("Name", "D3D11_VIDEO_USAGE_OPTIMAL_SPEED")]
        OptimalSpeed = 0x1,
        [NativeName("Name", "D3D11_VIDEO_USAGE_OPTIMAL_QUALITY")]
        OptimalQuality = 0x2,
    }
}
