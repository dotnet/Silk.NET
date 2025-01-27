// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [NativeName("AnonymousName", "__AnonymousEnum_SDL_hints_L2718_C9")]
    [NativeName("Name", "SDL_HintPriority")]
    public enum HintPriority : int
    {
        [Obsolete("Deprecated in favour of \"Default\"")]
        [NativeName("Name", "SDL_HINT_DEFAULT")]
        HintDefault = 0x0,
        [Obsolete("Deprecated in favour of \"Normal\"")]
        [NativeName("Name", "SDL_HINT_NORMAL")]
        HintNormal = 0x1,
        [Obsolete("Deprecated in favour of \"Override\"")]
        [NativeName("Name", "SDL_HINT_OVERRIDE")]
        HintOverride = 0x2,
        [NativeName("Name", "SDL_HINT_DEFAULT")]
        Default = 0x0,
        [NativeName("Name", "SDL_HINT_NORMAL")]
        Normal = 0x1,
        [NativeName("Name", "SDL_HINT_OVERRIDE")]
        Override = 0x2,
    }
}
