// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [NativeName("AnonymousName", "__AnonymousEnum_SDL_hints_L1278_C9")]
    [NativeName("Name", "SDL_HintPriority")]
    public enum HintPriority
    {
        [NativeName("Name", "SDL_HINT_DEFAULT")]
        HintDefault = 0x0,
        [NativeName("Name", "SDL_HINT_NORMAL")]
        HintNormal = 0x1,
        [NativeName("Name", "SDL_HINT_OVERRIDE")]
        HintOverride = 0x2,
    }
}
