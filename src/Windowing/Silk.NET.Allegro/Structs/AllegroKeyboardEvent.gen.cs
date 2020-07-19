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
    [NativeName("Name", "ALLEGRO_KEYBOARD_EVENT")]
    public unsafe partial struct AllegroKeyboardEvent
    {
        public AllegroKeyboardEvent
        (
            uint type = default,
            AllegroKeyboard* source = default,
            double timestamp = default,
            AllegroDisplay* display = default,
            int keycode = default,
            int unichar = default,
            uint modifiers = default,
            bool repeat = default
        )
        {
            Type = type;
            Source = source;
            Timestamp = timestamp;
            Display = display;
            Keycode = keycode;
            Unichar = unichar;
            Modifiers = modifiers;
            Repeat = repeat;
        }


        [NativeName("Type", "ALLEGRO_EVENT_TYPE")]
        [NativeName("Type.Name", "ALLEGRO_EVENT_TYPE")]
        [NativeName("Name", "type")]
        public uint Type;

        [NativeName("Type", "struct ALLEGRO_KEYBOARD *")]
        [NativeName("Type.Name", "struct ALLEGRO_KEYBOARD *")]
        [NativeName("Name", "source")]
        public AllegroKeyboard* Source;

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
        [NativeName("Name", "keycode")]
        public int Keycode;

        [NativeName("Type", "int")]
        [NativeName("Type.Name", "int")]
        [NativeName("Name", "unichar")]
        public int Unichar;

        [NativeName("Type", "unsigned int")]
        [NativeName("Type.Name", "unsigned int")]
        [NativeName("Name", "modifiers")]
        public uint Modifiers;

        [NativeName("Type", "bool")]
        [NativeName("Type.Name", "bool")]
        [NativeName("Name", "repeat")]
        public bool Repeat;
    }
}
