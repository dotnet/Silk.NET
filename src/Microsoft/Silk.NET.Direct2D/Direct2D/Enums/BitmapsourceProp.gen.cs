// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [NativeName("Name", "D2D1_BITMAPSOURCE_PROP")]
    public enum BitmapsourceProp : int
    {
        [NativeName("Name", "D2D1_BITMAPSOURCE_PROP_WIC_BITMAP_SOURCE")]
        WicBitmapSource = 0x0,
        [NativeName("Name", "D2D1_BITMAPSOURCE_PROP_SCALE")]
        Scale = 0x1,
        [NativeName("Name", "D2D1_BITMAPSOURCE_PROP_INTERPOLATION_MODE")]
        InterpolationMode = 0x2,
        [NativeName("Name", "D2D1_BITMAPSOURCE_PROP_ENABLE_DPI_CORRECTION")]
        EnableDpiCorrection = 0x3,
        [NativeName("Name", "D2D1_BITMAPSOURCE_PROP_ALPHA_MODE")]
        AlphaMode = 0x4,
        [NativeName("Name", "D2D1_BITMAPSOURCE_PROP_ORIENTATION")]
        Orientation = 0x5,
        [NativeName("Name", "D2D1_BITMAPSOURCE_PROP_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
