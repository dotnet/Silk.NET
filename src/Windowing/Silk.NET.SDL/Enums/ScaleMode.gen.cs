// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [Flags]
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
