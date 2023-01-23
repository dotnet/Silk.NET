// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [NativeName("Name", "D2D1_BITMAPSOURCE_INTERPOLATION_MODE")]
    public enum BitmapsourceInterpolationMode : int
    {
        [Obsolete("Deprecated in favour of \"NearestNeighbor\"")]
        [NativeName("Name", "D2D1_BITMAPSOURCE_INTERPOLATION_MODE_NEAREST_NEIGHBOR")]
        BitmapsourceInterpolationModeNearestNeighbor = 0x0,
        [Obsolete("Deprecated in favour of \"Linear\"")]
        [NativeName("Name", "D2D1_BITMAPSOURCE_INTERPOLATION_MODE_LINEAR")]
        BitmapsourceInterpolationModeLinear = 0x1,
        [Obsolete("Deprecated in favour of \"Cubic\"")]
        [NativeName("Name", "D2D1_BITMAPSOURCE_INTERPOLATION_MODE_CUBIC")]
        BitmapsourceInterpolationModeCubic = 0x2,
        [Obsolete("Deprecated in favour of \"Fant\"")]
        [NativeName("Name", "D2D1_BITMAPSOURCE_INTERPOLATION_MODE_FANT")]
        BitmapsourceInterpolationModeFant = 0x6,
        [Obsolete("Deprecated in favour of \"MipmapLinear\"")]
        [NativeName("Name", "D2D1_BITMAPSOURCE_INTERPOLATION_MODE_MIPMAP_LINEAR")]
        BitmapsourceInterpolationModeMipmapLinear = 0x7,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D2D1_BITMAPSOURCE_INTERPOLATION_MODE_FORCE_DWORD")]
        BitmapsourceInterpolationModeForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "D2D1_BITMAPSOURCE_INTERPOLATION_MODE_NEAREST_NEIGHBOR")]
        NearestNeighbor = 0x0,
        [NativeName("Name", "D2D1_BITMAPSOURCE_INTERPOLATION_MODE_LINEAR")]
        Linear = 0x1,
        [NativeName("Name", "D2D1_BITMAPSOURCE_INTERPOLATION_MODE_CUBIC")]
        Cubic = 0x2,
        [NativeName("Name", "D2D1_BITMAPSOURCE_INTERPOLATION_MODE_FANT")]
        Fant = 0x6,
        [NativeName("Name", "D2D1_BITMAPSOURCE_INTERPOLATION_MODE_MIPMAP_LINEAR")]
        MipmapLinear = 0x7,
        [NativeName("Name", "D2D1_BITMAPSOURCE_INTERPOLATION_MODE_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
