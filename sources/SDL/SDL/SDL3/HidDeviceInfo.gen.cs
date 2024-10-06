// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

public unsafe partial struct HidDeviceInfo
{
    [NativeTypeName("char *")]
    public sbyte* Path;

    [NativeTypeName("unsigned short")]
    public ushort VendorId;

    [NativeTypeName("unsigned short")]
    public ushort ProductId;

    [NativeTypeName("wchar_t *")]
    public uint* SerialNumber;

    [NativeTypeName("unsigned short")]
    public ushort ReleaseNumber;

    [NativeTypeName("wchar_t *")]
    public uint* ManufacturerString;

    [NativeTypeName("wchar_t *")]
    public uint* ProductString;

    [NativeTypeName("unsigned short")]
    public ushort UsagePage;

    [NativeTypeName("unsigned short")]
    public ushort Usage;
    public int InterfaceNumber;
    public int InterfaceClass;
    public int InterfaceSubclass;
    public int InterfaceProtocol;
    public HidBusType BusType;

    [NativeTypeName("struct SDL_hid_device_info *")]
    public HidDeviceInfo* Next;
}
