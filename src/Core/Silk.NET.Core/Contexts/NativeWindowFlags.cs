// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;

namespace Silk.NET.Core.Contexts
{
    [Flags]
    public enum NativeWindowFlags : ulong
    {
        Glfw = 1 << 0,
        Sdl = 1 << 1,
        // 1 << 2 through 1 << 8 have been reserved for future windowing platforms
        Win32 = 1 << 9,
        X11 = 1 << 10,
        DirectFB = 1 << 11,
        Cocoa = 1 << 12,
        UIKit = 1 << 13,
        Wayland = 1 << 14,
        WinRT = 1 << 15,
        Android = 1 << 16,
        Vivante = 1 << 17,
        OS2 = 1 << 18,
        Haiku = 1 << 19
    }
}
