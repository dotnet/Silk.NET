// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;

namespace Silk.NET.SDL;

public partial struct GamepadTouchpadEvent
{
    public EventType Type;

    [NativeTypeName("Uint32")]
    public uint Reserved;

    [NativeTypeName("Uint64")]
    public nuint Timestamp;

    [NativeTypeName("SDL_JoystickID")]
    public uint Which;

    [NativeTypeName("Sint32")]
    public int Touchpad;

    [NativeTypeName("Sint32")]
    public int Finger;
    public float X;
    public float Y;
    public float Pressure;
}
