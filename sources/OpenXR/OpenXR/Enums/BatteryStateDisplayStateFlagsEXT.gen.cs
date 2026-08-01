// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrBatteryStateDisplayStateFlagsEXT")]
[Flags]
public enum BatteryStateDisplayStateFlagsEXT : ulong
{
    None = 0x0,

    [NativeName("XR_BATTERY_STATE_DISPLAY_STATE_VALID_BIT_EXT")]
    ValidBit = 0x1,

    [NativeName("XR_BATTERY_STATE_DISPLAY_STATE_CHARGING_BIT_EXT")]
    ChargingBit = 0x2,

    [NativeName("XR_BATTERY_STATE_DISPLAY_STATE_PLUGGED_IN_BIT_EXT")]
    PluggedInBit = 0x4,

    [NativeName("XR_BATTERY_STATE_DISPLAY_STATE_NO_BATTERY_BIT_EXT")]
    NoBatteryBit = 0x8,
}
