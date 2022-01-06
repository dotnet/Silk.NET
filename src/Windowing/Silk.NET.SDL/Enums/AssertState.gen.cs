// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [Flags]
    [NativeName("AnonymousName", "__AnonymousEnum_SDL_assert_L106_C9")]
    [NativeName("Name", "SDL_AssertState")]
    public enum AssertState : int
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
