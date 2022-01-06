// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [Flags]
    [NativeName("AnonymousName", "__AnonymousEnum_SDL_keycode_L327_C9")]
    [NativeName("Name", "SDL_Keymod")]
    public enum Keymod : int
    {
        [NativeName("Name", "KMOD_NONE")]
        KmodNone = 0x0,
        [NativeName("Name", "KMOD_LSHIFT")]
        KmodLshift = 0x1,
        [NativeName("Name", "KMOD_RSHIFT")]
        KmodRshift = 0x2,
        [NativeName("Name", "KMOD_LCTRL")]
        KmodLctrl = 0x40,
        [NativeName("Name", "KMOD_RCTRL")]
        KmodRctrl = 0x80,
        [NativeName("Name", "KMOD_LALT")]
        KmodLalt = 0x100,
        [NativeName("Name", "KMOD_RALT")]
        KmodRalt = 0x200,
        [NativeName("Name", "KMOD_LGUI")]
        KmodLgui = 0x400,
        [NativeName("Name", "KMOD_RGUI")]
        KmodRgui = 0x800,
        [NativeName("Name", "KMOD_NUM")]
        KmodNum = 0x1000,
        [NativeName("Name", "KMOD_CAPS")]
        KmodCaps = 0x2000,
        [NativeName("Name", "KMOD_MODE")]
        KmodMode = 0x4000,
        [NativeName("Name", "KMOD_RESERVED")]
        KmodReserved = 0x8000,
        [NativeName("Name", "KMOD_CTRL")]
        KmodCtrl = 0xC0,
        [NativeName("Name", "KMOD_SHIFT")]
        KmodShift = 0x3,
        [NativeName("Name", "KMOD_ALT")]
        KmodAlt = 0x300,
        [NativeName("Name", "KMOD_GUI")]
        KmodGui = 0xC00,
    }
}
