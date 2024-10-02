// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;

namespace Silk.NET.SDL;

public partial struct PenButtonEvent
{
    public EventType Type;

    [NativeTypeName("Uint32")]
    public uint Reserved;

    [NativeTypeName("Uint64")]
    public ulong Timestamp;

    [NativeTypeName("SDL_WindowID")]
    public uint WindowID;

    [NativeTypeName("SDL_PenID")]
    public uint Which;

    [NativeTypeName("Uint8")]
    public byte Button;

    [NativeTypeName("Uint8")]
    public byte State;

    [NativeTypeName("Uint16")]
    public ushort PenState;
    public float X;
    public float Y;

    [NativeTypeName("float[6]")]
    public _axes_e__FixedBuffer Axes;

    [InlineArray(6)]
    public partial struct _axes_e__FixedBuffer
    {
        public float e0;
    }
}
