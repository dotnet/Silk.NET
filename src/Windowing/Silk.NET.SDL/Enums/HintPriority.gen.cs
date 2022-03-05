// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [Flags]
    [NativeName("AnonymousName", "__AnonymousEnum_SDL_hints_L1666_C9")]
    [NativeName("Name", "SDL_HintPriority")]
    public enum HintPriority : int
    {
        [NativeName("Name", "SDL_HINT_DEFAULT")]
        HintDefault = 0x0,
        [NativeName("Name", "SDL_HINT_NORMAL")]
        HintNormal = 0x1,
        [NativeName("Name", "SDL_HINT_OVERRIDE")]
        HintOverride = 0x2,
    }
}
