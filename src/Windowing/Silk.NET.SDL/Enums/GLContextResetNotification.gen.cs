// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [NativeName("AnonymousName", "__AnonymousEnum_SDL_video_L277_C9")]
    [NativeName("Name", "SDL_GLContextResetNotification")]
    public enum GLContextResetNotification : int
    {
        [Obsolete("Deprecated in favour of \"NoNotification\"")]
        [NativeName("Name", "SDL_GL_CONTEXT_RESET_NO_NOTIFICATION")]
        GLContextResetNoNotification = 0x0,
        [Obsolete("Deprecated in favour of \"LoseContext\"")]
        [NativeName("Name", "SDL_GL_CONTEXT_RESET_LOSE_CONTEXT")]
        GLContextResetLoseContext = 0x1,
        [NativeName("Name", "SDL_GL_CONTEXT_RESET_NO_NOTIFICATION")]
        NoNotification = 0x0,
        [NativeName("Name", "SDL_GL_CONTEXT_RESET_LOSE_CONTEXT")]
        LoseContext = 0x1,
    }
}
