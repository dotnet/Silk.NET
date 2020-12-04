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
    [NativeName("Name", "SDL_Palette")]
    public unsafe partial struct Palette
    {
        public Palette
        (
            int? ncolors = null,
            Color* colors = null,
            uint? version = null,
            int? refcount = null
        ) : this()
        {
            if (ncolors is not null)
            {
                Ncolors = ncolors.Value;
            }

            if (colors is not null)
            {
                Colors = colors;
            }

            if (version is not null)
            {
                Version = version.Value;
            }

            if (refcount is not null)
            {
                Refcount = refcount.Value;
            }
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
