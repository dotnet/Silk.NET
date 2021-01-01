// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [NativeName("AnonymousName", "__AnonymousEnum_SDL_gamecontroller_L346_C9")]
    [NativeName("Name", "SDL_GameControllerButton")]
    public enum GameControllerButton : int
    {
        [NativeName("Name", "SDL_CONTROLLER_BUTTON_INVALID")]
        ControllerButtonInvalid = unchecked((int)0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "SDL_CONTROLLER_BUTTON_A")]
        ControllerButtonA = 0x0,
        [NativeName("Name", "SDL_CONTROLLER_BUTTON_B")]
        ControllerButtonB = 0x1,
        [NativeName("Name", "SDL_CONTROLLER_BUTTON_X")]
        ControllerButtonX = 0x2,
        [NativeName("Name", "SDL_CONTROLLER_BUTTON_Y")]
        ControllerButtonY = 0x3,
        [NativeName("Name", "SDL_CONTROLLER_BUTTON_BACK")]
        ControllerButtonBack = 0x4,
        [NativeName("Name", "SDL_CONTROLLER_BUTTON_GUIDE")]
        ControllerButtonGuide = 0x5,
        [NativeName("Name", "SDL_CONTROLLER_BUTTON_START")]
        ControllerButtonStart = 0x6,
        [NativeName("Name", "SDL_CONTROLLER_BUTTON_LEFTSTICK")]
        ControllerButtonLeftstick = 0x7,
        [NativeName("Name", "SDL_CONTROLLER_BUTTON_RIGHTSTICK")]
        ControllerButtonRightstick = 0x8,
        [NativeName("Name", "SDL_CONTROLLER_BUTTON_LEFTSHOULDER")]
        ControllerButtonLeftshoulder = 0x9,
        [NativeName("Name", "SDL_CONTROLLER_BUTTON_RIGHTSHOULDER")]
        ControllerButtonRightshoulder = 0xA,
        [NativeName("Name", "SDL_CONTROLLER_BUTTON_DPAD_UP")]
        ControllerButtonDpadUp = 0xB,
        [NativeName("Name", "SDL_CONTROLLER_BUTTON_DPAD_DOWN")]
        ControllerButtonDpadDown = 0xC,
        [NativeName("Name", "SDL_CONTROLLER_BUTTON_DPAD_LEFT")]
        ControllerButtonDpadLeft = 0xD,
        [NativeName("Name", "SDL_CONTROLLER_BUTTON_DPAD_RIGHT")]
        ControllerButtonDpadRight = 0xE,
        [NativeName("Name", "SDL_CONTROLLER_BUTTON_MAX")]
        ControllerButtonMax = 0xF,
    }
}
