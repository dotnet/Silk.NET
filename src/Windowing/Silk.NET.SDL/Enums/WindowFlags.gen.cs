// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [NativeName("AnonymousName", "__AnonymousEnum_SDL_video_L97_C9")]
    [NativeName("Name", "SDL_WindowFlags")]
    public enum WindowFlags
    {
        [NativeName("Name", "SDL_WINDOW_FULLSCREEN")]
        WindowFullscreen = 0x1,
        [NativeName("Name", "SDL_WINDOW_OPENGL")]
        WindowOpengl = 0x2,
        [NativeName("Name", "SDL_WINDOW_SHOWN")]
        WindowShown = 0x4,
        [NativeName("Name", "SDL_WINDOW_HIDDEN")]
        WindowHidden = 0x8,
        [NativeName("Name", "SDL_WINDOW_BORDERLESS")]
        WindowBorderless = 0x10,
        [NativeName("Name", "SDL_WINDOW_RESIZABLE")]
        WindowResizable = 0x20,
        [NativeName("Name", "SDL_WINDOW_MINIMIZED")]
        WindowMinimized = 0x40,
        [NativeName("Name", "SDL_WINDOW_MAXIMIZED")]
        WindowMaximized = 0x80,
        [NativeName("Name", "SDL_WINDOW_INPUT_GRABBED")]
        WindowInputGrabbed = 0x100,
        [NativeName("Name", "SDL_WINDOW_INPUT_FOCUS")]
        WindowInputFocus = 0x200,
        [NativeName("Name", "SDL_WINDOW_MOUSE_FOCUS")]
        WindowMouseFocus = 0x400,
        [NativeName("Name", "SDL_WINDOW_FULLSCREEN_DESKTOP")]
        WindowFullscreenDesktop = 0x1001,
        [NativeName("Name", "SDL_WINDOW_FOREIGN")]
        WindowForeign = 0x800,
        [NativeName("Name", "SDL_WINDOW_ALLOW_HIGHDPI")]
        WindowAllowHighdpi = 0x2000,
        [NativeName("Name", "SDL_WINDOW_MOUSE_CAPTURE")]
        WindowMouseCapture = 0x4000,
        [NativeName("Name", "SDL_WINDOW_ALWAYS_ON_TOP")]
        WindowAlwaysOnTop = 0x8000,
        [NativeName("Name", "SDL_WINDOW_SKIP_TASKBAR")]
        WindowSkipTaskbar = 0x10000,
        [NativeName("Name", "SDL_WINDOW_UTILITY")]
        WindowUtility = 0x20000,
        [NativeName("Name", "SDL_WINDOW_TOOLTIP")]
        WindowTooltip = 0x40000,
        [NativeName("Name", "SDL_WINDOW_POPUP_MENU")]
        WindowPopupMenu = 0x80000,
        [NativeName("Name", "SDL_WINDOW_VULKAN")]
        WindowVulkan = 0x10000000,
    }
}
