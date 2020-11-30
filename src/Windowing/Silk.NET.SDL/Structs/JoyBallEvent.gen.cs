// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


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
    [NativeName("Name", "SDL_JoyBallEvent")]
    public unsafe partial struct JoyBallEvent
    {
        public JoyBallEvent
        (
            uint? type = null,
            uint? timestamp = null,
            int? which = null,
            byte? ball = null,
            byte? padding1 = null,
            byte? padding2 = null,
            byte? padding3 = null,
            short? xrel = null,
            short? yrel = null
        ) : this()
        {
            if (type is not null)
            {
                Type = type.Value;
            }

            if (timestamp is not null)
            {
                Timestamp = timestamp.Value;
            }

            if (which is not null)
            {
                Which = which.Value;
            }

            if (ball is not null)
            {
                Ball = ball.Value;
            }

            if (padding1 is not null)
            {
                Padding1 = padding1.Value;
            }

            if (padding2 is not null)
            {
                Padding2 = padding2.Value;
            }

            if (padding3 is not null)
            {
                Padding3 = padding3.Value;
            }

            if (xrel is not null)
            {
                Xrel = xrel.Value;
            }

            if (yrel is not null)
            {
                Yrel = yrel.Value;
            }
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
        [NativeName("Name", "ball")]
        public byte Ball;

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
        [NativeName("Name", "xrel")]
        public short Xrel;

        [NativeName("Type", "Sint16")]
        [NativeName("Type.Name", "Sint16")]
        [NativeName("Name", "yrel")]
        public short Yrel;
    }
}
