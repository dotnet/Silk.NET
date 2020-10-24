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
    [NativeName("Name", "SDL_HapticPeriodic")]
    public unsafe partial struct HapticPeriodic
    {
        public HapticPeriodic
        (
            ushort? type = null,
            HapticDirection? direction = null,
            uint? length = null,
            ushort? delay = null,
            ushort? button = null,
            ushort? interval = null,
            ushort? period = null,
            short? magnitude = null,
            short? offset = null,
            ushort? phase = null,
            ushort? attackLength = null,
            ushort? attackLevel = null,
            ushort? fadeLength = null,
            ushort? fadeLevel = null
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

            if (period is not null)
            {
                Period = period.Value;
            }

            if (magnitude is not null)
            {
                Magnitude = magnitude.Value;
            }

            if (offset is not null)
            {
                Offset = offset.Value;
            }

            if (phase is not null)
            {
                Phase = phase.Value;
            }

            if (attackLength is not null)
            {
                AttackLength = attackLength.Value;
            }

            if (attackLevel is not null)
            {
                AttackLevel = attackLevel.Value;
            }

            if (fadeLength is not null)
            {
                FadeLength = fadeLength.Value;
            }

            if (fadeLevel is not null)
            {
                FadeLevel = fadeLevel.Value;
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
