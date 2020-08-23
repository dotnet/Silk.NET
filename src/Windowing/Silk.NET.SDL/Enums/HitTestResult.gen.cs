// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [NativeName("AnonymousName", "__AnonymousEnum_SDL_video_L1019_C9")]
    [NativeName("Name", "SDL_HitTestResult")]
    public enum HitTestResult
    {
        [NativeName("Name", "SDL_HITTEST_NORMAL")]
        HittestNormal = 0x0,
        [NativeName("Name", "SDL_HITTEST_DRAGGABLE")]
        HittestDraggable = 0x1,
        [NativeName("Name", "SDL_HITTEST_RESIZE_TOPLEFT")]
        HittestResizeTopleft = 0x2,
        [NativeName("Name", "SDL_HITTEST_RESIZE_TOP")]
        HittestResizeTop = 0x3,
        [NativeName("Name", "SDL_HITTEST_RESIZE_TOPRIGHT")]
        HittestResizeTopright = 0x4,
        [NativeName("Name", "SDL_HITTEST_RESIZE_RIGHT")]
        HittestResizeRight = 0x5,
        [NativeName("Name", "SDL_HITTEST_RESIZE_BOTTOMRIGHT")]
        HittestResizeBottomright = 0x6,
        [NativeName("Name", "SDL_HITTEST_RESIZE_BOTTOM")]
        HittestResizeBottom = 0x7,
        [NativeName("Name", "SDL_HITTEST_RESIZE_BOTTOMLEFT")]
        HittestResizeBottomleft = 0x8,
        [NativeName("Name", "SDL_HITTEST_RESIZE_LEFT")]
        HittestResizeLeft = 0x9,
    }
}
