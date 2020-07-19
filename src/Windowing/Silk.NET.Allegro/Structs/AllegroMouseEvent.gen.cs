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
    [NativeName("Name", "ALLEGRO_MOUSE_EVENT")]
    public unsafe partial struct AllegroMouseEvent
    {
        public AllegroMouseEvent
        (
            uint type = default,
            AllegroMouse* source = default,
            double timestamp = default,
            AllegroDisplay* display = default,
            int x = default,
            int y = default,
            int z = default,
            int w = default,
            int dx = default,
            int dy = default,
            int dz = default,
            int dw = default,
            uint button = default,
            float pressure = default
        )
        {
            Type = type;
            Source = source;
            Timestamp = timestamp;
            Display = display;
            X = x;
            Y = y;
            Z = z;
            W = w;
            Dx = dx;
            Dy = dy;
            Dz = dz;
            Dw = dw;
            Button = button;
            Pressure = pressure;
        }


        [NativeName("Type", "ALLEGRO_EVENT_TYPE")]
        [NativeName("Type.Name", "ALLEGRO_EVENT_TYPE")]
        [NativeName("Name", "type")]
        public uint Type;

        [NativeName("Type", "struct ALLEGRO_MOUSE *")]
        [NativeName("Type.Name", "struct ALLEGRO_MOUSE *")]
        [NativeName("Name", "source")]
        public AllegroMouse* Source;

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
        [NativeName("Name", "x")]
        public int X;

        [NativeName("Type", "int")]
        [NativeName("Type.Name", "int")]
        [NativeName("Name", "y")]
        public int Y;

        [NativeName("Type", "int")]
        [NativeName("Type.Name", "int")]
        [NativeName("Name", "z")]
        public int Z;

        [NativeName("Type", "int")]
        [NativeName("Type.Name", "int")]
        [NativeName("Name", "w")]
        public int W;

        [NativeName("Type", "int")]
        [NativeName("Type.Name", "int")]
        [NativeName("Name", "dx")]
        public int Dx;

        [NativeName("Type", "int")]
        [NativeName("Type.Name", "int")]
        [NativeName("Name", "dy")]
        public int Dy;

        [NativeName("Type", "int")]
        [NativeName("Type.Name", "int")]
        [NativeName("Name", "dz")]
        public int Dz;

        [NativeName("Type", "int")]
        [NativeName("Type.Name", "int")]
        [NativeName("Name", "dw")]
        public int Dw;

        [NativeName("Type", "unsigned int")]
        [NativeName("Type.Name", "unsigned int")]
        [NativeName("Name", "button")]
        public uint Button;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "pressure")]
        public float Pressure;
    }
}
