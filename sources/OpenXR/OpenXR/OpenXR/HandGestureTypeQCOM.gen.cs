// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrHandGestureTypeQCOM")]
[SupportedApiProfile("openxr")]
public enum HandGestureTypeQCOM
{
    [NativeName("XR_HAND_GESTURE_TYPE_UNKNOWN_QCOM")]
    [SupportedApiProfile(
        "openxr",
        ["XR_QCOM_hand_tracking_gesture"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    Unknown = -1,

    [NativeName("XR_HAND_GESTURE_TYPE_OPEN_HAND_QCOM")]
    [SupportedApiProfile(
        "openxr",
        ["XR_QCOM_hand_tracking_gesture"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    OpenHand = 0,

    [NativeName("XR_HAND_GESTURE_TYPE_GRAB_QCOM")]
    [SupportedApiProfile(
        "openxr",
        ["XR_QCOM_hand_tracking_gesture"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    Grab = 2,

    [NativeName("XR_HAND_GESTURE_TYPE_PINCH_QCOM")]
    [SupportedApiProfile(
        "openxr",
        ["XR_QCOM_hand_tracking_gesture"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    Pinch = 7,
}
