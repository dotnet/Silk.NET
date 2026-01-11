// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;

namespace Silk.NET.SDL;

[NativeName("SDL_HapticCondition")]
public partial struct HapticCondition
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

    [NativeName("right_sat")]
    public HapticConditionRightSat RightSat;

    [NativeName("left_sat")]
    public HapticConditionLeftSat LeftSat;

    [NativeName("right_coeff")]
    public HapticConditionRightCoeff RightCoeff;

    [NativeName("left_coeff")]
    public HapticConditionLeftCoeff LeftCoeff;

    [NativeName("deadband")]
    public HapticConditionDeadband Deadband;

    [NativeName("center")]
    public HapticConditionCenter Center;
}
