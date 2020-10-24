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
    [NativeName("Name", "SDL_version")]
    public unsafe partial struct Version
    {
        public Version
        (
            byte? major = null,
            byte? minor = null,
            byte? patch = null
        ) : this()
        {
            if (major is not null)
            {
                Major = major.Value;
            }

            if (minor is not null)
            {
                Minor = minor.Value;
            }

            if (patch is not null)
            {
                Patch = patch.Value;
            }
        }


        [NativeName("Type", "Uint8")]
        [NativeName("Type.Name", "Uint8")]
        [NativeName("Name", "major")]
        public byte Major;

        [NativeName("Type", "Uint8")]
        [NativeName("Type.Name", "Uint8")]
        [NativeName("Name", "minor")]
        public byte Minor;

        [NativeName("Type", "Uint8")]
        [NativeName("Type.Name", "Uint8")]
        [NativeName("Name", "patch")]
        public byte Patch;
    }
}
