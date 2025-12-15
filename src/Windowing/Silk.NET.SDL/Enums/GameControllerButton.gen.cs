// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [NativeName("AnonymousName", "__AnonymousEnum_SDL_gamecontroller_L730_C9")]
    [NativeName("Name", "SDL_GameControllerButton")]
    public enum GameControllerButton : int
    {
        [Obsolete("Deprecated in favour of \"Invalid\"")]
        [NativeName("Name", "SDL_CONTROLLER_BUTTON_INVALID")]
        ControllerButtonInvalid = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [Obsolete("Deprecated in favour of \"A\"")]
        [NativeName("Name", "SDL_CONTROLLER_BUTTON_A")]
        ControllerButtonA = 0x0,
        [Obsolete("Deprecated in favour of \"B\"")]
        [NativeName("Name", "SDL_CONTROLLER_BUTTON_B")]
        ControllerButtonB = 0x1,
        [Obsolete("Deprecated in favour of \"X\"")]
        [NativeName("Name", "SDL_CONTROLLER_BUTTON_X")]
        ControllerButtonX = 0x2,
        [Obsolete("Deprecated in favour of \"Y\"")]
        [NativeName("Name", "SDL_CONTROLLER_BUTTON_Y")]
        ControllerButtonY = 0x3,
        [Obsolete("Deprecated in favour of \"Back\"")]
        [NativeName("Name", "SDL_CONTROLLER_BUTTON_BACK")]
        ControllerButtonBack = 0x4,
        [Obsolete("Deprecated in favour of \"Guide\"")]
        [NativeName("Name", "SDL_CONTROLLER_BUTTON_GUIDE")]
        ControllerButtonGuide = 0x5,
        [Obsolete("Deprecated in favour of \"Start\"")]
        [NativeName("Name", "SDL_CONTROLLER_BUTTON_START")]
        ControllerButtonStart = 0x6,
        [Obsolete("Deprecated in favour of \"Leftstick\"")]
        [NativeName("Name", "SDL_CONTROLLER_BUTTON_LEFTSTICK")]
        ControllerButtonLeftstick = 0x7,
        [Obsolete("Deprecated in favour of \"Rightstick\"")]
        [NativeName("Name", "SDL_CONTROLLER_BUTTON_RIGHTSTICK")]
        ControllerButtonRightstick = 0x8,
        [Obsolete("Deprecated in favour of \"Leftshoulder\"")]
        [NativeName("Name", "SDL_CONTROLLER_BUTTON_LEFTSHOULDER")]
        ControllerButtonLeftshoulder = 0x9,
        [Obsolete("Deprecated in favour of \"Rightshoulder\"")]
        [NativeName("Name", "SDL_CONTROLLER_BUTTON_RIGHTSHOULDER")]
        ControllerButtonRightshoulder = 0xA,
        [Obsolete("Deprecated in favour of \"DpadUp\"")]
        [NativeName("Name", "SDL_CONTROLLER_BUTTON_DPAD_UP")]
        ControllerButtonDpadUp = 0xB,
        [Obsolete("Deprecated in favour of \"DpadDown\"")]
        [NativeName("Name", "SDL_CONTROLLER_BUTTON_DPAD_DOWN")]
        ControllerButtonDpadDown = 0xC,
        [Obsolete("Deprecated in favour of \"DpadLeft\"")]
        [NativeName("Name", "SDL_CONTROLLER_BUTTON_DPAD_LEFT")]
        ControllerButtonDpadLeft = 0xD,
        [Obsolete("Deprecated in favour of \"DpadRight\"")]
        [NativeName("Name", "SDL_CONTROLLER_BUTTON_DPAD_RIGHT")]
        ControllerButtonDpadRight = 0xE,
        [Obsolete("Deprecated in favour of \"Misc1\"")]
        [NativeName("Name", "SDL_CONTROLLER_BUTTON_MISC1")]
        ControllerButtonMisc1 = 0xF,
        [Obsolete("Deprecated in favour of \"Paddle1\"")]
        [NativeName("Name", "SDL_CONTROLLER_BUTTON_PADDLE1")]
        ControllerButtonPaddle1 = 0x10,
        [Obsolete("Deprecated in favour of \"Paddle2\"")]
        [NativeName("Name", "SDL_CONTROLLER_BUTTON_PADDLE2")]
        ControllerButtonPaddle2 = 0x11,
        [Obsolete("Deprecated in favour of \"Paddle3\"")]
        [NativeName("Name", "SDL_CONTROLLER_BUTTON_PADDLE3")]
        ControllerButtonPaddle3 = 0x12,
        [Obsolete("Deprecated in favour of \"Paddle4\"")]
        [NativeName("Name", "SDL_CONTROLLER_BUTTON_PADDLE4")]
        ControllerButtonPaddle4 = 0x13,
        [Obsolete("Deprecated in favour of \"Touchpad\"")]
        [NativeName("Name", "SDL_CONTROLLER_BUTTON_TOUCHPAD")]
        ControllerButtonTouchpad = 0x14,
        [Obsolete("Deprecated in favour of \"Max\"")]
        [NativeName("Name", "SDL_CONTROLLER_BUTTON_MAX")]
        ControllerButtonMax = 0x15,
        [NativeName("Name", "SDL_CONTROLLER_BUTTON_INVALID")]
        Invalid = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "SDL_CONTROLLER_BUTTON_A")]
        A = 0x0,
        [NativeName("Name", "SDL_CONTROLLER_BUTTON_B")]
        B = 0x1,
        [NativeName("Name", "SDL_CONTROLLER_BUTTON_X")]
        X = 0x2,
        [NativeName("Name", "SDL_CONTROLLER_BUTTON_Y")]
        Y = 0x3,
        [NativeName("Name", "SDL_CONTROLLER_BUTTON_BACK")]
        Back = 0x4,
        [NativeName("Name", "SDL_CONTROLLER_BUTTON_GUIDE")]
        Guide = 0x5,
        [NativeName("Name", "SDL_CONTROLLER_BUTTON_START")]
        Start = 0x6,
        [NativeName("Name", "SDL_CONTROLLER_BUTTON_LEFTSTICK")]
        Leftstick = 0x7,
        [NativeName("Name", "SDL_CONTROLLER_BUTTON_RIGHTSTICK")]
        Rightstick = 0x8,
        [NativeName("Name", "SDL_CONTROLLER_BUTTON_LEFTSHOULDER")]
        Leftshoulder = 0x9,
        [NativeName("Name", "SDL_CONTROLLER_BUTTON_RIGHTSHOULDER")]
        Rightshoulder = 0xA,
        [NativeName("Name", "SDL_CONTROLLER_BUTTON_DPAD_UP")]
        DpadUp = 0xB,
        [NativeName("Name", "SDL_CONTROLLER_BUTTON_DPAD_DOWN")]
        DpadDown = 0xC,
        [NativeName("Name", "SDL_CONTROLLER_BUTTON_DPAD_LEFT")]
        DpadLeft = 0xD,
        [NativeName("Name", "SDL_CONTROLLER_BUTTON_DPAD_RIGHT")]
        DpadRight = 0xE,
        [NativeName("Name", "SDL_CONTROLLER_BUTTON_MISC1")]
        Misc1 = 0xF,
        [NativeName("Name", "SDL_CONTROLLER_BUTTON_PADDLE1")]
        Paddle1 = 0x10,
        [NativeName("Name", "SDL_CONTROLLER_BUTTON_PADDLE2")]
        Paddle2 = 0x11,
        [NativeName("Name", "SDL_CONTROLLER_BUTTON_PADDLE3")]
        Paddle3 = 0x12,
        [NativeName("Name", "SDL_CONTROLLER_BUTTON_PADDLE4")]
        Paddle4 = 0x13,
        [NativeName("Name", "SDL_CONTROLLER_BUTTON_TOUCHPAD")]
        Touchpad = 0x14,
        [NativeName("Name", "SDL_CONTROLLER_BUTTON_MAX")]
        Max = 0x15,
    }
}
