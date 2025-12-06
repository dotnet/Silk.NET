// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;

namespace Silk.NET.SDL;

[NativeName("SDL_MouseWheelEvent")]
public partial struct MouseWheelEvent
{
    [NativeName("type")]
    public EventType Type;

    [NativeName("reserved")]
    public uint Reserved;

    [NativeName("timestamp")]
    public nuint Timestamp;

    [NativeName("windowID")]
    public uint WindowID;

    [NativeName("which")]
    public uint Which;

    [NativeName("x")]
    public float X;

    [NativeName("y")]
    public float Y;

    [NativeName("direction")]
    public MouseWheelDirection Direction;

    [NativeName("mouse_x")]
    public float MouseX;

    [NativeName("mouse_y")]
    public float MouseY;
}
