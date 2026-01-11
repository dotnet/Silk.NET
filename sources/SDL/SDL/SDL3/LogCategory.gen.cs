// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

[NativeName("SDL_LogCategory")]
public enum LogCategory : uint
{
    [NativeName("SDL_LOG_CATEGORY_APPLICATION")]
    Application = 0,

    [NativeName("SDL_LOG_CATEGORY_ERROR")]
    Error = 1,

    [NativeName("SDL_LOG_CATEGORY_ASSERT")]
    Assert = 2,

    [NativeName("SDL_LOG_CATEGORY_SYSTEM")]
    System = 3,

    [NativeName("SDL_LOG_CATEGORY_AUDIO")]
    Audio = 4,

    [NativeName("SDL_LOG_CATEGORY_VIDEO")]
    Video = 5,

    [NativeName("SDL_LOG_CATEGORY_RENDER")]
    Render = 6,

    [NativeName("SDL_LOG_CATEGORY_INPUT")]
    Input = 7,

    [NativeName("SDL_LOG_CATEGORY_TEST")]
    Test = 8,

    [NativeName("SDL_LOG_CATEGORY_GPU")]
    Gpu = 9,

    [NativeName("SDL_LOG_CATEGORY_RESERVED2")]
    Reserved2 = 10,

    [NativeName("SDL_LOG_CATEGORY_RESERVED3")]
    Reserved3 = 11,

    [NativeName("SDL_LOG_CATEGORY_RESERVED4")]
    Reserved4 = 12,

    [NativeName("SDL_LOG_CATEGORY_RESERVED5")]
    Reserved5 = 13,

    [NativeName("SDL_LOG_CATEGORY_RESERVED6")]
    Reserved6 = 14,

    [NativeName("SDL_LOG_CATEGORY_RESERVED7")]
    Reserved7 = 15,

    [NativeName("SDL_LOG_CATEGORY_RESERVED8")]
    Reserved8 = 16,

    [NativeName("SDL_LOG_CATEGORY_RESERVED9")]
    Reserved9 = 17,

    [NativeName("SDL_LOG_CATEGORY_RESERVED10")]
    Reserved10 = 18,

    [NativeName("SDL_LOG_CATEGORY_CUSTOM")]
    Custom = 19,
}
