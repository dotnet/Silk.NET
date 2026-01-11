// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

[NativeName("SDL_VirtualJoystickDesc")]
public unsafe partial struct VirtualJoystickDesc
{
    [NativeName("version")]
    public uint Version;

    [NativeName("type")]
    public ushort Type;

    [NativeName("padding")]
    public ushort Padding;

    [NativeName("vendor_id")]
    public ushort VendorId;

    [NativeName("product_id")]
    public ushort ProductId;

    [NativeName("naxes")]
    public ushort Naxes;

    [NativeName("nbuttons")]
    public ushort Nbuttons;

    [NativeName("nballs")]
    public ushort Nballs;

    [NativeName("nhats")]
    public ushort Nhats;

    [NativeName("ntouchpads")]
    public ushort Ntouchpads;

    [NativeName("nsensors")]
    public ushort Nsensors;

    [NativeName("padding2")]
    public VirtualJoystickDescPadding2 Padding2;

    [NativeName("button_mask")]
    public uint ButtonMask;

    [NativeName("axis_mask")]
    public uint AxisMask;

    [NativeName("name")]
    public sbyte* Name;

    [NativeName("touchpads")]
    public VirtualJoystickTouchpadDesc* Touchpads;

    [NativeName("sensors")]
    public VirtualJoystickSensorDesc* Sensors;

    [NativeName("userdata")]
    public void* Userdata;

    [NativeName("Update")]
    public VirtualJoystickDescUpdate Update;

    [NativeName("SetPlayerIndex")]
    public VirtualJoystickDescSetPlayerIndex SetPlayerIndex;

    [NativeName("Rumble")]
    public VirtualJoystickDescRumble Rumble;

    [NativeName("RumbleTriggers")]
    public VirtualJoystickDescRumbleTriggers RumbleTriggers;

    [NativeName("SetLED")]
    public VirtualJoystickDescSetLed SetLed;

    [NativeName("SendEffect")]
    public VirtualJoystickDescSendEffect SendEffect;

    [NativeName("SetSensorsEnabled")]
    public VirtualJoystickDescSetSensorsEnabled SetSensorsEnabled;

    [NativeName("Cleanup")]
    public VirtualJoystickDescCleanup Cleanup;
}
