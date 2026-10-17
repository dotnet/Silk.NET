// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrFullBodyJointMETA")]
public enum FullBodyJointMETA : uint
{
    [NativeName("XR_FULL_BODY_JOINT_ROOT_META")]
    Root = 0,

    [NativeName("XR_FULL_BODY_JOINT_HIPS_META")]
    Hips = 1,

    [NativeName("XR_FULL_BODY_JOINT_SPINE_LOWER_META")]
    SpineLower = 2,

    [NativeName("XR_FULL_BODY_JOINT_SPINE_MIDDLE_META")]
    SpineMiddle = 3,

    [NativeName("XR_FULL_BODY_JOINT_SPINE_UPPER_META")]
    SpineUpper = 4,

    [NativeName("XR_FULL_BODY_JOINT_CHEST_META")]
    Chest = 5,

    [NativeName("XR_FULL_BODY_JOINT_NECK_META")]
    Neck = 6,

    [NativeName("XR_FULL_BODY_JOINT_HEAD_META")]
    Head = 7,

    [NativeName("XR_FULL_BODY_JOINT_LEFT_SHOULDER_META")]
    LeftShoulder = 8,

    [NativeName("XR_FULL_BODY_JOINT_LEFT_SCAPULA_META")]
    LeftScapula = 9,

    [NativeName("XR_FULL_BODY_JOINT_LEFT_ARM_UPPER_META")]
    LeftArmUpper = 10,

    [NativeName("XR_FULL_BODY_JOINT_LEFT_ARM_LOWER_META")]
    LeftArmLower = 11,

    [NativeName("XR_FULL_BODY_JOINT_LEFT_HAND_WRIST_TWIST_META")]
    LeftHandWristTwist = 12,

    [NativeName("XR_FULL_BODY_JOINT_RIGHT_SHOULDER_META")]
    RightShoulder = 13,

    [NativeName("XR_FULL_BODY_JOINT_RIGHT_SCAPULA_META")]
    RightScapula = 14,

    [NativeName("XR_FULL_BODY_JOINT_RIGHT_ARM_UPPER_META")]
    RightArmUpper = 15,

    [NativeName("XR_FULL_BODY_JOINT_RIGHT_ARM_LOWER_META")]
    RightArmLower = 16,

    [NativeName("XR_FULL_BODY_JOINT_RIGHT_HAND_WRIST_TWIST_META")]
    RightHandWristTwist = 17,

    [NativeName("XR_FULL_BODY_JOINT_LEFT_HAND_PALM_META")]
    LeftHandPalm = 18,

    [NativeName("XR_FULL_BODY_JOINT_LEFT_HAND_WRIST_META")]
    LeftHandWrist = 19,

    [NativeName("XR_FULL_BODY_JOINT_LEFT_HAND_THUMB_METACARPAL_META")]
    LeftHandThumbMetacarpal = 20,

    [NativeName("XR_FULL_BODY_JOINT_LEFT_HAND_THUMB_PROXIMAL_META")]
    LeftHandThumbProximal = 21,

    [NativeName("XR_FULL_BODY_JOINT_LEFT_HAND_THUMB_DISTAL_META")]
    LeftHandThumbDistal = 22,

    [NativeName("XR_FULL_BODY_JOINT_LEFT_HAND_THUMB_TIP_META")]
    LeftHandThumbTip = 23,

    [NativeName("XR_FULL_BODY_JOINT_LEFT_HAND_INDEX_METACARPAL_META")]
    LeftHandIndexMetacarpal = 24,

    [NativeName("XR_FULL_BODY_JOINT_LEFT_HAND_INDEX_PROXIMAL_META")]
    LeftHandIndexProximal = 25,

    [NativeName("XR_FULL_BODY_JOINT_LEFT_HAND_INDEX_INTERMEDIATE_META")]
    LeftHandIndexIntermediate = 26,

    [NativeName("XR_FULL_BODY_JOINT_LEFT_HAND_INDEX_DISTAL_META")]
    LeftHandIndexDistal = 27,

    [NativeName("XR_FULL_BODY_JOINT_LEFT_HAND_INDEX_TIP_META")]
    LeftHandIndexTip = 28,

    [NativeName("XR_FULL_BODY_JOINT_LEFT_HAND_MIDDLE_METACARPAL_META")]
    LeftHandMiddleMetacarpal = 29,

