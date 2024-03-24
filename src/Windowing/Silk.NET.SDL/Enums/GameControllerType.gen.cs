// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [NativeName("AnonymousName", "__AnonymousEnum_SDL_gamecontroller_L61_C9")]
    [NativeName("Name", "SDL_GameControllerType")]
    public enum GameControllerType : int
    {
        [Obsolete("Deprecated in favour of \"Unknown\"")]
        [NativeName("Name", "SDL_CONTROLLER_TYPE_UNKNOWN")]
        ControllerTypeUnknown = 0x0,
        [Obsolete("Deprecated in favour of \"Xbox360\"")]
        [NativeName("Name", "SDL_CONTROLLER_TYPE_XBOX360")]
        ControllerTypeXbox360 = 0x1,
        [Obsolete("Deprecated in favour of \"Xboxone\"")]
        [NativeName("Name", "SDL_CONTROLLER_TYPE_XBOXONE")]
        ControllerTypeXboxone = 0x2,
        [Obsolete("Deprecated in favour of \"PS3\"")]
        [NativeName("Name", "SDL_CONTROLLER_TYPE_PS3")]
        ControllerTypePS3 = 0x3,
        [Obsolete("Deprecated in favour of \"PS4\"")]
        [NativeName("Name", "SDL_CONTROLLER_TYPE_PS4")]
        ControllerTypePS4 = 0x4,
        [Obsolete("Deprecated in favour of \"NintendoSwitchPro\"")]
        [NativeName("Name", "SDL_CONTROLLER_TYPE_NINTENDO_SWITCH_PRO")]
        ControllerTypeNintendoSwitchPro = 0x5,
        [Obsolete("Deprecated in favour of \"Virtual\"")]
        [NativeName("Name", "SDL_CONTROLLER_TYPE_VIRTUAL")]
        ControllerTypeVirtual = 0x6,
        [Obsolete("Deprecated in favour of \"PS5\"")]
        [NativeName("Name", "SDL_CONTROLLER_TYPE_PS5")]
        ControllerTypePS5 = 0x7,
        [Obsolete("Deprecated in favour of \"AmazonLuna\"")]
        [NativeName("Name", "SDL_CONTROLLER_TYPE_AMAZON_LUNA")]
        ControllerTypeAmazonLuna = 0x8,
        [Obsolete("Deprecated in favour of \"GoogleStadia\"")]
        [NativeName("Name", "SDL_CONTROLLER_TYPE_GOOGLE_STADIA")]
        ControllerTypeGoogleStadia = 0x9,
        [Obsolete("Deprecated in favour of \"NvidiaShield\"")]
        [NativeName("Name", "SDL_CONTROLLER_TYPE_NVIDIA_SHIELD")]
        ControllerTypeNvidiaShield = 0xA,
        [Obsolete("Deprecated in favour of \"NintendoSwitchJoyconLeft\"")]
        [NativeName("Name", "SDL_CONTROLLER_TYPE_NINTENDO_SWITCH_JOYCON_LEFT")]
        ControllerTypeNintendoSwitchJoyconLeft = 0xB,
        [Obsolete("Deprecated in favour of \"NintendoSwitchJoyconRight\"")]
        [NativeName("Name", "SDL_CONTROLLER_TYPE_NINTENDO_SWITCH_JOYCON_RIGHT")]
        ControllerTypeNintendoSwitchJoyconRight = 0xC,
        [Obsolete("Deprecated in favour of \"NintendoSwitchJoyconPair\"")]
        [NativeName("Name", "SDL_CONTROLLER_TYPE_NINTENDO_SWITCH_JOYCON_PAIR")]
        ControllerTypeNintendoSwitchJoyconPair = 0xD,
        [Obsolete("Deprecated in favour of \"Max\"")]
        [NativeName("Name", "SDL_CONTROLLER_TYPE_MAX")]
        ControllerTypeMax = 0xE,
        [NativeName("Name", "SDL_CONTROLLER_TYPE_UNKNOWN")]
        Unknown = 0x0,
        [NativeName("Name", "SDL_CONTROLLER_TYPE_XBOX360")]
        Xbox360 = 0x1,
        [NativeName("Name", "SDL_CONTROLLER_TYPE_XBOXONE")]
        Xboxone = 0x2,
        [NativeName("Name", "SDL_CONTROLLER_TYPE_PS3")]
        PS3 = 0x3,
        [NativeName("Name", "SDL_CONTROLLER_TYPE_PS4")]
        PS4 = 0x4,
        [NativeName("Name", "SDL_CONTROLLER_TYPE_NINTENDO_SWITCH_PRO")]
        NintendoSwitchPro = 0x5,
        [NativeName("Name", "SDL_CONTROLLER_TYPE_VIRTUAL")]
        Virtual = 0x6,
        [NativeName("Name", "SDL_CONTROLLER_TYPE_PS5")]
        PS5 = 0x7,
        [NativeName("Name", "SDL_CONTROLLER_TYPE_AMAZON_LUNA")]
        AmazonLuna = 0x8,
        [NativeName("Name", "SDL_CONTROLLER_TYPE_GOOGLE_STADIA")]
        GoogleStadia = 0x9,
        [NativeName("Name", "SDL_CONTROLLER_TYPE_NVIDIA_SHIELD")]
        NvidiaShield = 0xA,
        [NativeName("Name", "SDL_CONTROLLER_TYPE_NINTENDO_SWITCH_JOYCON_LEFT")]
        NintendoSwitchJoyconLeft = 0xB,
        [NativeName("Name", "SDL_CONTROLLER_TYPE_NINTENDO_SWITCH_JOYCON_RIGHT")]
        NintendoSwitchJoyconRight = 0xC,
        [NativeName("Name", "SDL_CONTROLLER_TYPE_NINTENDO_SWITCH_JOYCON_PAIR")]
        NintendoSwitchJoyconPair = 0xD,
        [NativeName("Name", "SDL_CONTROLLER_TYPE_MAX")]
        Max = 0xE,
    }
}
