// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Allegro
{
    [NativeName("Name", "__AnonymousEnum_events_L15_C1")]
    public enum AllegroEventKind
    {
        [NativeName("Name", "ALLEGRO_EVENT_JOYSTICK_AXIS")]
        AllegroEventJoystickAxis = 0x1,
        [NativeName("Name", "ALLEGRO_EVENT_JOYSTICK_BUTTON_DOWN")]
        AllegroEventJoystickButtonDown = 0x2,
        [NativeName("Name", "ALLEGRO_EVENT_JOYSTICK_BUTTON_UP")]
        AllegroEventJoystickButtonUp = 0x3,
        [NativeName("Name", "ALLEGRO_EVENT_JOYSTICK_CONFIGURATION")]
        AllegroEventJoystickConfiguration = 0x4,
        [NativeName("Name", "ALLEGRO_EVENT_KEY_DOWN")]
        AllegroEventKeyDown = 0xA,
        [NativeName("Name", "ALLEGRO_EVENT_KEY_CHAR")]
        AllegroEventKeyChar = 0xB,
        [NativeName("Name", "ALLEGRO_EVENT_KEY_UP")]
        AllegroEventKeyUp = 0xC,
        [NativeName("Name", "ALLEGRO_EVENT_MOUSE_AXES")]
        AllegroEventMouseAxes = 0x14,
        [NativeName("Name", "ALLEGRO_EVENT_MOUSE_BUTTON_DOWN")]
        AllegroEventMouseButtonDown = 0x15,
        [NativeName("Name", "ALLEGRO_EVENT_MOUSE_BUTTON_UP")]
        AllegroEventMouseButtonUp = 0x16,
        [NativeName("Name", "ALLEGRO_EVENT_MOUSE_ENTER_DISPLAY")]
        AllegroEventMouseEnterDisplay = 0x17,
        [NativeName("Name", "ALLEGRO_EVENT_MOUSE_LEAVE_DISPLAY")]
        AllegroEventMouseLeaveDisplay = 0x18,
        [NativeName("Name", "ALLEGRO_EVENT_MOUSE_WARPED")]
        AllegroEventMouseWarped = 0x19,
        [NativeName("Name", "ALLEGRO_EVENT_TIMER")]
        AllegroEventTimer = 0x1E,
        [NativeName("Name", "ALLEGRO_EVENT_DISPLAY_EXPOSE")]
        AllegroEventDisplayExpose = 0x28,
        [NativeName("Name", "ALLEGRO_EVENT_DISPLAY_RESIZE")]
        AllegroEventDisplayResize = 0x29,
        [NativeName("Name", "ALLEGRO_EVENT_DISPLAY_CLOSE")]
        AllegroEventDisplayClose = 0x2A,
        [NativeName("Name", "ALLEGRO_EVENT_DISPLAY_LOST")]
        AllegroEventDisplayLost = 0x2B,
        [NativeName("Name", "ALLEGRO_EVENT_DISPLAY_FOUND")]
        AllegroEventDisplayFound = 0x2C,
        [NativeName("Name", "ALLEGRO_EVENT_DISPLAY_SWITCH_IN")]
        AllegroEventDisplaySwitchIn = 0x2D,
        [NativeName("Name", "ALLEGRO_EVENT_DISPLAY_SWITCH_OUT")]
        AllegroEventDisplaySwitchOut = 0x2E,
        [NativeName("Name", "ALLEGRO_EVENT_DISPLAY_ORIENTATION")]
        AllegroEventDisplayOrientation = 0x2F,
        [NativeName("Name", "ALLEGRO_EVENT_DISPLAY_HALT_DRAWING")]
        AllegroEventDisplayHaltDrawing = 0x30,
        [NativeName("Name", "ALLEGRO_EVENT_DISPLAY_RESUME_DRAWING")]
        AllegroEventDisplayResumeDrawing = 0x31,
        [NativeName("Name", "ALLEGRO_EVENT_TOUCH_BEGIN")]
        AllegroEventTouchBegin = 0x32,
        [NativeName("Name", "ALLEGRO_EVENT_TOUCH_END")]
        AllegroEventTouchEnd = 0x33,
        [NativeName("Name", "ALLEGRO_EVENT_TOUCH_MOVE")]
        AllegroEventTouchMove = 0x34,
        [NativeName("Name", "ALLEGRO_EVENT_TOUCH_CANCEL")]
        AllegroEventTouchCancel = 0x35,
        [NativeName("Name", "ALLEGRO_EVENT_DISPLAY_CONNECTED")]
        AllegroEventDisplayConnected = 0x3C,
        [NativeName("Name", "ALLEGRO_EVENT_DISPLAY_DISCONNECTED")]
        AllegroEventDisplayDisconnected = 0x3D,
    }
}
