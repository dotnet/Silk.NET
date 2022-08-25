// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [Flags]
    [NativeName("AnonymousName", "__AnonymousEnum_SDL_sensor_L69_C9")]
    [NativeName("Name", "SDL_SensorType")]
    public enum SensorType : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"Invalid\"")]
        [NativeName("Name", "SDL_SENSOR_INVALID")]
        SensorInvalid = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [Obsolete("Deprecated in favour of \"Unknown\"")]
        [NativeName("Name", "SDL_SENSOR_UNKNOWN")]
        SensorUnknown = 0x0,
        [Obsolete("Deprecated in favour of \"Accel\"")]
        [NativeName("Name", "SDL_SENSOR_ACCEL")]
        SensorAccel = 0x1,
        [Obsolete("Deprecated in favour of \"Gyro\"")]
        [NativeName("Name", "SDL_SENSOR_GYRO")]
        SensorGyro = 0x2,
        [NativeName("Name", "SDL_SENSOR_INVALID")]
        Invalid = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "SDL_SENSOR_UNKNOWN")]
        Unknown = 0x0,
        [NativeName("Name", "SDL_SENSOR_ACCEL")]
        Accel = 0x1,
        [NativeName("Name", "SDL_SENSOR_GYRO")]
        Gyro = 0x2,
    }
}
