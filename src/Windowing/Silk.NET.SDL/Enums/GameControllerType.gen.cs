// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [NativeName("AnonymousName", "__AnonymousEnum_SDL_gamecontroller_L60_C9")]
    [NativeName("Name", "SDL_GameControllerType")]
    public enum GameControllerType : int
    {
        [NativeName("Name", "SDL_CONTROLLER_TYPE_UNKNOWN")]
        ControllerTypeUnknown = 0x0,
        [NativeName("Name", "SDL_CONTROLLER_TYPE_XBOX360")]
        ControllerTypeXbox360 = 0x1,
        [NativeName("Name", "SDL_CONTROLLER_TYPE_XBOXONE")]
        ControllerTypeXboxone = 0x2,
        [NativeName("Name", "SDL_CONTROLLER_TYPE_PS3")]
        ControllerTypePS3 = 0x3,
        [NativeName("Name", "SDL_CONTROLLER_TYPE_PS4")]
        ControllerTypePS4 = 0x4,
        [NativeName("Name", "SDL_CONTROLLER_TYPE_NINTENDO_SWITCH_PRO")]
        ControllerTypeNintendoSwitchPro = 0x5,
    }
}
