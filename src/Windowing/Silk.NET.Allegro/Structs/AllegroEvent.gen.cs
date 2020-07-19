// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.Allegro
{
    [StructLayout(LayoutKind.Explicit)]
    [NativeName("Name", "ALLEGRO_EVENT")]
    public unsafe partial struct AllegroEvent
    {
        public AllegroEvent
        (
            uint type = default,
            AllegroAnyEvent any = default,
            AllegroDisplayEvent display = default,
            AllegroJoystickEvent joystick = default,
            AllegroKeyboardEvent keyboard = default,
            AllegroMouseEvent mouse = default,
            AllegroTimerEvent timer = default,
            AllegroTouchEvent touch = default,
            AllegroUserEvent user = default
        )
        {
            Type = type;
            Any = any;
            Display = display;
            Joystick = joystick;
            Keyboard = keyboard;
            Mouse = mouse;
            Timer = timer;
            Touch = touch;
            User = user;
        }


        [FieldOffset(0)]
        [NativeName("Type", "ALLEGRO_EVENT_TYPE")]
        [NativeName("Type.Name", "ALLEGRO_EVENT_TYPE")]
        [NativeName("Name", "type")]
        public uint Type;

        [FieldOffset(0)]
        [NativeName("Type", "ALLEGRO_ANY_EVENT")]
        [NativeName("Type.Name", "ALLEGRO_ANY_EVENT")]
        [NativeName("Name", "any")]
        public AllegroAnyEvent Any;

        [FieldOffset(0)]
        [NativeName("Type", "ALLEGRO_DISPLAY_EVENT")]
        [NativeName("Type.Name", "ALLEGRO_DISPLAY_EVENT")]
        [NativeName("Name", "display")]
        public AllegroDisplayEvent Display;

        [FieldOffset(0)]
        [NativeName("Type", "ALLEGRO_JOYSTICK_EVENT")]
        [NativeName("Type.Name", "ALLEGRO_JOYSTICK_EVENT")]
        [NativeName("Name", "joystick")]
        public AllegroJoystickEvent Joystick;

        [FieldOffset(0)]
        [NativeName("Type", "ALLEGRO_KEYBOARD_EVENT")]
        [NativeName("Type.Name", "ALLEGRO_KEYBOARD_EVENT")]
        [NativeName("Name", "keyboard")]
        public AllegroKeyboardEvent Keyboard;

        [FieldOffset(0)]
        [NativeName("Type", "ALLEGRO_MOUSE_EVENT")]
        [NativeName("Type.Name", "ALLEGRO_MOUSE_EVENT")]
        [NativeName("Name", "mouse")]
        public AllegroMouseEvent Mouse;

        [FieldOffset(0)]
        [NativeName("Type", "ALLEGRO_TIMER_EVENT")]
        [NativeName("Type.Name", "ALLEGRO_TIMER_EVENT")]
        [NativeName("Name", "timer")]
        public AllegroTimerEvent Timer;

        [FieldOffset(0)]
        [NativeName("Type", "ALLEGRO_TOUCH_EVENT")]
        [NativeName("Type.Name", "ALLEGRO_TOUCH_EVENT")]
        [NativeName("Name", "touch")]
        public AllegroTouchEvent Touch;

        [FieldOffset(0)]
        [NativeName("Type", "ALLEGRO_USER_EVENT")]
        [NativeName("Type.Name", "ALLEGRO_USER_EVENT")]
        [NativeName("Name", "user")]
        public AllegroUserEvent User;
    }
}
