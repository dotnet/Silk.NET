// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


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
    [NativeName("Name", "SDL_Keysym")]
    public unsafe partial struct Keysym
    {
        public Keysym
        (
            Scancode? scancode = null,
            int? sym = null,
            ushort? mod = null,
            uint? unused = null
        ) : this()
        {
            if (scancode is not null)
            {
                Scancode = scancode.Value;
            }

            if (sym is not null)
            {
                Sym = sym.Value;
            }

            if (mod is not null)
            {
                Mod = mod.Value;
            }

            if (unused is not null)
            {
                Unused = unused.Value;
            }
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