    [NativeName("XR_FULL_BODY_JOINT_LEFT_HAND_MIDDLE_PROXIMAL_META")]
    LeftHandMiddleProximal = 30,

    [NativeName("XR_FULL_BODY_JOINT_LEFT_HAND_MIDDLE_INTERMEDIATE_META")]
    LeftHandMiddleIntermediate = 31,

    [NativeName("XR_FULL_BODY_JOINT_LEFT_HAND_MIDDLE_DISTAL_META")]
    LeftHandMiddleDistal = 32,

    [NativeName("XR_FULL_BODY_JOINT_LEFT_HAND_MIDDLE_TIP_META")]
    LeftHandMiddleTip = 33,

    [NativeName("XR_FULL_BODY_JOINT_LEFT_HAND_RING_METACARPAL_META")]
    LeftHandRingMetacarpal = 34,

    [NativeName("XR_FULL_BODY_JOINT_LEFT_HAND_RING_PROXIMAL_META")]
    LeftHandRingProximal = 35,

    [NativeName("XR_FULL_BODY_JOINT_LEFT_HAND_RING_INTERMEDIATE_META")]
    LeftHandRingIntermediate = 36,

    [NativeName("XR_FULL_BODY_JOINT_LEFT_HAND_RING_DISTAL_META")]
    LeftHandRingDistal = 37,

    [NativeName("XR_FULL_BODY_JOINT_LEFT_HAND_RING_TIP_META")]
    LeftHandRingTip = 38,

    [NativeName("XR_FULL_BODY_JOINT_LEFT_HAND_LITTLE_METACARPAL_META")]
    LeftHandLittleMetacarpal = 39,

    [NativeName("XR_FULL_BODY_JOINT_LEFT_HAND_LITTLE_PROXIMAL_META")]
    LeftHandLittleProximal = 40,

    [NativeName("XR_FULL_BODY_JOINT_LEFT_HAND_LITTLE_INTERMEDIATE_META")]
    LeftHandLittleIntermediate = 41,

    [NativeName("XR_FULL_BODY_JOINT_LEFT_HAND_LITTLE_DISTAL_META")]
    LeftHandLittleDistal = 42,

    [NativeName("XR_FULL_BODY_JOINT_LEFT_HAND_LITTLE_TIP_META")]
    LeftHandLittleTip = 43,

    [NativeName("XR_FULL_BODY_JOINT_RIGHT_HAND_PALM_META")]
    RightHandPalm = 44,

    [NativeName("XR_FULL_BODY_JOINT_RIGHT_HAND_WRIST_META")]
    RightHandWrist = 45,

    [NativeName("XR_FULL_BODY_JOINT_RIGHT_HAND_THUMB_METACARPAL_META")]
    RightHandThumbMetacarpal = 46,

    [NativeName("XR_FULL_BODY_JOINT_RIGHT_HAND_THUMB_PROXIMAL_META")]
    RightHandThumbProximal = 47,

    [NativeName("XR_FULL_BODY_JOINT_RIGHT_HAND_THUMB_DISTAL_META")]
    RightHandThumbDistal = 48,

    [NativeName("XR_FULL_BODY_JOINT_RIGHT_HAND_THUMB_TIP_META")]
    RightHandThumbTip = 49,

    [NativeName("XR_FULL_BODY_JOINT_RIGHT_HAND_INDEX_METACARPAL_META")]
    RightHandIndexMetacarpal = 50,

    [NativeName("XR_FULL_BODY_JOINT_RIGHT_HAND_INDEX_PROXIMAL_META")]
    RightHandIndexProximal = 51,

    [NativeName("XR_FULL_BODY_JOINT_RIGHT_HAND_INDEX_INTERMEDIATE_META")]
    RightHandIndexIntermediate = 52,

    [NativeName("XR_FULL_BODY_JOINT_RIGHT_HAND_INDEX_DISTAL_META")]
    RightHandIndexDistal = 53,

    [NativeName("XR_FULL_BODY_JOINT_RIGHT_HAND_INDEX_TIP_META")]
    RightHandIndexTip = 54,

    [NativeName("XR_FULL_BODY_JOINT_RIGHT_HAND_MIDDLE_METACARPAL_META")]
    RightHandMiddleMetacarpal = 55,

    [NativeName("XR_FULL_BODY_JOINT_RIGHT_HAND_MIDDLE_PROXIMAL_META")]
    RightHandMiddleProximal = 56,

