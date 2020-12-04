// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


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
    [NativeName("Name", "SDL_DollarGestureEvent")]
    public unsafe partial struct DollarGestureEvent
    {
        public DollarGestureEvent
        (
            uint? type = null,
            uint? timestamp = null,
            long? touchId = null,
            long? gestureId = null,
            uint? numFingers = null,
            float? error = null,
            float? x = null,
            float? y = null
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

            if (touchId is not null)
            {
                TouchId = touchId.Value;
            }

            if (gestureId is not null)
            {
                GestureId = gestureId.Value;
            }

            if (numFingers is not null)
            {
                NumFingers = numFingers.Value;
            }

            if (error is not null)
            {
                Error = error.Value;
            }

            if (x is not null)
            {
                X = x.Value;
            }

            if (y is not null)
            {
                Y = y.Value;
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

        [NativeName("Type", "SDL_TouchID")]
        [NativeName("Type.Name", "SDL_TouchID")]
        [NativeName("Name", "touchId")]
        public long TouchId;

        [NativeName("Type", "SDL_GestureID")]
        [NativeName("Type.Name", "SDL_GestureID")]
        [NativeName("Name", "gestureId")]
        public long GestureId;

        [NativeName("Type", "Uint32")]
        [NativeName("Type.Name", "Uint32")]
        [NativeName("Name", "numFingers")]
        public uint NumFingers;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "error")]
        public float Error;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "x")]
        public float X;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "y")]
        public float Y;
    }
}
