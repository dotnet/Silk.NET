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
    [NativeName("Name", "SDL_SensorEvent")]
    public unsafe partial struct SensorEvent
    {
        public SensorEvent
        (
            uint? type = null,
            uint? timestamp = null,
            int? which = null,
            ulong? timestampUs = null
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

            if (timestampUs is not null)
            {
                TimestampUs = timestampUs.Value;
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
        [NativeName("Type", "float[6]")]
        [NativeName("Type.Name", "float[6]")]
        [NativeName("Name", "data")]
        public fixed float Data[6];

        [NativeName("Type", "Uint64")]
        [NativeName("Type.Name", "Uint64")]
        [NativeName("Name", "timestamp_us")]
        public ulong TimestampUs;
    }
}
