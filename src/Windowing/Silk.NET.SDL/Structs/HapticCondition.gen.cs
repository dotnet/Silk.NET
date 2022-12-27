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
    [NativeName("Name", "SDL_HapticCondition")]
    public unsafe partial struct HapticCondition
    {
        public HapticCondition
        (
            ushort? type = null,
            HapticDirection? direction = null,
            uint? length = null,
            ushort? delay = null,
            ushort? button = null,
            ushort? interval = null
        ) : this()
        {
            if (type is not null)
            {
                Type = type.Value;
            }

            if (direction is not null)
            {
                Direction = direction.Value;
            }

            if (length is not null)
            {
                Length = length.Value;
            }

            if (delay is not null)
            {
                Delay = delay.Value;
            }

            if (button is not null)
            {
                Button = button.Value;
            }

            if (interval is not null)
            {
                Interval = interval.Value;
            }
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
        [NativeName("Type", "Uint16[3]")]
        [NativeName("Type.Name", "Uint16[3]")]
        [NativeName("Name", "right_sat")]
        public fixed ushort RightSat[3];
        [NativeName("Type", "Uint16[3]")]
        [NativeName("Type.Name", "Uint16[3]")]
        [NativeName("Name", "left_sat")]
        public fixed ushort LeftSat[3];
        [NativeName("Type", "Sint16[3]")]
        [NativeName("Type.Name", "Sint16[3]")]
        [NativeName("Name", "right_coeff")]
        public fixed short RightCoeff[3];
        [NativeName("Type", "Sint16[3]")]
        [NativeName("Type.Name", "Sint16[3]")]
        [NativeName("Name", "left_coeff")]
        public fixed short LeftCoeff[3];
        [NativeName("Type", "Uint16[3]")]
        [NativeName("Type.Name", "Uint16[3]")]
        [NativeName("Name", "deadband")]
        public fixed ushort Deadband[3];
        [NativeName("Type", "Sint16[3]")]
        [NativeName("Type.Name", "Sint16[3]")]
        [NativeName("Name", "center")]
        public fixed short Center[3];
    }
}
