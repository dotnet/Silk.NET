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