    [NativeName("XR_FULL_BODY_JOINT_RIGHT_HAND_MIDDLE_INTERMEDIATE_META")]
    RightHandMiddleIntermediate = 57,

    [NativeName("XR_FULL_BODY_JOINT_RIGHT_HAND_MIDDLE_DISTAL_META")]
    RightHandMiddleDistal = 58,

    [NativeName("XR_FULL_BODY_JOINT_RIGHT_HAND_MIDDLE_TIP_META")]
    RightHandMiddleTip = 59,

    [NativeName("XR_FULL_BODY_JOINT_RIGHT_HAND_RING_METACARPAL_META")]
    RightHandRingMetacarpal = 60,

    [NativeName("XR_FULL_BODY_JOINT_RIGHT_HAND_RING_PROXIMAL_META")]
    RightHandRingProximal = 61,

    [NativeName("XR_FULL_BODY_JOINT_RIGHT_HAND_RING_INTERMEDIATE_META")]
    RightHandRingIntermediate = 62,

    [NativeName("XR_FULL_BODY_JOINT_RIGHT_HAND_RING_DISTAL_META")]
    RightHandRingDistal = 63,

    [NativeName("XR_FULL_BODY_JOINT_RIGHT_HAND_RING_TIP_META")]
    RightHandRingTip = 64,

    [NativeName("XR_FULL_BODY_JOINT_RIGHT_HAND_LITTLE_METACARPAL_META")]
    RightHandLittleMetacarpal = 65,

    [NativeName("XR_FULL_BODY_JOINT_RIGHT_HAND_LITTLE_PROXIMAL_META")]
    RightHandLittleProximal = 66,

    [NativeName("XR_FULL_BODY_JOINT_RIGHT_HAND_LITTLE_INTERMEDIATE_META")]
    RightHandLittleIntermediate = 67,

    [NativeName("XR_FULL_BODY_JOINT_RIGHT_HAND_LITTLE_DISTAL_META")]
    RightHandLittleDistal = 68,

    [NativeName("XR_FULL_BODY_JOINT_RIGHT_HAND_LITTLE_TIP_META")]
    RightHandLittleTip = 69,

    [NativeName("XR_FULL_BODY_JOINT_LEFT_UPPER_LEG_META")]
    LeftUpperLeg = 70,

    [NativeName("XR_FULL_BODY_JOINT_LEFT_LOWER_LEG_META")]
    LeftLowerLeg = 71,

    [NativeName("XR_FULL_BODY_JOINT_LEFT_FOOT_ANKLE_TWIST_META")]
    LeftFootAnkleTwist = 72,

    [NativeName("XR_FULL_BODY_JOINT_LEFT_FOOT_ANKLE_META")]
    LeftFootAnkle = 73,

    [NativeName("XR_FULL_BODY_JOINT_LEFT_FOOT_SUBTALAR_META")]
    LeftFootSubtalar = 74,

    [NativeName("XR_FULL_BODY_JOINT_LEFT_FOOT_TRANSVERSE_META")]
    LeftFootTransverse = 75,

    [NativeName("XR_FULL_BODY_JOINT_LEFT_FOOT_BALL_META")]
    LeftFootBall = 76,

    [NativeName("XR_FULL_BODY_JOINT_RIGHT_UPPER_LEG_META")]
    RightUpperLeg = 77,

    [NativeName("XR_FULL_BODY_JOINT_RIGHT_LOWER_LEG_META")]
    RightLowerLeg = 78,

    [NativeName("XR_FULL_BODY_JOINT_RIGHT_FOOT_ANKLE_TWIST_META")]
    RightFootAnkleTwist = 79,

    [NativeName("XR_FULL_BODY_JOINT_RIGHT_FOOT_ANKLE_META")]
    RightFootAnkle = 80,

    [NativeName("XR_FULL_BODY_JOINT_RIGHT_FOOT_SUBTALAR_META")]
    RightFootSubtalar = 81,

    [NativeName("XR_FULL_BODY_JOINT_RIGHT_FOOT_TRANSVERSE_META")]
    RightFootTransverse = 82,

    [NativeName("XR_FULL_BODY_JOINT_RIGHT_FOOT_BALL_META")]
    RightFootBall = 83,

    [NativeName("XR_FULL_BODY_JOINT_COUNT_META")]
    Count = 84,

    [NativeName("XR_FULL_BODY_JOINT_NONE_META")]
    None = 85,
}
