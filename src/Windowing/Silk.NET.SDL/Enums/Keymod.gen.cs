// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [NativeName("AnonymousName", "__AnonymousEnum_SDL_keycode_L325_C9")]
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
    }
}
