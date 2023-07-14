// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRV
{
    [NativeName("Name", "SpvFragmentShadingRateShift_")]
    public enum FragmentShadingRateShift : int
    {
        [NativeName("Name", "SpvFragmentShadingRateVertical2PixelsShift")]
        Vertical2PixelsShift = 0x0,
        [NativeName("Name", "SpvFragmentShadingRateVertical4PixelsShift")]
        Vertical4PixelsShift = 0x1,
        [NativeName("Name", "SpvFragmentShadingRateHorizontal2PixelsShift")]
        Horizontal2PixelsShift = 0x2,
        [NativeName("Name", "SpvFragmentShadingRateHorizontal4PixelsShift")]
        Horizontal4PixelsShift = 0x3,
        [NativeName("Name", "SpvFragmentShadingRateMax")]
        Max = 0x7FFFFFFF,
    }
}
