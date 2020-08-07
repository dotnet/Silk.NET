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
    [NativeName("Name", "SDL_TouchFingerEvent")]
    public unsafe partial struct TouchFingerEvent
    {
        public TouchFingerEvent
        (
            uint type = default,
            uint timestamp = default,
            long touchId = default,
            long fingerId = default,
            float x = default,
            float y = default,
            float dx = default,
            float dy = default,
            float pressure = default,
            uint windowID = default
        )
        {
            Type = type;
            Timestamp = timestamp;
            TouchId = touchId;
            FingerId = fingerId;
            X = x;
            Y = y;
            Dx = dx;
            Dy = dy;
            Pressure = pressure;
            WindowID = windowID;
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

        [NativeName("Type", "SDL_FingerID")]
        [NativeName("Type.Name", "SDL_FingerID")]
        [NativeName("Name", "fingerId")]
        public long FingerId;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "x")]
        public float X;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "y")]
        public float Y;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "dx")]
        public float Dx;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "dy")]
        public float Dy;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "pressure")]
        public float Pressure;

        [NativeName("Type", "Uint32")]
        [NativeName("Type.Name", "Uint32")]
        [NativeName("Name", "windowID")]
        public uint WindowID;
    }
}
