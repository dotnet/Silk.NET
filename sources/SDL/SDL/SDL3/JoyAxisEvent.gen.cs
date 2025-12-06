// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

[NativeName("SDL_JoyAxisEvent")]
public partial struct JoyAxisEvent
{
    [NativeName("type")]
    public EventType Type;

    [NativeName("reserved")]
    public uint Reserved;

    [NativeName("timestamp")]
    public ulong Timestamp;

    [NativeName("which")]
    public uint Which;

    [NativeName("axis")]
    public byte Axis;

    [NativeName("padding1")]
    public byte Padding1;

    [NativeName("padding2")]
    public byte Padding2;

    [NativeName("padding3")]
    public byte Padding3;

    [NativeName("value")]
    public short Value;

    [NativeName("padding4")]
    public ushort Padding4;
}
