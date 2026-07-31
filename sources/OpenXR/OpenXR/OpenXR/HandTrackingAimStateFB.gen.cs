// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrHandTrackingAimStateFB")]
[SupportedApiProfile("openxr")]
public unsafe partial struct HandTrackingAimStateFB
{
    [NativeName("type")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_hand_tracking_aim"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    public StructureType Type = StructureType.HandTrackingAimStateFB;

    [NativeName("next")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_hand_tracking_aim"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    public void* Next;

    [NativeName("status")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_hand_tracking_aim"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    public HandTrackingAimFlagsFB Status;

    [NativeName("aimPose")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_hand_tracking_aim"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    public Posef AimPose;

    [NativeName("pinchStrengthIndex")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_hand_tracking_aim"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    public float PinchStrengthIndex;

    [NativeName("pinchStrengthMiddle")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_hand_tracking_aim"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    public float PinchStrengthMiddle;

    [NativeName("pinchStrengthRing")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_hand_tracking_aim"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    public float PinchStrengthRing;

    [NativeName("pinchStrengthLittle")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_hand_tracking_aim"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    public float PinchStrengthLittle;

    [SupportedApiProfile(
        "openxr",
        ["XR_FB_hand_tracking_aim"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    public HandTrackingAimStateFB() { }
}
