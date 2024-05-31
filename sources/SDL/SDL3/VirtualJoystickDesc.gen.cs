// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.SDL.ChromaLocation;
using static Silk.NET.SDL.ColorPrimaries;
using static Silk.NET.SDL.ColorRange;
using static Silk.NET.SDL.ColorType;
using static Silk.NET.SDL.MatrixCoefficients;
using static Silk.NET.SDL.TransferCharacteristics;

namespace Silk.NET.SDL;

public unsafe partial struct VirtualJoystickDesc
{
    [NativeTypeName("Uint16")]
    public ushort Type;

    [NativeTypeName("Uint16")]
    public ushort Naxes;

    [NativeTypeName("Uint16")]
    public ushort Nbuttons;

    [NativeTypeName("Uint16")]
    public ushort Nhats;

    [NativeTypeName("Uint16")]
    public ushort VendorId;

    [NativeTypeName("Uint16")]
    public ushort ProductId;

    [NativeTypeName("Uint16")]
    public ushort Padding;

    [NativeTypeName("Uint32")]
    public uint ButtonMask;

    [NativeTypeName("Uint32")]
    public uint AxisMask;

    [NativeTypeName("const char *")]
    public sbyte* Name;
    public void* Userdata;

    [NativeTypeName("void (*)(void *)")]
    public delegate* unmanaged<void*, void> Update;

    [NativeTypeName("void (*)(void *, int)")]
    public delegate* unmanaged<void*, int, void> SetPlayerIndex;

    [NativeTypeName("int (*)(void *, Uint16, Uint16)")]
    public delegate* unmanaged<void*, ushort, ushort, int> Rumble;

    [NativeTypeName("int (*)(void *, Uint16, Uint16)")]
    public delegate* unmanaged<void*, ushort, ushort, int> RumbleTriggers;

    [NativeTypeName("int (*)(void *, Uint8, Uint8, Uint8)")]
    public delegate* unmanaged<void*, byte, byte, byte, int> SetLED;

    [NativeTypeName("int (*)(void *, const void *, int)")]
    public delegate* unmanaged<void*, void*, int, int> SendEffect;
}
