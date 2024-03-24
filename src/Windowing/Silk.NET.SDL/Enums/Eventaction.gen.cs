// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [NativeName("AnonymousName", "__AnonymousEnum_SDL_events_L699_C9")]
    [NativeName("Name", "SDL_eventaction")]
    public enum Eventaction : int
    {
        [NativeName("Name", "SDL_ADDEVENT")]
        Addevent = 0x0,
        [NativeName("Name", "SDL_PEEKEVENT")]
        Peekevent = 0x1,
        [NativeName("Name", "SDL_GETEVENT")]
        Getevent = 0x2,
    }
}
