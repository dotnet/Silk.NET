// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [Flags]
    [NativeName("AnonymousName", "__AnonymousEnum_SDL_video_L263_C9")]
    [NativeName("Name", "SDL_GLcontextFlag")]
    public enum GLcontextFlag : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"DebugFlag\"")]
        [NativeName("Name", "SDL_GL_CONTEXT_DEBUG_FLAG")]
        GLContextDebugFlag = 0x1,
        [Obsolete("Deprecated in favour of \"ForwardCompatibleFlag\"")]
        [NativeName("Name", "SDL_GL_CONTEXT_FORWARD_COMPATIBLE_FLAG")]
        GLContextForwardCompatibleFlag = 0x2,
        [Obsolete("Deprecated in favour of \"RobustAccessFlag\"")]
        [NativeName("Name", "SDL_GL_CONTEXT_ROBUST_ACCESS_FLAG")]
        GLContextRobustAccessFlag = 0x4,
        [Obsolete("Deprecated in favour of \"ResetIsolationFlag\"")]
        [NativeName("Name", "SDL_GL_CONTEXT_RESET_ISOLATION_FLAG")]
        GLContextResetIsolationFlag = 0x8,
        [NativeName("Name", "SDL_GL_CONTEXT_DEBUG_FLAG")]
        DebugFlag = 0x1,
        [NativeName("Name", "SDL_GL_CONTEXT_FORWARD_COMPATIBLE_FLAG")]
        ForwardCompatibleFlag = 0x2,
        [NativeName("Name", "SDL_GL_CONTEXT_ROBUST_ACCESS_FLAG")]
        RobustAccessFlag = 0x4,
        [NativeName("Name", "SDL_GL_CONTEXT_RESET_ISOLATION_FLAG")]
        ResetIsolationFlag = 0x8,
    }
}
