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
    [NativeName("Name", "SDL_Color")]
    public unsafe partial struct Color
    {
        public Color
        (
            byte? r = null,
            byte? g = null,
            byte? b = null,
            byte? a = null
        ) : this()
        {
            if (r is not null)
            {
                R = r.Value;
            }

            if (g is not null)
            {
                G = g.Value;
            }

            if (b is not null)
            {
                B = b.Value;
            }

            if (a is not null)
            {
                A = a.Value;
            }
        }


        [NativeName("Type", "Uint8")]
        [NativeName("Type.Name", "Uint8")]
        [NativeName("Name", "r")]
        public byte R;

        [NativeName("Type", "Uint8")]
        [NativeName("Type.Name", "Uint8")]
        [NativeName("Name", "g")]
        public byte G;

        [NativeName("Type", "Uint8")]
        [NativeName("Type.Name", "Uint8")]
        [NativeName("Name", "b")]
        public byte B;

        [NativeName("Type", "Uint8")]
        [NativeName("Type.Name", "Uint8")]
        [NativeName("Name", "a")]
        public byte A;
    }
}
