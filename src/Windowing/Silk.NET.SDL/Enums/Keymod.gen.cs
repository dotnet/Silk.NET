// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [Flags]
    [NativeName("AnonymousName", "__AnonymousEnum_SDL_keycode_L332_C9")]
    [NativeName("Name", "SDL_Keymod")]
    public enum Keymod : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "KMOD_NONE")]
        KmodNone = 0x0,
        [Obsolete("Deprecated in favour of \"Lshift\"")]
        [NativeName("Name", "KMOD_LSHIFT")]
        KmodLshift = 0x1,
        [Obsolete("Deprecated in favour of \"Rshift\"")]
        [NativeName("Name", "KMOD_RSHIFT")]
        KmodRshift = 0x2,
        [Obsolete("Deprecated in favour of \"Lctrl\"")]
        [NativeName("Name", "KMOD_LCTRL")]
        KmodLctrl = 0x40,
        [Obsolete("Deprecated in favour of \"Rctrl\"")]
        [NativeName("Name", "KMOD_RCTRL")]
        KmodRctrl = 0x80,
        [Obsolete("Deprecated in favour of \"Lalt\"")]
        [NativeName("Name", "KMOD_LALT")]
        KmodLalt = 0x100,
        [Obsolete("Deprecated in favour of \"Ralt\"")]
        [NativeName("Name", "KMOD_RALT")]
        KmodRalt = 0x200,
        [Obsolete("Deprecated in favour of \"Lgui\"")]
        [NativeName("Name", "KMOD_LGUI")]
        KmodLgui = 0x400,
        [Obsolete("Deprecated in favour of \"Rgui\"")]
        [NativeName("Name", "KMOD_RGUI")]
        KmodRgui = 0x800,
        [Obsolete("Deprecated in favour of \"Num\"")]
        [NativeName("Name", "KMOD_NUM")]
        KmodNum = 0x1000,
        [Obsolete("Deprecated in favour of \"Caps\"")]
        [NativeName("Name", "KMOD_CAPS")]
        KmodCaps = 0x2000,
        [Obsolete("Deprecated in favour of \"Mode\"")]
        [NativeName("Name", "KMOD_MODE")]
        KmodMode = 0x4000,
        [Obsolete("Deprecated in favour of \"Scroll\"")]
        [NativeName("Name", "KMOD_SCROLL")]
        KmodScroll = 0x8000,
        [Obsolete("Deprecated in favour of \"Ctrl\"")]
        [NativeName("Name", "KMOD_CTRL")]
        KmodCtrl = 0xC0,
        [Obsolete("Deprecated in favour of \"Shift\"")]
        [NativeName("Name", "KMOD_SHIFT")]
        KmodShift = 0x3,
        [Obsolete("Deprecated in favour of \"Alt\"")]
        [NativeName("Name", "KMOD_ALT")]
        KmodAlt = 0x300,
        [Obsolete("Deprecated in favour of \"Gui\"")]
        [NativeName("Name", "KMOD_GUI")]
        KmodGui = 0xC00,
        [Obsolete("Deprecated in favour of \"Reserved\"")]
        [NativeName("Name", "KMOD_RESERVED")]
        KmodReserved = 0x8000,
        [NativeName("Name", "KMOD_NONE")]
        None = 0x0,
        [NativeName("Name", "KMOD_LSHIFT")]
        Lshift = 0x1,
        [NativeName("Name", "KMOD_RSHIFT")]
        Rshift = 0x2,
        [NativeName("Name", "KMOD_LCTRL")]
        Lctrl = 0x40,
        [NativeName("Name", "KMOD_RCTRL")]
        Rctrl = 0x80,
        [NativeName("Name", "KMOD_LALT")]
        Lalt = 0x100,
        [NativeName("Name", "KMOD_RALT")]
        Ralt = 0x200,
        [NativeName("Name", "KMOD_LGUI")]
        Lgui = 0x400,
        [NativeName("Name", "KMOD_RGUI")]
        Rgui = 0x800,
        [NativeName("Name", "KMOD_NUM")]
        Num = 0x1000,
        [NativeName("Name", "KMOD_CAPS")]
        Caps = 0x2000,
        [NativeName("Name", "KMOD_MODE")]
        Mode = 0x4000,
        [NativeName("Name", "KMOD_SCROLL")]
        Scroll = 0x8000,
        [NativeName("Name", "KMOD_CTRL")]
        Ctrl = 0xC0,
        [NativeName("Name", "KMOD_SHIFT")]
        Shift = 0x3,
        [NativeName("Name", "KMOD_ALT")]
        Alt = 0x300,
        [NativeName("Name", "KMOD_GUI")]
        Gui = 0xC00,
        [NativeName("Name", "KMOD_RESERVED")]
        Reserved = 0x8000,
    }
}
