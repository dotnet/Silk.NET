// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrInteractionProfileAnalogThresholdVALVE")]
public unsafe partial struct InteractionProfileAnalogThresholdVALVE
{
    [NativeName("type")]
    public StructureType Type = StructureType.InteractionProfileAnalogThresholdVALVE;

    [NativeName("next")]
    public void* Next;

    [NativeName("action")]
    public ActionHandle Action;

    [NativeName("binding")]
    public ulong Binding;

    [NativeName("onThreshold")]
    public float OnThreshold;

    [NativeName("offThreshold")]
    public float OffThreshold;

    [NativeName("onHaptic")]
    public HapticBaseHeader* OnHaptic;

    [NativeName("offHaptic")]
    public HapticBaseHeader* OffHaptic;

    public InteractionProfileAnalogThresholdVALVE() { }
}
