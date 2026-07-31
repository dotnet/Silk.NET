// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrInteractionProfileAnalogThresholdVALVE")]
[SupportedApiProfile("openxr")]
public unsafe partial struct InteractionProfileAnalogThresholdVALVE
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_VALVE_analog_threshold"])]
    public StructureType Type = StructureType.InteractionProfileAnalogThresholdVALVE;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_VALVE_analog_threshold"])]
    public void* Next;

    [NativeName("action")]
    [SupportedApiProfile("openxr", ["XR_VALVE_analog_threshold"])]
    public ActionHandle Action;

    [NativeName("binding")]
    [SupportedApiProfile("openxr", ["XR_VALVE_analog_threshold"])]
    public ulong Binding;

    [NativeName("onThreshold")]
    [SupportedApiProfile("openxr", ["XR_VALVE_analog_threshold"])]
    public float OnThreshold;

    [NativeName("offThreshold")]
    [SupportedApiProfile("openxr", ["XR_VALVE_analog_threshold"])]
    public float OffThreshold;

    [NativeName("onHaptic")]
    [SupportedApiProfile("openxr", ["XR_VALVE_analog_threshold"])]
    public HapticBaseHeader* OnHaptic;

    [NativeName("offHaptic")]
    [SupportedApiProfile("openxr", ["XR_VALVE_analog_threshold"])]
    public HapticBaseHeader* OffHaptic;

    [SupportedApiProfile("openxr", ["XR_VALVE_analog_threshold"])]
    public InteractionProfileAnalogThresholdVALVE() { }
}
