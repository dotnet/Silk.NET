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
    [NativeName("Name", "SDL_HapticLeftRight")]
    public unsafe partial struct HapticLeftRight
    {
        public HapticLeftRight
        (
            ushort type = default,
            uint length = default,
            ushort largeMagnitude = default,
            ushort smallMagnitude = default
        )
        {
            Type = type;
            Length = length;
            LargeMagnitude = largeMagnitude;
            SmallMagnitude = smallMagnitude;
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
