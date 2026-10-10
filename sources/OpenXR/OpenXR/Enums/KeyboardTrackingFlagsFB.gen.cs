// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrKeyboardTrackingFlagsFB")]
[Flags]
public enum KeyboardTrackingFlagsFB : ulong
{
    None = 0x0,

    [NativeName("XR_KEYBOARD_TRACKING_EXISTS_BIT_FB")]
    ExistsBit = 0x1,

    [NativeName("XR_KEYBOARD_TRACKING_LOCAL_BIT_FB")]
    LocalBit = 0x2,

    [NativeName("XR_KEYBOARD_TRACKING_REMOTE_BIT_FB")]
    RemoteBit = 0x4,

    [NativeName("XR_KEYBOARD_TRACKING_CONNECTED_BIT_FB")]
    ConnectedBit = 0x8,
}
