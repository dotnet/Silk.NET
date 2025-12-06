// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

[NativeName("SDL_HapticRamp")]
public partial struct HapticRamp
{
    [NativeName("type")]
    public ushort Type;

    [NativeName("direction")]
    public HapticDirection Direction;

    [NativeName("length")]
    public uint Length;

    [NativeName("delay")]
    public ushort Delay;

    [NativeName("button")]
    public ushort Button;

    [NativeName("interval")]
    public ushort Interval;

    [NativeName("start")]
    public short Start;

    [NativeName("end")]
    public short End;

    [NativeName("attack_length")]
    public ushort AttackLength;

    [NativeName("attack_level")]
    public ushort AttackLevel;

    [NativeName("fade_length")]
    public ushort FadeLength;

    [NativeName("fade_level")]
    public ushort FadeLevel;
}
