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
    [NativeName("Name", "SDL_TextEditingEvent")]
    public unsafe partial struct TextEditingEvent
    {
        public TextEditingEvent
        (
            uint type = default,
            uint timestamp = default,
            uint windowID = default,
            int start = default,
            int length = default
        )
        {
            Type = type;
            Timestamp = timestamp;
            WindowID = windowID;
            Start = start;
            Length = length;
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
        [NativeName("Type", "char [32]")]
        [NativeName("Type.Name", "char [32]")]
        [NativeName("Name", "text")]
        public fixed byte Text[32];

        [NativeName("Type", "Sint32")]
        [NativeName("Type.Name", "Sint32")]
        [NativeName("Name", "start")]
        public int Start;

        [NativeName("Type", "Sint32")]
        [NativeName("Type.Name", "Sint32")]
        [NativeName("Name", "length")]
        public int Length;
    }
}
