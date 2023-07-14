// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DirectWrite
{
    [NativeName("Name", "DWRITE_PIXEL_GEOMETRY")]
    public enum PixelGeometry : int
    {
        [NativeName("Name", "DWRITE_PIXEL_GEOMETRY_FLAT")]
        Flat = 0x0,
        [NativeName("Name", "DWRITE_PIXEL_GEOMETRY_RGB")]
        Rgb = 0x1,
        [NativeName("Name", "DWRITE_PIXEL_GEOMETRY_BGR")]
        Bgr = 0x2,
    }
}
