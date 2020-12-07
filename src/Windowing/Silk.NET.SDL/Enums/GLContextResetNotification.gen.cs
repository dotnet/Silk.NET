// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [NativeName("AnonymousName", "__AnonymousEnum_SDL_video_L249_C9")]
    [NativeName("Name", "SDL_GLContextResetNotification")]
    public enum GLContextResetNotification
    {
        [NativeName("Name", "SDL_GL_CONTEXT_RESET_NO_NOTIFICATION")]
        GLContextResetNoNotification = 0x0,
        [NativeName("Name", "SDL_GL_CONTEXT_RESET_LOSE_CONTEXT")]
        GLContextResetLoseContext = 0x1,
    }
}
