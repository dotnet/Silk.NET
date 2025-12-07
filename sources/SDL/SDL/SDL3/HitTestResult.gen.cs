// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

[NativeName("SDL_HitTestResult")]
public enum HitTestResult
{
    [NativeName("SDL_HITTEST_NORMAL")]
    Normal = 0,

    [NativeName("SDL_HITTEST_DRAGGABLE")]
    Draggable = 1,

    [NativeName("SDL_HITTEST_RESIZE_TOPLEFT")]
    ResizeTopleft = 2,

    [NativeName("SDL_HITTEST_RESIZE_TOP")]
    ResizeTop = 3,

    [NativeName("SDL_HITTEST_RESIZE_TOPRIGHT")]
    ResizeTopright = 4,

    [NativeName("SDL_HITTEST_RESIZE_RIGHT")]
    ResizeRight = 5,

    [NativeName("SDL_HITTEST_RESIZE_BOTTOMRIGHT")]
    ResizeBottomright = 6,

    [NativeName("SDL_HITTEST_RESIZE_BOTTOM")]
    ResizeBottom = 7,

    [NativeName("SDL_HITTEST_RESIZE_BOTTOMLEFT")]
    ResizeBottomleft = 8,

    [NativeName("SDL_HITTEST_RESIZE_LEFT")]
    ResizeLeft = 9,
}
