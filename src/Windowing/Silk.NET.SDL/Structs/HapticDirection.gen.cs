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
    [NativeName("Name", "SDL_HapticDirection")]
    public unsafe partial struct HapticDirection
    {
        public HapticDirection
        (
            byte type = default
        )
        {
            Type = type;
        }


        [NativeName("Type", "Uint8")]
        [NativeName("Type.Name", "Uint8")]
        [NativeName("Name", "type")]
        public byte Type;
        [NativeName("Type", "Sint32 [3]")]
        [NativeName("Type.Name", "Sint32 [3]")]
        [NativeName("Name", "dir")]
        public fixed int Dir[3];
    }
}
