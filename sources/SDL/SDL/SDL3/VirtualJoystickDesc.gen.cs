// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

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
    public ClipboardCleanupCallback Update;

    [NativeTypeName("void (*)(void *, int)")]
    public VirtualJoystickDescSetPlayerIndex SetPlayerIndex;

    [NativeTypeName("int (*)(void *, Uint16, Uint16)")]
    public VirtualJoystickDescFunction1 Rumble;

    [NativeTypeName("int (*)(void *, Uint16, Uint16)")]
    public VirtualJoystickDescFunction1 RumbleTriggers;

    [NativeTypeName("int (*)(void *, Uint8, Uint8, Uint8)")]
    public VirtualJoystickDescSetLED SetLED;

    [NativeTypeName("int (*)(void *, const void *, int)")]
    public VirtualJoystickDescSendEffect SendEffect;
}
