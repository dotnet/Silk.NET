// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrBodyJointFB")]
public enum BodyJointFB
{
    [NativeName("XR_BODY_JOINT_ROOT_FB")]
    Root = 0,

    [NativeName("XR_BODY_JOINT_HIPS_FB")]
    Hips = 1,

    [NativeName("XR_BODY_JOINT_SPINE_LOWER_FB")]
    SpineLower = 2,

    [NativeName("XR_BODY_JOINT_SPINE_MIDDLE_FB")]
    SpineMiddle = 3,

    [NativeName("XR_BODY_JOINT_SPINE_UPPER_FB")]
    SpineUpper = 4,

    [NativeName("XR_BODY_JOINT_CHEST_FB")]
    Chest = 5,

    [NativeName("XR_BODY_JOINT_NECK_FB")]
    Neck = 6,

    [NativeName("XR_BODY_JOINT_HEAD_FB")]
    Head = 7,

    [NativeName("XR_BODY_JOINT_LEFT_SHOULDER_FB")]
    LeftShoulder = 8,

    [NativeName("XR_BODY_JOINT_LEFT_SCAPULA_FB")]
    LeftScapula = 9,

    [NativeName("XR_BODY_JOINT_LEFT_ARM_UPPER_FB")]
    LeftArmUpper = 10,

    [NativeName("XR_BODY_JOINT_LEFT_ARM_LOWER_FB")]
    LeftArmLower = 11,

    [NativeName("XR_BODY_JOINT_LEFT_HAND_WRIST_TWIST_FB")]
    LeftHandWristTwist = 12,

    [NativeName("XR_BODY_JOINT_RIGHT_SHOULDER_FB")]
    RightShoulder = 13,

    [NativeName("XR_BODY_JOINT_RIGHT_SCAPULA_FB")]
    RightScapula = 14,

    [NativeName("XR_BODY_JOINT_RIGHT_ARM_UPPER_FB")]
    RightArmUpper = 15,

    [NativeName("XR_BODY_JOINT_RIGHT_ARM_LOWER_FB")]
    RightArmLower = 16,

    [NativeName("XR_BODY_JOINT_RIGHT_HAND_WRIST_TWIST_FB")]
    RightHandWristTwist = 17,

    [NativeName("XR_BODY_JOINT_LEFT_HAND_PALM_FB")]
    LeftHandPalm = 18,

    [NativeName("XR_BODY_JOINT_LEFT_HAND_WRIST_FB")]
    LeftHandWrist = 19,

    [NativeName("XR_BODY_JOINT_LEFT_HAND_THUMB_METACARPAL_FB")]
    LeftHandThumbMetacarpal = 20,

    [NativeName("XR_BODY_JOINT_LEFT_HAND_THUMB_PROXIMAL_FB")]
    LeftHandThumbProximal = 21,

    [NativeName("XR_BODY_JOINT_LEFT_HAND_THUMB_DISTAL_FB")]
    LeftHandThumbDistal = 22,

    [NativeName("XR_BODY_JOINT_LEFT_HAND_THUMB_TIP_FB")]
    LeftHandThumbTip = 23,

    [NativeName("XR_BODY_JOINT_LEFT_HAND_INDEX_METACARPAL_FB")]
    LeftHandIndexMetacarpal = 24,

    [NativeName("XR_BODY_JOINT_LEFT_HAND_INDEX_PROXIMAL_FB")]
    LeftHandIndexProximal = 25,

    [NativeName("XR_BODY_JOINT_LEFT_HAND_INDEX_INTERMEDIATE_FB")]
    LeftHandIndexIntermediate = 26,

    [NativeName("XR_BODY_JOINT_LEFT_HAND_INDEX_DISTAL_FB")]
    LeftHandIndexDistal = 27,

    [NativeName("XR_BODY_JOINT_LEFT_HAND_INDEX_TIP_FB")]
    LeftHandIndexTip = 28,

    [NativeName("XR_BODY_JOINT_LEFT_HAND_MIDDLE_METACARPAL_FB")]
    LeftHandMiddleMetacarpal = 29,

    [NativeName("XR_BODY_JOINT_LEFT_HAND_MIDDLE_PROXIMAL_FB")]
    LeftHandMiddleProximal = 30,

    [NativeName("XR_BODY_JOINT_LEFT_HAND_MIDDLE_INTERMEDIATE_FB")]
    LeftHandMiddleIntermediate = 31,

    [NativeName("XR_BODY_JOINT_LEFT_HAND_MIDDLE_DISTAL_FB")]
    LeftHandMiddleDistal = 32,

    [NativeName("XR_BODY_JOINT_LEFT_HAND_MIDDLE_TIP_FB")]
    LeftHandMiddleTip = 33,

    [NativeName("XR_BODY_JOINT_LEFT_HAND_RING_METACARPAL_FB")]
    LeftHandRingMetacarpal = 34,

    [NativeName("XR_BODY_JOINT_LEFT_HAND_RING_PROXIMAL_FB")]
    LeftHandRingProximal = 35,

    [NativeName("XR_BODY_JOINT_LEFT_HAND_RING_INTERMEDIATE_FB")]
    LeftHandRingIntermediate = 36,

