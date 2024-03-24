// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [NativeName("AnonymousName", "__AnonymousEnum_SDL_pixels_L95_C9")]
    [NativeName("Name", "SDL_ArrayOrder")]
    public enum ArrayOrder : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "SDL_ARRAYORDER_NONE")]
        ArrayorderNone = 0x0,
        [Obsolete("Deprecated in favour of \"Rgb\"")]
        [NativeName("Name", "SDL_ARRAYORDER_RGB")]
        ArrayorderRgb = 0x1,
        [Obsolete("Deprecated in favour of \"Rgba\"")]
        [NativeName("Name", "SDL_ARRAYORDER_RGBA")]
        ArrayorderRgba = 0x2,
        [Obsolete("Deprecated in favour of \"Argb\"")]
        [NativeName("Name", "SDL_ARRAYORDER_ARGB")]
        ArrayorderArgb = 0x3,
        [Obsolete("Deprecated in favour of \"Bgr\"")]
        [NativeName("Name", "SDL_ARRAYORDER_BGR")]
        ArrayorderBgr = 0x4,
        [Obsolete("Deprecated in favour of \"Bgra\"")]
        [NativeName("Name", "SDL_ARRAYORDER_BGRA")]
        ArrayorderBgra = 0x5,
        [Obsolete("Deprecated in favour of \"Abgr\"")]
        [NativeName("Name", "SDL_ARRAYORDER_ABGR")]
        ArrayorderAbgr = 0x6,
        [NativeName("Name", "SDL_ARRAYORDER_NONE")]
        None = 0x0,
        [NativeName("Name", "SDL_ARRAYORDER_RGB")]
        Rgb = 0x1,
        [NativeName("Name", "SDL_ARRAYORDER_RGBA")]
        Rgba = 0x2,
        [NativeName("Name", "SDL_ARRAYORDER_ARGB")]
        Argb = 0x3,
        [NativeName("Name", "SDL_ARRAYORDER_BGR")]
        Bgr = 0x4,
        [NativeName("Name", "SDL_ARRAYORDER_BGRA")]
        Bgra = 0x5,
        [NativeName("Name", "SDL_ARRAYORDER_ABGR")]
        Abgr = 0x6,
    }
}
