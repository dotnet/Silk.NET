// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRV
{
    [NativeName("Name", "SpvFragmentShadingRateMask_")]
    public enum FragmentShadingRateMask : int
    {
        [NativeName("Name", "SpvFragmentShadingRateMaskNone")]
        MaskNone = 0x0,
        [NativeName("Name", "SpvFragmentShadingRateVertical2PixelsMask")]
        Vertical2PixelsMask = 0x1,
        [NativeName("Name", "SpvFragmentShadingRateVertical4PixelsMask")]
        Vertical4PixelsMask = 0x2,
        [NativeName("Name", "SpvFragmentShadingRateHorizontal2PixelsMask")]
        Horizontal2PixelsMask = 0x4,
        [NativeName("Name", "SpvFragmentShadingRateHorizontal4PixelsMask")]
        Horizontal4PixelsMask = 0x8,
    }
}
