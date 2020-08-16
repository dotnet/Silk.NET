// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [NativeName("Name", "SDL_Keysym")]
    public unsafe partial struct Keysym
    {
        public Keysym
        (
            Scancode scancode = default,
            int sym = default,
            ushort mod = default,
            uint unused = default
        )
        {
            Scancode = scancode;
            Sym = sym;
            Mod = mod;
            Unused = unused;
        }


        [NativeName("Type", "SDL_Scancode")]
        [NativeName("Type.Name", "SDL_Scancode")]
        [NativeName("Name", "scancode")]
        public Scancode Scancode;

        [NativeName("Type", "SDL_Keycode")]
        [NativeName("Type.Name", "SDL_Keycode")]
        [NativeName("Name", "sym")]
        public int Sym;

        [NativeName("Type", "Uint16")]
        [NativeName("Type.Name", "Uint16")]
        [NativeName("Name", "mod")]
        public ushort Mod;

        [NativeName("Type", "Uint32")]
        [NativeName("Type.Name", "Uint32")]
        [NativeName("Name", "unused")]
        public uint Unused;
    }
}
