// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [Flags]
    [NativeName("AnonymousName", "__AnonymousEnum_SDL_pixels_L76_C9")]
    [NativeName("Name", "SDL_PackedOrder")]
    public enum PackedOrder : int
    {
        [NativeName("Name", "SDL_PACKEDORDER_NONE")]
        PackedorderNone = 0x0,
        [NativeName("Name", "SDL_PACKEDORDER_XRGB")]
        PackedorderXrgb = 0x1,
        [NativeName("Name", "SDL_PACKEDORDER_RGBX")]
        PackedorderRgbx = 0x2,
        [NativeName("Name", "SDL_PACKEDORDER_ARGB")]
        PackedorderArgb = 0x3,
        [NativeName("Name", "SDL_PACKEDORDER_RGBA")]
        PackedorderRgba = 0x4,
        [NativeName("Name", "SDL_PACKEDORDER_XBGR")]
        PackedorderXbgr = 0x5,
        [NativeName("Name", "SDL_PACKEDORDER_BGRX")]
        PackedorderBgrx = 0x6,
        [NativeName("Name", "SDL_PACKEDORDER_ABGR")]
        PackedorderAbgr = 0x7,
        [NativeName("Name", "SDL_PACKEDORDER_BGRA")]
        PackedorderBgra = 0x8,
    }
}
