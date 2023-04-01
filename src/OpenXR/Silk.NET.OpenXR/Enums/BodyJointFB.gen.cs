// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrBodyJointFB")]
    public enum BodyJointFB : int
    {
        [Obsolete("Deprecated in favour of \"RootFB\"")]
        [NativeName("Name", "XR_BODY_JOINT_ROOT_FB")]
        BodyJointRootFB = 0,
        [Obsolete("Deprecated in favour of \"HipsFB\"")]
        [NativeName("Name", "XR_BODY_JOINT_HIPS_FB")]
        BodyJointHipsFB = 1,
        [Obsolete("Deprecated in favour of \"SpineLowerFB\"")]
        [NativeName("Name", "XR_BODY_JOINT_SPINE_LOWER_FB")]
        BodyJointSpineLowerFB = 2,
        [Obsolete("Deprecated in favour of \"SpineMiddleFB\"")]
        [NativeName("Name", "XR_BODY_JOINT_SPINE_MIDDLE_FB")]
        BodyJointSpineMiddleFB = 3,
        [Obsolete("Deprecated in favour of \"SpineUpperFB\"")]
        [NativeName("Name", "XR_BODY_JOINT_SPINE_UPPER_FB")]
        BodyJointSpineUpperFB = 4,
        [Obsolete("Deprecated in favour of \"ChestFB\"")]
        [NativeName("Name", "XR_BODY_JOINT_CHEST_FB")]
        BodyJointChestFB = 5,
        [Obsolete("Deprecated in favour of \"NeckFB\"")]
        [NativeName("Name", "XR_BODY_JOINT_NECK_FB")]
        BodyJointNeckFB = 6,
        [Obsolete("Deprecated in favour of \"HeadFB\"")]
        [NativeName("Name", "XR_BODY_JOINT_HEAD_FB")]
        BodyJointHeadFB = 7,
        [Obsolete("Deprecated in favour of \"LeftShoulderFB\"")]
        [NativeName("Name", "XR_BODY_JOINT_LEFT_SHOULDER_FB")]
        BodyJointLeftShoulderFB = 8,
        [Obsolete("Deprecated in favour of \"LeftScapulaFB\"")]
        [NativeName("Name", "XR_BODY_JOINT_LEFT_SCAPULA_FB")]
        BodyJointLeftScapulaFB = 9,
        [Obsolete("Deprecated in favour of \"LeftArmUpperFB\"")]
        [NativeName("Name", "XR_BODY_JOINT_LEFT_ARM_UPPER_FB")]
        BodyJointLeftArmUpperFB = 10,
        [Obsolete("Deprecated in favour of \"LeftArmLowerFB\"")]
        [NativeName("Name", "XR_BODY_JOINT_LEFT_ARM_LOWER_FB")]
        BodyJointLeftArmLowerFB = 11,
        [Obsolete("Deprecated in favour of \"LeftHandWristTwistFB\"")]
        [NativeName("Name", "XR_BODY_JOINT_LEFT_HAND_WRIST_TWIST_FB")]
        BodyJointLeftHandWristTwistFB = 12,
        [Obsolete("Deprecated in favour of \"RightShoulderFB\"")]
        [NativeName("Name", "XR_BODY_JOINT_RIGHT_SHOULDER_FB")]
        BodyJointRightShoulderFB = 13,
        [Obsolete("Deprecated in favour of \"RightScapulaFB\"")]
        [NativeName("Name", "XR_BODY_JOINT_RIGHT_SCAPULA_FB")]
        BodyJointRightScapulaFB = 14,
        [Obsolete("Deprecated in favour of \"RightArmUpperFB\"")]
        [NativeName("Name", "XR_BODY_JOINT_RIGHT_ARM_UPPER_FB")]
        BodyJointRightArmUpperFB = 15,
        [Obsolete("Deprecated in favour of \"RightArmLowerFB\"")]
        [NativeName("Name", "XR_BODY_JOINT_RIGHT_ARM_LOWER_FB")]
        BodyJointRightArmLowerFB = 16,
        [Obsolete("Deprecated in favour of \"RightHandWristTwistFB\"")]
        [NativeName("Name", "XR_BODY_JOINT_RIGHT_HAND_WRIST_TWIST_FB")]
        BodyJointRightHandWristTwistFB = 17,
        [Obsolete("Deprecated in favour of \"LeftHandPalmFB\"")]
        [NativeName("Name", "XR_BODY_JOINT_LEFT_HAND_PALM_FB")]
        BodyJointLeftHandPalmFB = 18,
        [Obsolete("Deprecated in favour of \"LeftHandWristFB\"")]
        [NativeName("Name", "XR_BODY_JOINT_LEFT_HAND_WRIST_FB")]
        BodyJointLeftHandWristFB = 19,
        [Obsolete("Deprecated in favour of \"LeftHandThumbMetacarpalFB\"")]
        [NativeName("Name", "XR_BODY_JOINT_LEFT_HAND_THUMB_METACARPAL_FB")]
        BodyJointLeftHandThumbMetacarpalFB = 20,
        [Obsolete("Deprecated in favour of \"LeftHandThumbProximalFB\"")]
        [NativeName("Name", "XR_BODY_JOINT_LEFT_HAND_THUMB_PROXIMAL_FB")]
        BodyJointLeftHandThumbProximalFB = 21,
        [Obsolete("Deprecated in favour of \"LeftHandThumbDistalFB\"")]
        [NativeName("Name", "XR_BODY_JOINT_LEFT_HAND_THUMB_DISTAL_FB")]
        BodyJointLeftHandThumbDistalFB = 22,
        [Obsolete("Deprecated in favour of \"LeftHandThumbTipFB\"")]
        [NativeName("Name", "XR_BODY_JOINT_LEFT_HAND_THUMB_TIP_FB")]
        BodyJointLeftHandThumbTipFB = 23,
        [Obsolete("Deprecated in favour of \"LeftHandIndexMetacarpalFB\"")]
        [NativeName("Name", "XR_BODY_JOINT_LEFT_HAND_INDEX_METACARPAL_FB")]
        BodyJointLeftHandIndexMetacarpalFB = 24,
        [Obsolete("Deprecated in favour of \"LeftHandIndexProximalFB\"")]
        [NativeName("Name", "XR_BODY_JOINT_LEFT_HAND_INDEX_PROXIMAL_FB")]
        BodyJointLeftHandIndexProximalFB = 25,
        [Obsolete("Deprecated in favour of \"LeftHandIndexIntermediateFB\"")]
        [NativeName("Name", "XR_BODY_JOINT_LEFT_HAND_INDEX_INTERMEDIATE_FB")]
        BodyJointLeftHandIndexIntermediateFB = 26,
        [Obsolete("Deprecated in favour of \"LeftHandIndexDistalFB\"")]
        [NativeName("Name", "XR_BODY_JOINT_LEFT_HAND_INDEX_DISTAL_FB")]
        BodyJointLeftHandIndexDistalFB = 27,
        [Obsolete("Deprecated in favour of \"LeftHandIndexTipFB\"")]
        [NativeName("Name", "XR_BODY_JOINT_LEFT_HAND_INDEX_TIP_FB")]
        BodyJointLeftHandIndexTipFB = 28,
        [Obsolete("Deprecated in favour of \"LeftHandMiddleMetacarpalFB\"")]
        [NativeName("Name", "XR_BODY_JOINT_LEFT_HAND_MIDDLE_METACARPAL_FB")]
        BodyJointLeftHandMiddleMetacarpalFB = 29,
        [Obsolete("Deprecated in favour of \"LeftHandMiddleProximalFB\"")]
        [NativeName("Name", "XR_BODY_JOINT_LEFT_HAND_MIDDLE_PROXIMAL_FB")]
        BodyJointLeftHandMiddleProximalFB = 30,
        [Obsolete("Deprecated in favour of \"LeftHandMiddleIntermediateFB\"")]
        [NativeName("Name", "XR_BODY_JOINT_LEFT_HAND_MIDDLE_INTERMEDIATE_FB")]
        BodyJointLeftHandMiddleIntermediateFB = 31,
        [Obsolete("Deprecated in favour of \"LeftHandMiddleDistalFB\"")]
        [NativeName("Name", "XR_BODY_JOINT_LEFT_HAND_MIDDLE_DISTAL_FB")]
        BodyJointLeftHandMiddleDistalFB = 32,
        [Obsolete("Deprecated in favour of \"LeftHandMiddleTipFB\"")]
        [NativeName("Name", "XR_BODY_JOINT_LEFT_HAND_MIDDLE_TIP_FB")]
        BodyJointLeftHandMiddleTipFB = 33,
        [Obsolete("Deprecated in favour of \"LeftHandRingMetacarpalFB\"")]
        [NativeName("Name", "XR_BODY_JOINT_LEFT_HAND_RING_METACARPAL_FB")]
        BodyJointLeftHandRingMetacarpalFB = 34,
        [Obsolete("Deprecated in favour of \"LeftHandRingProximalFB\"")]
        [NativeName("Name", "XR_BODY_JOINT_LEFT_HAND_RING_PROXIMAL_FB")]
        BodyJointLeftHandRingProximalFB = 35,
        [Obsolete("Deprecated in favour of \"LeftHandRingIntermediateFB\"")]
        [NativeName("Name", "XR_BODY_JOINT_LEFT_HAND_RING_INTERMEDIATE_FB")]
        BodyJointLeftHandRingIntermediateFB = 36,
        [Obsolete("Deprecated in favour of \"LeftHandRingDistalFB\"")]
        [NativeName("Name", "XR_BODY_JOINT_LEFT_HAND_RING_DISTAL_FB")]
        BodyJointLeftHandRingDistalFB = 37,
        [Obsolete("Deprecated in favour of \"LeftHandRingTipFB\"")]
        [NativeName("Name", "XR_BODY_JOINT_LEFT_HAND_RING_TIP_FB")]
        BodyJointLeftHandRingTipFB = 38,
        [Obsolete("Deprecated in favour of \"LeftHandLittleMetacarpalFB\"")]
        [NativeName("Name", "XR_BODY_JOINT_LEFT_HAND_LITTLE_METACARPAL_FB")]
        BodyJointLeftHandLittleMetacarpalFB = 39,
        [Obsolete("Deprecated in favour of \"LeftHandLittleProximalFB\"")]
        [NativeName("Name", "XR_BODY_JOINT_LEFT_HAND_LITTLE_PROXIMAL_FB")]
        BodyJointLeftHandLittleProximalFB = 40,
        [Obsolete("Deprecated in favour of \"LeftHandLittleIntermediateFB\"")]
        [NativeName("Name", "XR_BODY_JOINT_LEFT_HAND_LITTLE_INTERMEDIATE_FB")]
        BodyJointLeftHandLittleIntermediateFB = 41,
        [Obsolete("Deprecated in favour of \"LeftHandLittleDistalFB\"")]
        [NativeName("Name", "XR_BODY_JOINT_LEFT_HAND_LITTLE_DISTAL_FB")]
        BodyJointLeftHandLittleDistalFB = 42,
        [Obsolete("Deprecated in favour of \"LeftHandLittleTipFB\"")]
        [NativeName("Name", "XR_BODY_JOINT_LEFT_HAND_LITTLE_TIP_FB")]
        BodyJointLeftHandLittleTipFB = 43,
        [Obsolete("Deprecated in favour of \"RightHandPalmFB\"")]
        [NativeName("Name", "XR_BODY_JOINT_RIGHT_HAND_PALM_FB")]
        BodyJointRightHandPalmFB = 44,
        [Obsolete("Deprecated in favour of \"RightHandWristFB\"")]
        [NativeName("Name", "XR_BODY_JOINT_RIGHT_HAND_WRIST_FB")]
        BodyJointRightHandWristFB = 45,
        [Obsolete("Deprecated in favour of \"RightHandThumbMetacarpalFB\"")]
        [NativeName("Name", "XR_BODY_JOINT_RIGHT_HAND_THUMB_METACARPAL_FB")]
        BodyJointRightHandThumbMetacarpalFB = 46,
        [Obsolete("Deprecated in favour of \"RightHandThumbProximalFB\"")]
        [NativeName("Name", "XR_BODY_JOINT_RIGHT_HAND_THUMB_PROXIMAL_FB")]
        BodyJointRightHandThumbProximalFB = 47,
        [Obsolete("Deprecated in favour of \"RightHandThumbDistalFB\"")]
        [NativeName("Name", "XR_BODY_JOINT_RIGHT_HAND_THUMB_DISTAL_FB")]
        BodyJointRightHandThumbDistalFB = 48,
        [Obsolete("Deprecated in favour of \"RightHandThumbTipFB\"")]
        [NativeName("Name", "XR_BODY_JOINT_RIGHT_HAND_THUMB_TIP_FB")]
        BodyJointRightHandThumbTipFB = 49,
        [Obsolete("Deprecated in favour of \"RightHandIndexMetacarpalFB\"")]
        [NativeName("Name", "XR_BODY_JOINT_RIGHT_HAND_INDEX_METACARPAL_FB")]
        BodyJointRightHandIndexMetacarpalFB = 50,
        [Obsolete("Deprecated in favour of \"RightHandIndexProximalFB\"")]
        [NativeName("Name", "XR_BODY_JOINT_RIGHT_HAND_INDEX_PROXIMAL_FB")]
        BodyJointRightHandIndexProximalFB = 51,
        [Obsolete("Deprecated in favour of \"RightHandIndexIntermediateFB\"")]
        [NativeName("Name", "XR_BODY_JOINT_RIGHT_HAND_INDEX_INTERMEDIATE_FB")]
        BodyJointRightHandIndexIntermediateFB = 52,
        [Obsolete("Deprecated in favour of \"RightHandIndexDistalFB\"")]
        [NativeName("Name", "XR_BODY_JOINT_RIGHT_HAND_INDEX_DISTAL_FB")]
        BodyJointRightHandIndexDistalFB = 53,
        [Obsolete("Deprecated in favour of \"RightHandIndexTipFB\"")]
        [NativeName("Name", "XR_BODY_JOINT_RIGHT_HAND_INDEX_TIP_FB")]
        BodyJointRightHandIndexTipFB = 54,
        [Obsolete("Deprecated in favour of \"RightHandMiddleMetacarpalFB\"")]
        [NativeName("Name", "XR_BODY_JOINT_RIGHT_HAND_MIDDLE_METACARPAL_FB")]
        BodyJointRightHandMiddleMetacarpalFB = 55,
        [Obsolete("Deprecated in favour of \"RightHandMiddleProximalFB\"")]
        [NativeName("Name", "XR_BODY_JOINT_RIGHT_HAND_MIDDLE_PROXIMAL_FB")]
        BodyJointRightHandMiddleProximalFB = 56,
        [Obsolete("Deprecated in favour of \"RightHandMiddleIntermediateFB\"")]
        [NativeName("Name", "XR_BODY_JOINT_RIGHT_HAND_MIDDLE_INTERMEDIATE_FB")]
        BodyJointRightHandMiddleIntermediateFB = 57,
        [Obsolete("Deprecated in favour of \"RightHandMiddleDistalFB\"")]
        [NativeName("Name", "XR_BODY_JOINT_RIGHT_HAND_MIDDLE_DISTAL_FB")]
        BodyJointRightHandMiddleDistalFB = 58,
        [Obsolete("Deprecated in favour of \"RightHandMiddleTipFB\"")]
        [NativeName("Name", "XR_BODY_JOINT_RIGHT_HAND_MIDDLE_TIP_FB")]
        BodyJointRightHandMiddleTipFB = 59,
        [Obsolete("Deprecated in favour of \"RightHandRingMetacarpalFB\"")]
        [NativeName("Name", "XR_BODY_JOINT_RIGHT_HAND_RING_METACARPAL_FB")]
        BodyJointRightHandRingMetacarpalFB = 60,
        [Obsolete("Deprecated in favour of \"RightHandRingProximalFB\"")]
        [NativeName("Name", "XR_BODY_JOINT_RIGHT_HAND_RING_PROXIMAL_FB")]
        BodyJointRightHandRingProximalFB = 61,
        [Obsolete("Deprecated in favour of \"RightHandRingIntermediateFB\"")]
        [NativeName("Name", "XR_BODY_JOINT_RIGHT_HAND_RING_INTERMEDIATE_FB")]
        BodyJointRightHandRingIntermediateFB = 62,
        [Obsolete("Deprecated in favour of \"RightHandRingDistalFB\"")]
        [NativeName("Name", "XR_BODY_JOINT_RIGHT_HAND_RING_DISTAL_FB")]
        BodyJointRightHandRingDistalFB = 63,
        [Obsolete("Deprecated in favour of \"RightHandRingTipFB\"")]
        [NativeName("Name", "XR_BODY_JOINT_RIGHT_HAND_RING_TIP_FB")]
        BodyJointRightHandRingTipFB = 64,
        [Obsolete("Deprecated in favour of \"RightHandLittleMetacarpalFB\"")]
        [NativeName("Name", "XR_BODY_JOINT_RIGHT_HAND_LITTLE_METACARPAL_FB")]
        BodyJointRightHandLittleMetacarpalFB = 65,
        [Obsolete("Deprecated in favour of \"RightHandLittleProximalFB\"")]
        [NativeName("Name", "XR_BODY_JOINT_RIGHT_HAND_LITTLE_PROXIMAL_FB")]
        BodyJointRightHandLittleProximalFB = 66,
        [Obsolete("Deprecated in favour of \"RightHandLittleIntermediateFB\"")]
        [NativeName("Name", "XR_BODY_JOINT_RIGHT_HAND_LITTLE_INTERMEDIATE_FB")]
        BodyJointRightHandLittleIntermediateFB = 67,
        [Obsolete("Deprecated in favour of \"RightHandLittleDistalFB\"")]
        [NativeName("Name", "XR_BODY_JOINT_RIGHT_HAND_LITTLE_DISTAL_FB")]
        BodyJointRightHandLittleDistalFB = 68,
        [Obsolete("Deprecated in favour of \"RightHandLittleTipFB\"")]
        [NativeName("Name", "XR_BODY_JOINT_RIGHT_HAND_LITTLE_TIP_FB")]
        BodyJointRightHandLittleTipFB = 69,
        [Obsolete("Deprecated in favour of \"CountFB\"")]
        [NativeName("Name", "XR_BODY_JOINT_COUNT_FB")]
        BodyJointCountFB = 70,
        [Obsolete("Deprecated in favour of \"NoneFB\"")]
        [NativeName("Name", "XR_BODY_JOINT_NONE_FB")]
        BodyJointNoneFB = unchecked((int) -1),
        [NativeName("Name", "XR_BODY_JOINT_ROOT_FB")]
        RootFB = 0,
        [NativeName("Name", "XR_BODY_JOINT_HIPS_FB")]
        HipsFB = 1,
        [NativeName("Name", "XR_BODY_JOINT_SPINE_LOWER_FB")]
        SpineLowerFB = 2,
        [NativeName("Name", "XR_BODY_JOINT_SPINE_MIDDLE_FB")]
        SpineMiddleFB = 3,
        [NativeName("Name", "XR_BODY_JOINT_SPINE_UPPER_FB")]
        SpineUpperFB = 4,
        [NativeName("Name", "XR_BODY_JOINT_CHEST_FB")]
        ChestFB = 5,
        [NativeName("Name", "XR_BODY_JOINT_NECK_FB")]
        NeckFB = 6,
        [NativeName("Name", "XR_BODY_JOINT_HEAD_FB")]
        HeadFB = 7,
        [NativeName("Name", "XR_BODY_JOINT_LEFT_SHOULDER_FB")]
        LeftShoulderFB = 8,
        [NativeName("Name", "XR_BODY_JOINT_LEFT_SCAPULA_FB")]
        LeftScapulaFB = 9,
        [NativeName("Name", "XR_BODY_JOINT_LEFT_ARM_UPPER_FB")]
        LeftArmUpperFB = 10,
        [NativeName("Name", "XR_BODY_JOINT_LEFT_ARM_LOWER_FB")]
        LeftArmLowerFB = 11,
        [NativeName("Name", "XR_BODY_JOINT_LEFT_HAND_WRIST_TWIST_FB")]
        LeftHandWristTwistFB = 12,
        [NativeName("Name", "XR_BODY_JOINT_RIGHT_SHOULDER_FB")]
        RightShoulderFB = 13,
        [NativeName("Name", "XR_BODY_JOINT_RIGHT_SCAPULA_FB")]
        RightScapulaFB = 14,
        [NativeName("Name", "XR_BODY_JOINT_RIGHT_ARM_UPPER_FB")]
        RightArmUpperFB = 15,
        [NativeName("Name", "XR_BODY_JOINT_RIGHT_ARM_LOWER_FB")]
        RightArmLowerFB = 16,
        [NativeName("Name", "XR_BODY_JOINT_RIGHT_HAND_WRIST_TWIST_FB")]
        RightHandWristTwistFB = 17,
        [NativeName("Name", "XR_BODY_JOINT_LEFT_HAND_PALM_FB")]
        LeftHandPalmFB = 18,
        [NativeName("Name", "XR_BODY_JOINT_LEFT_HAND_WRIST_FB")]
        LeftHandWristFB = 19,
        [NativeName("Name", "XR_BODY_JOINT_LEFT_HAND_THUMB_METACARPAL_FB")]
        LeftHandThumbMetacarpalFB = 20,
        [NativeName("Name", "XR_BODY_JOINT_LEFT_HAND_THUMB_PROXIMAL_FB")]
        LeftHandThumbProximalFB = 21,
        [NativeName("Name", "XR_BODY_JOINT_LEFT_HAND_THUMB_DISTAL_FB")]
        LeftHandThumbDistalFB = 22,
        [NativeName("Name", "XR_BODY_JOINT_LEFT_HAND_THUMB_TIP_FB")]
        LeftHandThumbTipFB = 23,
        [NativeName("Name", "XR_BODY_JOINT_LEFT_HAND_INDEX_METACARPAL_FB")]
        LeftHandIndexMetacarpalFB = 24,
        [NativeName("Name", "XR_BODY_JOINT_LEFT_HAND_INDEX_PROXIMAL_FB")]
        LeftHandIndexProximalFB = 25,
        [NativeName("Name", "XR_BODY_JOINT_LEFT_HAND_INDEX_INTERMEDIATE_FB")]
        LeftHandIndexIntermediateFB = 26,
        [NativeName("Name", "XR_BODY_JOINT_LEFT_HAND_INDEX_DISTAL_FB")]
        LeftHandIndexDistalFB = 27,
        [NativeName("Name", "XR_BODY_JOINT_LEFT_HAND_INDEX_TIP_FB")]
        LeftHandIndexTipFB = 28,
        [NativeName("Name", "XR_BODY_JOINT_LEFT_HAND_MIDDLE_METACARPAL_FB")]
        LeftHandMiddleMetacarpalFB = 29,
        [NativeName("Name", "XR_BODY_JOINT_LEFT_HAND_MIDDLE_PROXIMAL_FB")]
        LeftHandMiddleProximalFB = 30,
        [NativeName("Name", "XR_BODY_JOINT_LEFT_HAND_MIDDLE_INTERMEDIATE_FB")]
        LeftHandMiddleIntermediateFB = 31,
        [NativeName("Name", "XR_BODY_JOINT_LEFT_HAND_MIDDLE_DISTAL_FB")]
        LeftHandMiddleDistalFB = 32,
        [NativeName("Name", "XR_BODY_JOINT_LEFT_HAND_MIDDLE_TIP_FB")]
        LeftHandMiddleTipFB = 33,
        [NativeName("Name", "XR_BODY_JOINT_LEFT_HAND_RING_METACARPAL_FB")]
        LeftHandRingMetacarpalFB = 34,
        [NativeName("Name", "XR_BODY_JOINT_LEFT_HAND_RING_PROXIMAL_FB")]
        LeftHandRingProximalFB = 35,
        [NativeName("Name", "XR_BODY_JOINT_LEFT_HAND_RING_INTERMEDIATE_FB")]
        LeftHandRingIntermediateFB = 36,
        [NativeName("Name", "XR_BODY_JOINT_LEFT_HAND_RING_DISTAL_FB")]
        LeftHandRingDistalFB = 37,
        [NativeName("Name", "XR_BODY_JOINT_LEFT_HAND_RING_TIP_FB")]
        LeftHandRingTipFB = 38,
        [NativeName("Name", "XR_BODY_JOINT_LEFT_HAND_LITTLE_METACARPAL_FB")]
        LeftHandLittleMetacarpalFB = 39,
        [NativeName("Name", "XR_BODY_JOINT_LEFT_HAND_LITTLE_PROXIMAL_FB")]
        LeftHandLittleProximalFB = 40,
        [NativeName("Name", "XR_BODY_JOINT_LEFT_HAND_LITTLE_INTERMEDIATE_FB")]
        LeftHandLittleIntermediateFB = 41,
        [NativeName("Name", "XR_BODY_JOINT_LEFT_HAND_LITTLE_DISTAL_FB")]
        LeftHandLittleDistalFB = 42,
        [NativeName("Name", "XR_BODY_JOINT_LEFT_HAND_LITTLE_TIP_FB")]
        LeftHandLittleTipFB = 43,
        [NativeName("Name", "XR_BODY_JOINT_RIGHT_HAND_PALM_FB")]
        RightHandPalmFB = 44,
        [NativeName("Name", "XR_BODY_JOINT_RIGHT_HAND_WRIST_FB")]
        RightHandWristFB = 45,
        [NativeName("Name", "XR_BODY_JOINT_RIGHT_HAND_THUMB_METACARPAL_FB")]
        RightHandThumbMetacarpalFB = 46,
        [NativeName("Name", "XR_BODY_JOINT_RIGHT_HAND_THUMB_PROXIMAL_FB")]
        RightHandThumbProximalFB = 47,
        [NativeName("Name", "XR_BODY_JOINT_RIGHT_HAND_THUMB_DISTAL_FB")]
        RightHandThumbDistalFB = 48,
        [NativeName("Name", "XR_BODY_JOINT_RIGHT_HAND_THUMB_TIP_FB")]
        RightHandThumbTipFB = 49,
        [NativeName("Name", "XR_BODY_JOINT_RIGHT_HAND_INDEX_METACARPAL_FB")]
        RightHandIndexMetacarpalFB = 50,
        [NativeName("Name", "XR_BODY_JOINT_RIGHT_HAND_INDEX_PROXIMAL_FB")]
        RightHandIndexProximalFB = 51,
        [NativeName("Name", "XR_BODY_JOINT_RIGHT_HAND_INDEX_INTERMEDIATE_FB")]
        RightHandIndexIntermediateFB = 52,
        [NativeName("Name", "XR_BODY_JOINT_RIGHT_HAND_INDEX_DISTAL_FB")]
        RightHandIndexDistalFB = 53,
        [NativeName("Name", "XR_BODY_JOINT_RIGHT_HAND_INDEX_TIP_FB")]
        RightHandIndexTipFB = 54,
        [NativeName("Name", "XR_BODY_JOINT_RIGHT_HAND_MIDDLE_METACARPAL_FB")]
        RightHandMiddleMetacarpalFB = 55,
        [NativeName("Name", "XR_BODY_JOINT_RIGHT_HAND_MIDDLE_PROXIMAL_FB")]
        RightHandMiddleProximalFB = 56,
        [NativeName("Name", "XR_BODY_JOINT_RIGHT_HAND_MIDDLE_INTERMEDIATE_FB")]
        RightHandMiddleIntermediateFB = 57,
        [NativeName("Name", "XR_BODY_JOINT_RIGHT_HAND_MIDDLE_DISTAL_FB")]
        RightHandMiddleDistalFB = 58,
        [NativeName("Name", "XR_BODY_JOINT_RIGHT_HAND_MIDDLE_TIP_FB")]
        RightHandMiddleTipFB = 59,
        [NativeName("Name", "XR_BODY_JOINT_RIGHT_HAND_RING_METACARPAL_FB")]
        RightHandRingMetacarpalFB = 60,
        [NativeName("Name", "XR_BODY_JOINT_RIGHT_HAND_RING_PROXIMAL_FB")]
        RightHandRingProximalFB = 61,
        [NativeName("Name", "XR_BODY_JOINT_RIGHT_HAND_RING_INTERMEDIATE_FB")]
        RightHandRingIntermediateFB = 62,
        [NativeName("Name", "XR_BODY_JOINT_RIGHT_HAND_RING_DISTAL_FB")]
        RightHandRingDistalFB = 63,
        [NativeName("Name", "XR_BODY_JOINT_RIGHT_HAND_RING_TIP_FB")]
        RightHandRingTipFB = 64,
        [NativeName("Name", "XR_BODY_JOINT_RIGHT_HAND_LITTLE_METACARPAL_FB")]
        RightHandLittleMetacarpalFB = 65,
        [NativeName("Name", "XR_BODY_JOINT_RIGHT_HAND_LITTLE_PROXIMAL_FB")]
        RightHandLittleProximalFB = 66,
        [NativeName("Name", "XR_BODY_JOINT_RIGHT_HAND_LITTLE_INTERMEDIATE_FB")]
        RightHandLittleIntermediateFB = 67,
        [NativeName("Name", "XR_BODY_JOINT_RIGHT_HAND_LITTLE_DISTAL_FB")]
        RightHandLittleDistalFB = 68,
        [NativeName("Name", "XR_BODY_JOINT_RIGHT_HAND_LITTLE_TIP_FB")]
        RightHandLittleTipFB = 69,
        [NativeName("Name", "XR_BODY_JOINT_COUNT_FB")]
        CountFB = 70,
        [NativeName("Name", "XR_BODY_JOINT_NONE_FB")]
        NoneFB = unchecked((int) -1),
    }
}
