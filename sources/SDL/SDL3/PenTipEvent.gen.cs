// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.SDL.ChromaLocation;
using static Silk.NET.SDL.ColorPrimaries;
using static Silk.NET.SDL.ColorRange;
using static Silk.NET.SDL.ColorType;
using static Silk.NET.SDL.MatrixCoefficients;
using static Silk.NET.SDL.PenAxis;
using static Silk.NET.SDL.Scancode;
using static Silk.NET.SDL.TransferCharacteristics;

namespace Silk.NET.SDL;

public partial struct PenTipEvent
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
    public byte Tip;

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
