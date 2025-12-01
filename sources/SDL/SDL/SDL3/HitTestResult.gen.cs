// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;

namespace Silk.NET.SDL;

[NativeName("SDL_HitTestResult")]
public enum HitTestResult : uint
{
    [NativeName("SDL_HITTEST_NORMAL")]
    Normal,

    [NativeName("SDL_HITTEST_DRAGGABLE")]
    Draggable,

    [NativeName("SDL_HITTEST_RESIZE_TOPLEFT")]
    ResizeTopleft,

    [NativeName("SDL_HITTEST_RESIZE_TOP")]
    ResizeTop,

    [NativeName("SDL_HITTEST_RESIZE_TOPRIGHT")]
    ResizeTopright,

    [NativeName("SDL_HITTEST_RESIZE_RIGHT")]
    ResizeRight,

    [NativeName("SDL_HITTEST_RESIZE_BOTTOMRIGHT")]
    ResizeBottomright,

    [NativeName("SDL_HITTEST_RESIZE_BOTTOM")]
    ResizeBottom,

    [NativeName("SDL_HITTEST_RESIZE_BOTTOMLEFT")]
    ResizeBottomleft,

    [NativeName("SDL_HITTEST_RESIZE_LEFT")]
    ResizeLeft,
}
