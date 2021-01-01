// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_VIDEO_SCALE_SUPPORT_FLAGS")]
    public enum VideoScaleSupportFlags : int
    {
        [NativeName("Name", "D3D12_VIDEO_SCALE_SUPPORT_FLAG_NONE")]
        VideoScaleSupportFlagNone = 0x0,
        [NativeName("Name", "D3D12_VIDEO_SCALE_SUPPORT_FLAG_POW2_ONLY")]
        VideoScaleSupportFlagPow2Only = 0x1,
        [NativeName("Name", "D3D12_VIDEO_SCALE_SUPPORT_FLAG_EVEN_DIMENSIONS_ONLY")]
        VideoScaleSupportFlagEvenDimensionsOnly = 0x2,
    }
}
