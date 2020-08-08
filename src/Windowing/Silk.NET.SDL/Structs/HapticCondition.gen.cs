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
    [NativeName("Name", "SDL_HapticCondition")]
    public unsafe partial struct HapticCondition
    {
        public HapticCondition
        (
            ushort type = default,
            HapticDirection direction = default,
            uint length = default,
            ushort delay = default,
            ushort button = default,
            ushort interval = default
        )
        {
            Type = type;
            Direction = direction;
            Length = length;
            Delay = delay;
            Button = button;
            Interval = interval;
        }


        [NativeName("Type", "Uint16")]
        [NativeName("Type.Name", "Uint16")]
        [NativeName("Name", "type")]
        public ushort Type;

        [NativeName("Type", "SDL_HapticDirection")]
        [NativeName("Type.Name", "SDL_HapticDirection")]
        [NativeName("Name", "direction")]
        public HapticDirection Direction;

        [NativeName("Type", "Uint32")]
        [NativeName("Type.Name", "Uint32")]
        [NativeName("Name", "length")]
        public uint Length;

        [NativeName("Type", "Uint16")]
        [NativeName("Type.Name", "Uint16")]
        [NativeName("Name", "delay")]
        public ushort Delay;

        [NativeName("Type", "Uint16")]
        [NativeName("Type.Name", "Uint16")]
        [NativeName("Name", "button")]
        public ushort Button;

        [NativeName("Type", "Uint16")]
        [NativeName("Type.Name", "Uint16")]
        [NativeName("Name", "interval")]
        public ushort Interval;
        [NativeName("Type", "Uint16 [3]")]
        [NativeName("Type.Name", "Uint16 [3]")]
        [NativeName("Name", "right_sat")]
        public fixed ushort RightSat[3];
        [NativeName("Type", "Uint16 [3]")]
        [NativeName("Type.Name", "Uint16 [3]")]
        [NativeName("Name", "left_sat")]
        public fixed ushort LeftSat[3];
        [NativeName("Type", "Sint16 [3]")]
        [NativeName("Type.Name", "Sint16 [3]")]
        [NativeName("Name", "right_coeff")]
        public fixed short RightCoeff[3];
        [NativeName("Type", "Sint16 [3]")]
        [NativeName("Type.Name", "Sint16 [3]")]
        [NativeName("Name", "left_coeff")]
        public fixed short LeftCoeff[3];
        [NativeName("Type", "Uint16 [3]")]
        [NativeName("Type.Name", "Uint16 [3]")]
        [NativeName("Name", "deadband")]
        public fixed ushort Deadband[3];
        [NativeName("Type", "Sint16 [3]")]
        [NativeName("Type.Name", "Sint16 [3]")]
        [NativeName("Name", "center")]
        public fixed short Center[3];
    }
}
