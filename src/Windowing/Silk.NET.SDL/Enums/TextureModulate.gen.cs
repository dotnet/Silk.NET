// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [NativeName("AnonymousName", "__AnonymousEnum_SDL_render_L121_C9")]
    [NativeName("Name", "SDL_TextureModulate")]
    public enum TextureModulate : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "SDL_TEXTUREMODULATE_NONE")]
        TexturemodulateNone = 0x0,
        [Obsolete("Deprecated in favour of \"Color\"")]
        [NativeName("Name", "SDL_TEXTUREMODULATE_COLOR")]
        TexturemodulateColor = 0x1,
        [Obsolete("Deprecated in favour of \"Alpha\"")]
        [NativeName("Name", "SDL_TEXTUREMODULATE_ALPHA")]
        TexturemodulateAlpha = 0x2,
        [NativeName("Name", "SDL_TEXTUREMODULATE_NONE")]
        None = 0x0,
        [NativeName("Name", "SDL_TEXTUREMODULATE_COLOR")]
        Color = 0x1,
        [NativeName("Name", "SDL_TEXTUREMODULATE_ALPHA")]
        Alpha = 0x2,
    }
}
