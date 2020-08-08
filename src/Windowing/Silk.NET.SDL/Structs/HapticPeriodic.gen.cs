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
    [NativeName("Name", "SDL_HapticPeriodic")]
    public unsafe partial struct HapticPeriodic
    {
        public HapticPeriodic
        (
            ushort type = default,
            HapticDirection direction = default,
            uint length = default,
            ushort delay = default,
            ushort button = default,
            ushort interval = default,
            ushort period = default,
            short magnitude = default,
            short offset = default,
            ushort phase = default,
            ushort attackLength = default,
            ushort attackLevel = default,
            ushort fadeLength = default,
            ushort fadeLevel = default
        )
        {
            Type = type;
            Direction = direction;
            Length = length;
            Delay = delay;
            Button = button;
            Interval = interval;
            Period = period;
            Magnitude = magnitude;
            Offset = offset;
            Phase = phase;
            AttackLength = attackLength;
            AttackLevel = attackLevel;
            FadeLength = fadeLength;
            FadeLevel = fadeLevel;
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

        [NativeName("Type", "Uint16")]
        [NativeName("Type.Name", "Uint16")]
        [NativeName("Name", "period")]
        public ushort Period;

        [NativeName("Type", "Sint16")]
        [NativeName("Type.Name", "Sint16")]
        [NativeName("Name", "magnitude")]
        public short Magnitude;

        [NativeName("Type", "Sint16")]
        [NativeName("Type.Name", "Sint16")]
        [NativeName("Name", "offset")]
        public short Offset;

        [NativeName("Type", "Uint16")]
        [NativeName("Type.Name", "Uint16")]
        [NativeName("Name", "phase")]
        public ushort Phase;

        [NativeName("Type", "Uint16")]
        [NativeName("Type.Name", "Uint16")]
        [NativeName("Name", "attack_length")]
        public ushort AttackLength;

        [NativeName("Type", "Uint16")]
        [NativeName("Type.Name", "Uint16")]
        [NativeName("Name", "attack_level")]
        public ushort AttackLevel;

        [NativeName("Type", "Uint16")]
        [NativeName("Type.Name", "Uint16")]
        [NativeName("Name", "fade_length")]
        public ushort FadeLength;

        [NativeName("Type", "Uint16")]
        [NativeName("Type.Name", "Uint16")]
        [NativeName("Name", "fade_level")]
        public ushort FadeLevel;
    }
}
