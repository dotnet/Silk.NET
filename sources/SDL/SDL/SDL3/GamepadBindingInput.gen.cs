// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

[NativeName("_input_e__Union")]
[StructLayout(LayoutKind.Explicit)]
public partial struct GamepadBindingInput
{
    [NativeName("button")]
    [FieldOffset(0)]
    public int Button;

    [NativeName("axis")]
    [FieldOffset(0)]
    public GamepadBindingInputAxis Axis;

    [NativeName("hat")]
    [FieldOffset(0)]
    public GamepadBindingInputHat Hat;
}
