// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;

namespace Silk.NET.SDL;

[NativeName("SDL_GamepadSensorEvent")]
public partial struct GamepadSensorEvent
{
    [NativeName("type")]
    public EventType Type;

    [NativeName("reserved")]
    public uint Reserved;

    [NativeName("timestamp")]
    public nuint Timestamp;

    [NativeName("which")]
    public uint Which;

    [NativeName("sensor")]
    public int Sensor;

    [NativeName("data")]
    public GamepadSensorEventData Data;

    [NativeName("sensor_timestamp")]
    public nuint SensorTimestamp;
}
