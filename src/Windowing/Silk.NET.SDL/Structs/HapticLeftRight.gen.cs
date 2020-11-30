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
    [NativeName("Name", "SDL_HapticLeftRight")]
    public unsafe partial struct HapticLeftRight
    {
        public HapticLeftRight
        (
            ushort? type = null,
            uint? length = null,
            ushort? largeMagnitude = null,
            ushort? smallMagnitude = null
        ) : this()
        {
            if (type is not null)
            {
                Type = type.Value;
            }

            if (length is not null)
            {
                Length = length.Value;
            }

            if (largeMagnitude is not null)
            {
                LargeMagnitude = largeMagnitude.Value;
            }

            if (smallMagnitude is not null)
            {
                SmallMagnitude = smallMagnitude.Value;
            }
        }


        [NativeName("Type", "Uint16")]
        [NativeName("Type.Name", "Uint16")]
        [NativeName("Name", "type")]
        public ushort Type;

        [NativeName("Type", "Uint32")]
        [NativeName("Type.Name", "Uint32")]
        [NativeName("Name", "length")]
        public uint Length;

        [NativeName("Type", "Uint16")]
        [NativeName("Type.Name", "Uint16")]
        [NativeName("Name", "large_magnitude")]
        public ushort LargeMagnitude;

        [NativeName("Type", "Uint16")]
        [NativeName("Type.Name", "Uint16")]
        [NativeName("Name", "small_magnitude")]
        public ushort SmallMagnitude;
    }
}
