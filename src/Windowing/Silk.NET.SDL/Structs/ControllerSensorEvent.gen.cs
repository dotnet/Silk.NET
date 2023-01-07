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
    [NativeName("Name", "SDL_ControllerSensorEvent")]
    public unsafe partial struct ControllerSensorEvent
    {
        public ControllerSensorEvent
        (
            uint? type = null,
            uint? timestamp = null,
            int? which = null,
            int? sensor = null,
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

            if (sensor is not null)
            {
                Sensor = sensor.Value;
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

        [NativeName("Type", "SDL_JoystickID")]
        [NativeName("Type.Name", "SDL_JoystickID")]
        [NativeName("Name", "which")]
        public int Which;

        [NativeName("Type", "Sint32")]
        [NativeName("Type.Name", "Sint32")]
        [NativeName("Name", "sensor")]
        public int Sensor;
        [NativeName("Type", "float[3]")]
        [NativeName("Type.Name", "float[3]")]
        [NativeName("Name", "data")]
        public fixed float Data[3];

        [NativeName("Type", "Uint64")]
        [NativeName("Type.Name", "Uint64")]
        [NativeName("Name", "timestamp_us")]
        public ulong TimestampUs;
    }
}
