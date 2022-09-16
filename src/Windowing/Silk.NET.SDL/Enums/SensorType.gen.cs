// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [NativeName("AnonymousName", "__AnonymousEnum_SDL_sensor_L69_C9")]
    [NativeName("Name", "SDL_SensorType")]
    public enum SensorType : int
    {
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
        [Obsolete("Deprecated in favour of \"AccelL\"")]
        [NativeName("Name", "SDL_SENSOR_ACCEL_L")]
        SensorAccelL = 0x3,
        [Obsolete("Deprecated in favour of \"GyroL\"")]
        [NativeName("Name", "SDL_SENSOR_GYRO_L")]
        SensorGyroL = 0x4,
        [Obsolete("Deprecated in favour of \"AccelR\"")]
        [NativeName("Name", "SDL_SENSOR_ACCEL_R")]
        SensorAccelR = 0x5,
        [Obsolete("Deprecated in favour of \"GyroR\"")]
        [NativeName("Name", "SDL_SENSOR_GYRO_R")]
        SensorGyroR = 0x6,
        [NativeName("Name", "SDL_SENSOR_INVALID")]
        Invalid = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "SDL_SENSOR_UNKNOWN")]
        Unknown = 0x0,
        [NativeName("Name", "SDL_SENSOR_ACCEL")]
        Accel = 0x1,
        [NativeName("Name", "SDL_SENSOR_GYRO")]
        Gyro = 0x2,
        [NativeName("Name", "SDL_SENSOR_ACCEL_L")]
        AccelL = 0x3,
        [NativeName("Name", "SDL_SENSOR_GYRO_L")]
        GyroL = 0x4,
        [NativeName("Name", "SDL_SENSOR_ACCEL_R")]
        AccelR = 0x5,
        [NativeName("Name", "SDL_SENSOR_GYRO_R")]
        GyroR = 0x6,
    }
}
