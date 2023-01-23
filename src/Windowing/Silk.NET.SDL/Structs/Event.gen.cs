// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
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
            uint? type = null,
            CommonEvent? common = null,
            DisplayEvent? display = null,
            WindowEvent? window = null,
            KeyboardEvent? key = null,
            TextEditingEvent? edit = null,
            TextEditingExtEvent? editExt = null,
            TextInputEvent? text = null,
            MouseMotionEvent? motion = null,
            MouseButtonEvent? button = null,
            MouseWheelEvent? wheel = null,
            JoyAxisEvent? jaxis = null,
            JoyBallEvent? jball = null,
            JoyHatEvent? jhat = null,
            JoyButtonEvent? jbutton = null,
            JoyDeviceEvent? jdevice = null,
            JoyBatteryEvent? jbattery = null,
            ControllerAxisEvent? caxis = null,
            ControllerButtonEvent? cbutton = null,
            ControllerDeviceEvent? cdevice = null,
            ControllerTouchpadEvent? ctouchpad = null,
            ControllerSensorEvent? csensor = null,
            AudioDeviceEvent? adevice = null,
            SensorEvent? sensor = null,
            QuitEvent? quit = null,
            UserEvent? user = null,
            SysWMEvent? syswm = null,
            TouchFingerEvent? tfinger = null,
            MultiGestureEvent? mgesture = null,
            DollarGestureEvent? dgesture = null,
            DropEvent? drop = null
        ) : this()
        {
            if (type is not null)
            {
                Type = type.Value;
            }

            if (common is not null)
            {
                Common = common.Value;
            }

            if (display is not null)
            {
                Display = display.Value;
            }

            if (window is not null)
            {
                Window = window.Value;
            }

            if (key is not null)
            {
                Key = key.Value;
            }

            if (edit is not null)
            {
                Edit = edit.Value;
            }

            if (editExt is not null)
            {
                EditExt = editExt.Value;
            }

            if (text is not null)
            {
                Text = text.Value;
            }

            if (motion is not null)
            {
                Motion = motion.Value;
            }

            if (button is not null)
            {
                Button = button.Value;
            }

            if (wheel is not null)
            {
                Wheel = wheel.Value;
            }

            if (jaxis is not null)
            {
                Jaxis = jaxis.Value;
            }

            if (jball is not null)
            {
                Jball = jball.Value;
            }

            if (jhat is not null)
            {
                Jhat = jhat.Value;
            }

            if (jbutton is not null)
            {
                Jbutton = jbutton.Value;
            }

            if (jdevice is not null)
            {
                Jdevice = jdevice.Value;
            }

            if (jbattery is not null)
            {
                Jbattery = jbattery.Value;
            }

            if (caxis is not null)
            {
                Caxis = caxis.Value;
            }

            if (cbutton is not null)
            {
                Cbutton = cbutton.Value;
            }

            if (cdevice is not null)
            {
                Cdevice = cdevice.Value;
            }

            if (ctouchpad is not null)
            {
                Ctouchpad = ctouchpad.Value;
            }

            if (csensor is not null)
            {
                Csensor = csensor.Value;
            }

            if (adevice is not null)
            {
                Adevice = adevice.Value;
            }

            if (sensor is not null)
            {
                Sensor = sensor.Value;
            }

            if (quit is not null)
            {
                Quit = quit.Value;
            }

            if (user is not null)
            {
                User = user.Value;
            }

            if (syswm is not null)
            {
                Syswm = syswm.Value;
            }

            if (tfinger is not null)
            {
                Tfinger = tfinger.Value;
            }

            if (mgesture is not null)
            {
                Mgesture = mgesture.Value;
            }

            if (dgesture is not null)
            {
                Dgesture = dgesture.Value;
            }

            if (drop is not null)
            {
                Drop = drop.Value;
            }
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
        [NativeName("Type", "SDL_TextEditingExtEvent")]
        [NativeName("Type.Name", "SDL_TextEditingExtEvent")]
        [NativeName("Name", "editExt")]
        public TextEditingExtEvent EditExt;

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
        [NativeName("Type", "SDL_JoyBatteryEvent")]
        [NativeName("Type.Name", "SDL_JoyBatteryEvent")]
        [NativeName("Name", "jbattery")]
        public JoyBatteryEvent Jbattery;

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
        [NativeName("Type", "SDL_ControllerTouchpadEvent")]
        [NativeName("Type.Name", "SDL_ControllerTouchpadEvent")]
        [NativeName("Name", "ctouchpad")]
        public ControllerTouchpadEvent Ctouchpad;

        [FieldOffset(0)]
        [NativeName("Type", "SDL_ControllerSensorEvent")]
        [NativeName("Type.Name", "SDL_ControllerSensorEvent")]
        [NativeName("Name", "csensor")]
        public ControllerSensorEvent Csensor;

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
        [NativeName("Type", "Uint8[56]")]
        [NativeName("Type.Name", "Uint8[56]")]
        [NativeName("Name", "padding")]
        public fixed byte Padding[56];
    }
}
