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
    [NativeName("Name", "SDL_AudioDeviceEvent")]
    public unsafe partial struct AudioDeviceEvent
    {
        public AudioDeviceEvent
        (
            uint? type = null,
            uint? timestamp = null,
            uint? which = null,
            byte? iscapture = null,
            byte? padding1 = null,
            byte? padding2 = null,
            byte? padding3 = null
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

            if (iscapture is not null)
            {
                Iscapture = iscapture.Value;
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
        }


        [NativeName("Type", "Uint32")]
        [NativeName("Type.Name", "Uint32")]
        [NativeName("Name", "type")]
        public uint Type;

        [NativeName("Type", "Uint32")]
        [NativeName("Type.Name", "Uint32")]
        [NativeName("Name", "timestamp")]
        public uint Timestamp;

        [NativeName("Type", "Uint32")]
        [NativeName("Type.Name", "Uint32")]
        [NativeName("Name", "which")]
        public uint Which;

        [NativeName("Type", "Uint8")]
        [NativeName("Type.Name", "Uint8")]
        [NativeName("Name", "iscapture")]
        public byte Iscapture;

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
    }
}
