// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
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
