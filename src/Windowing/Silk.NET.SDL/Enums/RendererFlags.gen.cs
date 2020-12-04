// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [NativeName("AnonymousName", "__AnonymousEnum_SDL_render_L64_C9")]
    [NativeName("Name", "SDL_RendererFlags")]
    public enum RendererFlags
    {
        [NativeName("Name", "SDL_RENDERER_SOFTWARE")]
        RendererSoftware = 0x1,
        [NativeName("Name", "SDL_RENDERER_ACCELERATED")]
        RendererAccelerated = 0x2,
        [NativeName("Name", "SDL_RENDERER_PRESENTVSYNC")]
        RendererPresentvsync = 0x4,
        [NativeName("Name", "SDL_RENDERER_TARGETTEXTURE")]
        RendererTargettexture = 0x8,
    }
}
