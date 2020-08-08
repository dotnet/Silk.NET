// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [NativeName("AnonymousName", "__AnonymousEnum_SDL_events_L614_C9")]
    [NativeName("Name", "SDL_eventaction")]
    public enum Eventaction
    {
        [NativeName("Name", "SDL_ADDEVENT")]
        Addevent = 0x0,
        [NativeName("Name", "SDL_PEEKEVENT")]
        Peekevent = 0x1,
        [NativeName("Name", "SDL_GETEVENT")]
        Getevent = 0x2,
    }
}
