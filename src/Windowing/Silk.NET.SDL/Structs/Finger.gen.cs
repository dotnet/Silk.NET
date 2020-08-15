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
    [NativeName("Name", "SDL_Finger")]
    public unsafe partial struct Finger
    {
        public Finger
        (
            long id = default,
            float x = default,
            float y = default,
            float pressure = default
        )
        {
            Id = id;
            X = x;
            Y = y;
            Pressure = pressure;
        }


        [NativeName("Type", "SDL_FingerID")]
        [NativeName("Type.Name", "SDL_FingerID")]
        [NativeName("Name", "id")]
        public long Id;

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
        [NativeName("Name", "pressure")]
        public float Pressure;
    }
}
