// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.SDL.ArrayOrder;
using static Silk.NET.SDL.BitmapOrder;
using static Silk.NET.SDL.PackedLayout;
using static Silk.NET.SDL.PackedOrder;
using static Silk.NET.SDL.PixelType;

namespace Silk.NET.SDL;

[NativeTypeName("unsigned int")]
public enum InitFlags : uint
{
    Timer = 0x00000001,
    Audio = 0x00000010,
    Video = 0x00000020,
    Joystick = 0x00000200,
    Haptic = 0x00001000,
    Gamepad = 0x00002000,
    Events = 0x00004000,
    Sensor = 0x00008000,
    Camera = 0x00010000,
}
