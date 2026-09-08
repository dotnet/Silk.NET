// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrHandTrackingAimFlagsFB")]
[Flags]
public enum HandTrackingAimFlagsFB : ulong
{
    None = 0x0,

    [NativeName("XR_HAND_TRACKING_AIM_COMPUTED_BIT_FB")]
    ComputedBit = 0x1,

    [NativeName("XR_HAND_TRACKING_AIM_VALID_BIT_FB")]
    ValidBit = 0x2,

    [NativeName("XR_HAND_TRACKING_AIM_INDEX_PINCHING_BIT_FB")]
    IndexPinchingBit = 0x4,

    [NativeName("XR_HAND_TRACKING_AIM_MIDDLE_PINCHING_BIT_FB")]
    MiddlePinchingBit = 0x8,

    [NativeName("XR_HAND_TRACKING_AIM_RING_PINCHING_BIT_FB")]
    RingPinchingBit = 0x10,

    [NativeName("XR_HAND_TRACKING_AIM_LITTLE_PINCHING_BIT_FB")]
    LittlePinchingBit = 0x20,

    [NativeName("XR_HAND_TRACKING_AIM_SYSTEM_GESTURE_BIT_FB")]
    SystemGestureBit = 0x40,

    [NativeName("XR_HAND_TRACKING_AIM_DOMINANT_HAND_BIT_FB")]
    DominantHandBit = 0x80,

    [NativeName("XR_HAND_TRACKING_AIM_MENU_PRESSED_BIT_FB")]
    MenuPressedBit = 0x100,
}
