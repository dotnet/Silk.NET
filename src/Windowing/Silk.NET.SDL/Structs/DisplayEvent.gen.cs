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
    [NativeName("Name", "SDL_DisplayEvent")]
    public unsafe partial struct DisplayEvent
    {
        public DisplayEvent
        (
            uint type = default,
            uint timestamp = default,
            uint display = default,
            byte @event = default,
            byte padding1 = default,
            byte padding2 = default,
            byte padding3 = default,
            int data1 = default
        )
        {
            Type = type;
            Timestamp = timestamp;
            Display = display;
            Event = @event;
            Padding1 = padding1;
            Padding2 = padding2;
            Padding3 = padding3;
            Data1 = data1;
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
        [NativeName("Name", "display")]
        public uint Display;

        [NativeName("Type", "Uint8")]
        [NativeName("Type.Name", "Uint8")]
        [NativeName("Name", "event")]
        public byte Event;

        [NativeName("Type", "Uint8")]
        [NativeName("Type.Name", "Uint8")]
        [NativeName("Name", "padding1")]
        public byte Padding1;

        [NativeName("Type", "Uint8")]
        [NativeName("Type.Name", "Uint8")]
        [NativeName("Name", "padding2")]
        public byte Padding2;

        [NativeName("Type", "Uint8")]
        [NativeName("Type.Name", "Uint8")]
        [NativeName("Name", "padding3")]
        public byte Padding3;

        [NativeName("Type", "Sint32")]
        [NativeName("Type.Name", "Sint32")]
        [NativeName("Name", "data1")]
        public int Data1;
    }
}
