// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [NativeName("AnonymousName", "__AnonymousEnum_SDL_video_L228_C9")]
    [NativeName("Name", "SDL_GLprofile")]
    public enum GLprofile
    {
        [NativeName("Name", "SDL_GL_CONTEXT_PROFILE_CORE")]
        GLContextProfileCore = 0x1,
        [NativeName("Name", "SDL_GL_CONTEXT_PROFILE_COMPATIBILITY")]
        GLContextProfileCompatibility = 0x2,
        [NativeName("Name", "SDL_GL_CONTEXT_PROFILE_ES")]
        GLContextProfileES = 0x4,
    }
}
