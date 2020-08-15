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
    [NativeName("Name", "SDL_HapticRamp")]
    public unsafe partial struct HapticRamp
    {
        public HapticRamp
        (
            ushort type = default,
            HapticDirection direction = default,
            uint length = default,
            ushort delay = default,
            ushort button = default,
            ushort interval = default,
            short start = default,
            short end = default,
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
            Start = start;
            End = end;
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

        [NativeName("Type", "Sint16")]
        [NativeName("Type.Name", "Sint16")]
        [NativeName("Name", "start")]
        public short Start;

        [NativeName("Type", "Sint16")]
        [NativeName("Type.Name", "Sint16")]
        [NativeName("Name", "end")]
        public short End;

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
