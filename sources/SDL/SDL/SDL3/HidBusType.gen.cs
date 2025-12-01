// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;

namespace Silk.NET.SDL;

[NativeName("SDL_hid_bus_type")]
public enum HidBusType : uint
{
    [NativeName("SDL_HID_API_BUS_UNKNOWN")]
    Unknown = 0x00,

    [NativeName("SDL_HID_API_BUS_USB")]
    Usb = 0x01,

    [NativeName("SDL_HID_API_BUS_BLUETOOTH")]
    Bluetooth = 0x02,

    [NativeName("SDL_HID_API_BUS_I2C")]
    I2C = 0x03,

    [NativeName("SDL_HID_API_BUS_SPI")]
    Spi = 0x04,
}
