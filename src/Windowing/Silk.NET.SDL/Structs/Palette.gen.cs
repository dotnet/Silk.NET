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
    [NativeName("Name", "SDL_Palette")]
    public unsafe partial struct Palette
    {
        public Palette
        (
            int ncolors = default,
            Color* colors = default,
            uint version = default,
            int refcount = default
        )
        {
            Ncolors = ncolors;
            Colors = colors;
            Version = version;
            Refcount = refcount;
        }


        [NativeName("Type", "int")]
        [NativeName("Type.Name", "int")]
        [NativeName("Name", "ncolors")]
        public int Ncolors;

        [NativeName("Type", "SDL_Color *")]
        [NativeName("Type.Name", "SDL_Color *")]
        [NativeName("Name", "colors")]
        public Color* Colors;

        [NativeName("Type", "Uint32")]
        [NativeName("Type.Name", "Uint32")]
        [NativeName("Name", "version")]
        public uint Version;

        [NativeName("Type", "int")]
        [NativeName("Type.Name", "int")]
        [NativeName("Name", "refcount")]
        public int Refcount;
    }
}
