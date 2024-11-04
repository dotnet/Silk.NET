// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrBodyJointHTC")]
    public enum BodyJointHTC : int
    {
        [Obsolete("Deprecated in favour of \"PelvisHtc\"")]
        [NativeName("Name", "XR_BODY_JOINT_PELVIS_HTC")]
        BodyJointPelvisHtc = 0,
        [Obsolete("Deprecated in favour of \"LeftHipHtc\"")]
        [NativeName("Name", "XR_BODY_JOINT_LEFT_HIP_HTC")]
        BodyJointLeftHipHtc = 1,
        [Obsolete("Deprecated in favour of \"LeftKneeHtc\"")]
        [NativeName("Name", "XR_BODY_JOINT_LEFT_KNEE_HTC")]
        BodyJointLeftKneeHtc = 2,
        [Obsolete("Deprecated in favour of \"LeftAnkleHtc\"")]
        [NativeName("Name", "XR_BODY_JOINT_LEFT_ANKLE_HTC")]
        BodyJointLeftAnkleHtc = 3,
        [Obsolete("Deprecated in favour of \"LeftFeetHtc\"")]
        [NativeName("Name", "XR_BODY_JOINT_LEFT_FEET_HTC")]
        BodyJointLeftFeetHtc = 4,
        [Obsolete("Deprecated in favour of \"RightHipHtc\"")]
        [NativeName("Name", "XR_BODY_JOINT_RIGHT_HIP_HTC")]
        BodyJointRightHipHtc = 5,
        [Obsolete("Deprecated in favour of \"RightKneeHtc\"")]
        [NativeName("Name", "XR_BODY_JOINT_RIGHT_KNEE_HTC")]
        BodyJointRightKneeHtc = 6,
        [Obsolete("Deprecated in favour of \"RightAnkleHtc\"")]
        [NativeName("Name", "XR_BODY_JOINT_RIGHT_ANKLE_HTC")]
        BodyJointRightAnkleHtc = 7,
        [Obsolete("Deprecated in favour of \"RightFeetHtc\"")]
        [NativeName("Name", "XR_BODY_JOINT_RIGHT_FEET_HTC")]
        BodyJointRightFeetHtc = 8,
        [Obsolete("Deprecated in favour of \"WaistHtc\"")]
        [NativeName("Name", "XR_BODY_JOINT_WAIST_HTC")]
        BodyJointWaistHtc = 9,
        [Obsolete("Deprecated in favour of \"SpineLowerHtc\"")]
        [NativeName("Name", "XR_BODY_JOINT_SPINE_LOWER_HTC")]
        BodyJointSpineLowerHtc = 10,
        [Obsolete("Deprecated in favour of \"SpineMiddleHtc\"")]
        [NativeName("Name", "XR_BODY_JOINT_SPINE_MIDDLE_HTC")]
        BodyJointSpineMiddleHtc = 11,
        [Obsolete("Deprecated in favour of \"SpineHighHtc\"")]
        [NativeName("Name", "XR_BODY_JOINT_SPINE_HIGH_HTC")]
        BodyJointSpineHighHtc = 12,
        [Obsolete("Deprecated in favour of \"ChestHtc\"")]
        [NativeName("Name", "XR_BODY_JOINT_CHEST_HTC")]
        BodyJointChestHtc = 13,
        [Obsolete("Deprecated in favour of \"NeckHtc\"")]
        [NativeName("Name", "XR_BODY_JOINT_NECK_HTC")]
        BodyJointNeckHtc = 14,
        [Obsolete("Deprecated in favour of \"HeadHtc\"")]
        [NativeName("Name", "XR_BODY_JOINT_HEAD_HTC")]
        BodyJointHeadHtc = 15,
        [Obsolete("Deprecated in favour of \"LeftClavicleHtc\"")]
        [NativeName("Name", "XR_BODY_JOINT_LEFT_CLAVICLE_HTC")]
        BodyJointLeftClavicleHtc = 16,
        [Obsolete("Deprecated in favour of \"LeftScapulaHtc\"")]
        [NativeName("Name", "XR_BODY_JOINT_LEFT_SCAPULA_HTC")]
        BodyJointLeftScapulaHtc = 17,
        [Obsolete("Deprecated in favour of \"LeftArmHtc\"")]
        [NativeName("Name", "XR_BODY_JOINT_LEFT_ARM_HTC")]
        BodyJointLeftArmHtc = 18,
        [Obsolete("Deprecated in favour of \"LeftElbowHtc\"")]
        [NativeName("Name", "XR_BODY_JOINT_LEFT_ELBOW_HTC")]
        BodyJointLeftElbowHtc = 19,
        [Obsolete("Deprecated in favour of \"LeftWristHtc\"")]
        [NativeName("Name", "XR_BODY_JOINT_LEFT_WRIST_HTC")]
        BodyJointLeftWristHtc = 20,
        [Obsolete("Deprecated in favour of \"RightClavicleHtc\"")]
        [NativeName("Name", "XR_BODY_JOINT_RIGHT_CLAVICLE_HTC")]
        BodyJointRightClavicleHtc = 21,
        [Obsolete("Deprecated in favour of \"RightScapulaHtc\"")]
        [NativeName("Name", "XR_BODY_JOINT_RIGHT_SCAPULA_HTC")]
        BodyJointRightScapulaHtc = 22,
        [Obsolete("Deprecated in favour of \"RightArmHtc\"")]
        [NativeName("Name", "XR_BODY_JOINT_RIGHT_ARM_HTC")]
        BodyJointRightArmHtc = 23,
        [Obsolete("Deprecated in favour of \"RightElbowHtc\"")]
        [NativeName("Name", "XR_BODY_JOINT_RIGHT_ELBOW_HTC")]
        BodyJointRightElbowHtc = 24,
        [Obsolete("Deprecated in favour of \"RightWristHtc\"")]
        [NativeName("Name", "XR_BODY_JOINT_RIGHT_WRIST_HTC")]
        BodyJointRightWristHtc = 25,
        [NativeName("Name", "XR_BODY_JOINT_PELVIS_HTC")]
        PelvisHtc = 0,
        [NativeName("Name", "XR_BODY_JOINT_LEFT_HIP_HTC")]
        LeftHipHtc = 1,
        [NativeName("Name", "XR_BODY_JOINT_LEFT_KNEE_HTC")]
        LeftKneeHtc = 2,
        [NativeName("Name", "XR_BODY_JOINT_LEFT_ANKLE_HTC")]
        LeftAnkleHtc = 3,
        [NativeName("Name", "XR_BODY_JOINT_LEFT_FEET_HTC")]
        LeftFeetHtc = 4,
        [NativeName("Name", "XR_BODY_JOINT_RIGHT_HIP_HTC")]
        RightHipHtc = 5,
        [NativeName("Name", "XR_BODY_JOINT_RIGHT_KNEE_HTC")]
        RightKneeHtc = 6,
        [NativeName("Name", "XR_BODY_JOINT_RIGHT_ANKLE_HTC")]
        RightAnkleHtc = 7,
        [NativeName("Name", "XR_BODY_JOINT_RIGHT_FEET_HTC")]
        RightFeetHtc = 8,
        [NativeName("Name", "XR_BODY_JOINT_WAIST_HTC")]
        WaistHtc = 9,
        [NativeName("Name", "XR_BODY_JOINT_SPINE_LOWER_HTC")]
        SpineLowerHtc = 10,
        [NativeName("Name", "XR_BODY_JOINT_SPINE_MIDDLE_HTC")]
        SpineMiddleHtc = 11,
        [NativeName("Name", "XR_BODY_JOINT_SPINE_HIGH_HTC")]
        SpineHighHtc = 12,
        [NativeName("Name", "XR_BODY_JOINT_CHEST_HTC")]
        ChestHtc = 13,
        [NativeName("Name", "XR_BODY_JOINT_NECK_HTC")]
        NeckHtc = 14,
        [NativeName("Name", "XR_BODY_JOINT_HEAD_HTC")]
        HeadHtc = 15,
        [NativeName("Name", "XR_BODY_JOINT_LEFT_CLAVICLE_HTC")]
        LeftClavicleHtc = 16,
        [NativeName("Name", "XR_BODY_JOINT_LEFT_SCAPULA_HTC")]
        LeftScapulaHtc = 17,
        [NativeName("Name", "XR_BODY_JOINT_LEFT_ARM_HTC")]
        LeftArmHtc = 18,
        [NativeName("Name", "XR_BODY_JOINT_LEFT_ELBOW_HTC")]
        LeftElbowHtc = 19,
        [NativeName("Name", "XR_BODY_JOINT_LEFT_WRIST_HTC")]
        LeftWristHtc = 20,
        [NativeName("Name", "XR_BODY_JOINT_RIGHT_CLAVICLE_HTC")]
        RightClavicleHtc = 21,
        [NativeName("Name", "XR_BODY_JOINT_RIGHT_SCAPULA_HTC")]
        RightScapulaHtc = 22,
        [NativeName("Name", "XR_BODY_JOINT_RIGHT_ARM_HTC")]
        RightArmHtc = 23,
        [NativeName("Name", "XR_BODY_JOINT_RIGHT_ELBOW_HTC")]
        RightElbowHtc = 24,
        [NativeName("Name", "XR_BODY_JOINT_RIGHT_WRIST_HTC")]
        RightWristHtc = 25,
    }
}