    [NativeName("XR_BODY_JOINT_LEFT_HAND_RING_DISTAL_FB")]
    LeftHandRingDistal = 37,

    [NativeName("XR_BODY_JOINT_LEFT_HAND_RING_TIP_FB")]
    LeftHandRingTip = 38,

    [NativeName("XR_BODY_JOINT_LEFT_HAND_LITTLE_METACARPAL_FB")]
    LeftHandLittleMetacarpal = 39,

    [NativeName("XR_BODY_JOINT_LEFT_HAND_LITTLE_PROXIMAL_FB")]
    LeftHandLittleProximal = 40,

    [NativeName("XR_BODY_JOINT_LEFT_HAND_LITTLE_INTERMEDIATE_FB")]
    LeftHandLittleIntermediate = 41,

    [NativeName("XR_BODY_JOINT_LEFT_HAND_LITTLE_DISTAL_FB")]
    LeftHandLittleDistal = 42,

    [NativeName("XR_BODY_JOINT_LEFT_HAND_LITTLE_TIP_FB")]
    LeftHandLittleTip = 43,

    [NativeName("XR_BODY_JOINT_RIGHT_HAND_PALM_FB")]
    RightHandPalm = 44,

    [NativeName("XR_BODY_JOINT_RIGHT_HAND_WRIST_FB")]
    RightHandWrist = 45,

    [NativeName("XR_BODY_JOINT_RIGHT_HAND_THUMB_METACARPAL_FB")]
    RightHandThumbMetacarpal = 46,

    [NativeName("XR_BODY_JOINT_RIGHT_HAND_THUMB_PROXIMAL_FB")]
    RightHandThumbProximal = 47,

    [NativeName("XR_BODY_JOINT_RIGHT_HAND_THUMB_DISTAL_FB")]
    RightHandThumbDistal = 48,

    [NativeName("XR_BODY_JOINT_RIGHT_HAND_THUMB_TIP_FB")]
    RightHandThumbTip = 49,

    [NativeName("XR_BODY_JOINT_RIGHT_HAND_INDEX_METACARPAL_FB")]
    RightHandIndexMetacarpal = 50,

    [NativeName("XR_BODY_JOINT_RIGHT_HAND_INDEX_PROXIMAL_FB")]
    RightHandIndexProximal = 51,

    [NativeName("XR_BODY_JOINT_RIGHT_HAND_INDEX_INTERMEDIATE_FB")]
    RightHandIndexIntermediate = 52,

    [NativeName("XR_BODY_JOINT_RIGHT_HAND_INDEX_DISTAL_FB")]
    RightHandIndexDistal = 53,

    [NativeName("XR_BODY_JOINT_RIGHT_HAND_INDEX_TIP_FB")]
    RightHandIndexTip = 54,

    [NativeName("XR_BODY_JOINT_RIGHT_HAND_MIDDLE_METACARPAL_FB")]
    RightHandMiddleMetacarpal = 55,

    [NativeName("XR_BODY_JOINT_RIGHT_HAND_MIDDLE_PROXIMAL_FB")]
    RightHandMiddleProximal = 56,

    [NativeName("XR_BODY_JOINT_RIGHT_HAND_MIDDLE_INTERMEDIATE_FB")]
    RightHandMiddleIntermediate = 57,

    [NativeName("XR_BODY_JOINT_RIGHT_HAND_MIDDLE_DISTAL_FB")]
    RightHandMiddleDistal = 58,

    [NativeName("XR_BODY_JOINT_RIGHT_HAND_MIDDLE_TIP_FB")]
    RightHandMiddleTip = 59,

    [NativeName("XR_BODY_JOINT_RIGHT_HAND_RING_METACARPAL_FB")]
    RightHandRingMetacarpal = 60,

    [NativeName("XR_BODY_JOINT_RIGHT_HAND_RING_PROXIMAL_FB")]
    RightHandRingProximal = 61,

    [NativeName("XR_BODY_JOINT_RIGHT_HAND_RING_INTERMEDIATE_FB")]
    RightHandRingIntermediate = 62,

    [NativeName("XR_BODY_JOINT_RIGHT_HAND_RING_DISTAL_FB")]
    RightHandRingDistal = 63,

    [NativeName("XR_BODY_JOINT_RIGHT_HAND_RING_TIP_FB")]
    RightHandRingTip = 64,

    [NativeName("XR_BODY_JOINT_RIGHT_HAND_LITTLE_METACARPAL_FB")]
    RightHandLittleMetacarpal = 65,

    [NativeName("XR_BODY_JOINT_RIGHT_HAND_LITTLE_PROXIMAL_FB")]
    RightHandLittleProximal = 66,

    [NativeName("XR_BODY_JOINT_RIGHT_HAND_LITTLE_INTERMEDIATE_FB")]
    RightHandLittleIntermediate = 67,

    [NativeName("XR_BODY_JOINT_RIGHT_HAND_LITTLE_DISTAL_FB")]
    RightHandLittleDistal = 68,

    [NativeName("XR_BODY_JOINT_RIGHT_HAND_LITTLE_TIP_FB")]
    RightHandLittleTip = 69,

    [NativeName("XR_BODY_JOINT_COUNT_FB")]
    Count = 70,

    [NativeName("XR_BODY_JOINT_NONE_FB")]
    None = -1,
}
