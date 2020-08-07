// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [NativeName("AnonymousName", "__AnonymousEnum_SDL_error_L55_C9")]
    [NativeName("Name", "SDL_errorcode")]
    public enum Errorcode
    {
        [NativeName("Name", "SDL_ENOMEM")]
        Enomem = 0x0,
        [NativeName("Name", "SDL_EFREAD")]
        Efread = 0x1,
        [NativeName("Name", "SDL_EFWRITE")]
        Efwrite = 0x2,
        [NativeName("Name", "SDL_EFSEEK")]
        Efseek = 0x3,
        [NativeName("Name", "SDL_UNSUPPORTED")]
        Unsupported = 0x4,
        [NativeName("Name", "SDL_LASTERROR")]
        Lasterror = 0x5,
    }
}
