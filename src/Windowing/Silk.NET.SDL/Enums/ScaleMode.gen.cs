// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [NativeName("AnonymousName", "__AnonymousEnum_SDL_render_L91_C9")]
    [NativeName("Name", "SDL_ScaleMode")]
    public enum ScaleMode : int
    {
        [NativeName("Name", "SDL_ScaleModeNearest")]
        ScaleModeNearest = 0x0,
        [NativeName("Name", "SDL_ScaleModeLinear")]
        ScaleModeLinear = 0x1,
        [NativeName("Name", "SDL_ScaleModeBest")]
        ScaleModeBest = 0x2,
    }
}
