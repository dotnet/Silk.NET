// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrInteractionProfileDpadBindingEXT")]
public unsafe partial struct InteractionProfileDpadBindingEXT
{
    [NativeName("type")]
    public StructureType Type = StructureType.InteractionProfileDpadBindingEXT;

    [NativeName("next")]
    public void* Next;

    [NativeName("binding")]
    public ulong Binding;

    [NativeName("actionSet")]
    public ActionSetHandle ActionSet;

    [NativeName("forceThreshold")]
    public float ForceThreshold;

    [NativeName("forceThresholdReleased")]
    public float ForceThresholdReleased;

    [NativeName("centerRegion")]
    public float CenterRegion;

    [NativeName("wedgeAngle")]
    public float WedgeAngle;

    [NativeName("isSticky")]
    public MaybeBool<uint> IsSticky;

    [NativeName("onHaptic")]
    public HapticBaseHeader* OnHaptic;

    [NativeName("offHaptic")]
    public HapticBaseHeader* OffHaptic;

    public InteractionProfileDpadBindingEXT() { }
}
