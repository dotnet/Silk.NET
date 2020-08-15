// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [NativeName("AnonymousName", "__AnonymousEnum_SDL_video_L235_C9")]
    [NativeName("Name", "SDL_GLcontextFlag")]
    public enum GLcontextFlag
    {
        [NativeName("Name", "SDL_GL_CONTEXT_DEBUG_FLAG")]
        GLContextDebugFlag = 0x1,
        [NativeName("Name", "SDL_GL_CONTEXT_FORWARD_COMPATIBLE_FLAG")]
        GLContextForwardCompatibleFlag = 0x2,
        [NativeName("Name", "SDL_GL_CONTEXT_ROBUST_ACCESS_FLAG")]
        GLContextRobustAccessFlag = 0x4,
        [NativeName("Name", "SDL_GL_CONTEXT_RESET_ISOLATION_FLAG")]
        GLContextResetIsolationFlag = 0x8,
    }
}
