// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

[NativeName("SDL_SensorType")]
public enum SensorType
{
    [NativeName("SDL_SENSOR_INVALID")]
    Invalid = -1,

    [NativeName("SDL_SENSOR_UNKNOWN")]
    Unknown,

    [NativeName("SDL_SENSOR_ACCEL")]
    Accel,

    [NativeName("SDL_SENSOR_GYRO")]
    Gyro,

    [NativeName("SDL_SENSOR_ACCEL_L")]
    AccelL,

    [NativeName("SDL_SENSOR_GYRO_L")]
    GyroL,

    [NativeName("SDL_SENSOR_ACCEL_R")]
    AccelR,

    [NativeName("SDL_SENSOR_GYRO_R")]
    GyroR,
}
