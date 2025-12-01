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
    Invalid,

    [NativeName("SDL_LOG_PRIORITY_TRACE")]
    Trace,

    [NativeName("SDL_LOG_PRIORITY_VERBOSE")]
    Verbose,

    [NativeName("SDL_LOG_PRIORITY_DEBUG")]
    Debug,

    [NativeName("SDL_LOG_PRIORITY_INFO")]
    Info,

    [NativeName("SDL_LOG_PRIORITY_WARN")]
    Warn,

    [NativeName("SDL_LOG_PRIORITY_ERROR")]
    Error,

    [NativeName("SDL_LOG_PRIORITY_CRITICAL")]
    Critical,

    [NativeName("SDL_LOG_PRIORITY_COUNT")]
    Count,
}
