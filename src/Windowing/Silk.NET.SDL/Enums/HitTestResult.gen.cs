// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [NativeName("AnonymousName", "__AnonymousEnum_SDL_video_L1714_C9")]
    [NativeName("Name", "SDL_HitTestResult")]
    public enum HitTestResult : int
    {
        [Obsolete("Deprecated in favour of \"Normal\"")]
        [NativeName("Name", "SDL_HITTEST_NORMAL")]
        HittestNormal = 0x0,
        [Obsolete("Deprecated in favour of \"Draggable\"")]
        [NativeName("Name", "SDL_HITTEST_DRAGGABLE")]
        HittestDraggable = 0x1,
        [Obsolete("Deprecated in favour of \"ResizeTopleft\"")]
        [NativeName("Name", "SDL_HITTEST_RESIZE_TOPLEFT")]
        HittestResizeTopleft = 0x2,
        [Obsolete("Deprecated in favour of \"ResizeTop\"")]
        [NativeName("Name", "SDL_HITTEST_RESIZE_TOP")]
        HittestResizeTop = 0x3,
        [Obsolete("Deprecated in favour of \"ResizeTopright\"")]
        [NativeName("Name", "SDL_HITTEST_RESIZE_TOPRIGHT")]
        HittestResizeTopright = 0x4,
        [Obsolete("Deprecated in favour of \"ResizeRight\"")]
        [NativeName("Name", "SDL_HITTEST_RESIZE_RIGHT")]
        HittestResizeRight = 0x5,
        [Obsolete("Deprecated in favour of \"ResizeBottomright\"")]
        [NativeName("Name", "SDL_HITTEST_RESIZE_BOTTOMRIGHT")]
        HittestResizeBottomright = 0x6,
        [Obsolete("Deprecated in favour of \"ResizeBottom\"")]
        [NativeName("Name", "SDL_HITTEST_RESIZE_BOTTOM")]
        HittestResizeBottom = 0x7,
        [Obsolete("Deprecated in favour of \"ResizeBottomleft\"")]
        [NativeName("Name", "SDL_HITTEST_RESIZE_BOTTOMLEFT")]
        HittestResizeBottomleft = 0x8,
        [Obsolete("Deprecated in favour of \"ResizeLeft\"")]
        [NativeName("Name", "SDL_HITTEST_RESIZE_LEFT")]
        HittestResizeLeft = 0x9,
        [NativeName("Name", "SDL_HITTEST_NORMAL")]
        Normal = 0x0,
        [NativeName("Name", "SDL_HITTEST_DRAGGABLE")]
        Draggable = 0x1,
        [NativeName("Name", "SDL_HITTEST_RESIZE_TOPLEFT")]
        ResizeTopleft = 0x2,
        [NativeName("Name", "SDL_HITTEST_RESIZE_TOP")]
        ResizeTop = 0x3,
        [NativeName("Name", "SDL_HITTEST_RESIZE_TOPRIGHT")]
        ResizeTopright = 0x4,
        [NativeName("Name", "SDL_HITTEST_RESIZE_RIGHT")]
        ResizeRight = 0x5,
        [NativeName("Name", "SDL_HITTEST_RESIZE_BOTTOMRIGHT")]
        ResizeBottomright = 0x6,
        [NativeName("Name", "SDL_HITTEST_RESIZE_BOTTOM")]
        ResizeBottom = 0x7,
        [NativeName("Name", "SDL_HITTEST_RESIZE_BOTTOMLEFT")]
        ResizeBottomleft = 0x8,
        [NativeName("Name", "SDL_HITTEST_RESIZE_LEFT")]
        ResizeLeft = 0x9,
    }
}
