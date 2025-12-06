// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

[NativeName("SDL_ThreadPriority")]
public enum ThreadPriority
{
    [NativeName("SDL_THREAD_PRIORITY_LOW")]
    Low = 0,

    [NativeName("SDL_THREAD_PRIORITY_NORMAL")]
    Normal = 1,

    [NativeName("SDL_THREAD_PRIORITY_HIGH")]
    High = 2,

    [NativeName("SDL_THREAD_PRIORITY_TIME_CRITICAL")]
    TimeCritical = 3,
}
