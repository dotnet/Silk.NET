// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;

namespace Silk.NET.SDL;

[NativeName("SDL_LogPriority")]
public enum LogPriority : uint
{
    [NativeName("SDL_LOG_PRIORITY_INVALID")]
    Invalid = 0,

    [NativeName("SDL_LOG_PRIORITY_TRACE")]
    Trace = 1,

    [NativeName("SDL_LOG_PRIORITY_VERBOSE")]
    Verbose = 2,

    [NativeName("SDL_LOG_PRIORITY_DEBUG")]
    Debug = 3,

    [NativeName("SDL_LOG_PRIORITY_INFO")]
    Info = 4,

    [NativeName("SDL_LOG_PRIORITY_WARN")]
    Warn = 5,

    [NativeName("SDL_LOG_PRIORITY_ERROR")]
    Error = 6,

    [NativeName("SDL_LOG_PRIORITY_CRITICAL")]
    Critical = 7,

    [NativeName("SDL_LOG_PRIORITY_COUNT")]
    Count = 8,
}
