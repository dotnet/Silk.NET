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
    [NativeName("Name", "SDL_Rect")]
    public unsafe partial struct Rect
    {
        public Rect
        (
            int? x = null,
            int? y = null,
            int? w = null,
            int? h = null
        ) : this()
        {
            if (x is not null)
            {
                X = x.Value;
            }

            if (y is not null)
            {
                Y = y.Value;
            }

            if (w is not null)
            {
                W = w.Value;
            }

            if (h is not null)
            {
                H = h.Value;
            }
        }


        [NativeName("Type", "int")]
        [NativeName("Type.Name", "int")]
        [NativeName("Name", "x")]
        public int X;

        [NativeName("Type", "int")]
        [NativeName("Type.Name", "int")]
        [NativeName("Name", "y")]
        public int Y;

        [NativeName("Type", "int")]
        [NativeName("Type.Name", "int")]
        [NativeName("Name", "w")]
        public int W;

        [NativeName("Type", "int")]
        [NativeName("Type.Name", "int")]
        [NativeName("Name", "h")]
        public int H;
    }
}
