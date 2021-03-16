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
    [NativeName("Name", "SDL_WindowEvent")]
    public unsafe partial struct WindowEvent
    {
        public WindowEvent
        (
            uint? type = null,
            uint? timestamp = null,
            uint? windowID = null,
            byte? @event = null,
            byte? padding1 = null,
            byte? padding2 = null,
            byte? padding3 = null,
            int? data1 = null,
            int? data2 = null
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

            if (@event is not null)
            {
                Event = @event.Value;
            }

            if (padding1 is not null)
            {
                Padding1 = padding1.Value;
            }

            if (padding2 is not null)
            {
                Padding2 = padding2.Value;
            }

            if (padding3 is not null)
            {
                Padding3 = padding3.Value;
            }

            if (data1 is not null)
            {
                Data1 = data1.Value;
            }

            if (data2 is not null)
            {
                Data2 = data2.Value;
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

        [NativeName("Type", "Sint32")]
        [NativeName("Type.Name", "Sint32")]
        [NativeName("Name", "data2")]
        public int Data2;
    }
}
