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
    [NativeName("Name", "SDL_DollarGestureEvent")]
    public unsafe partial struct DollarGestureEvent
    {
        public DollarGestureEvent
        (
            uint type = default,
            uint timestamp = default,
            long touchId = default,
            long gestureId = default,
            uint numFingers = default,
            float error = default,
            float x = default,
            float y = default
        )
        {
            Type = type;
            Timestamp = timestamp;
            TouchId = touchId;
            GestureId = gestureId;
            NumFingers = numFingers;
            Error = error;
            X = x;
            Y = y;
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
