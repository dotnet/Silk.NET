// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrVirtualKeyboardInputStateFlagsMETA")]
[Flags]
public enum VirtualKeyboardInputStateFlagsMETA : ulong
{
    None = 0x0,

    [NativeName("XR_VIRTUAL_KEYBOARD_INPUT_STATE_PRESSED_BIT_META")]
    PressedBit = 0x1,
}
