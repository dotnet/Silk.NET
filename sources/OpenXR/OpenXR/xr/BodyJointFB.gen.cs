// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrBodyJointFB")]
[SupportedApiProfile("openxr")]
public enum BodyJointFB
{
    [NativeName("XR_BODY_JOINT_ROOT_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_body_tracking"])]
    Root = 0,

    [NativeName("XR_BODY_JOINT_HIPS_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_body_tracking"])]
    Hips = 1,

    [NativeName("XR_BODY_JOINT_SPINE_LOWER_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_body_tracking"])]
    SpineLower = 2,

    [NativeName("XR_BODY_JOINT_SPINE_MIDDLE_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_body_tracking"])]
    SpineMiddle = 3,

    [NativeName("XR_BODY_JOINT_SPINE_UPPER_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_body_tracking"])]
    SpineUpper = 4,

    [NativeName("XR_BODY_JOINT_CHEST_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_body_tracking"])]
    Chest = 5,

    [NativeName("XR_BODY_JOINT_NECK_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_body_tracking"])]
    Neck = 6,

    [NativeName("XR_BODY_JOINT_HEAD_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_body_tracking"])]
    Head = 7,

    [NativeName("XR_BODY_JOINT_LEFT_SHOULDER_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_body_tracking"])]
    LeftShoulder = 8,

    [NativeName("XR_BODY_JOINT_LEFT_SCAPULA_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_body_tracking"])]
    LeftScapula = 9,

    [NativeName("XR_BODY_JOINT_LEFT_ARM_UPPER_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_body_tracking"])]
    LeftArmUpper = 10,

    [NativeName("XR_BODY_JOINT_LEFT_ARM_LOWER_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_body_tracking"])]
    LeftArmLower = 11,

    [NativeName("XR_BODY_JOINT_LEFT_HAND_WRIST_TWIST_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_body_tracking"])]
    LeftHandWristTwist = 12,

    [NativeName("XR_BODY_JOINT_RIGHT_SHOULDER_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_body_tracking"])]
    RightShoulder = 13,

    [NativeName("XR_BODY_JOINT_RIGHT_SCAPULA_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_body_tracking"])]
    RightScapula = 14,

    [NativeName("XR_BODY_JOINT_RIGHT_ARM_UPPER_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_body_tracking"])]
    RightArmUpper = 15,

    [NativeName("XR_BODY_JOINT_RIGHT_ARM_LOWER_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_body_tracking"])]
    RightArmLower = 16,

    [NativeName("XR_BODY_JOINT_RIGHT_HAND_WRIST_TWIST_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_body_tracking"])]
    RightHandWristTwist = 17,

    [NativeName("XR_BODY_JOINT_LEFT_HAND_PALM_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_body_tracking"])]
    LeftHandPalm = 18,

    [NativeName("XR_BODY_JOINT_LEFT_HAND_WRIST_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_body_tracking"])]
    LeftHandWrist = 19,

    [NativeName("XR_BODY_JOINT_LEFT_HAND_THUMB_METACARPAL_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_body_tracking"])]
    LeftHandThumbMetacarpal = 20,

    [NativeName("XR_BODY_JOINT_LEFT_HAND_THUMB_PROXIMAL_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_body_tracking"])]
    LeftHandThumbProximal = 21,

    [NativeName("XR_BODY_JOINT_LEFT_HAND_THUMB_DISTAL_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_body_tracking"])]
    LeftHandThumbDistal = 22,

    [NativeName("XR_BODY_JOINT_LEFT_HAND_THUMB_TIP_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_body_tracking"])]
    LeftHandThumbTip = 23,

    [NativeName("XR_BODY_JOINT_LEFT_HAND_INDEX_METACARPAL_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_body_tracking"])]
    LeftHandIndexMetacarpal = 24,

    [NativeName("XR_BODY_JOINT_LEFT_HAND_INDEX_PROXIMAL_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_body_tracking"])]
    LeftHandIndexProximal = 25,

    [NativeName("XR_BODY_JOINT_LEFT_HAND_INDEX_INTERMEDIATE_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_body_tracking"])]
    LeftHandIndexIntermediate = 26,

    [NativeName("XR_BODY_JOINT_LEFT_HAND_INDEX_DISTAL_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_body_tracking"])]
    LeftHandIndexDistal = 27,

    [NativeName("XR_BODY_JOINT_LEFT_HAND_INDEX_TIP_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_body_tracking"])]
    LeftHandIndexTip = 28,

    [NativeName("XR_BODY_JOINT_LEFT_HAND_MIDDLE_METACARPAL_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_body_tracking"])]
    LeftHandMiddleMetacarpal = 29,

    [NativeName("XR_BODY_JOINT_LEFT_HAND_MIDDLE_PROXIMAL_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_body_tracking"])]
    LeftHandMiddleProximal = 30,

    [NativeName("XR_BODY_JOINT_LEFT_HAND_MIDDLE_INTERMEDIATE_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_body_tracking"])]
    LeftHandMiddleIntermediate = 31,

    [NativeName("XR_BODY_JOINT_LEFT_HAND_MIDDLE_DISTAL_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_body_tracking"])]
    LeftHandMiddleDistal = 32,

    [NativeName("XR_BODY_JOINT_LEFT_HAND_MIDDLE_TIP_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_body_tracking"])]
    LeftHandMiddleTip = 33,

    [NativeName("XR_BODY_JOINT_LEFT_HAND_RING_METACARPAL_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_body_tracking"])]
    LeftHandRingMetacarpal = 34,

    [NativeName("XR_BODY_JOINT_LEFT_HAND_RING_PROXIMAL_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_body_tracking"])]
    LeftHandRingProximal = 35,

    [NativeName("XR_BODY_JOINT_LEFT_HAND_RING_INTERMEDIATE_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_body_tracking"])]
    LeftHandRingIntermediate = 36,

    [NativeName("XR_BODY_JOINT_LEFT_HAND_RING_DISTAL_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_body_tracking"])]
    LeftHandRingDistal = 37,

    [NativeName("XR_BODY_JOINT_LEFT_HAND_RING_TIP_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_body_tracking"])]
    LeftHandRingTip = 38,

    [NativeName("XR_BODY_JOINT_LEFT_HAND_LITTLE_METACARPAL_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_body_tracking"])]
    LeftHandLittleMetacarpal = 39,

    [NativeName("XR_BODY_JOINT_LEFT_HAND_LITTLE_PROXIMAL_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_body_tracking"])]
    LeftHandLittleProximal = 40,

    [NativeName("XR_BODY_JOINT_LEFT_HAND_LITTLE_INTERMEDIATE_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_body_tracking"])]
    LeftHandLittleIntermediate = 41,

    [NativeName("XR_BODY_JOINT_LEFT_HAND_LITTLE_DISTAL_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_body_tracking"])]
    LeftHandLittleDistal = 42,

    [NativeName("XR_BODY_JOINT_LEFT_HAND_LITTLE_TIP_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_body_tracking"])]
    LeftHandLittleTip = 43,

    [NativeName("XR_BODY_JOINT_RIGHT_HAND_PALM_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_body_tracking"])]
    RightHandPalm = 44,

    [NativeName("XR_BODY_JOINT_RIGHT_HAND_WRIST_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_body_tracking"])]
    RightHandWrist = 45,

    [NativeName("XR_BODY_JOINT_RIGHT_HAND_THUMB_METACARPAL_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_body_tracking"])]
    RightHandThumbMetacarpal = 46,

    [NativeName("XR_BODY_JOINT_RIGHT_HAND_THUMB_PROXIMAL_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_body_tracking"])]
    RightHandThumbProximal = 47,

    [NativeName("XR_BODY_JOINT_RIGHT_HAND_THUMB_DISTAL_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_body_tracking"])]
    RightHandThumbDistal = 48,

    [NativeName("XR_BODY_JOINT_RIGHT_HAND_THUMB_TIP_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_body_tracking"])]
    RightHandThumbTip = 49,

    [NativeName("XR_BODY_JOINT_RIGHT_HAND_INDEX_METACARPAL_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_body_tracking"])]
    RightHandIndexMetacarpal = 50,

    [NativeName("XR_BODY_JOINT_RIGHT_HAND_INDEX_PROXIMAL_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_body_tracking"])]
    RightHandIndexProximal = 51,

    [NativeName("XR_BODY_JOINT_RIGHT_HAND_INDEX_INTERMEDIATE_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_body_tracking"])]
    RightHandIndexIntermediate = 52,

    [NativeName("XR_BODY_JOINT_RIGHT_HAND_INDEX_DISTAL_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_body_tracking"])]
    RightHandIndexDistal = 53,

    [NativeName("XR_BODY_JOINT_RIGHT_HAND_INDEX_TIP_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_body_tracking"])]
    RightHandIndexTip = 54,

    [NativeName("XR_BODY_JOINT_RIGHT_HAND_MIDDLE_METACARPAL_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_body_tracking"])]
    RightHandMiddleMetacarpal = 55,

    [NativeName("XR_BODY_JOINT_RIGHT_HAND_MIDDLE_PROXIMAL_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_body_tracking"])]
    RightHandMiddleProximal = 56,

    [NativeName("XR_BODY_JOINT_RIGHT_HAND_MIDDLE_INTERMEDIATE_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_body_tracking"])]
    RightHandMiddleIntermediate = 57,

    [NativeName("XR_BODY_JOINT_RIGHT_HAND_MIDDLE_DISTAL_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_body_tracking"])]
    RightHandMiddleDistal = 58,

    [NativeName("XR_BODY_JOINT_RIGHT_HAND_MIDDLE_TIP_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_body_tracking"])]
    RightHandMiddleTip = 59,

    [NativeName("XR_BODY_JOINT_RIGHT_HAND_RING_METACARPAL_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_body_tracking"])]
    RightHandRingMetacarpal = 60,

    [NativeName("XR_BODY_JOINT_RIGHT_HAND_RING_PROXIMAL_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_body_tracking"])]
    RightHandRingProximal = 61,

    [NativeName("XR_BODY_JOINT_RIGHT_HAND_RING_INTERMEDIATE_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_body_tracking"])]
    RightHandRingIntermediate = 62,

    [NativeName("XR_BODY_JOINT_RIGHT_HAND_RING_DISTAL_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_body_tracking"])]
    RightHandRingDistal = 63,

    [NativeName("XR_BODY_JOINT_RIGHT_HAND_RING_TIP_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_body_tracking"])]
    RightHandRingTip = 64,

    [NativeName("XR_BODY_JOINT_RIGHT_HAND_LITTLE_METACARPAL_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_body_tracking"])]
    RightHandLittleMetacarpal = 65,

    [NativeName("XR_BODY_JOINT_RIGHT_HAND_LITTLE_PROXIMAL_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_body_tracking"])]
    RightHandLittleProximal = 66,

    [NativeName("XR_BODY_JOINT_RIGHT_HAND_LITTLE_INTERMEDIATE_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_body_tracking"])]
    RightHandLittleIntermediate = 67,

    [NativeName("XR_BODY_JOINT_RIGHT_HAND_LITTLE_DISTAL_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_body_tracking"])]
    RightHandLittleDistal = 68,

    [NativeName("XR_BODY_JOINT_RIGHT_HAND_LITTLE_TIP_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_body_tracking"])]
    RightHandLittleTip = 69,

    [NativeName("XR_BODY_JOINT_COUNT_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_body_tracking"])]
    Count = 70,

    [NativeName("XR_BODY_JOINT_NONE_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_body_tracking"])]
    None = -1,
}
