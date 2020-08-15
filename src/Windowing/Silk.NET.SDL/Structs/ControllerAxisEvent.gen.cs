// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [NativeName("Name", "SDL_ControllerAxisEvent")]
    public unsafe partial struct ControllerAxisEvent
    {
        public ControllerAxisEvent
        (
            uint type = default,
            uint timestamp = default,
            int which = default,
            byte axis = default,
            byte padding1 = default,
            byte padding2 = default,
            byte padding3 = default,
            short value = default,
            ushort padding4 = default
        )
        {
            Type = type;
            Timestamp = timestamp;
            Which = which;
            Axis = axis;
            Padding1 = padding1;
            Padding2 = padding2;
            Padding3 = padding3;
            Value = value;
            Padding4 = padding4;
        }


        [NativeName("Type", "Uint32")]
        [NativeName("Type.Name", "Uint32")]
        [NativeName("Name", "type")]
        public uint Type;

        [NativeName("Type", "Uint32")]
        [NativeName("Type.Name", "Uint32")]
        [NativeName("Name", "timestamp")]
        public uint Timestamp;

        [NativeName("Type", "SDL_JoystickID")]
        [NativeName("Type.Name", "SDL_JoystickID")]
        [NativeName("Name", "which")]
        public int Which;

        [NativeName("Type", "Uint8")]
        [NativeName("Type.Name", "Uint8")]
        [NativeName("Name", "axis")]
        public byte Axis;

        [NativeName("Type", "Uint8")]
        [NativeName("Type.Name", "Uint8")]
        [NativeName("Name", "padding1")]
        public byte Padding1;

        [NativeName("Type", "Uint8")]
        [NativeName("Type.Name", "Uint8")]
        [NativeName("Name", "padding2")]
        public byte Padding2;

        [NativeName("Type", "Uint8")]
        [NativeName("Type.Name", "Uint8")]
        [NativeName("Name", "padding3")]
        public byte Padding3;

        [NativeName("Type", "Sint16")]
        [NativeName("Type.Name", "Sint16")]
        [NativeName("Name", "value")]
        public short Value;

        [NativeName("Type", "Uint16")]
        [NativeName("Type.Name", "Uint16")]
        [NativeName("Name", "padding4")]
        public ushort Padding4;
    }
}
