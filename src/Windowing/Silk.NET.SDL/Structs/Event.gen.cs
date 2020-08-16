// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [StructLayout(LayoutKind.Explicit)]
    [NativeName("Name", "SDL_Event")]
    public unsafe partial struct Event
    {
        public Event
        (
            uint type = default,
            CommonEvent common = default,
            DisplayEvent display = default,
            WindowEvent window = default,
            KeyboardEvent key = default,
            TextEditingEvent edit = default,
            TextInputEvent text = default,
            MouseMotionEvent motion = default,
            MouseButtonEvent button = default,
            MouseWheelEvent wheel = default,
            JoyAxisEvent jaxis = default,
            JoyBallEvent jball = default,
            JoyHatEvent jhat = default,
            JoyButtonEvent jbutton = default,
            JoyDeviceEvent jdevice = default,
            ControllerAxisEvent caxis = default,
            ControllerButtonEvent cbutton = default,
            ControllerDeviceEvent cdevice = default,
            AudioDeviceEvent adevice = default,
            SensorEvent sensor = default,
            QuitEvent quit = default,
            UserEvent user = default,
            SysWMEvent syswm = default,
            TouchFingerEvent tfinger = default,
            MultiGestureEvent mgesture = default,
            DollarGestureEvent dgesture = default,
            DropEvent drop = default
        )
        {
            Type = type;
            Common = common;
            Display = display;
            Window = window;
            Key = key;
            Edit = edit;
            Text = text;
            Motion = motion;
            Button = button;
            Wheel = wheel;
            Jaxis = jaxis;
            Jball = jball;
            Jhat = jhat;
            Jbutton = jbutton;
            Jdevice = jdevice;
            Caxis = caxis;
            Cbutton = cbutton;
            Cdevice = cdevice;
            Adevice = adevice;
            Sensor = sensor;
            Quit = quit;
            User = user;
            Syswm = syswm;
            Tfinger = tfinger;
            Mgesture = mgesture;
            Dgesture = dgesture;
            Drop = drop;
        }


        [FieldOffset(0)]
        [NativeName("Type", "Uint32")]
        [NativeName("Type.Name", "Uint32")]
        [NativeName("Name", "type")]
        public uint Type;

        [FieldOffset(0)]
        [NativeName("Type", "SDL_CommonEvent")]
        [NativeName("Type.Name", "SDL_CommonEvent")]
        [NativeName("Name", "common")]
        public CommonEvent Common;

        [FieldOffset(0)]
        [NativeName("Type", "SDL_DisplayEvent")]
        [NativeName("Type.Name", "SDL_DisplayEvent")]
        [NativeName("Name", "display")]
        public DisplayEvent Display;

        [FieldOffset(0)]
        [NativeName("Type", "SDL_WindowEvent")]
        [NativeName("Type.Name", "SDL_WindowEvent")]
        [NativeName("Name", "window")]
        public WindowEvent Window;

        [FieldOffset(0)]
        [NativeName("Type", "SDL_KeyboardEvent")]
        [NativeName("Type.Name", "SDL_KeyboardEvent")]
        [NativeName("Name", "key")]
        public KeyboardEvent Key;

        [FieldOffset(0)]
        [NativeName("Type", "SDL_TextEditingEvent")]
        [NativeName("Type.Name", "SDL_TextEditingEvent")]
        [NativeName("Name", "edit")]
        public TextEditingEvent Edit;

        [FieldOffset(0)]
        [NativeName("Type", "SDL_TextInputEvent")]
        [NativeName("Type.Name", "SDL_TextInputEvent")]
        [NativeName("Name", "text")]
        public TextInputEvent Text;

        [FieldOffset(0)]
        [NativeName("Type", "SDL_MouseMotionEvent")]
        [NativeName("Type.Name", "SDL_MouseMotionEvent")]
        [NativeName("Name", "motion")]
        public MouseMotionEvent Motion;

        [FieldOffset(0)]
        [NativeName("Type", "SDL_MouseButtonEvent")]
        [NativeName("Type.Name", "SDL_MouseButtonEvent")]
        [NativeName("Name", "button")]
        public MouseButtonEvent Button;

        [FieldOffset(0)]
        [NativeName("Type", "SDL_MouseWheelEvent")]
        [NativeName("Type.Name", "SDL_MouseWheelEvent")]
        [NativeName("Name", "wheel")]
        public MouseWheelEvent Wheel;

        [FieldOffset(0)]
        [NativeName("Type", "SDL_JoyAxisEvent")]
        [NativeName("Type.Name", "SDL_JoyAxisEvent")]
        [NativeName("Name", "jaxis")]
        public JoyAxisEvent Jaxis;

        [FieldOffset(0)]
        [NativeName("Type", "SDL_JoyBallEvent")]
        [NativeName("Type.Name", "SDL_JoyBallEvent")]
        [NativeName("Name", "jball")]
        public JoyBallEvent Jball;

        [FieldOffset(0)]
        [NativeName("Type", "SDL_JoyHatEvent")]
        [NativeName("Type.Name", "SDL_JoyHatEvent")]
        [NativeName("Name", "jhat")]
        public JoyHatEvent Jhat;

        [FieldOffset(0)]
        [NativeName("Type", "SDL_JoyButtonEvent")]
        [NativeName("Type.Name", "SDL_JoyButtonEvent")]
        [NativeName("Name", "jbutton")]
        public JoyButtonEvent Jbutton;

        [FieldOffset(0)]
        [NativeName("Type", "SDL_JoyDeviceEvent")]
        [NativeName("Type.Name", "SDL_JoyDeviceEvent")]
        [NativeName("Name", "jdevice")]
        public JoyDeviceEvent Jdevice;

        [FieldOffset(0)]
        [NativeName("Type", "SDL_ControllerAxisEvent")]
        [NativeName("Type.Name", "SDL_ControllerAxisEvent")]
        [NativeName("Name", "caxis")]
        public ControllerAxisEvent Caxis;

        [FieldOffset(0)]
        [NativeName("Type", "SDL_ControllerButtonEvent")]
        [NativeName("Type.Name", "SDL_ControllerButtonEvent")]
        [NativeName("Name", "cbutton")]
        public ControllerButtonEvent Cbutton;

        [FieldOffset(0)]
        [NativeName("Type", "SDL_ControllerDeviceEvent")]
        [NativeName("Type.Name", "SDL_ControllerDeviceEvent")]
        [NativeName("Name", "cdevice")]
        public ControllerDeviceEvent Cdevice;

        [FieldOffset(0)]
        [NativeName("Type", "SDL_AudioDeviceEvent")]
        [NativeName("Type.Name", "SDL_AudioDeviceEvent")]
        [NativeName("Name", "adevice")]
        public AudioDeviceEvent Adevice;

        [FieldOffset(0)]
        [NativeName("Type", "SDL_SensorEvent")]
        [NativeName("Type.Name", "SDL_SensorEvent")]
        [NativeName("Name", "sensor")]
        public SensorEvent Sensor;

        [FieldOffset(0)]
        [NativeName("Type", "SDL_QuitEvent")]
        [NativeName("Type.Name", "SDL_QuitEvent")]
        [NativeName("Name", "quit")]
        public QuitEvent Quit;

        [FieldOffset(0)]
        [NativeName("Type", "SDL_UserEvent")]
        [NativeName("Type.Name", "SDL_UserEvent")]
        [NativeName("Name", "user")]
        public UserEvent User;

        [FieldOffset(0)]
        [NativeName("Type", "SDL_SysWMEvent")]
        [NativeName("Type.Name", "SDL_SysWMEvent")]
        [NativeName("Name", "syswm")]
        public SysWMEvent Syswm;

        [FieldOffset(0)]
        [NativeName("Type", "SDL_TouchFingerEvent")]
        [NativeName("Type.Name", "SDL_TouchFingerEvent")]
        [NativeName("Name", "tfinger")]
        public TouchFingerEvent Tfinger;

        [FieldOffset(0)]
        [NativeName("Type", "SDL_MultiGestureEvent")]
        [NativeName("Type.Name", "SDL_MultiGestureEvent")]
        [NativeName("Name", "mgesture")]
        public MultiGestureEvent Mgesture;

        [FieldOffset(0)]
        [NativeName("Type", "SDL_DollarGestureEvent")]
        [NativeName("Type.Name", "SDL_DollarGestureEvent")]
        [NativeName("Name", "dgesture")]
        public DollarGestureEvent Dgesture;

        [FieldOffset(0)]
        [NativeName("Type", "SDL_DropEvent")]
        [NativeName("Type.Name", "SDL_DropEvent")]
        [NativeName("Name", "drop")]
        public DropEvent Drop;
        [FieldOffset(0)]
        [NativeName("Type", "Uint8 [56]")]
        [NativeName("Type.Name", "Uint8 [56]")]
        [NativeName("Name", "padding")]
        public fixed byte Padding[56];
    }
}
