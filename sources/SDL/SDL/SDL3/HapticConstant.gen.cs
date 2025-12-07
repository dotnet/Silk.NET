// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

public partial struct HapticConstant
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

    [NativeTypeName("Sint16")]
    public short Level;

    [NativeTypeName("Uint16")]
    public ushort AttackLength;

    [NativeTypeName("Uint16")]
    public ushort AttackLevel;

    [NativeTypeName("Uint16")]
    public ushort FadeLength;

    [NativeTypeName("Uint16")]
    public ushort FadeLevel;
}
