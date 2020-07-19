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
    [NativeName("Name", "ALLEGRO_JOYSTICK_EVENT")]
    public unsafe partial struct AllegroJoystickEvent
    {
        public AllegroJoystickEvent
        (
            uint type = default,
            AllegroJoystick* source = default,
            double timestamp = default,
            AllegroJoystick* id = default,
            int stick = default,
            int axis = default,
            float pos = default,
            int button = default
        )
        {
            Type = type;
            Source = source;
            Timestamp = timestamp;
            Id = id;
            Stick = stick;
            Axis = axis;
            Pos = pos;
            Button = button;
        }


        [NativeName("Type", "ALLEGRO_EVENT_TYPE")]
        [NativeName("Type.Name", "ALLEGRO_EVENT_TYPE")]
        [NativeName("Name", "type")]
        public uint Type;

        [NativeName("Type", "struct ALLEGRO_JOYSTICK *")]
        [NativeName("Type.Name", "struct ALLEGRO_JOYSTICK *")]
        [NativeName("Name", "source")]
        public AllegroJoystick* Source;

        [NativeName("Type", "double")]
        [NativeName("Type.Name", "double")]
        [NativeName("Name", "timestamp")]
        public double Timestamp;

        [NativeName("Type", "struct ALLEGRO_JOYSTICK *")]
        [NativeName("Type.Name", "struct ALLEGRO_JOYSTICK *")]
        [NativeName("Name", "id")]
        public AllegroJoystick* Id;

        [NativeName("Type", "int")]
        [NativeName("Type.Name", "int")]
        [NativeName("Name", "stick")]
        public int Stick;

        [NativeName("Type", "int")]
        [NativeName("Type.Name", "int")]
        [NativeName("Name", "axis")]
        public int Axis;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "pos")]
        public float Pos;

        [NativeName("Type", "int")]
        [NativeName("Type.Name", "int")]
        [NativeName("Name", "button")]
        public int Button;
    }
}
