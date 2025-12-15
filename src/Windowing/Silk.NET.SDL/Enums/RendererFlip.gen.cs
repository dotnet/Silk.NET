// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [NativeName("AnonymousName", "__AnonymousEnum_SDL_render_L131_C9")]
    [NativeName("Name", "SDL_RendererFlip")]
    public enum RendererFlip : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "SDL_FLIP_NONE")]
        FlipNone = 0x0,
        [Obsolete("Deprecated in favour of \"Horizontal\"")]
        [NativeName("Name", "SDL_FLIP_HORIZONTAL")]
        FlipHorizontal = 0x1,
        [Obsolete("Deprecated in favour of \"Vertical\"")]
        [NativeName("Name", "SDL_FLIP_VERTICAL")]
        FlipVertical = 0x2,
        [NativeName("Name", "SDL_FLIP_NONE")]
        None = 0x0,
        [NativeName("Name", "SDL_FLIP_HORIZONTAL")]
        Horizontal = 0x1,
        [NativeName("Name", "SDL_FLIP_VERTICAL")]
        Vertical = 0x2,
    }
}
