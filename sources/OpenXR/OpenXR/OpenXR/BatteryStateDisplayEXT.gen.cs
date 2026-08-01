// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrBatteryStateDisplayEXT")]
[SupportedApiProfile("openxr")]
public unsafe partial struct BatteryStateDisplayEXT
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_EXT_interaction_profile_battery_state_display"])]
    public StructureType Type = StructureType.BatteryStateDisplayEXT;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_EXT_interaction_profile_battery_state_display"])]
    public void* Next;

    [NativeName("stateFlags")]
    [SupportedApiProfile("openxr", ["XR_EXT_interaction_profile_battery_state_display"])]
    public BatteryStateDisplayStateFlagsEXT StateFlags;

    [NativeName("batteryLevel")]
    [SupportedApiProfile("openxr", ["XR_EXT_interaction_profile_battery_state_display"])]
    public float BatteryLevel;

    [SupportedApiProfile("openxr", ["XR_EXT_interaction_profile_battery_state_display"])]
    public BatteryStateDisplayEXT() { }
}
