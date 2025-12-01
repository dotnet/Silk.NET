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
    Application,

    [NativeName("SDL_LOG_CATEGORY_ERROR")]
    Error,

    [NativeName("SDL_LOG_CATEGORY_ASSERT")]
    Assert,

    [NativeName("SDL_LOG_CATEGORY_SYSTEM")]
    System,

    [NativeName("SDL_LOG_CATEGORY_AUDIO")]
    Audio,

    [NativeName("SDL_LOG_CATEGORY_VIDEO")]
    Video,

    [NativeName("SDL_LOG_CATEGORY_RENDER")]
    Render,

    [NativeName("SDL_LOG_CATEGORY_INPUT")]
    Input,

    [NativeName("SDL_LOG_CATEGORY_TEST")]
    Test,

    [NativeName("SDL_LOG_CATEGORY_GPU")]
    Gpu,

    [NativeName("SDL_LOG_CATEGORY_RESERVED2")]
    Reserved2,

    [NativeName("SDL_LOG_CATEGORY_RESERVED3")]
    Reserved3,

    [NativeName("SDL_LOG_CATEGORY_RESERVED4")]
    Reserved4,

    [NativeName("SDL_LOG_CATEGORY_RESERVED5")]
    Reserved5,

    [NativeName("SDL_LOG_CATEGORY_RESERVED6")]
    Reserved6,

    [NativeName("SDL_LOG_CATEGORY_RESERVED7")]
    Reserved7,

    [NativeName("SDL_LOG_CATEGORY_RESERVED8")]
    Reserved8,

    [NativeName("SDL_LOG_CATEGORY_RESERVED9")]
    Reserved9,

    [NativeName("SDL_LOG_CATEGORY_RESERVED10")]
    Reserved10,

    [NativeName("SDL_LOG_CATEGORY_CUSTOM")]
    Custom,
}
