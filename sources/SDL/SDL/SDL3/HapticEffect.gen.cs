// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

[StructLayout(LayoutKind.Explicit)]
public partial struct HapticEffect
{
    [FieldOffset(0)]
    [NativeTypeName("Uint16")]
    public ushort Type;

    [FieldOffset(0)]
    public HapticConstant Constant;

    [FieldOffset(0)]
    public HapticPeriodic Periodic;

    [FieldOffset(0)]
    public HapticCondition Condition;

    [FieldOffset(0)]
    public HapticRamp Ramp;

    [FieldOffset(0)]
    public HapticLeftRight Leftright;

    [FieldOffset(0)]
    public HapticCustom Custom;
}
