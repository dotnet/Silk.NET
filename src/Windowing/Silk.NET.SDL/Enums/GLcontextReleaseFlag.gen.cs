// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [NativeName("AnonymousName", "__AnonymousEnum_SDL_video_L271_C9")]
    [NativeName("Name", "SDL_GLcontextReleaseFlag")]
    public enum GLcontextReleaseFlag : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "SDL_GL_CONTEXT_RELEASE_BEHAVIOR_NONE")]
        GLContextReleaseBehaviorNone = 0x0,
        [Obsolete("Deprecated in favour of \"Flush\"")]
        [NativeName("Name", "SDL_GL_CONTEXT_RELEASE_BEHAVIOR_FLUSH")]
        GLContextReleaseBehaviorFlush = 0x1,
        [NativeName("Name", "SDL_GL_CONTEXT_RELEASE_BEHAVIOR_NONE")]
        None = 0x0,
        [NativeName("Name", "SDL_GL_CONTEXT_RELEASE_BEHAVIOR_FLUSH")]
        Flush = 0x1,
    }
}
