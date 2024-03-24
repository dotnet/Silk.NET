// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [NativeName("AnonymousName", "__AnonymousEnum_SDL_pixels_L79_C9")]
    [NativeName("Name", "SDL_PackedOrder")]
    public enum PackedOrder : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "SDL_PACKEDORDER_NONE")]
        PackedorderNone = 0x0,
        [Obsolete("Deprecated in favour of \"Xrgb\"")]
        [NativeName("Name", "SDL_PACKEDORDER_XRGB")]
        PackedorderXrgb = 0x1,
        [Obsolete("Deprecated in favour of \"Rgbx\"")]
        [NativeName("Name", "SDL_PACKEDORDER_RGBX")]
        PackedorderRgbx = 0x2,
        [Obsolete("Deprecated in favour of \"Argb\"")]
        [NativeName("Name", "SDL_PACKEDORDER_ARGB")]
        PackedorderArgb = 0x3,
        [Obsolete("Deprecated in favour of \"Rgba\"")]
        [NativeName("Name", "SDL_PACKEDORDER_RGBA")]
        PackedorderRgba = 0x4,
        [Obsolete("Deprecated in favour of \"Xbgr\"")]
        [NativeName("Name", "SDL_PACKEDORDER_XBGR")]
        PackedorderXbgr = 0x5,
        [Obsolete("Deprecated in favour of \"Bgrx\"")]
        [NativeName("Name", "SDL_PACKEDORDER_BGRX")]
        PackedorderBgrx = 0x6,
        [Obsolete("Deprecated in favour of \"Abgr\"")]
        [NativeName("Name", "SDL_PACKEDORDER_ABGR")]
        PackedorderAbgr = 0x7,
        [Obsolete("Deprecated in favour of \"Bgra\"")]
        [NativeName("Name", "SDL_PACKEDORDER_BGRA")]
        PackedorderBgra = 0x8,
        [NativeName("Name", "SDL_PACKEDORDER_NONE")]
        None = 0x0,
        [NativeName("Name", "SDL_PACKEDORDER_XRGB")]
        Xrgb = 0x1,
        [NativeName("Name", "SDL_PACKEDORDER_RGBX")]
        Rgbx = 0x2,
        [NativeName("Name", "SDL_PACKEDORDER_ARGB")]
        Argb = 0x3,
        [NativeName("Name", "SDL_PACKEDORDER_RGBA")]
        Rgba = 0x4,
        [NativeName("Name", "SDL_PACKEDORDER_XBGR")]
        Xbgr = 0x5,
        [NativeName("Name", "SDL_PACKEDORDER_BGRX")]
        Bgrx = 0x6,
        [NativeName("Name", "SDL_PACKEDORDER_ABGR")]
        Abgr = 0x7,
        [NativeName("Name", "SDL_PACKEDORDER_BGRA")]
        Bgra = 0x8,
    }
}
