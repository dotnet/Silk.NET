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
    [NativeName("Name", "SDL_JoyDeviceEvent")]
    public unsafe partial struct JoyDeviceEvent
    {
        public JoyDeviceEvent
        (
            uint? type = null,
            uint? timestamp = null,
            int? which = null
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
        }


        [NativeName("Type", "Uint32")]
        [NativeName("Type.Name", "Uint32")]
        [NativeName("Name", "type")]
        public uint Type;

        [NativeName("Type", "Uint32")]
        [NativeName("Type.Name", "Uint32")]
        [NativeName("Name", "timestamp")]
        public uint Timestamp;

        [NativeName("Type", "Sint32")]
        [NativeName("Type.Name", "Sint32")]
        [NativeName("Name", "which")]
        public int Which;
    }
}
