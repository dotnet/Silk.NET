// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

[NativeTypeName("unsigned int")]
public enum HidBusType : uint
{
    Unknown = 0x00,
    Usb = 0x01,
    Bluetooth = 0x02,
    I2C = 0x03,
    Spi = 0x04,
}
