// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_VIDEO_SCALE_SUPPORT_FLAGS")]
    public enum VideoScaleSupportFlags : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "D3D12_VIDEO_SCALE_SUPPORT_FLAG_NONE")]
        VideoScaleSupportFlagNone = 0x0,
        [Obsolete("Deprecated in favour of \"Pow2Only\"")]
        [NativeName("Name", "D3D12_VIDEO_SCALE_SUPPORT_FLAG_POW2_ONLY")]
        VideoScaleSupportFlagPow2Only = 0x1,
        [Obsolete("Deprecated in favour of \"EvenDimensionsOnly\"")]
        [NativeName("Name", "D3D12_VIDEO_SCALE_SUPPORT_FLAG_EVEN_DIMENSIONS_ONLY")]
        VideoScaleSupportFlagEvenDimensionsOnly = 0x2,
        [NativeName("Name", "D3D12_VIDEO_SCALE_SUPPORT_FLAG_NONE")]
        None = 0x0,
        [NativeName("Name", "D3D12_VIDEO_SCALE_SUPPORT_FLAG_POW2_ONLY")]
        Pow2Only = 0x1,
        [NativeName("Name", "D3D12_VIDEO_SCALE_SUPPORT_FLAG_EVEN_DIMENSIONS_ONLY")]
        EvenDimensionsOnly = 0x2,
    }
}
