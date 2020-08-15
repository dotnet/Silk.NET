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

namespace Silk.NET.SDL
{
    [NativeName("Name", "SDL_KeyboardEvent")]
    public unsafe partial struct KeyboardEvent
    {
        public KeyboardEvent
        (
            uint type = default,
            uint timestamp = default,
            uint windowID = default,
            byte state = default,
            byte repeat = default,
            byte padding2 = default,
            byte padding3 = default,
            Keysym keysym = default
        )
        {
            Type = type;
            Timestamp = timestamp;
            WindowID = windowID;
            State = state;
            Repeat = repeat;
            Padding2 = padding2;
            Padding3 = padding3;
            Keysym = keysym;
        }


        [NativeName("Type", "Uint32")]
        [NativeName("Type.Name", "Uint32")]
        [NativeName("Name", "type")]
        public uint Type;

        [NativeName("Type", "Uint32")]
        [NativeName("Type.Name", "Uint32")]
        [NativeName("Name", "timestamp")]
        public uint Timestamp;

        [NativeName("Type", "Uint32")]
        [NativeName("Type.Name", "Uint32")]
        [NativeName("Name", "windowID")]
        public uint WindowID;

        [NativeName("Type", "Uint8")]
        [NativeName("Type.Name", "Uint8")]
        [NativeName("Name", "state")]
        public byte State;

        [NativeName("Type", "Uint8")]
        [NativeName("Type.Name", "Uint8")]
        [NativeName("Name", "repeat")]
        public byte Repeat;

        [NativeName("Type", "Uint8")]
        [NativeName("Type.Name", "Uint8")]
        [NativeName("Name", "padding2")]
        public byte Padding2;

        [NativeName("Type", "Uint8")]
        [NativeName("Type.Name", "Uint8")]
        [NativeName("Name", "padding3")]
        public byte Padding3;

        [NativeName("Type", "SDL_Keysym")]
        [NativeName("Type.Name", "SDL_Keysym")]
        [NativeName("Name", "keysym")]
        public Keysym Keysym;
    }
}
