// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
namespace Silk.NET.SDL;

[NativeTypeName("unsigned int")]
public enum Keymod : uint
{
    None = 0x0000,
    Lshift = 0x0001,
    Rshift = 0x0002,
    Lctrl = 0x0040,
    Rctrl = 0x0080,
    Lalt = 0x0100,
    Ralt = 0x0200,
    Lgui = 0x0400,
    Rgui = 0x0800,
    Num = 0x1000,
    Caps = 0x2000,
    Mode = 0x4000,
    Scroll = 0x8000,
    Ctrl = Lctrl | Rctrl,
    Shift = Lshift | Rshift,
    Alt = Lalt | Ralt,
    Gui = Lgui | Rgui,
}
