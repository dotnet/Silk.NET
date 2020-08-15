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
    [StructLayout(LayoutKind.Explicit)]
    [NativeName("Name", "SDL_HapticEffect")]
    public unsafe partial struct HapticEffect
    {
        public HapticEffect
        (
            ushort type = default,
            HapticConstant constant = default,
            HapticPeriodic periodic = default,
            HapticCondition condition = default,
            HapticRamp ramp = default,
            HapticLeftRight leftright = default,
            HapticCustom custom = default
        )
        {
            Type = type;
            Constant = constant;
            Periodic = periodic;
            Condition = condition;
            Ramp = ramp;
            Leftright = leftright;
            Custom = custom;
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
