// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrHandTrackingScaleFB")]
[SupportedApiProfile("openxr")]
public unsafe partial struct HandTrackingScaleFB
{
    [NativeName("type")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_hand_tracking_mesh"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    public StructureType Type = StructureType.HandTrackingScaleFB;

    [NativeName("next")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_hand_tracking_mesh"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    public void* Next;

    [NativeName("sensorOutput")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_hand_tracking_mesh"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    public float SensorOutput;

    [NativeName("currentOutput")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_hand_tracking_mesh"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    public float CurrentOutput;

    [NativeName("overrideHandScale")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_hand_tracking_mesh"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    public MaybeBool<uint> OverrideHandScale;

    [NativeName("overrideValueInput")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_hand_tracking_mesh"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    public float OverrideValueInput;

    [SupportedApiProfile(
        "openxr",
        ["XR_FB_hand_tracking_mesh"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    public HandTrackingScaleFB() { }
}
