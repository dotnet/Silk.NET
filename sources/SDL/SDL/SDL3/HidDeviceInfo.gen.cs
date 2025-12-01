// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;

namespace Silk.NET.SDL;

[NativeName("SDL_hid_device_info")]
public unsafe partial struct HidDeviceInfo
{
    [NativeName("path")]
    public sbyte* Path;

    [NativeName("vendor_id")]
    public ushort VendorId;

    [NativeName("product_id")]
    public ushort ProductId;

    [NativeName("serial_number")]
    public uint* SerialNumber;

    [NativeName("release_number")]
    public ushort ReleaseNumber;

    [NativeName("manufacturer_string")]
    public uint* ManufacturerString;

    [NativeName("product_string")]
    public uint* ProductString;

    [NativeName("usage_page")]
    public ushort UsagePage;

    [NativeName("usage")]
    public ushort Usage;

    [NativeName("interface_number")]
    public int InterfaceNumber;

    [NativeName("interface_class")]
    public int InterfaceClass;

    [NativeName("interface_subclass")]
    public int InterfaceSubclass;

    [NativeName("interface_protocol")]
    public int InterfaceProtocol;

    [NativeName("bus_type")]
    public HidBusType BusType;

    [NativeName("next")]
    public HidDeviceInfo* Next;
}
