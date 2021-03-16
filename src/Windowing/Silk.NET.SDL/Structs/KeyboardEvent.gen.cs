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
    [NativeName("Name", "SDL_KeyboardEvent")]
    public unsafe partial struct KeyboardEvent
    {
        public KeyboardEvent
        (
            uint? type = null,
            uint? timestamp = null,
            uint? windowID = null,
            byte? state = null,
            byte? repeat = null,
            byte? padding2 = null,
            byte? padding3 = null,
            Keysym? keysym = null
        ) : this()
        {
            if (type is not null)
            {
                Type = type.Value;
            }

            if (timestamp is not null)
            {
                Timestamp = timestamp.Value;
            }

            if (windowID is not null)
            {
                WindowID = windowID.Value;
            }

            if (state is not null)
            {
                State = state.Value;
            }

            if (repeat is not null)
            {
                Repeat = repeat.Value;
            }

            if (padding2 is not null)
            {
                Padding2 = padding2.Value;
            }

            if (padding3 is not null)
            {
                Padding3 = padding3.Value;
            }

            if (keysym is not null)
            {
                Keysym = keysym.Value;
            }
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
