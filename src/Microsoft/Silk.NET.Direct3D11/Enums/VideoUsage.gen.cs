// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_VIDEO_USAGE")]
    public enum VideoUsage
    {
        [NativeName("Name", "D3D11_VIDEO_USAGE_PLAYBACK_NORMAL")]
        VideoUsagePlaybackNormal = 0x0,
        [NativeName("Name", "D3D11_VIDEO_USAGE_OPTIMAL_SPEED")]
        VideoUsageOptimalSpeed = 0x1,
        [NativeName("Name", "D3D11_VIDEO_USAGE_OPTIMAL_QUALITY")]
        VideoUsageOptimalQuality = 0x2,
    }
}
