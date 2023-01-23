// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [Flags]
    [NativeName("AnonymousName", "__AnonymousEnum_SDL_video_L102_C9")]
    [NativeName("Name", "SDL_WindowFlags")]
    public enum WindowFlags : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"Fullscreen\"")]
        [NativeName("Name", "SDL_WINDOW_FULLSCREEN")]
        WindowFullscreen = 0x1,
        [Obsolete("Deprecated in favour of \"Opengl\"")]
        [NativeName("Name", "SDL_WINDOW_OPENGL")]
        WindowOpengl = 0x2,
        [Obsolete("Deprecated in favour of \"Shown\"")]
        [NativeName("Name", "SDL_WINDOW_SHOWN")]
        WindowShown = 0x4,
        [Obsolete("Deprecated in favour of \"Hidden\"")]
        [NativeName("Name", "SDL_WINDOW_HIDDEN")]
        WindowHidden = 0x8,
        [Obsolete("Deprecated in favour of \"Borderless\"")]
        [NativeName("Name", "SDL_WINDOW_BORDERLESS")]
        WindowBorderless = 0x10,
        [Obsolete("Deprecated in favour of \"Resizable\"")]
        [NativeName("Name", "SDL_WINDOW_RESIZABLE")]
        WindowResizable = 0x20,
        [Obsolete("Deprecated in favour of \"Minimized\"")]
        [NativeName("Name", "SDL_WINDOW_MINIMIZED")]
        WindowMinimized = 0x40,
        [Obsolete("Deprecated in favour of \"Maximized\"")]
        [NativeName("Name", "SDL_WINDOW_MAXIMIZED")]
        WindowMaximized = 0x80,
        [Obsolete("Deprecated in favour of \"MouseGrabbed\"")]
        [NativeName("Name", "SDL_WINDOW_MOUSE_GRABBED")]
        WindowMouseGrabbed = 0x100,
        [Obsolete("Deprecated in favour of \"InputFocus\"")]
        [NativeName("Name", "SDL_WINDOW_INPUT_FOCUS")]
        WindowInputFocus = 0x200,
        [Obsolete("Deprecated in favour of \"MouseFocus\"")]
        [NativeName("Name", "SDL_WINDOW_MOUSE_FOCUS")]
        WindowMouseFocus = 0x400,
        [Obsolete("Deprecated in favour of \"FullscreenDesktop\"")]
        [NativeName("Name", "SDL_WINDOW_FULLSCREEN_DESKTOP")]
        WindowFullscreenDesktop = 0x1001,
        [Obsolete("Deprecated in favour of \"Foreign\"")]
        [NativeName("Name", "SDL_WINDOW_FOREIGN")]
        WindowForeign = 0x800,
        [Obsolete("Deprecated in favour of \"AllowHighdpi\"")]
        [NativeName("Name", "SDL_WINDOW_ALLOW_HIGHDPI")]
        WindowAllowHighdpi = 0x2000,
        [Obsolete("Deprecated in favour of \"MouseCapture\"")]
        [NativeName("Name", "SDL_WINDOW_MOUSE_CAPTURE")]
        WindowMouseCapture = 0x4000,
        [Obsolete("Deprecated in favour of \"AlwaysOnTop\"")]
        [NativeName("Name", "SDL_WINDOW_ALWAYS_ON_TOP")]
        WindowAlwaysOnTop = 0x8000,
        [Obsolete("Deprecated in favour of \"SkipTaskbar\"")]
        [NativeName("Name", "SDL_WINDOW_SKIP_TASKBAR")]
        WindowSkipTaskbar = 0x10000,
        [Obsolete("Deprecated in favour of \"Utility\"")]
        [NativeName("Name", "SDL_WINDOW_UTILITY")]
        WindowUtility = 0x20000,
        [Obsolete("Deprecated in favour of \"Tooltip\"")]
        [NativeName("Name", "SDL_WINDOW_TOOLTIP")]
        WindowTooltip = 0x40000,
        [Obsolete("Deprecated in favour of \"PopupMenu\"")]
        [NativeName("Name", "SDL_WINDOW_POPUP_MENU")]
        WindowPopupMenu = 0x80000,
        [Obsolete("Deprecated in favour of \"KeyboardGrabbed\"")]
        [NativeName("Name", "SDL_WINDOW_KEYBOARD_GRABBED")]
        WindowKeyboardGrabbed = 0x100000,
        [Obsolete("Deprecated in favour of \"Vulkan\"")]
        [NativeName("Name", "SDL_WINDOW_VULKAN")]
        WindowVulkan = 0x10000000,
        [Obsolete("Deprecated in favour of \"Metal\"")]
        [NativeName("Name", "SDL_WINDOW_METAL")]
        WindowMetal = 0x20000000,
        [Obsolete("Deprecated in favour of \"InputGrabbed\"")]
        [NativeName("Name", "SDL_WINDOW_INPUT_GRABBED")]
        WindowInputGrabbed = 0x100,
        [NativeName("Name", "SDL_WINDOW_FULLSCREEN")]
        Fullscreen = 0x1,
        [NativeName("Name", "SDL_WINDOW_OPENGL")]
        Opengl = 0x2,
        [NativeName("Name", "SDL_WINDOW_SHOWN")]
        Shown = 0x4,
        [NativeName("Name", "SDL_WINDOW_HIDDEN")]
        Hidden = 0x8,
        [NativeName("Name", "SDL_WINDOW_BORDERLESS")]
        Borderless = 0x10,
        [NativeName("Name", "SDL_WINDOW_RESIZABLE")]
        Resizable = 0x20,
        [NativeName("Name", "SDL_WINDOW_MINIMIZED")]
        Minimized = 0x40,
        [NativeName("Name", "SDL_WINDOW_MAXIMIZED")]
        Maximized = 0x80,
        [NativeName("Name", "SDL_WINDOW_MOUSE_GRABBED")]
        MouseGrabbed = 0x100,
        [NativeName("Name", "SDL_WINDOW_INPUT_FOCUS")]
        InputFocus = 0x200,
        [NativeName("Name", "SDL_WINDOW_MOUSE_FOCUS")]
        MouseFocus = 0x400,
        [NativeName("Name", "SDL_WINDOW_FULLSCREEN_DESKTOP")]
        FullscreenDesktop = 0x1001,
        [NativeName("Name", "SDL_WINDOW_FOREIGN")]
        Foreign = 0x800,
        [NativeName("Name", "SDL_WINDOW_ALLOW_HIGHDPI")]
        AllowHighdpi = 0x2000,
        [NativeName("Name", "SDL_WINDOW_MOUSE_CAPTURE")]
        MouseCapture = 0x4000,
        [NativeName("Name", "SDL_WINDOW_ALWAYS_ON_TOP")]
        AlwaysOnTop = 0x8000,
        [NativeName("Name", "SDL_WINDOW_SKIP_TASKBAR")]
        SkipTaskbar = 0x10000,
        [NativeName("Name", "SDL_WINDOW_UTILITY")]
        Utility = 0x20000,
        [NativeName("Name", "SDL_WINDOW_TOOLTIP")]
        Tooltip = 0x40000,
        [NativeName("Name", "SDL_WINDOW_POPUP_MENU")]
        PopupMenu = 0x80000,
        [NativeName("Name", "SDL_WINDOW_KEYBOARD_GRABBED")]
        KeyboardGrabbed = 0x100000,
        [NativeName("Name", "SDL_WINDOW_VULKAN")]
        Vulkan = 0x10000000,
        [NativeName("Name", "SDL_WINDOW_METAL")]
        Metal = 0x20000000,
        [NativeName("Name", "SDL_WINDOW_INPUT_GRABBED")]
        InputGrabbed = 0x100,
    }
}
