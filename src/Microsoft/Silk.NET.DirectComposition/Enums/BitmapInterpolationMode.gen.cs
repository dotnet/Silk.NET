// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DirectComposition
{
    [Flags]
    [NativeName("Name", "DCOMPOSITION_BITMAP_INTERPOLATION_MODE")]
    public enum BitmapInterpolationMode : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"NearestNeighbor\"")]
        [NativeName("Name", "DCOMPOSITION_BITMAP_INTERPOLATION_MODE_NEAREST_NEIGHBOR")]
        BitmapInterpolationModeNearestNeighbor = 0x0,
        [Obsolete("Deprecated in favour of \"Linear\"")]
        [NativeName("Name", "DCOMPOSITION_BITMAP_INTERPOLATION_MODE_LINEAR")]
        BitmapInterpolationModeLinear = 0x1,
        [Obsolete("Deprecated in favour of \"Inherit\"")]
        [NativeName("Name", "DCOMPOSITION_BITMAP_INTERPOLATION_MODE_INHERIT")]
        BitmapInterpolationModeInherit = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "DCOMPOSITION_BITMAP_INTERPOLATION_MODE_NEAREST_NEIGHBOR")]
        NearestNeighbor = 0x0,
        [NativeName("Name", "DCOMPOSITION_BITMAP_INTERPOLATION_MODE_LINEAR")]
        Linear = 0x1,
        [NativeName("Name", "DCOMPOSITION_BITMAP_INTERPOLATION_MODE_INHERIT")]
        Inherit = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
