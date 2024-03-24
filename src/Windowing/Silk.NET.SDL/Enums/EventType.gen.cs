// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [NativeName("AnonymousName", "__AnonymousEnum_SDL_events_L55_C9")]
    [NativeName("Name", "SDL_EventType")]
    public enum EventType : int
    {
        [NativeName("Name", "SDL_FIRSTEVENT")]
        Firstevent = 0x0,
        [NativeName("Name", "SDL_QUIT")]
        Quit = 0x100,
        [NativeName("Name", "SDL_APP_TERMINATING")]
        AppTerminating = 0x101,
        [NativeName("Name", "SDL_APP_LOWMEMORY")]
        AppLowmemory = 0x102,
        [NativeName("Name", "SDL_APP_WILLENTERBACKGROUND")]
        AppWillenterbackground = 0x103,
        [NativeName("Name", "SDL_APP_DIDENTERBACKGROUND")]
        AppDidenterbackground = 0x104,
        [NativeName("Name", "SDL_APP_WILLENTERFOREGROUND")]
        AppWillenterforeground = 0x105,
        [NativeName("Name", "SDL_APP_DIDENTERFOREGROUND")]
        AppDidenterforeground = 0x106,
        [NativeName("Name", "SDL_LOCALECHANGED")]
        Localechanged = 0x107,
        [NativeName("Name", "SDL_DISPLAYEVENT")]
        Displayevent = 0x150,
        [NativeName("Name", "SDL_WINDOWEVENT")]
        Windowevent = 0x200,
        [NativeName("Name", "SDL_SYSWMEVENT")]
        Syswmevent = 0x201,
        [NativeName("Name", "SDL_KEYDOWN")]
        Keydown = 0x300,
        [NativeName("Name", "SDL_KEYUP")]
        Keyup = 0x301,
        [NativeName("Name", "SDL_TEXTEDITING")]
        Textediting = 0x302,
        [NativeName("Name", "SDL_TEXTINPUT")]
        Textinput = 0x303,
        [NativeName("Name", "SDL_KEYMAPCHANGED")]
        Keymapchanged = 0x304,
        [NativeName("Name", "SDL_TEXTEDITING_EXT")]
        TexteditingExt = 0x305,
        [NativeName("Name", "SDL_MOUSEMOTION")]
        Mousemotion = 0x400,
        [NativeName("Name", "SDL_MOUSEBUTTONDOWN")]
        Mousebuttondown = 0x401,
        [NativeName("Name", "SDL_MOUSEBUTTONUP")]
        Mousebuttonup = 0x402,
        [NativeName("Name", "SDL_MOUSEWHEEL")]
        Mousewheel = 0x403,
        [NativeName("Name", "SDL_JOYAXISMOTION")]
        Joyaxismotion = 0x600,
        [NativeName("Name", "SDL_JOYBALLMOTION")]
        Joyballmotion = 0x601,
        [NativeName("Name", "SDL_JOYHATMOTION")]
        Joyhatmotion = 0x602,
        [NativeName("Name", "SDL_JOYBUTTONDOWN")]
        Joybuttondown = 0x603,
        [NativeName("Name", "SDL_JOYBUTTONUP")]
        Joybuttonup = 0x604,
        [NativeName("Name", "SDL_JOYDEVICEADDED")]
        Joydeviceadded = 0x605,
        [NativeName("Name", "SDL_JOYDEVICEREMOVED")]
        Joydeviceremoved = 0x606,
        [NativeName("Name", "SDL_JOYBATTERYUPDATED")]
        Joybatteryupdated = 0x607,
        [NativeName("Name", "SDL_CONTROLLERAXISMOTION")]
        Controlleraxismotion = 0x650,
        [NativeName("Name", "SDL_CONTROLLERBUTTONDOWN")]
        Controllerbuttondown = 0x651,
        [NativeName("Name", "SDL_CONTROLLERBUTTONUP")]
        Controllerbuttonup = 0x652,
        [NativeName("Name", "SDL_CONTROLLERDEVICEADDED")]
        Controllerdeviceadded = 0x653,
        [NativeName("Name", "SDL_CONTROLLERDEVICEREMOVED")]
        Controllerdeviceremoved = 0x654,
        [NativeName("Name", "SDL_CONTROLLERDEVICEREMAPPED")]
        Controllerdeviceremapped = 0x655,
        [NativeName("Name", "SDL_CONTROLLERTOUCHPADDOWN")]
        Controllertouchpaddown = 0x656,
        [NativeName("Name", "SDL_CONTROLLERTOUCHPADMOTION")]
        Controllertouchpadmotion = 0x657,
        [NativeName("Name", "SDL_CONTROLLERTOUCHPADUP")]
        Controllertouchpadup = 0x658,
        [NativeName("Name", "SDL_CONTROLLERSENSORUPDATE")]
        Controllersensorupdate = 0x659,
        [NativeName("Name", "SDL_CONTROLLERUPDATECOMPLETE_RESERVED_FOR_SDL3")]
        ControllerupdatecompleteReservedForSdl3 = 0x65A,
        [NativeName("Name", "SDL_CONTROLLERSTEAMHANDLEUPDATED")]
        Controllersteamhandleupdated = 0x65B,
        [NativeName("Name", "SDL_FINGERDOWN")]
        Fingerdown = 0x700,
        [NativeName("Name", "SDL_FINGERUP")]
        Fingerup = 0x701,
        [NativeName("Name", "SDL_FINGERMOTION")]
        Fingermotion = 0x702,
        [NativeName("Name", "SDL_DOLLARGESTURE")]
        Dollargesture = 0x800,
        [NativeName("Name", "SDL_DOLLARRECORD")]
        Dollarrecord = 0x801,
        [NativeName("Name", "SDL_MULTIGESTURE")]
        Multigesture = 0x802,
        [NativeName("Name", "SDL_CLIPBOARDUPDATE")]
        Clipboardupdate = 0x900,
        [NativeName("Name", "SDL_DROPFILE")]
        Dropfile = 0x1000,
        [NativeName("Name", "SDL_DROPTEXT")]
        Droptext = 0x1001,
        [NativeName("Name", "SDL_DROPBEGIN")]
        Dropbegin = 0x1002,
        [NativeName("Name", "SDL_DROPCOMPLETE")]
        Dropcomplete = 0x1003,
        [NativeName("Name", "SDL_AUDIODEVICEADDED")]
        Audiodeviceadded = 0x1100,
        [NativeName("Name", "SDL_AUDIODEVICEREMOVED")]
        Audiodeviceremoved = 0x1101,
        [NativeName("Name", "SDL_SENSORUPDATE")]
        Sensorupdate = 0x1200,
        [NativeName("Name", "SDL_RENDER_TARGETS_RESET")]
        RenderTargetsReset = 0x2000,
        [NativeName("Name", "SDL_RENDER_DEVICE_RESET")]
        RenderDeviceReset = 0x2001,
        [NativeName("Name", "SDL_POLLSENTINEL")]
        Pollsentinel = 0x7F00,
        [NativeName("Name", "SDL_USEREVENT")]
        Userevent = 0x8000,
        [NativeName("Name", "SDL_LASTEVENT")]
        Lastevent = 0xFFFF,
    }
}
