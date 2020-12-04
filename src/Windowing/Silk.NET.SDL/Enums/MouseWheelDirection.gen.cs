// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [NativeName("AnonymousName", "__AnonymousEnum_SDL_mouse_L66_C9")]
    [NativeName("Name", "SDL_MouseWheelDirection")]
    public enum MouseWheelDirection
    {
        [NativeName("Name", "SDL_MOUSEWHEEL_NORMAL")]
        MousewheelNormal = 0x0,
        [NativeName("Name", "SDL_MOUSEWHEEL_FLIPPED")]
        MousewheelFlipped = 0x1,
    }
}
