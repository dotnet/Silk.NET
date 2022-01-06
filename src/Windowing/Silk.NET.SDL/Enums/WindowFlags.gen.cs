// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [Flags]
    [NativeName("AnonymousName", "__AnonymousEnum_SDL_video_L101_C9")]
    [NativeName("Name", "SDL_WindowFlags")]
    public enum WindowFlags : int
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
        [NativeName("Name", "SDL_WINDOW_MOUSE_GRABBED")]
        WindowMouseGrabbed = 0x100,
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
        [NativeName("Name", "SDL_WINDOW_KEYBOARD_GRABBED")]
        WindowKeyboardGrabbed = 0x100000,
        [NativeName("Name", "SDL_WINDOW_VULKAN")]
        WindowVulkan = 0x10000000,
        [NativeName("Name", "SDL_WINDOW_METAL")]
        WindowMetal = 0x20000000,
        [NativeName("Name", "SDL_WINDOW_INPUT_GRABBED")]
        WindowInputGrabbed = 0x100,
    }
}
