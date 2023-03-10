// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WGL
{
    [Flags]
    [NativeName("Name", "GLenum")]
    public enum WGLEnum : int
    {
        [NativeName("Name", "WGL_FONT_LINES")]
        FontLines = 0x0,
        [NativeName("Name", "WGL_FONT_POLYGONS")]
        FontPolygons = 0x1,
        [NativeName("Name", "WGL_SWAP_MAIN_PLANE")]
        SwapMainPlane = 0x1,
        [NativeName("Name", "WGL_SWAP_OVERLAY1")]
        SwapOverlay1 = 0x2,
        [NativeName("Name", "WGL_SWAP_OVERLAY2")]
        SwapOverlay2 = 0x4,
        [NativeName("Name", "WGL_SWAP_OVERLAY3")]
        SwapOverlay3 = 0x8,
        [NativeName("Name", "WGL_SWAP_OVERLAY4")]
        SwapOverlay4 = 0x10,
        [NativeName("Name", "WGL_SWAP_OVERLAY5")]
        SwapOverlay5 = 0x20,
        [NativeName("Name", "WGL_SWAP_OVERLAY6")]
        SwapOverlay6 = 0x40,
        [NativeName("Name", "WGL_SWAP_OVERLAY7")]
        SwapOverlay7 = 0x80,
        [NativeName("Name", "WGL_SWAP_OVERLAY8")]
        SwapOverlay8 = 0x100,
        [NativeName("Name", "WGL_SWAP_OVERLAY9")]
        SwapOverlay9 = 0x200,
        [NativeName("Name", "WGL_SWAP_OVERLAY10")]
        SwapOverlay10 = 0x400,
        [NativeName("Name", "WGL_SWAP_OVERLAY11")]
        SwapOverlay11 = 0x800,
        [NativeName("Name", "WGL_SWAP_OVERLAY12")]
        SwapOverlay12 = 0x1000,
        [NativeName("Name", "WGL_SWAP_OVERLAY13")]
        SwapOverlay13 = 0x2000,
        [NativeName("Name", "WGL_SWAP_OVERLAY14")]
        SwapOverlay14 = 0x4000,
        [NativeName("Name", "WGL_SWAP_OVERLAY15")]
        SwapOverlay15 = 0x8000,
        [NativeName("Name", "WGL_SWAP_UNDERLAY1")]
        SwapUnderlay1 = 0x10000,
        [NativeName("Name", "WGL_SWAP_UNDERLAY2")]
        SwapUnderlay2 = 0x20000,
        [NativeName("Name", "WGL_SWAP_UNDERLAY3")]
        SwapUnderlay3 = 0x40000,
        [NativeName("Name", "WGL_SWAP_UNDERLAY4")]
        SwapUnderlay4 = 0x80000,
        [NativeName("Name", "WGL_SWAP_UNDERLAY5")]
        SwapUnderlay5 = 0x100000,
        [NativeName("Name", "WGL_SWAP_UNDERLAY6")]
        SwapUnderlay6 = 0x200000,
        [NativeName("Name", "WGL_SWAP_UNDERLAY7")]
        SwapUnderlay7 = 0x400000,
        [NativeName("Name", "WGL_SWAP_UNDERLAY8")]
        SwapUnderlay8 = 0x800000,
        [NativeName("Name", "WGL_SWAP_UNDERLAY9")]
        SwapUnderlay9 = 0x1000000,
        [NativeName("Name", "WGL_SWAP_UNDERLAY10")]
        SwapUnderlay10 = 0x2000000,
        [NativeName("Name", "WGL_SWAP_UNDERLAY11")]
        SwapUnderlay11 = 0x4000000,
        [NativeName("Name", "WGL_SWAP_UNDERLAY12")]
        SwapUnderlay12 = 0x8000000,
        [NativeName("Name", "WGL_SWAP_UNDERLAY13")]
        SwapUnderlay13 = 0x10000000,
        [NativeName("Name", "WGL_SWAP_UNDERLAY14")]
        SwapUnderlay14 = 0x20000000,
        [NativeName("Name", "WGL_SWAP_UNDERLAY15")]
        SwapUnderlay15 = 0x40000000,
    }
}
