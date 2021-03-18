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
    [NativeName("Name", "SDL_HapticCustom")]
    public unsafe partial struct HapticCustom
    {
        public HapticCustom
        (
            ushort? type = null,
            HapticDirection? direction = null,
            uint? length = null,
            ushort? delay = null,
            ushort? button = null,
            ushort? interval = null,
            byte? channels = null,
            ushort? period = null,
            ushort? samples = null,
            ushort* data = null,
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

            if (channels is not null)
            {
                Channels = channels.Value;
            }

            if (period is not null)
            {
                Period = period.Value;
            }

            if (samples is not null)
            {
                Samples = samples.Value;
            }

            if (data is not null)
            {
                Data = data;
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

        [NativeName("Type", "Uint8")]
        [NativeName("Type.Name", "Uint8")]
        [NativeName("Name", "channels")]
        public byte Channels;

        [NativeName("Type", "Uint16")]
        [NativeName("Type.Name", "Uint16")]
        [NativeName("Name", "period")]
        public ushort Period;

        [NativeName("Type", "Uint16")]
        [NativeName("Type.Name", "Uint16")]
        [NativeName("Name", "samples")]
        public ushort Samples;

        [NativeName("Type", "Uint16 *")]
        [NativeName("Type.Name", "Uint16 *")]
        [NativeName("Name", "data")]
        public ushort* Data;

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
