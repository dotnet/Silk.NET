// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

public unsafe partial struct VirtualJoystickDesc
{
    [NativeTypeName("Uint32")]
    public uint Version;

    [NativeTypeName("Uint16")]
    public ushort Type;

    [NativeTypeName("Uint16")]
    public ushort Padding;

    [NativeTypeName("Uint16")]
    public ushort VendorId;

    [NativeTypeName("Uint16")]
    public ushort ProductId;

    [NativeTypeName("Uint16")]
    public ushort Naxes;

    [NativeTypeName("Uint16")]
    public ushort Nbuttons;

    [NativeTypeName("Uint16")]
    public ushort Nballs;

    [NativeTypeName("Uint16")]
    public ushort Nhats;

    [NativeTypeName("Uint16")]
    public ushort Ntouchpads;

    [NativeTypeName("Uint16")]
    public ushort Nsensors;

    [NativeTypeName("Uint16[2]")]
    public VirtualJoystickDescPadding2 Padding2;

    [NativeTypeName("Uint32")]
    public uint ButtonMask;

    [NativeTypeName("Uint32")]
    public uint AxisMask;

    [NativeTypeName("const char *")]
    public sbyte* Name;

    [NativeTypeName("const SDL_VirtualJoystickTouchpadDesc *")]
    public VirtualJoystickTouchpadDesc* Touchpads;

    [NativeTypeName("const SDL_VirtualJoystickSensorDesc *")]
    public VirtualJoystickSensorDesc* Sensors;
    public void* Userdata;

    [NativeTypeName("void (*)(void *)")]
    public VirtualJoystickDescUpdate Update;

    [NativeTypeName("void (*)(void *, int)")]
    public VirtualJoystickDescSetPlayerIndex SetPlayerIndex;

    [NativeTypeName("bool (*)(void *, Uint16, Uint16)")]
    public VirtualJoystickDescRumble Rumble;

    [NativeTypeName("bool (*)(void *, Uint16, Uint16)")]
    public VirtualJoystickDescRumbleTriggers RumbleTriggers;

    [NativeTypeName("bool (*)(void *, Uint8, Uint8, Uint8)")]
    public VirtualJoystickDescSetLED SetLED;

    [NativeTypeName("bool (*)(void *, const void *, int)")]
    public VirtualJoystickDescSendEffect SendEffect;

    [NativeTypeName("bool (*)(void *, bool)")]
    public VirtualJoystickDescSetSensorsEnabled SetSensorsEnabled;

    [NativeTypeName("void (*)(void *)")]
    public VirtualJoystickDescCleanup Cleanup;
}
