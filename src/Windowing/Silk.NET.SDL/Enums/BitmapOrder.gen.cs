// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [NativeName("AnonymousName", "__AnonymousEnum_SDL_pixels_L71_C9")]
    [NativeName("Name", "SDL_BitmapOrder")]
    public enum BitmapOrder : int
    {
        [NativeName("Name", "SDL_BITMAPORDER_NONE")]
        BitmaporderNone = 0x0,
        [NativeName("Name", "SDL_BITMAPORDER_4321")]
        Bitmaporder4321 = 0x1,
        [NativeName("Name", "SDL_BITMAPORDER_1234")]
        Bitmaporder1234 = 0x2,
    }
}
