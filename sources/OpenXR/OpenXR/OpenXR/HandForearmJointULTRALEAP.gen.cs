// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrHandForearmJointULTRALEAP")]
[SupportedApiProfile("openxr")]
public enum HandForearmJointULTRALEAP : uint
{
    [NativeName("XR_HAND_FOREARM_JOINT_PALM_ULTRALEAP")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ULTRALEAP_hand_tracking_forearm"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    Palm = 0,

    [NativeName("XR_HAND_FOREARM_JOINT_WRIST_ULTRALEAP")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ULTRALEAP_hand_tracking_forearm"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    Wrist = 1,

    [NativeName("XR_HAND_FOREARM_JOINT_THUMB_METACARPAL_ULTRALEAP")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ULTRALEAP_hand_tracking_forearm"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    ThumbMetacarpal = 2,

    [NativeName("XR_HAND_FOREARM_JOINT_THUMB_PROXIMAL_ULTRALEAP")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ULTRALEAP_hand_tracking_forearm"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    ThumbProximal = 3,

    [NativeName("XR_HAND_FOREARM_JOINT_THUMB_DISTAL_ULTRALEAP")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ULTRALEAP_hand_tracking_forearm"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    ThumbDistal = 4,

    [NativeName("XR_HAND_FOREARM_JOINT_THUMB_TIP_ULTRALEAP")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ULTRALEAP_hand_tracking_forearm"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    ThumbTip = 5,

    [NativeName("XR_HAND_FOREARM_JOINT_INDEX_METACARPAL_ULTRALEAP")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ULTRALEAP_hand_tracking_forearm"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    IndexMetacarpal = 6,

    [NativeName("XR_HAND_FOREARM_JOINT_INDEX_PROXIMAL_ULTRALEAP")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ULTRALEAP_hand_tracking_forearm"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    IndexProximal = 7,

    [NativeName("XR_HAND_FOREARM_JOINT_INDEX_INTERMEDIATE_ULTRALEAP")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ULTRALEAP_hand_tracking_forearm"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    IndexIntermediate = 8,

    [NativeName("XR_HAND_FOREARM_JOINT_INDEX_DISTAL_ULTRALEAP")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ULTRALEAP_hand_tracking_forearm"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    IndexDistal = 9,

    [NativeName("XR_HAND_FOREARM_JOINT_INDEX_TIP_ULTRALEAP")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ULTRALEAP_hand_tracking_forearm"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    IndexTip = 10,

    [NativeName("XR_HAND_FOREARM_JOINT_MIDDLE_METACARPAL_ULTRALEAP")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ULTRALEAP_hand_tracking_forearm"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    MiddleMetacarpal = 11,

    [NativeName("XR_HAND_FOREARM_JOINT_MIDDLE_PROXIMAL_ULTRALEAP")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ULTRALEAP_hand_tracking_forearm"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    MiddleProximal = 12,

    [NativeName("XR_HAND_FOREARM_JOINT_MIDDLE_INTERMEDIATE_ULTRALEAP")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ULTRALEAP_hand_tracking_forearm"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    MiddleIntermediate = 13,

    [NativeName("XR_HAND_FOREARM_JOINT_MIDDLE_DISTAL_ULTRALEAP")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ULTRALEAP_hand_tracking_forearm"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    MiddleDistal = 14,

    [NativeName("XR_HAND_FOREARM_JOINT_MIDDLE_TIP_ULTRALEAP")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ULTRALEAP_hand_tracking_forearm"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    MiddleTip = 15,

    [NativeName("XR_HAND_FOREARM_JOINT_RING_METACARPAL_ULTRALEAP")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ULTRALEAP_hand_tracking_forearm"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    RingMetacarpal = 16,

    [NativeName("XR_HAND_FOREARM_JOINT_RING_PROXIMAL_ULTRALEAP")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ULTRALEAP_hand_tracking_forearm"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    RingProximal = 17,

    [NativeName("XR_HAND_FOREARM_JOINT_RING_INTERMEDIATE_ULTRALEAP")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ULTRALEAP_hand_tracking_forearm"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    RingIntermediate = 18,

    [NativeName("XR_HAND_FOREARM_JOINT_RING_DISTAL_ULTRALEAP")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ULTRALEAP_hand_tracking_forearm"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    RingDistal = 19,

    [NativeName("XR_HAND_FOREARM_JOINT_RING_TIP_ULTRALEAP")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ULTRALEAP_hand_tracking_forearm"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    RingTip = 20,

    [NativeName("XR_HAND_FOREARM_JOINT_LITTLE_METACARPAL_ULTRALEAP")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ULTRALEAP_hand_tracking_forearm"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    LittleMetacarpal = 21,

    [NativeName("XR_HAND_FOREARM_JOINT_LITTLE_PROXIMAL_ULTRALEAP")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ULTRALEAP_hand_tracking_forearm"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    LittleProximal = 22,

    [NativeName("XR_HAND_FOREARM_JOINT_LITTLE_INTERMEDIATE_ULTRALEAP")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ULTRALEAP_hand_tracking_forearm"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    LittleIntermediate = 23,

    [NativeName("XR_HAND_FOREARM_JOINT_LITTLE_DISTAL_ULTRALEAP")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ULTRALEAP_hand_tracking_forearm"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    LittleDistal = 24,

    [NativeName("XR_HAND_FOREARM_JOINT_LITTLE_TIP_ULTRALEAP")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ULTRALEAP_hand_tracking_forearm"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    LittleTip = 25,

    [NativeName("XR_HAND_FOREARM_JOINT_ELBOW_ULTRALEAP")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ULTRALEAP_hand_tracking_forearm"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    Elbow = 26,
}
