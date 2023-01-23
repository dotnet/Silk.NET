// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [NativeName("AnonymousName", "__AnonymousEnum_SDL_blendmode_L77_C9")]
    [NativeName("Name", "SDL_BlendFactor")]
    public enum BlendFactor : int
    {
        [Obsolete("Deprecated in favour of \"Zero\"")]
        [NativeName("Name", "SDL_BLENDFACTOR_ZERO")]
        BlendfactorZero = 0x1,
        [Obsolete("Deprecated in favour of \"One\"")]
        [NativeName("Name", "SDL_BLENDFACTOR_ONE")]
        BlendfactorOne = 0x2,
        [Obsolete("Deprecated in favour of \"SrcColor\"")]
        [NativeName("Name", "SDL_BLENDFACTOR_SRC_COLOR")]
        BlendfactorSrcColor = 0x3,
        [Obsolete("Deprecated in favour of \"OneMinusSrcColor\"")]
        [NativeName("Name", "SDL_BLENDFACTOR_ONE_MINUS_SRC_COLOR")]
        BlendfactorOneMinusSrcColor = 0x4,
        [Obsolete("Deprecated in favour of \"SrcAlpha\"")]
        [NativeName("Name", "SDL_BLENDFACTOR_SRC_ALPHA")]
        BlendfactorSrcAlpha = 0x5,
        [Obsolete("Deprecated in favour of \"OneMinusSrcAlpha\"")]
        [NativeName("Name", "SDL_BLENDFACTOR_ONE_MINUS_SRC_ALPHA")]
        BlendfactorOneMinusSrcAlpha = 0x6,
        [Obsolete("Deprecated in favour of \"DstColor\"")]
        [NativeName("Name", "SDL_BLENDFACTOR_DST_COLOR")]
        BlendfactorDstColor = 0x7,
        [Obsolete("Deprecated in favour of \"OneMinusDstColor\"")]
        [NativeName("Name", "SDL_BLENDFACTOR_ONE_MINUS_DST_COLOR")]
        BlendfactorOneMinusDstColor = 0x8,
        [Obsolete("Deprecated in favour of \"DstAlpha\"")]
        [NativeName("Name", "SDL_BLENDFACTOR_DST_ALPHA")]
        BlendfactorDstAlpha = 0x9,
        [Obsolete("Deprecated in favour of \"OneMinusDstAlpha\"")]
        [NativeName("Name", "SDL_BLENDFACTOR_ONE_MINUS_DST_ALPHA")]
        BlendfactorOneMinusDstAlpha = 0xA,
        [NativeName("Name", "SDL_BLENDFACTOR_ZERO")]
        Zero = 0x1,
        [NativeName("Name", "SDL_BLENDFACTOR_ONE")]
        One = 0x2,
        [NativeName("Name", "SDL_BLENDFACTOR_SRC_COLOR")]
        SrcColor = 0x3,
        [NativeName("Name", "SDL_BLENDFACTOR_ONE_MINUS_SRC_COLOR")]
        OneMinusSrcColor = 0x4,
        [NativeName("Name", "SDL_BLENDFACTOR_SRC_ALPHA")]
        SrcAlpha = 0x5,
        [NativeName("Name", "SDL_BLENDFACTOR_ONE_MINUS_SRC_ALPHA")]
        OneMinusSrcAlpha = 0x6,
        [NativeName("Name", "SDL_BLENDFACTOR_DST_COLOR")]
        DstColor = 0x7,
        [NativeName("Name", "SDL_BLENDFACTOR_ONE_MINUS_DST_COLOR")]
        OneMinusDstColor = 0x8,
        [NativeName("Name", "SDL_BLENDFACTOR_DST_ALPHA")]
        DstAlpha = 0x9,
        [NativeName("Name", "SDL_BLENDFACTOR_ONE_MINUS_DST_ALPHA")]
        OneMinusDstAlpha = 0xA,
    }
}
