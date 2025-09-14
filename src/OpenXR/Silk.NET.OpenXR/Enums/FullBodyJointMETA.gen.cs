// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrFullBodyJointMETA")]
    public enum FullBodyJointMETA : int
    {
        [Obsolete("Deprecated in favour of \"RootMeta\"")]
        [NativeName("Name", "XR_FULL_BODY_JOINT_ROOT_META")]
        FullBodyJointRootMeta = 0,
        [Obsolete("Deprecated in favour of \"HipsMeta\"")]
        [NativeName("Name", "XR_FULL_BODY_JOINT_HIPS_META")]
        FullBodyJointHipsMeta = 1,
        [Obsolete("Deprecated in favour of \"SpineLowerMeta\"")]
        [NativeName("Name", "XR_FULL_BODY_JOINT_SPINE_LOWER_META")]
        FullBodyJointSpineLowerMeta = 2,
        [Obsolete("Deprecated in favour of \"SpineMiddleMeta\"")]
        [NativeName("Name", "XR_FULL_BODY_JOINT_SPINE_MIDDLE_META")]
        FullBodyJointSpineMiddleMeta = 3,
        [Obsolete("Deprecated in favour of \"SpineUpperMeta\"")]
        [NativeName("Name", "XR_FULL_BODY_JOINT_SPINE_UPPER_META")]
        FullBodyJointSpineUpperMeta = 4,
        [Obsolete("Deprecated in favour of \"ChestMeta\"")]
        [NativeName("Name", "XR_FULL_BODY_JOINT_CHEST_META")]
        FullBodyJointChestMeta = 5,
        [Obsolete("Deprecated in favour of \"NeckMeta\"")]
        [NativeName("Name", "XR_FULL_BODY_JOINT_NECK_META")]
        FullBodyJointNeckMeta = 6,
        [Obsolete("Deprecated in favour of \"HeadMeta\"")]
        [NativeName("Name", "XR_FULL_BODY_JOINT_HEAD_META")]
        FullBodyJointHeadMeta = 7,
        [Obsolete("Deprecated in favour of \"LeftShoulderMeta\"")]
        [NativeName("Name", "XR_FULL_BODY_JOINT_LEFT_SHOULDER_META")]
        FullBodyJointLeftShoulderMeta = 8,
        [Obsolete("Deprecated in favour of \"LeftScapulaMeta\"")]
        [NativeName("Name", "XR_FULL_BODY_JOINT_LEFT_SCAPULA_META")]
        FullBodyJointLeftScapulaMeta = 9,
        [Obsolete("Deprecated in favour of \"LeftArmUpperMeta\"")]
        [NativeName("Name", "XR_FULL_BODY_JOINT_LEFT_ARM_UPPER_META")]
        FullBodyJointLeftArmUpperMeta = 10,
        [Obsolete("Deprecated in favour of \"LeftArmLowerMeta\"")]
        [NativeName("Name", "XR_FULL_BODY_JOINT_LEFT_ARM_LOWER_META")]
        FullBodyJointLeftArmLowerMeta = 11,
        [Obsolete("Deprecated in favour of \"LeftHandWristTwistMeta\"")]
        [NativeName("Name", "XR_FULL_BODY_JOINT_LEFT_HAND_WRIST_TWIST_META")]
        FullBodyJointLeftHandWristTwistMeta = 12,
        [Obsolete("Deprecated in favour of \"RightShoulderMeta\"")]
        [NativeName("Name", "XR_FULL_BODY_JOINT_RIGHT_SHOULDER_META")]
        FullBodyJointRightShoulderMeta = 13,
        [Obsolete("Deprecated in favour of \"RightScapulaMeta\"")]
        [NativeName("Name", "XR_FULL_BODY_JOINT_RIGHT_SCAPULA_META")]
        FullBodyJointRightScapulaMeta = 14,
        [Obsolete("Deprecated in favour of \"RightArmUpperMeta\"")]
        [NativeName("Name", "XR_FULL_BODY_JOINT_RIGHT_ARM_UPPER_META")]
        FullBodyJointRightArmUpperMeta = 15,
        [Obsolete("Deprecated in favour of \"RightArmLowerMeta\"")]
        [NativeName("Name", "XR_FULL_BODY_JOINT_RIGHT_ARM_LOWER_META")]
        FullBodyJointRightArmLowerMeta = 16,
        [Obsolete("Deprecated in favour of \"RightHandWristTwistMeta\"")]
        [NativeName("Name", "XR_FULL_BODY_JOINT_RIGHT_HAND_WRIST_TWIST_META")]
        FullBodyJointRightHandWristTwistMeta = 17,
        [Obsolete("Deprecated in favour of \"LeftHandPalmMeta\"")]
        [NativeName("Name", "XR_FULL_BODY_JOINT_LEFT_HAND_PALM_META")]
        FullBodyJointLeftHandPalmMeta = 18,
        [Obsolete("Deprecated in favour of \"LeftHandWristMeta\"")]
        [NativeName("Name", "XR_FULL_BODY_JOINT_LEFT_HAND_WRIST_META")]
        FullBodyJointLeftHandWristMeta = 19,
        [Obsolete("Deprecated in favour of \"LeftHandThumbMetacarpalMeta\"")]
        [NativeName("Name", "XR_FULL_BODY_JOINT_LEFT_HAND_THUMB_METACARPAL_META")]
        FullBodyJointLeftHandThumbMetacarpalMeta = 20,
        [Obsolete("Deprecated in favour of \"LeftHandThumbProximalMeta\"")]
        [NativeName("Name", "XR_FULL_BODY_JOINT_LEFT_HAND_THUMB_PROXIMAL_META")]
        FullBodyJointLeftHandThumbProximalMeta = 21,
        [Obsolete("Deprecated in favour of \"LeftHandThumbDistalMeta\"")]
        [NativeName("Name", "XR_FULL_BODY_JOINT_LEFT_HAND_THUMB_DISTAL_META")]
        FullBodyJointLeftHandThumbDistalMeta = 22,
        [Obsolete("Deprecated in favour of \"LeftHandThumbTipMeta\"")]
        [NativeName("Name", "XR_FULL_BODY_JOINT_LEFT_HAND_THUMB_TIP_META")]
        FullBodyJointLeftHandThumbTipMeta = 23,
        [Obsolete("Deprecated in favour of \"LeftHandIndexMetacarpalMeta\"")]
        [NativeName("Name", "XR_FULL_BODY_JOINT_LEFT_HAND_INDEX_METACARPAL_META")]
        FullBodyJointLeftHandIndexMetacarpalMeta = 24,
        [Obsolete("Deprecated in favour of \"LeftHandIndexProximalMeta\"")]
        [NativeName("Name", "XR_FULL_BODY_JOINT_LEFT_HAND_INDEX_PROXIMAL_META")]
        FullBodyJointLeftHandIndexProximalMeta = 25,
        [Obsolete("Deprecated in favour of \"LeftHandIndexIntermediateMeta\"")]
        [NativeName("Name", "XR_FULL_BODY_JOINT_LEFT_HAND_INDEX_INTERMEDIATE_META")]
        FullBodyJointLeftHandIndexIntermediateMeta = 26,
        [Obsolete("Deprecated in favour of \"LeftHandIndexDistalMeta\"")]
        [NativeName("Name", "XR_FULL_BODY_JOINT_LEFT_HAND_INDEX_DISTAL_META")]
        FullBodyJointLeftHandIndexDistalMeta = 27,
        [Obsolete("Deprecated in favour of \"LeftHandIndexTipMeta\"")]
        [NativeName("Name", "XR_FULL_BODY_JOINT_LEFT_HAND_INDEX_TIP_META")]
        FullBodyJointLeftHandIndexTipMeta = 28,
        [Obsolete("Deprecated in favour of \"LeftHandMiddleMetacarpalMeta\"")]
        [NativeName("Name", "XR_FULL_BODY_JOINT_LEFT_HAND_MIDDLE_METACARPAL_META")]
        FullBodyJointLeftHandMiddleMetacarpalMeta = 29,
        [Obsolete("Deprecated in favour of \"LeftHandMiddleProximalMeta\"")]
        [NativeName("Name", "XR_FULL_BODY_JOINT_LEFT_HAND_MIDDLE_PROXIMAL_META")]
        FullBodyJointLeftHandMiddleProximalMeta = 30,
        [Obsolete("Deprecated in favour of \"LeftHandMiddleIntermediateMeta\"")]
        [NativeName("Name", "XR_FULL_BODY_JOINT_LEFT_HAND_MIDDLE_INTERMEDIATE_META")]
        FullBodyJointLeftHandMiddleIntermediateMeta = 31,
        [Obsolete("Deprecated in favour of \"LeftHandMiddleDistalMeta\"")]
        [NativeName("Name", "XR_FULL_BODY_JOINT_LEFT_HAND_MIDDLE_DISTAL_META")]
        FullBodyJointLeftHandMiddleDistalMeta = 32,
        [Obsolete("Deprecated in favour of \"LeftHandMiddleTipMeta\"")]
        [NativeName("Name", "XR_FULL_BODY_JOINT_LEFT_HAND_MIDDLE_TIP_META")]
        FullBodyJointLeftHandMiddleTipMeta = 33,
        [Obsolete("Deprecated in favour of \"LeftHandRingMetacarpalMeta\"")]
        [NativeName("Name", "XR_FULL_BODY_JOINT_LEFT_HAND_RING_METACARPAL_META")]
        FullBodyJointLeftHandRingMetacarpalMeta = 34,
        [Obsolete("Deprecated in favour of \"LeftHandRingProximalMeta\"")]
        [NativeName("Name", "XR_FULL_BODY_JOINT_LEFT_HAND_RING_PROXIMAL_META")]
        FullBodyJointLeftHandRingProximalMeta = 35,
        [Obsolete("Deprecated in favour of \"LeftHandRingIntermediateMeta\"")]
        [NativeName("Name", "XR_FULL_BODY_JOINT_LEFT_HAND_RING_INTERMEDIATE_META")]
        FullBodyJointLeftHandRingIntermediateMeta = 36,
        [Obsolete("Deprecated in favour of \"LeftHandRingDistalMeta\"")]
        [NativeName("Name", "XR_FULL_BODY_JOINT_LEFT_HAND_RING_DISTAL_META")]
        FullBodyJointLeftHandRingDistalMeta = 37,
        [Obsolete("Deprecated in favour of \"LeftHandRingTipMeta\"")]
        [NativeName("Name", "XR_FULL_BODY_JOINT_LEFT_HAND_RING_TIP_META")]
        FullBodyJointLeftHandRingTipMeta = 38,
        [Obsolete("Deprecated in favour of \"LeftHandLittleMetacarpalMeta\"")]
        [NativeName("Name", "XR_FULL_BODY_JOINT_LEFT_HAND_LITTLE_METACARPAL_META")]
        FullBodyJointLeftHandLittleMetacarpalMeta = 39,
        [Obsolete("Deprecated in favour of \"LeftHandLittleProximalMeta\"")]
        [NativeName("Name", "XR_FULL_BODY_JOINT_LEFT_HAND_LITTLE_PROXIMAL_META")]
        FullBodyJointLeftHandLittleProximalMeta = 40,
        [Obsolete("Deprecated in favour of \"LeftHandLittleIntermediateMeta\"")]
        [NativeName("Name", "XR_FULL_BODY_JOINT_LEFT_HAND_LITTLE_INTERMEDIATE_META")]
        FullBodyJointLeftHandLittleIntermediateMeta = 41,
        [Obsolete("Deprecated in favour of \"LeftHandLittleDistalMeta\"")]
        [NativeName("Name", "XR_FULL_BODY_JOINT_LEFT_HAND_LITTLE_DISTAL_META")]
        FullBodyJointLeftHandLittleDistalMeta = 42,
        [Obsolete("Deprecated in favour of \"LeftHandLittleTipMeta\"")]
        [NativeName("Name", "XR_FULL_BODY_JOINT_LEFT_HAND_LITTLE_TIP_META")]
        FullBodyJointLeftHandLittleTipMeta = 43,
        [Obsolete("Deprecated in favour of \"RightHandPalmMeta\"")]
        [NativeName("Name", "XR_FULL_BODY_JOINT_RIGHT_HAND_PALM_META")]
        FullBodyJointRightHandPalmMeta = 44,
        [Obsolete("Deprecated in favour of \"RightHandWristMeta\"")]
        [NativeName("Name", "XR_FULL_BODY_JOINT_RIGHT_HAND_WRIST_META")]
        FullBodyJointRightHandWristMeta = 45,
        [Obsolete("Deprecated in favour of \"RightHandThumbMetacarpalMeta\"")]
        [NativeName("Name", "XR_FULL_BODY_JOINT_RIGHT_HAND_THUMB_METACARPAL_META")]
        FullBodyJointRightHandThumbMetacarpalMeta = 46,
        [Obsolete("Deprecated in favour of \"RightHandThumbProximalMeta\"")]
        [NativeName("Name", "XR_FULL_BODY_JOINT_RIGHT_HAND_THUMB_PROXIMAL_META")]
        FullBodyJointRightHandThumbProximalMeta = 47,
        [Obsolete("Deprecated in favour of \"RightHandThumbDistalMeta\"")]
        [NativeName("Name", "XR_FULL_BODY_JOINT_RIGHT_HAND_THUMB_DISTAL_META")]
        FullBodyJointRightHandThumbDistalMeta = 48,
        [Obsolete("Deprecated in favour of \"RightHandThumbTipMeta\"")]
        [NativeName("Name", "XR_FULL_BODY_JOINT_RIGHT_HAND_THUMB_TIP_META")]
        FullBodyJointRightHandThumbTipMeta = 49,
        [Obsolete("Deprecated in favour of \"RightHandIndexMetacarpalMeta\"")]
        [NativeName("Name", "XR_FULL_BODY_JOINT_RIGHT_HAND_INDEX_METACARPAL_META")]
        FullBodyJointRightHandIndexMetacarpalMeta = 50,
        [Obsolete("Deprecated in favour of \"RightHandIndexProximalMeta\"")]
        [NativeName("Name", "XR_FULL_BODY_JOINT_RIGHT_HAND_INDEX_PROXIMAL_META")]
        FullBodyJointRightHandIndexProximalMeta = 51,
        [Obsolete("Deprecated in favour of \"RightHandIndexIntermediateMeta\"")]
        [NativeName("Name", "XR_FULL_BODY_JOINT_RIGHT_HAND_INDEX_INTERMEDIATE_META")]
        FullBodyJointRightHandIndexIntermediateMeta = 52,
        [Obsolete("Deprecated in favour of \"RightHandIndexDistalMeta\"")]
        [NativeName("Name", "XR_FULL_BODY_JOINT_RIGHT_HAND_INDEX_DISTAL_META")]
        FullBodyJointRightHandIndexDistalMeta = 53,
        [Obsolete("Deprecated in favour of \"RightHandIndexTipMeta\"")]
        [NativeName("Name", "XR_FULL_BODY_JOINT_RIGHT_HAND_INDEX_TIP_META")]
        FullBodyJointRightHandIndexTipMeta = 54,
        [Obsolete("Deprecated in favour of \"RightHandMiddleMetacarpalMeta\"")]
        [NativeName("Name", "XR_FULL_BODY_JOINT_RIGHT_HAND_MIDDLE_METACARPAL_META")]
        FullBodyJointRightHandMiddleMetacarpalMeta = 55,
        [Obsolete("Deprecated in favour of \"RightHandMiddleProximalMeta\"")]
        [NativeName("Name", "XR_FULL_BODY_JOINT_RIGHT_HAND_MIDDLE_PROXIMAL_META")]
        FullBodyJointRightHandMiddleProximalMeta = 56,
        [Obsolete("Deprecated in favour of \"RightHandMiddleIntermediateMeta\"")]
        [NativeName("Name", "XR_FULL_BODY_JOINT_RIGHT_HAND_MIDDLE_INTERMEDIATE_META")]
        FullBodyJointRightHandMiddleIntermediateMeta = 57,
        [Obsolete("Deprecated in favour of \"RightHandMiddleDistalMeta\"")]
        [NativeName("Name", "XR_FULL_BODY_JOINT_RIGHT_HAND_MIDDLE_DISTAL_META")]
        FullBodyJointRightHandMiddleDistalMeta = 58,
        [Obsolete("Deprecated in favour of \"RightHandMiddleTipMeta\"")]
        [NativeName("Name", "XR_FULL_BODY_JOINT_RIGHT_HAND_MIDDLE_TIP_META")]
        FullBodyJointRightHandMiddleTipMeta = 59,
        [Obsolete("Deprecated in favour of \"RightHandRingMetacarpalMeta\"")]
        [NativeName("Name", "XR_FULL_BODY_JOINT_RIGHT_HAND_RING_METACARPAL_META")]
        FullBodyJointRightHandRingMetacarpalMeta = 60,
        [Obsolete("Deprecated in favour of \"RightHandRingProximalMeta\"")]
        [NativeName("Name", "XR_FULL_BODY_JOINT_RIGHT_HAND_RING_PROXIMAL_META")]
        FullBodyJointRightHandRingProximalMeta = 61,
        [Obsolete("Deprecated in favour of \"RightHandRingIntermediateMeta\"")]
        [NativeName("Name", "XR_FULL_BODY_JOINT_RIGHT_HAND_RING_INTERMEDIATE_META")]
        FullBodyJointRightHandRingIntermediateMeta = 62,
        [Obsolete("Deprecated in favour of \"RightHandRingDistalMeta\"")]
        [NativeName("Name", "XR_FULL_BODY_JOINT_RIGHT_HAND_RING_DISTAL_META")]
        FullBodyJointRightHandRingDistalMeta = 63,
        [Obsolete("Deprecated in favour of \"RightHandRingTipMeta\"")]
        [NativeName("Name", "XR_FULL_BODY_JOINT_RIGHT_HAND_RING_TIP_META")]
        FullBodyJointRightHandRingTipMeta = 64,
        [Obsolete("Deprecated in favour of \"RightHandLittleMetacarpalMeta\"")]
        [NativeName("Name", "XR_FULL_BODY_JOINT_RIGHT_HAND_LITTLE_METACARPAL_META")]
        FullBodyJointRightHandLittleMetacarpalMeta = 65,
        [Obsolete("Deprecated in favour of \"RightHandLittleProximalMeta\"")]
        [NativeName("Name", "XR_FULL_BODY_JOINT_RIGHT_HAND_LITTLE_PROXIMAL_META")]
        FullBodyJointRightHandLittleProximalMeta = 66,
        [Obsolete("Deprecated in favour of \"RightHandLittleIntermediateMeta\"")]
        [NativeName("Name", "XR_FULL_BODY_JOINT_RIGHT_HAND_LITTLE_INTERMEDIATE_META")]
        FullBodyJointRightHandLittleIntermediateMeta = 67,
        [Obsolete("Deprecated in favour of \"RightHandLittleDistalMeta\"")]
        [NativeName("Name", "XR_FULL_BODY_JOINT_RIGHT_HAND_LITTLE_DISTAL_META")]
        FullBodyJointRightHandLittleDistalMeta = 68,
        [Obsolete("Deprecated in favour of \"RightHandLittleTipMeta\"")]
        [NativeName("Name", "XR_FULL_BODY_JOINT_RIGHT_HAND_LITTLE_TIP_META")]
        FullBodyJointRightHandLittleTipMeta = 69,
        [Obsolete("Deprecated in favour of \"LeftUpperLegMeta\"")]
        [NativeName("Name", "XR_FULL_BODY_JOINT_LEFT_UPPER_LEG_META")]
        FullBodyJointLeftUpperLegMeta = 70,
        [Obsolete("Deprecated in favour of \"LeftLowerLegMeta\"")]
        [NativeName("Name", "XR_FULL_BODY_JOINT_LEFT_LOWER_LEG_META")]
        FullBodyJointLeftLowerLegMeta = 71,
        [Obsolete("Deprecated in favour of \"LeftFootAnkleTwistMeta\"")]
        [NativeName("Name", "XR_FULL_BODY_JOINT_LEFT_FOOT_ANKLE_TWIST_META")]
        FullBodyJointLeftFootAnkleTwistMeta = 72,
        [Obsolete("Deprecated in favour of \"LeftFootAnkleMeta\"")]
        [NativeName("Name", "XR_FULL_BODY_JOINT_LEFT_FOOT_ANKLE_META")]
        FullBodyJointLeftFootAnkleMeta = 73,
        [Obsolete("Deprecated in favour of \"LeftFootSubtalarMeta\"")]
        [NativeName("Name", "XR_FULL_BODY_JOINT_LEFT_FOOT_SUBTALAR_META")]
        FullBodyJointLeftFootSubtalarMeta = 74,
        [Obsolete("Deprecated in favour of \"LeftFootTransverseMeta\"")]
        [NativeName("Name", "XR_FULL_BODY_JOINT_LEFT_FOOT_TRANSVERSE_META")]
        FullBodyJointLeftFootTransverseMeta = 75,
        [Obsolete("Deprecated in favour of \"LeftFootBallMeta\"")]
        [NativeName("Name", "XR_FULL_BODY_JOINT_LEFT_FOOT_BALL_META")]
        FullBodyJointLeftFootBallMeta = 76,
        [Obsolete("Deprecated in favour of \"RightUpperLegMeta\"")]
        [NativeName("Name", "XR_FULL_BODY_JOINT_RIGHT_UPPER_LEG_META")]
        FullBodyJointRightUpperLegMeta = 77,
        [Obsolete("Deprecated in favour of \"RightLowerLegMeta\"")]
        [NativeName("Name", "XR_FULL_BODY_JOINT_RIGHT_LOWER_LEG_META")]
        FullBodyJointRightLowerLegMeta = 78,
        [Obsolete("Deprecated in favour of \"RightFootAnkleTwistMeta\"")]
        [NativeName("Name", "XR_FULL_BODY_JOINT_RIGHT_FOOT_ANKLE_TWIST_META")]
        FullBodyJointRightFootAnkleTwistMeta = 79,
        [Obsolete("Deprecated in favour of \"RightFootAnkleMeta\"")]
        [NativeName("Name", "XR_FULL_BODY_JOINT_RIGHT_FOOT_ANKLE_META")]
        FullBodyJointRightFootAnkleMeta = 80,
        [Obsolete("Deprecated in favour of \"RightFootSubtalarMeta\"")]
        [NativeName("Name", "XR_FULL_BODY_JOINT_RIGHT_FOOT_SUBTALAR_META")]
        FullBodyJointRightFootSubtalarMeta = 81,
        [Obsolete("Deprecated in favour of \"RightFootTransverseMeta\"")]
        [NativeName("Name", "XR_FULL_BODY_JOINT_RIGHT_FOOT_TRANSVERSE_META")]
        FullBodyJointRightFootTransverseMeta = 82,
        [Obsolete("Deprecated in favour of \"RightFootBallMeta\"")]
        [NativeName("Name", "XR_FULL_BODY_JOINT_RIGHT_FOOT_BALL_META")]
        FullBodyJointRightFootBallMeta = 83,
        [Obsolete("Deprecated in favour of \"CountMeta\"")]
        [NativeName("Name", "XR_FULL_BODY_JOINT_COUNT_META")]
        FullBodyJointCountMeta = 84,
        [Obsolete("Deprecated in favour of \"NoneMeta\"")]
        [NativeName("Name", "XR_FULL_BODY_JOINT_NONE_META")]
        FullBodyJointNoneMeta = 85,
        [NativeName("Name", "XR_FULL_BODY_JOINT_ROOT_META")]
        RootMeta = 0,
        [NativeName("Name", "XR_FULL_BODY_JOINT_HIPS_META")]
        HipsMeta = 1,
        [NativeName("Name", "XR_FULL_BODY_JOINT_SPINE_LOWER_META")]
        SpineLowerMeta = 2,
        [NativeName("Name", "XR_FULL_BODY_JOINT_SPINE_MIDDLE_META")]
        SpineMiddleMeta = 3,
        [NativeName("Name", "XR_FULL_BODY_JOINT_SPINE_UPPER_META")]
        SpineUpperMeta = 4,
        [NativeName("Name", "XR_FULL_BODY_JOINT_CHEST_META")]
        ChestMeta = 5,
        [NativeName("Name", "XR_FULL_BODY_JOINT_NECK_META")]
        NeckMeta = 6,
        [NativeName("Name", "XR_FULL_BODY_JOINT_HEAD_META")]
        HeadMeta = 7,
        [NativeName("Name", "XR_FULL_BODY_JOINT_LEFT_SHOULDER_META")]
        LeftShoulderMeta = 8,
        [NativeName("Name", "XR_FULL_BODY_JOINT_LEFT_SCAPULA_META")]
        LeftScapulaMeta = 9,
        [NativeName("Name", "XR_FULL_BODY_JOINT_LEFT_ARM_UPPER_META")]
        LeftArmUpperMeta = 10,
        [NativeName("Name", "XR_FULL_BODY_JOINT_LEFT_ARM_LOWER_META")]
        LeftArmLowerMeta = 11,
        [NativeName("Name", "XR_FULL_BODY_JOINT_LEFT_HAND_WRIST_TWIST_META")]
        LeftHandWristTwistMeta = 12,
        [NativeName("Name", "XR_FULL_BODY_JOINT_RIGHT_SHOULDER_META")]
        RightShoulderMeta = 13,
        [NativeName("Name", "XR_FULL_BODY_JOINT_RIGHT_SCAPULA_META")]
        RightScapulaMeta = 14,
        [NativeName("Name", "XR_FULL_BODY_JOINT_RIGHT_ARM_UPPER_META")]
        RightArmUpperMeta = 15,
        [NativeName("Name", "XR_FULL_BODY_JOINT_RIGHT_ARM_LOWER_META")]
        RightArmLowerMeta = 16,
        [NativeName("Name", "XR_FULL_BODY_JOINT_RIGHT_HAND_WRIST_TWIST_META")]
        RightHandWristTwistMeta = 17,
        [NativeName("Name", "XR_FULL_BODY_JOINT_LEFT_HAND_PALM_META")]
        LeftHandPalmMeta = 18,
        [NativeName("Name", "XR_FULL_BODY_JOINT_LEFT_HAND_WRIST_META")]
        LeftHandWristMeta = 19,
        [NativeName("Name", "XR_FULL_BODY_JOINT_LEFT_HAND_THUMB_METACARPAL_META")]
        LeftHandThumbMetacarpalMeta = 20,
        [NativeName("Name", "XR_FULL_BODY_JOINT_LEFT_HAND_THUMB_PROXIMAL_META")]
        LeftHandThumbProximalMeta = 21,
        [NativeName("Name", "XR_FULL_BODY_JOINT_LEFT_HAND_THUMB_DISTAL_META")]
        LeftHandThumbDistalMeta = 22,
        [NativeName("Name", "XR_FULL_BODY_JOINT_LEFT_HAND_THUMB_TIP_META")]
        LeftHandThumbTipMeta = 23,
        [NativeName("Name", "XR_FULL_BODY_JOINT_LEFT_HAND_INDEX_METACARPAL_META")]
        LeftHandIndexMetacarpalMeta = 24,
        [NativeName("Name", "XR_FULL_BODY_JOINT_LEFT_HAND_INDEX_PROXIMAL_META")]
        LeftHandIndexProximalMeta = 25,
        [NativeName("Name", "XR_FULL_BODY_JOINT_LEFT_HAND_INDEX_INTERMEDIATE_META")]
        LeftHandIndexIntermediateMeta = 26,
        [NativeName("Name", "XR_FULL_BODY_JOINT_LEFT_HAND_INDEX_DISTAL_META")]
        LeftHandIndexDistalMeta = 27,
        [NativeName("Name", "XR_FULL_BODY_JOINT_LEFT_HAND_INDEX_TIP_META")]
        LeftHandIndexTipMeta = 28,
        [NativeName("Name", "XR_FULL_BODY_JOINT_LEFT_HAND_MIDDLE_METACARPAL_META")]
        LeftHandMiddleMetacarpalMeta = 29,
        [NativeName("Name", "XR_FULL_BODY_JOINT_LEFT_HAND_MIDDLE_PROXIMAL_META")]
        LeftHandMiddleProximalMeta = 30,
        [NativeName("Name", "XR_FULL_BODY_JOINT_LEFT_HAND_MIDDLE_INTERMEDIATE_META")]
        LeftHandMiddleIntermediateMeta = 31,
        [NativeName("Name", "XR_FULL_BODY_JOINT_LEFT_HAND_MIDDLE_DISTAL_META")]
        LeftHandMiddleDistalMeta = 32,
        [NativeName("Name", "XR_FULL_BODY_JOINT_LEFT_HAND_MIDDLE_TIP_META")]
        LeftHandMiddleTipMeta = 33,
        [NativeName("Name", "XR_FULL_BODY_JOINT_LEFT_HAND_RING_METACARPAL_META")]
        LeftHandRingMetacarpalMeta = 34,
        [NativeName("Name", "XR_FULL_BODY_JOINT_LEFT_HAND_RING_PROXIMAL_META")]
        LeftHandRingProximalMeta = 35,
        [NativeName("Name", "XR_FULL_BODY_JOINT_LEFT_HAND_RING_INTERMEDIATE_META")]
        LeftHandRingIntermediateMeta = 36,
        [NativeName("Name", "XR_FULL_BODY_JOINT_LEFT_HAND_RING_DISTAL_META")]
        LeftHandRingDistalMeta = 37,
        [NativeName("Name", "XR_FULL_BODY_JOINT_LEFT_HAND_RING_TIP_META")]
        LeftHandRingTipMeta = 38,
        [NativeName("Name", "XR_FULL_BODY_JOINT_LEFT_HAND_LITTLE_METACARPAL_META")]
        LeftHandLittleMetacarpalMeta = 39,
        [NativeName("Name", "XR_FULL_BODY_JOINT_LEFT_HAND_LITTLE_PROXIMAL_META")]
        LeftHandLittleProximalMeta = 40,
        [NativeName("Name", "XR_FULL_BODY_JOINT_LEFT_HAND_LITTLE_INTERMEDIATE_META")]
        LeftHandLittleIntermediateMeta = 41,
        [NativeName("Name", "XR_FULL_BODY_JOINT_LEFT_HAND_LITTLE_DISTAL_META")]
        LeftHandLittleDistalMeta = 42,
        [NativeName("Name", "XR_FULL_BODY_JOINT_LEFT_HAND_LITTLE_TIP_META")]
        LeftHandLittleTipMeta = 43,
        [NativeName("Name", "XR_FULL_BODY_JOINT_RIGHT_HAND_PALM_META")]
        RightHandPalmMeta = 44,
        [NativeName("Name", "XR_FULL_BODY_JOINT_RIGHT_HAND_WRIST_META")]
        RightHandWristMeta = 45,
        [NativeName("Name", "XR_FULL_BODY_JOINT_RIGHT_HAND_THUMB_METACARPAL_META")]
        RightHandThumbMetacarpalMeta = 46,
        [NativeName("Name", "XR_FULL_BODY_JOINT_RIGHT_HAND_THUMB_PROXIMAL_META")]
        RightHandThumbProximalMeta = 47,
        [NativeName("Name", "XR_FULL_BODY_JOINT_RIGHT_HAND_THUMB_DISTAL_META")]
        RightHandThumbDistalMeta = 48,
        [NativeName("Name", "XR_FULL_BODY_JOINT_RIGHT_HAND_THUMB_TIP_META")]
        RightHandThumbTipMeta = 49,
        [NativeName("Name", "XR_FULL_BODY_JOINT_RIGHT_HAND_INDEX_METACARPAL_META")]
        RightHandIndexMetacarpalMeta = 50,
        [NativeName("Name", "XR_FULL_BODY_JOINT_RIGHT_HAND_INDEX_PROXIMAL_META")]
        RightHandIndexProximalMeta = 51,
        [NativeName("Name", "XR_FULL_BODY_JOINT_RIGHT_HAND_INDEX_INTERMEDIATE_META")]
        RightHandIndexIntermediateMeta = 52,
        [NativeName("Name", "XR_FULL_BODY_JOINT_RIGHT_HAND_INDEX_DISTAL_META")]
        RightHandIndexDistalMeta = 53,
        [NativeName("Name", "XR_FULL_BODY_JOINT_RIGHT_HAND_INDEX_TIP_META")]
        RightHandIndexTipMeta = 54,
        [NativeName("Name", "XR_FULL_BODY_JOINT_RIGHT_HAND_MIDDLE_METACARPAL_META")]
        RightHandMiddleMetacarpalMeta = 55,
        [NativeName("Name", "XR_FULL_BODY_JOINT_RIGHT_HAND_MIDDLE_PROXIMAL_META")]
        RightHandMiddleProximalMeta = 56,
        [NativeName("Name", "XR_FULL_BODY_JOINT_RIGHT_HAND_MIDDLE_INTERMEDIATE_META")]
        RightHandMiddleIntermediateMeta = 57,
        [NativeName("Name", "XR_FULL_BODY_JOINT_RIGHT_HAND_MIDDLE_DISTAL_META")]
        RightHandMiddleDistalMeta = 58,
        [NativeName("Name", "XR_FULL_BODY_JOINT_RIGHT_HAND_MIDDLE_TIP_META")]
        RightHandMiddleTipMeta = 59,
        [NativeName("Name", "XR_FULL_BODY_JOINT_RIGHT_HAND_RING_METACARPAL_META")]
        RightHandRingMetacarpalMeta = 60,
        [NativeName("Name", "XR_FULL_BODY_JOINT_RIGHT_HAND_RING_PROXIMAL_META")]
        RightHandRingProximalMeta = 61,
        [NativeName("Name", "XR_FULL_BODY_JOINT_RIGHT_HAND_RING_INTERMEDIATE_META")]
        RightHandRingIntermediateMeta = 62,
        [NativeName("Name", "XR_FULL_BODY_JOINT_RIGHT_HAND_RING_DISTAL_META")]
        RightHandRingDistalMeta = 63,
        [NativeName("Name", "XR_FULL_BODY_JOINT_RIGHT_HAND_RING_TIP_META")]
        RightHandRingTipMeta = 64,
        [NativeName("Name", "XR_FULL_BODY_JOINT_RIGHT_HAND_LITTLE_METACARPAL_META")]
        RightHandLittleMetacarpalMeta = 65,
        [NativeName("Name", "XR_FULL_BODY_JOINT_RIGHT_HAND_LITTLE_PROXIMAL_META")]
        RightHandLittleProximalMeta = 66,
        [NativeName("Name", "XR_FULL_BODY_JOINT_RIGHT_HAND_LITTLE_INTERMEDIATE_META")]
        RightHandLittleIntermediateMeta = 67,
        [NativeName("Name", "XR_FULL_BODY_JOINT_RIGHT_HAND_LITTLE_DISTAL_META")]
        RightHandLittleDistalMeta = 68,
        [NativeName("Name", "XR_FULL_BODY_JOINT_RIGHT_HAND_LITTLE_TIP_META")]
        RightHandLittleTipMeta = 69,
        [NativeName("Name", "XR_FULL_BODY_JOINT_LEFT_UPPER_LEG_META")]
        LeftUpperLegMeta = 70,
        [NativeName("Name", "XR_FULL_BODY_JOINT_LEFT_LOWER_LEG_META")]
        LeftLowerLegMeta = 71,
        [NativeName("Name", "XR_FULL_BODY_JOINT_LEFT_FOOT_ANKLE_TWIST_META")]
        LeftFootAnkleTwistMeta = 72,
        [NativeName("Name", "XR_FULL_BODY_JOINT_LEFT_FOOT_ANKLE_META")]
        LeftFootAnkleMeta = 73,
        [NativeName("Name", "XR_FULL_BODY_JOINT_LEFT_FOOT_SUBTALAR_META")]
        LeftFootSubtalarMeta = 74,
        [NativeName("Name", "XR_FULL_BODY_JOINT_LEFT_FOOT_TRANSVERSE_META")]
        LeftFootTransverseMeta = 75,
        [NativeName("Name", "XR_FULL_BODY_JOINT_LEFT_FOOT_BALL_META")]
        LeftFootBallMeta = 76,
        [NativeName("Name", "XR_FULL_BODY_JOINT_RIGHT_UPPER_LEG_META")]
        RightUpperLegMeta = 77,
        [NativeName("Name", "XR_FULL_BODY_JOINT_RIGHT_LOWER_LEG_META")]
        RightLowerLegMeta = 78,
        [NativeName("Name", "XR_FULL_BODY_JOINT_RIGHT_FOOT_ANKLE_TWIST_META")]
        RightFootAnkleTwistMeta = 79,
        [NativeName("Name", "XR_FULL_BODY_JOINT_RIGHT_FOOT_ANKLE_META")]
        RightFootAnkleMeta = 80,
        [NativeName("Name", "XR_FULL_BODY_JOINT_RIGHT_FOOT_SUBTALAR_META")]
        RightFootSubtalarMeta = 81,
        [NativeName("Name", "XR_FULL_BODY_JOINT_RIGHT_FOOT_TRANSVERSE_META")]
        RightFootTransverseMeta = 82,
        [NativeName("Name", "XR_FULL_BODY_JOINT_RIGHT_FOOT_BALL_META")]
        RightFootBallMeta = 83,
        [NativeName("Name", "XR_FULL_BODY_JOINT_COUNT_META")]
        CountMeta = 84,
        [NativeName("Name", "XR_FULL_BODY_JOINT_NONE_META")]
        NoneMeta = 85,
    }
}
