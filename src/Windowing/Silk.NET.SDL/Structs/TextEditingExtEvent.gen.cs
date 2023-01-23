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
    [NativeName("Name", "SDL_TextEditingExtEvent")]
    public unsafe partial struct TextEditingExtEvent
    {
        public TextEditingExtEvent
        (
            uint? type = null,
            uint? timestamp = null,
            uint? windowID = null,
            byte* text = null,
            int? start = null,
            int? length = null
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

            if (text is not null)
            {
                Text = text;
            }

            if (start is not null)
            {
                Start = start.Value;
            }

            if (length is not null)
            {
                Length = length.Value;
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

        [NativeName("Type", "char *")]
        [NativeName("Type.Name", "char *")]
        [NativeName("Name", "text")]
        public byte* Text;

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
