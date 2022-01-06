// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [Flags]
    [NativeName("AnonymousName", "__AnonymousEnum_SDL_render_L111_C9")]
    [NativeName("Name", "SDL_TextureModulate")]
    public enum TextureModulate : int
    {
        [NativeName("Name", "SDL_TEXTUREMODULATE_NONE")]
        TexturemodulateNone = 0x0,
        [NativeName("Name", "SDL_TEXTUREMODULATE_COLOR")]
        TexturemodulateColor = 0x1,
        [NativeName("Name", "SDL_TEXTUREMODULATE_ALPHA")]
        TexturemodulateAlpha = 0x2,
    }
}
