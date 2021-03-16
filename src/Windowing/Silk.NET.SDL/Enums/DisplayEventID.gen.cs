// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [NativeName("AnonymousName", "__AnonymousEnum_SDL_video_L174_C9")]
    [NativeName("Name", "SDL_DisplayEventID")]
    public enum DisplayEventID : int
    {
        [NativeName("Name", "SDL_DISPLAYEVENT_NONE")]
        DisplayeventNone = 0x0,
        [NativeName("Name", "SDL_DISPLAYEVENT_ORIENTATION")]
        DisplayeventOrientation = 0x1,
    }
}
