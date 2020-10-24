// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [NativeName("Name", "SDL_MouseMotionEvent")]
    public unsafe partial struct MouseMotionEvent
    {
        public MouseMotionEvent
        (
            uint? type = null,
            uint? timestamp = null,
            uint? windowID = null,
            uint? which = null,
            uint? state = null,
            int? x = null,
            int? y = null,
            int? xrel = null,
            int? yrel = null
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

            if (which is not null)
            {
                Which = which.Value;
            }

            if (state is not null)
            {
                State = state.Value;
            }

            if (x is not null)
            {
                X = x.Value;
            }

            if (y is not null)
            {
                Y = y.Value;
            }

            if (xrel is not null)
            {
                Xrel = xrel.Value;
            }

            if (yrel is not null)
            {
                Yrel = yrel.Value;
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

        [NativeName("Type", "Uint32")]
        [NativeName("Type.Name", "Uint32")]
        [NativeName("Name", "which")]
        public uint Which;

        [NativeName("Type", "Uint32")]
        [NativeName("Type.Name", "Uint32")]
        [NativeName("Name", "state")]
        public uint State;

        [NativeName("Type", "Sint32")]
        [NativeName("Type.Name", "Sint32")]
        [NativeName("Name", "x")]
        public int X;

        [NativeName("Type", "Sint32")]
        [NativeName("Type.Name", "Sint32")]
        [NativeName("Name", "y")]
        public int Y;

        [NativeName("Type", "Sint32")]
        [NativeName("Type.Name", "Sint32")]
        [NativeName("Name", "xrel")]
        public int Xrel;

        [NativeName("Type", "Sint32")]
        [NativeName("Type.Name", "Sint32")]
        [NativeName("Name", "yrel")]
        public int Yrel;
    }
}
