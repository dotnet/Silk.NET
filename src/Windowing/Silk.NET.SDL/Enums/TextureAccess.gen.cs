// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [NativeName("AnonymousName", "__AnonymousEnum_SDL_render_L101_C9")]
    [NativeName("Name", "SDL_TextureAccess")]
    public enum TextureAccess : int
    {
        [NativeName("Name", "SDL_TEXTUREACCESS_STATIC")]
        TextureaccessStatic = 0x0,
        [NativeName("Name", "SDL_TEXTUREACCESS_STREAMING")]
        TextureaccessStreaming = 0x1,
        [NativeName("Name", "SDL_TEXTUREACCESS_TARGET")]
        TextureaccessTarget = 0x2,
    }
}
