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
    [NativeName("Name", "ALLEGRO_TOUCH_EVENT")]
    public unsafe partial struct AllegroTouchEvent
    {
        public AllegroTouchEvent
        (
            uint type = default,
            AllegroTouchInput* source = default,
            double timestamp = default,
            AllegroDisplay* display = default,
            int id = default,
            float x = default,
            float y = default,
            float dx = default,
            float dy = default,
            bool primary = default
        )
        {
            Type = type;
            Source = source;
            Timestamp = timestamp;
            Display = display;
            Id = id;
            X = x;
            Y = y;
            Dx = dx;
            Dy = dy;
            Primary = primary;
        }


        [NativeName("Type", "ALLEGRO_EVENT_TYPE")]
        [NativeName("Type.Name", "ALLEGRO_EVENT_TYPE")]
        [NativeName("Name", "type")]
        public uint Type;

        [NativeName("Type", "struct ALLEGRO_TOUCH_INPUT *")]
        [NativeName("Type.Name", "struct ALLEGRO_TOUCH_INPUT *")]
        [NativeName("Name", "source")]
        public AllegroTouchInput* Source;

        [NativeName("Type", "double")]
        [NativeName("Type.Name", "double")]
        [NativeName("Name", "timestamp")]
        public double Timestamp;

        [NativeName("Type", "struct ALLEGRO_DISPLAY *")]
        [NativeName("Type.Name", "struct ALLEGRO_DISPLAY *")]
        [NativeName("Name", "display")]
        public AllegroDisplay* Display;

        [NativeName("Type", "int")]
        [NativeName("Type.Name", "int")]
        [NativeName("Name", "id")]
        public int Id;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "x")]
        public float X;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "y")]
        public float Y;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "dx")]
        public float Dx;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "dy")]
        public float Dy;

        [NativeName("Type", "bool")]
        [NativeName("Type.Name", "bool")]
        [NativeName("Name", "primary")]
        public bool Primary;
    }
}
