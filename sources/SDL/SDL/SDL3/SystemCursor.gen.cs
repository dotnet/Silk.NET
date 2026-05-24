// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

[NativeName("SDL_SystemCursor")]
public enum SystemCursor
{
    [NativeName("SDL_SYSTEM_CURSOR_DEFAULT")]
    Default = 0,

    [NativeName("SDL_SYSTEM_CURSOR_TEXT")]
    Text = 1,

    [NativeName("SDL_SYSTEM_CURSOR_WAIT")]
    Wait = 2,

    [NativeName("SDL_SYSTEM_CURSOR_CROSSHAIR")]
    Crosshair = 3,

    [NativeName("SDL_SYSTEM_CURSOR_PROGRESS")]
    Progress = 4,

    [NativeName("SDL_SYSTEM_CURSOR_NWSE_RESIZE")]
    NwseResize = 5,

    [NativeName("SDL_SYSTEM_CURSOR_NESW_RESIZE")]
    NeswResize = 6,

    [NativeName("SDL_SYSTEM_CURSOR_EW_RESIZE")]
    EwResize = 7,

    [NativeName("SDL_SYSTEM_CURSOR_NS_RESIZE")]
    NsResize = 8,

    [NativeName("SDL_SYSTEM_CURSOR_MOVE")]
    Move = 9,

    [NativeName("SDL_SYSTEM_CURSOR_NOT_ALLOWED")]
    NotAllowed = 10,

    [NativeName("SDL_SYSTEM_CURSOR_POINTER")]
    Pointer = 11,

    [NativeName("SDL_SYSTEM_CURSOR_NW_RESIZE")]
    NwResize = 12,

    [NativeName("SDL_SYSTEM_CURSOR_N_RESIZE")]
    NResize = 13,

    [NativeName("SDL_SYSTEM_CURSOR_NE_RESIZE")]
    NeResize = 14,

    [NativeName("SDL_SYSTEM_CURSOR_E_RESIZE")]
    EResize = 15,

    [NativeName("SDL_SYSTEM_CURSOR_SE_RESIZE")]
    SeResize = 16,

    [NativeName("SDL_SYSTEM_CURSOR_S_RESIZE")]
    SResize = 17,

    [NativeName("SDL_SYSTEM_CURSOR_SW_RESIZE")]
    SwResize = 18,

    [NativeName("SDL_SYSTEM_CURSOR_W_RESIZE")]
    WResize = 19,

    [NativeName("SDL_SYSTEM_CURSOR_COUNT")]
    Count = 20,
}
