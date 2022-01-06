// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [Flags]
    [NativeName("AnonymousName", "__AnonymousEnum_SDL_pixels_L92_C9")]
    [NativeName("Name", "SDL_ArrayOrder")]
    public enum ArrayOrder : int
    {
        [NativeName("Name", "SDL_ARRAYORDER_NONE")]
        ArrayorderNone = 0x0,
        [NativeName("Name", "SDL_ARRAYORDER_RGB")]
        ArrayorderRgb = 0x1,
        [NativeName("Name", "SDL_ARRAYORDER_RGBA")]
        ArrayorderRgba = 0x2,
        [NativeName("Name", "SDL_ARRAYORDER_ARGB")]
        ArrayorderArgb = 0x3,
        [NativeName("Name", "SDL_ARRAYORDER_BGR")]
        ArrayorderBgr = 0x4,
        [NativeName("Name", "SDL_ARRAYORDER_BGRA")]
        ArrayorderBgra = 0x5,
        [NativeName("Name", "SDL_ARRAYORDER_ABGR")]
        ArrayorderAbgr = 0x6,
    }
}
