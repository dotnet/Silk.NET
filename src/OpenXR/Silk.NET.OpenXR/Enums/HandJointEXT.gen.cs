// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrHandJointEXT")]
    public enum HandJointEXT : int
    {
        [NativeName("Name", "XR_HAND_JOINT_PALM_EXT")]
        HandJointPalmExt = 0,
        [NativeName("Name", "XR_HAND_JOINT_WRIST_EXT")]
        HandJointWristExt = 1,
        [NativeName("Name", "XR_HAND_JOINT_THUMB_METACARPAL_EXT")]
        HandJointThumbMetacarpalExt = 2,
        [NativeName("Name", "XR_HAND_JOINT_THUMB_PROXIMAL_EXT")]
        HandJointThumbProximalExt = 3,
        [NativeName("Name", "XR_HAND_JOINT_THUMB_DISTAL_EXT")]
        HandJointThumbDistalExt = 4,
        [NativeName("Name", "XR_HAND_JOINT_THUMB_TIP_EXT")]
        HandJointThumbTipExt = 5,
        [NativeName("Name", "XR_HAND_JOINT_INDEX_METACARPAL_EXT")]
        HandJointIndexMetacarpalExt = 6,
        [NativeName("Name", "XR_HAND_JOINT_INDEX_PROXIMAL_EXT")]
        HandJointIndexProximalExt = 7,
        [NativeName("Name", "XR_HAND_JOINT_INDEX_INTERMEDIATE_EXT")]
        HandJointIndexIntermediateExt = 8,
        [NativeName("Name", "XR_HAND_JOINT_INDEX_DISTAL_EXT")]
        HandJointIndexDistalExt = 9,
        [NativeName("Name", "XR_HAND_JOINT_INDEX_TIP_EXT")]
        HandJointIndexTipExt = 10,
        [NativeName("Name", "XR_HAND_JOINT_MIDDLE_METACARPAL_EXT")]
        HandJointMiddleMetacarpalExt = 11,
        [NativeName("Name", "XR_HAND_JOINT_MIDDLE_PROXIMAL_EXT")]
        HandJointMiddleProximalExt = 12,
        [NativeName("Name", "XR_HAND_JOINT_MIDDLE_INTERMEDIATE_EXT")]
        HandJointMiddleIntermediateExt = 13,
        [NativeName("Name", "XR_HAND_JOINT_MIDDLE_DISTAL_EXT")]
        HandJointMiddleDistalExt = 14,
        [NativeName("Name", "XR_HAND_JOINT_MIDDLE_TIP_EXT")]
        HandJointMiddleTipExt = 15,
        [NativeName("Name", "XR_HAND_JOINT_RING_METACARPAL_EXT")]
        HandJointRingMetacarpalExt = 16,
        [NativeName("Name", "XR_HAND_JOINT_RING_PROXIMAL_EXT")]
        HandJointRingProximalExt = 17,
        [NativeName("Name", "XR_HAND_JOINT_RING_INTERMEDIATE_EXT")]
        HandJointRingIntermediateExt = 18,
        [NativeName("Name", "XR_HAND_JOINT_RING_DISTAL_EXT")]
        HandJointRingDistalExt = 19,
        [NativeName("Name", "XR_HAND_JOINT_RING_TIP_EXT")]
        HandJointRingTipExt = 20,
        [NativeName("Name", "XR_HAND_JOINT_LITTLE_METACARPAL_EXT")]
        HandJointLittleMetacarpalExt = 21,
        [NativeName("Name", "XR_HAND_JOINT_LITTLE_PROXIMAL_EXT")]
        HandJointLittleProximalExt = 22,
        [NativeName("Name", "XR_HAND_JOINT_LITTLE_INTERMEDIATE_EXT")]
        HandJointLittleIntermediateExt = 23,
        [NativeName("Name", "XR_HAND_JOINT_LITTLE_DISTAL_EXT")]
        HandJointLittleDistalExt = 24,
        [NativeName("Name", "XR_HAND_JOINT_LITTLE_TIP_EXT")]
        HandJointLittleTipExt = 25,
    }
}
