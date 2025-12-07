// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

[NativeName("SDL_PenTouchEvent")]
public partial struct PenTouchEvent
{
    [NativeName("type")]
    public EventType Type;

    [NativeName("reserved")]
    public uint Reserved;

    [NativeName("timestamp")]
    public ulong Timestamp;

    [NativeName("windowID")]
    public uint WindowID;

    [NativeName("which")]
    public uint Which;

    [NativeName("pen_state")]
    public uint PenState;

    [NativeName("x")]
    public float X;

    [NativeName("y")]
    public float Y;

    [NativeName("eraser")]
    public byte Eraser;

    [NativeName("down")]
    public byte Down;
}
