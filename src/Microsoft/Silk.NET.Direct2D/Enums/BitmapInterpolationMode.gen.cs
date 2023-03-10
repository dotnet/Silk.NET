// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [Flags]
    [NativeName("Name", "D2D1_BITMAP_INTERPOLATION_MODE")]
    public enum BitmapInterpolationMode : int
    {
        [Obsolete("Deprecated in favour of \"NearestNeighbor\"")]
        [NativeName("Name", "D2D1_BITMAP_INTERPOLATION_MODE_NEAREST_NEIGHBOR")]
        BitmapInterpolationModeNearestNeighbor = 0x0,
        [Obsolete("Deprecated in favour of \"Linear\"")]
        [NativeName("Name", "D2D1_BITMAP_INTERPOLATION_MODE_LINEAR")]
        BitmapInterpolationModeLinear = 0x1,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D2D1_BITMAP_INTERPOLATION_MODE_FORCE_DWORD")]
        BitmapInterpolationModeForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "D2D1_BITMAP_INTERPOLATION_MODE_NEAREST_NEIGHBOR")]
        NearestNeighbor = 0x0,
        [NativeName("Name", "D2D1_BITMAP_INTERPOLATION_MODE_LINEAR")]
        Linear = 0x1,
        [NativeName("Name", "D2D1_BITMAP_INTERPOLATION_MODE_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
