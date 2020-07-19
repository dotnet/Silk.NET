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
    [NativeName("Name", "ALLEGRO_KEYBOARD_STATE")]
    public unsafe partial struct AllegroKeyboardState
    {
        public AllegroKeyboardState
        (
            AllegroDisplay* display = default
        )
        {
            Display = display;
        }


        [NativeName("Type", "struct ALLEGRO_DISPLAY *")]
        [NativeName("Type.Name", "struct ALLEGRO_DISPLAY *")]
        [NativeName("Name", "display")]
        public AllegroDisplay* Display;
        [NativeName("Type", "unsigned int [8]")]
        [NativeName("Type.Name", "unsigned int [8]")]
        [NativeName("Name", "__key_down__internal__")]
        public fixed uint KeyDowninternal[8];
    }
}
