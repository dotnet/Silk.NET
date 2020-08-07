// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [NativeName("AnonymousName", "__AnonymousEnum_SDL_blendmode_L40_C9")]
    [NativeName("Name", "SDL_BlendMode")]
    public enum BlendMode
    {
        [NativeName("Name", "SDL_BLENDMODE_NONE")]
        BlendmodeNone = 0x0,
        [NativeName("Name", "SDL_BLENDMODE_BLEND")]
        BlendmodeBlend = 0x1,
        [NativeName("Name", "SDL_BLENDMODE_ADD")]
        BlendmodeAdd = 0x2,
        [NativeName("Name", "SDL_BLENDMODE_MOD")]
        BlendmodeMod = 0x4,
        [NativeName("Name", "SDL_BLENDMODE_MUL")]
        BlendmodeMul = 0x8,
        [NativeName("Name", "SDL_BLENDMODE_INVALID")]
        BlendmodeInvalid = 0x7FFFFFFF,
    }
}
