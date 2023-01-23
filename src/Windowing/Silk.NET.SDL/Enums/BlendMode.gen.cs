// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [Flags]
    [NativeName("AnonymousName", "__AnonymousEnum_SDL_blendmode_L40_C9")]
    [NativeName("Name", "SDL_BlendMode")]
    public enum BlendMode : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "SDL_BLENDMODE_NONE")]
        BlendmodeNone = 0x0,
        [Obsolete("Deprecated in favour of \"Blend\"")]
        [NativeName("Name", "SDL_BLENDMODE_BLEND")]
        BlendmodeBlend = 0x1,
        [Obsolete("Deprecated in favour of \"Add\"")]
        [NativeName("Name", "SDL_BLENDMODE_ADD")]
        BlendmodeAdd = 0x2,
        [Obsolete("Deprecated in favour of \"Mod\"")]
        [NativeName("Name", "SDL_BLENDMODE_MOD")]
        BlendmodeMod = 0x4,
        [Obsolete("Deprecated in favour of \"Mul\"")]
        [NativeName("Name", "SDL_BLENDMODE_MUL")]
        BlendmodeMul = 0x8,
        [Obsolete("Deprecated in favour of \"Invalid\"")]
        [NativeName("Name", "SDL_BLENDMODE_INVALID")]
        BlendmodeInvalid = 0x7FFFFFFF,
        [NativeName("Name", "SDL_BLENDMODE_NONE")]
        None = 0x0,
        [NativeName("Name", "SDL_BLENDMODE_BLEND")]
        Blend = 0x1,
        [NativeName("Name", "SDL_BLENDMODE_ADD")]
        Add = 0x2,
        [NativeName("Name", "SDL_BLENDMODE_MOD")]
        Mod = 0x4,
        [NativeName("Name", "SDL_BLENDMODE_MUL")]
        Mul = 0x8,
        [NativeName("Name", "SDL_BLENDMODE_INVALID")]
        Invalid = 0x7FFFFFFF,
    }
}
