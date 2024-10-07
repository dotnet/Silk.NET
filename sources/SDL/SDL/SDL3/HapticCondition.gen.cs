// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

public partial struct HapticCondition
{
    [NativeTypeName("Uint16")]
    public ushort Type;
    public HapticDirection Direction;

    [NativeTypeName("Uint32")]
    public uint Length;

    [NativeTypeName("Uint16")]
    public ushort Delay;

    [NativeTypeName("Uint16")]
    public ushort Button;

    [NativeTypeName("Uint16")]
    public ushort Interval;

    [NativeTypeName("Uint16[3]")]
    public HapticConditionRightSat RightSat;

    [NativeTypeName("Uint16[3]")]
    public HapticConditionLeftSat LeftSat;

    [NativeTypeName("Sint16[3]")]
    public HapticConditionRightCoeff RightCoeff;

    [NativeTypeName("Sint16[3]")]
    public HapticConditionLeftCoeff LeftCoeff;

    [NativeTypeName("Uint16[3]")]
    public HapticConditionDeadband Deadband;

    [NativeTypeName("Sint16[3]")]
    public HapticConditionCenter Center;
}
