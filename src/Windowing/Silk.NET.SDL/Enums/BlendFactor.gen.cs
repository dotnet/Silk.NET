// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [NativeName("AnonymousName", "__AnonymousEnum_SDL_blendmode_L78_C9")]
    [NativeName("Name", "SDL_BlendFactor")]
    public enum BlendFactor
    {
        [NativeName("Name", "SDL_BLENDFACTOR_ZERO")]
        BlendfactorZero = 0x1,
        [NativeName("Name", "SDL_BLENDFACTOR_ONE")]
        BlendfactorOne = 0x2,
        [NativeName("Name", "SDL_BLENDFACTOR_SRC_COLOR")]
        BlendfactorSrcColor = 0x3,
        [NativeName("Name", "SDL_BLENDFACTOR_ONE_MINUS_SRC_COLOR")]
        BlendfactorOneMinusSrcColor = 0x4,
        [NativeName("Name", "SDL_BLENDFACTOR_SRC_ALPHA")]
        BlendfactorSrcAlpha = 0x5,
        [NativeName("Name", "SDL_BLENDFACTOR_ONE_MINUS_SRC_ALPHA")]
        BlendfactorOneMinusSrcAlpha = 0x6,
        [NativeName("Name", "SDL_BLENDFACTOR_DST_COLOR")]
        BlendfactorDstColor = 0x7,
        [NativeName("Name", "SDL_BLENDFACTOR_ONE_MINUS_DST_COLOR")]
        BlendfactorOneMinusDstColor = 0x8,
        [NativeName("Name", "SDL_BLENDFACTOR_DST_ALPHA")]
        BlendfactorDstAlpha = 0x9,
        [NativeName("Name", "SDL_BLENDFACTOR_ONE_MINUS_DST_ALPHA")]
        BlendfactorOneMinusDstAlpha = 0xA,
    }
}
