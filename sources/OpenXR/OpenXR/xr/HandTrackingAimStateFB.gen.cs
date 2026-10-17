// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrHandTrackingAimStateFB")]
public unsafe partial struct HandTrackingAimStateFB
{
    [NativeName("type")]
    public StructureType Type = StructureType.HandTrackingAimStateFB;

    [NativeName("next")]
    public void* Next;

    [NativeName("status")]
    public HandTrackingAimFlagsFB Status;

    [NativeName("aimPose")]
    public Posef AimPose;

    [NativeName("pinchStrengthIndex")]
    public float PinchStrengthIndex;

    [NativeName("pinchStrengthMiddle")]
    public float PinchStrengthMiddle;

    [NativeName("pinchStrengthRing")]
    public float PinchStrengthRing;

    [NativeName("pinchStrengthLittle")]
    public float PinchStrengthLittle;

    public HandTrackingAimStateFB() { }
}
