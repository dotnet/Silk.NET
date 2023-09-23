// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WindowsCodecs
{
    [NativeName("Name", "WICBitmapInterpolationMode")]
    public enum BitmapInterpolationMode : int
    {
        [NativeName("Name", "WICBitmapInterpolationModeNearestNeighbor")]
        BitmapInterpolationModeNearestNeighbor = 0x0,
        [NativeName("Name", "WICBitmapInterpolationModeLinear")]
        BitmapInterpolationModeLinear = 0x1,
        [NativeName("Name", "WICBitmapInterpolationModeCubic")]
        BitmapInterpolationModeCubic = 0x2,
        [NativeName("Name", "WICBitmapInterpolationModeFant")]
        BitmapInterpolationModeFant = 0x3,
        [NativeName("Name", "WICBitmapInterpolationModeHighQualityCubic")]
        BitmapInterpolationModeHighQualityCubic = 0x4,
        [NativeName("Name", "WICBITMAPINTERPOLATIONMODE_FORCE_DWORD")]
        ItmapinterpolationmodeForceDword = 0x7FFFFFFF,
    }
}
