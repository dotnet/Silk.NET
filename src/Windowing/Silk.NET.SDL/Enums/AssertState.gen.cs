// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [NativeName("AnonymousName", "__AnonymousEnum_SDL_assert_L102_C9")]
    [NativeName("Name", "SDL_AssertState")]
    public enum AssertState
    {
        [NativeName("Name", "SDL_ASSERTION_RETRY")]
        AssertionRetry = 0x0,
        [NativeName("Name", "SDL_ASSERTION_BREAK")]
        AssertionBreak = 0x1,
        [NativeName("Name", "SDL_ASSERTION_ABORT")]
        AssertionAbort = 0x2,
        [NativeName("Name", "SDL_ASSERTION_IGNORE")]
        AssertionIgnore = 0x3,
        [NativeName("Name", "SDL_ASSERTION_ALWAYS_IGNORE")]
        AssertionAlwaysIgnore = 0x4,
    }
}
