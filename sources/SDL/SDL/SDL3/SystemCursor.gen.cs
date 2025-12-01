// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;

namespace Silk.NET.SDL;

[NativeName("SDL_SystemCursor")]
public enum SystemCursor : uint
{
    [NativeName("SDL_SYSTEM_CURSOR_DEFAULT")]
    Default,

    [NativeName("SDL_SYSTEM_CURSOR_TEXT")]
    Text,

    [NativeName("SDL_SYSTEM_CURSOR_WAIT")]
    Wait,

    [NativeName("SDL_SYSTEM_CURSOR_CROSSHAIR")]
    Crosshair,

    [NativeName("SDL_SYSTEM_CURSOR_PROGRESS")]
    Progress,

    [NativeName("SDL_SYSTEM_CURSOR_NWSE_RESIZE")]
    NwseResize,

    [NativeName("SDL_SYSTEM_CURSOR_NESW_RESIZE")]
    NeswResize,

    [NativeName("SDL_SYSTEM_CURSOR_EW_RESIZE")]
    EwResize,

    [NativeName("SDL_SYSTEM_CURSOR_NS_RESIZE")]
    NsResize,

    [NativeName("SDL_SYSTEM_CURSOR_MOVE")]
    Move,

    [NativeName("SDL_SYSTEM_CURSOR_NOT_ALLOWED")]
    NotAllowed,

    [NativeName("SDL_SYSTEM_CURSOR_POINTER")]
    Pointer,

    [NativeName("SDL_SYSTEM_CURSOR_NW_RESIZE")]
    NwResize,

    [NativeName("SDL_SYSTEM_CURSOR_N_RESIZE")]
    NResize,

    [NativeName("SDL_SYSTEM_CURSOR_NE_RESIZE")]
    NeResize,

    [NativeName("SDL_SYSTEM_CURSOR_E_RESIZE")]
    EResize,

    [NativeName("SDL_SYSTEM_CURSOR_SE_RESIZE")]
    SeResize,

    [NativeName("SDL_SYSTEM_CURSOR_S_RESIZE")]
    SResize,

    [NativeName("SDL_SYSTEM_CURSOR_SW_RESIZE")]
    SwResize,

    [NativeName("SDL_SYSTEM_CURSOR_W_RESIZE")]
    WResize,

    [NativeName("SDL_SYSTEM_CURSOR_COUNT")]
    Count,
}
