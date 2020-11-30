// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [NativeName("Name", "SDL_Finger")]
    public unsafe partial struct Finger
    {
        public Finger
        (
            long? id = null,
            float? x = null,
            float? y = null,
            float? pressure = null
        ) : this()
        {
            if (id is not null)
            {
                Id = id.Value;
            }

            if (x is not null)
            {
                X = x.Value;
            }

            if (y is not null)
            {
                Y = y.Value;
            }

            if (pressure is not null)
            {
                Pressure = pressure.Value;
            }
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
