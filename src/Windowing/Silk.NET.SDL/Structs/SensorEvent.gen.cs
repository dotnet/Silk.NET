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
    [NativeName("Name", "SDL_SensorEvent")]
    public unsafe partial struct SensorEvent
    {
        public SensorEvent
        (
            uint type = default,
            uint timestamp = default,
            int which = default
        )
        {
            Type = type;
            Timestamp = timestamp;
            Which = which;
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
        [NativeName("Type", "float [6]")]
        [NativeName("Type.Name", "float [6]")]
        [NativeName("Name", "data")]
        public fixed float Data[6];
    }
}
