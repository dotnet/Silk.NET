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
    [StructLayout(LayoutKind.Explicit)]
    [NativeName("Name", "SDL_HapticEffect")]
    public unsafe partial struct HapticEffect
    {
        public HapticEffect
        (
            ushort? type = null,
            HapticConstant? constant = null,
            HapticPeriodic? periodic = null,
            HapticCondition? condition = null,
            HapticRamp? ramp = null,
            HapticLeftRight? leftright = null,
            HapticCustom? custom = null
        ) : this()
        {
            if (type is not null)
            {
                Type = type.Value;
            }

            if (constant is not null)
            {
                Constant = constant.Value;
            }

            if (periodic is not null)
            {
                Periodic = periodic.Value;
            }

            if (condition is not null)
            {
                Condition = condition.Value;
            }

            if (ramp is not null)
            {
                Ramp = ramp.Value;
            }

            if (leftright is not null)
            {
                Leftright = leftright.Value;
            }

            if (custom is not null)
            {
                Custom = custom.Value;
            }
        }


        [FieldOffset(0)]
        [NativeName("Type", "Uint16")]
        [NativeName("Type.Name", "Uint16")]
        [NativeName("Name", "type")]
        public ushort Type;

        [FieldOffset(0)]
        [NativeName("Type", "SDL_HapticConstant")]
        [NativeName("Type.Name", "SDL_HapticConstant")]
        [NativeName("Name", "constant")]
        public HapticConstant Constant;

        [FieldOffset(0)]
        [NativeName("Type", "SDL_HapticPeriodic")]
        [NativeName("Type.Name", "SDL_HapticPeriodic")]
        [NativeName("Name", "periodic")]
        public HapticPeriodic Periodic;

        [FieldOffset(0)]
        [NativeName("Type", "SDL_HapticCondition")]
        [NativeName("Type.Name", "SDL_HapticCondition")]
        [NativeName("Name", "condition")]
        public HapticCondition Condition;

        [FieldOffset(0)]
        [NativeName("Type", "SDL_HapticRamp")]
        [NativeName("Type.Name", "SDL_HapticRamp")]
        [NativeName("Name", "ramp")]
        public HapticRamp Ramp;

        [FieldOffset(0)]
        [NativeName("Type", "SDL_HapticLeftRight")]
        [NativeName("Type.Name", "SDL_HapticLeftRight")]
        [NativeName("Name", "leftright")]
        public HapticLeftRight Leftright;

        [FieldOffset(0)]
        [NativeName("Type", "SDL_HapticCustom")]
        [NativeName("Type.Name", "SDL_HapticCustom")]
        [NativeName("Name", "custom")]
        public HapticCustom Custom;
    }
}
