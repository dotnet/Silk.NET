// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

[NativeName("SDL_AssertState")]
public enum AssertState : uint
{
    [NativeName("SDL_ASSERTION_RETRY")]
    Retry,

    [NativeName("SDL_ASSERTION_BREAK")]
    Break,

    [NativeName("SDL_ASSERTION_ABORT")]
    Abort,

    [NativeName("SDL_ASSERTION_IGNORE")]
    Ignore,

    [NativeName("SDL_ASSERTION_ALWAYS_IGNORE")]
    AlwaysIgnore,
}
