// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [NativeName("AnonymousName", "__AnonymousEnum_SDL_mouse_L46_C9")]
    [NativeName("Name", "SDL_SystemCursor")]
    public enum SystemCursor : int
    {
        [NativeName("Name", "SDL_SYSTEM_CURSOR_ARROW")]
        SystemCursorArrow = 0x0,
        [NativeName("Name", "SDL_SYSTEM_CURSOR_IBEAM")]
        SystemCursorIbeam = 0x1,
        [NativeName("Name", "SDL_SYSTEM_CURSOR_WAIT")]
        SystemCursorWait = 0x2,
        [NativeName("Name", "SDL_SYSTEM_CURSOR_CROSSHAIR")]
        SystemCursorCrosshair = 0x3,
        [NativeName("Name", "SDL_SYSTEM_CURSOR_WAITARROW")]
        SystemCursorWaitarrow = 0x4,
        [NativeName("Name", "SDL_SYSTEM_CURSOR_SIZENWSE")]
        SystemCursorSizenwse = 0x5,
        [NativeName("Name", "SDL_SYSTEM_CURSOR_SIZENESW")]
        SystemCursorSizenesw = 0x6,
        [NativeName("Name", "SDL_SYSTEM_CURSOR_SIZEWE")]
        SystemCursorSizewe = 0x7,
        [NativeName("Name", "SDL_SYSTEM_CURSOR_SIZENS")]
        SystemCursorSizens = 0x8,
        [NativeName("Name", "SDL_SYSTEM_CURSOR_SIZEALL")]
        SystemCursorSizeall = 0x9,
        [NativeName("Name", "SDL_SYSTEM_CURSOR_NO")]
        SystemCursorNo = 0xA,
        [NativeName("Name", "SDL_SYSTEM_CURSOR_HAND")]
        SystemCursorHand = 0xB,
        [NativeName("Name", "SDL_NUM_SYSTEM_CURSORS")]
        NumSystemCursors = 0xC,
    }
}
