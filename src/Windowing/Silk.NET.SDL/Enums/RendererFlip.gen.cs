// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [Flags]
    [NativeName("AnonymousName", "__AnonymousEnum_SDL_render_L121_C9")]
    [NativeName("Name", "SDL_RendererFlip")]
    public enum RendererFlip : int
    {
        [NativeName("Name", "SDL_FLIP_NONE")]
        FlipNone = 0x0,
        [NativeName("Name", "SDL_FLIP_HORIZONTAL")]
        FlipHorizontal = 0x1,
        [NativeName("Name", "SDL_FLIP_VERTICAL")]
        FlipVertical = 0x2,
    }
}
