// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [NativeName("AnonymousName", "__AnonymousEnum_SDL_video_L243_C9")]
    [NativeName("Name", "SDL_GLcontextReleaseFlag")]
    public enum GLcontextReleaseFlag : int
    {
        [NativeName("Name", "SDL_GL_CONTEXT_RELEASE_BEHAVIOR_NONE")]
        GLContextReleaseBehaviorNone = 0x0,
        [NativeName("Name", "SDL_GL_CONTEXT_RELEASE_BEHAVIOR_FLUSH")]
        GLContextReleaseBehaviorFlush = 0x1,
    }
}
