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
    [NativeName("Name", "ALLEGRO_MOUSE_STATE")]
    public unsafe partial struct AllegroMouseState
    {
        public AllegroMouseState
        (
            int x = default,
            int y = default,
            int z = default,
            int w = default,
            int buttons = default,
            float pressure = default,
            AllegroDisplay* display = default
        )
        {
            X = x;
            Y = y;
            Z = z;
            W = w;
            Buttons = buttons;
            Pressure = pressure;
            Display = display;
        }


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
        [NativeName("Type", "int [4]")]
        [NativeName("Type.Name", "int [4]")]
        [NativeName("Name", "more_axes")]
        public fixed int MoreAxes[4];

        [NativeName("Type", "int")]
        [NativeName("Type.Name", "int")]
        [NativeName("Name", "buttons")]
        public int Buttons;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "pressure")]
        public float Pressure;

        [NativeName("Type", "struct ALLEGRO_DISPLAY *")]
        [NativeName("Type.Name", "struct ALLEGRO_DISPLAY *")]
        [NativeName("Name", "display")]
        public AllegroDisplay* Display;
    }
}
