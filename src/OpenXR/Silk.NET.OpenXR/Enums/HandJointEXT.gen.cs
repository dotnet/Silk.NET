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
        [Obsolete("Deprecated in favour of \"PalmExt\"")]
        [NativeName("Name", "XR_HAND_JOINT_PALM_EXT")]
        HandJointPalmExt = 0,
        [Obsolete("Deprecated in favour of \"WristExt\"")]
        [NativeName("Name", "XR_HAND_JOINT_WRIST_EXT")]
        HandJointWristExt = 1,
        [Obsolete("Deprecated in favour of \"ThumbMetacarpalExt\"")]
        [NativeName("Name", "XR_HAND_JOINT_THUMB_METACARPAL_EXT")]
        HandJointThumbMetacarpalExt = 2,
        [Obsolete("Deprecated in favour of \"ThumbProximalExt\"")]
        [NativeName("Name", "XR_HAND_JOINT_THUMB_PROXIMAL_EXT")]
        HandJointThumbProximalExt = 3,
        [Obsolete("Deprecated in favour of \"ThumbDistalExt\"")]
        [NativeName("Name", "XR_HAND_JOINT_THUMB_DISTAL_EXT")]
        HandJointThumbDistalExt = 4,
        [Obsolete("Deprecated in favour of \"ThumbTipExt\"")]
        [NativeName("Name", "XR_HAND_JOINT_THUMB_TIP_EXT")]
        HandJointThumbTipExt = 5,
        [Obsolete("Deprecated in favour of \"IndexMetacarpalExt\"")]
        [NativeName("Name", "XR_HAND_JOINT_INDEX_METACARPAL_EXT")]
        HandJointIndexMetacarpalExt = 6,
        [Obsolete("Deprecated in favour of \"IndexProximalExt\"")]
        [NativeName("Name", "XR_HAND_JOINT_INDEX_PROXIMAL_EXT")]
        HandJointIndexProximalExt = 7,
        [Obsolete("Deprecated in favour of \"IndexIntermediateExt\"")]
        [NativeName("Name", "XR_HAND_JOINT_INDEX_INTERMEDIATE_EXT")]
        HandJointIndexIntermediateExt = 8,
        [Obsolete("Deprecated in favour of \"IndexDistalExt\"")]
        [NativeName("Name", "XR_HAND_JOINT_INDEX_DISTAL_EXT")]
        HandJointIndexDistalExt = 9,
        [Obsolete("Deprecated in favour of \"IndexTipExt\"")]
        [NativeName("Name", "XR_HAND_JOINT_INDEX_TIP_EXT")]
        HandJointIndexTipExt = 10,
        [Obsolete("Deprecated in favour of \"MiddleMetacarpalExt\"")]
        [NativeName("Name", "XR_HAND_JOINT_MIDDLE_METACARPAL_EXT")]
        HandJointMiddleMetacarpalExt = 11,
        [Obsolete("Deprecated in favour of \"MiddleProximalExt\"")]
        [NativeName("Name", "XR_HAND_JOINT_MIDDLE_PROXIMAL_EXT")]
        HandJointMiddleProximalExt = 12,
        [Obsolete("Deprecated in favour of \"MiddleIntermediateExt\"")]
        [NativeName("Name", "XR_HAND_JOINT_MIDDLE_INTERMEDIATE_EXT")]
        HandJointMiddleIntermediateExt = 13,
        [Obsolete("Deprecated in favour of \"MiddleDistalExt\"")]
        [NativeName("Name", "XR_HAND_JOINT_MIDDLE_DISTAL_EXT")]
        HandJointMiddleDistalExt = 14,
        [Obsolete("Deprecated in favour of \"MiddleTipExt\"")]
        [NativeName("Name", "XR_HAND_JOINT_MIDDLE_TIP_EXT")]
        HandJointMiddleTipExt = 15,
        [Obsolete("Deprecated in favour of \"RingMetacarpalExt\"")]
        [NativeName("Name", "XR_HAND_JOINT_RING_METACARPAL_EXT")]
        HandJointRingMetacarpalExt = 16,
        [Obsolete("Deprecated in favour of \"RingProximalExt\"")]
        [NativeName("Name", "XR_HAND_JOINT_RING_PROXIMAL_EXT")]
        HandJointRingProximalExt = 17,
        [Obsolete("Deprecated in favour of \"RingIntermediateExt\"")]
        [NativeName("Name", "XR_HAND_JOINT_RING_INTERMEDIATE_EXT")]
        HandJointRingIntermediateExt = 18,
        [Obsolete("Deprecated in favour of \"RingDistalExt\"")]
        [NativeName("Name", "XR_HAND_JOINT_RING_DISTAL_EXT")]
        HandJointRingDistalExt = 19,
        [Obsolete("Deprecated in favour of \"RingTipExt\"")]
        [NativeName("Name", "XR_HAND_JOINT_RING_TIP_EXT")]
        HandJointRingTipExt = 20,
        [Obsolete("Deprecated in favour of \"LittleMetacarpalExt\"")]
        [NativeName("Name", "XR_HAND_JOINT_LITTLE_METACARPAL_EXT")]
        HandJointLittleMetacarpalExt = 21,
        [Obsolete("Deprecated in favour of \"LittleProximalExt\"")]
        [NativeName("Name", "XR_HAND_JOINT_LITTLE_PROXIMAL_EXT")]
        HandJointLittleProximalExt = 22,
        [Obsolete("Deprecated in favour of \"LittleIntermediateExt\"")]
        [NativeName("Name", "XR_HAND_JOINT_LITTLE_INTERMEDIATE_EXT")]
        HandJointLittleIntermediateExt = 23,
        [Obsolete("Deprecated in favour of \"LittleDistalExt\"")]
        [NativeName("Name", "XR_HAND_JOINT_LITTLE_DISTAL_EXT")]
        HandJointLittleDistalExt = 24,
        [Obsolete("Deprecated in favour of \"LittleTipExt\"")]
        [NativeName("Name", "XR_HAND_JOINT_LITTLE_TIP_EXT")]
        HandJointLittleTipExt = 25,
        [NativeName("Name", "XR_HAND_JOINT_PALM_EXT")]
        PalmExt = 0,
        [NativeName("Name", "XR_HAND_JOINT_WRIST_EXT")]
        WristExt = 1,
        [NativeName("Name", "XR_HAND_JOINT_THUMB_METACARPAL_EXT")]
        ThumbMetacarpalExt = 2,
        [NativeName("Name", "XR_HAND_JOINT_THUMB_PROXIMAL_EXT")]
        ThumbProximalExt = 3,
        [NativeName("Name", "XR_HAND_JOINT_THUMB_DISTAL_EXT")]
        ThumbDistalExt = 4,
        [NativeName("Name", "XR_HAND_JOINT_THUMB_TIP_EXT")]
        ThumbTipExt = 5,
        [NativeName("Name", "XR_HAND_JOINT_INDEX_METACARPAL_EXT")]
        IndexMetacarpalExt = 6,
        [NativeName("Name", "XR_HAND_JOINT_INDEX_PROXIMAL_EXT")]
        IndexProximalExt = 7,
        [NativeName("Name", "XR_HAND_JOINT_INDEX_INTERMEDIATE_EXT")]
        IndexIntermediateExt = 8,
        [NativeName("Name", "XR_HAND_JOINT_INDEX_DISTAL_EXT")]
        IndexDistalExt = 9,
        [NativeName("Name", "XR_HAND_JOINT_INDEX_TIP_EXT")]
        IndexTipExt = 10,
        [NativeName("Name", "XR_HAND_JOINT_MIDDLE_METACARPAL_EXT")]
        MiddleMetacarpalExt = 11,
        [NativeName("Name", "XR_HAND_JOINT_MIDDLE_PROXIMAL_EXT")]
        MiddleProximalExt = 12,
        [NativeName("Name", "XR_HAND_JOINT_MIDDLE_INTERMEDIATE_EXT")]
        MiddleIntermediateExt = 13,
        [NativeName("Name", "XR_HAND_JOINT_MIDDLE_DISTAL_EXT")]
        MiddleDistalExt = 14,
        [NativeName("Name", "XR_HAND_JOINT_MIDDLE_TIP_EXT")]
        MiddleTipExt = 15,
        [NativeName("Name", "XR_HAND_JOINT_RING_METACARPAL_EXT")]
        RingMetacarpalExt = 16,
        [NativeName("Name", "XR_HAND_JOINT_RING_PROXIMAL_EXT")]
        RingProximalExt = 17,
        [NativeName("Name", "XR_HAND_JOINT_RING_INTERMEDIATE_EXT")]
        RingIntermediateExt = 18,
        [NativeName("Name", "XR_HAND_JOINT_RING_DISTAL_EXT")]
        RingDistalExt = 19,
        [NativeName("Name", "XR_HAND_JOINT_RING_TIP_EXT")]
        RingTipExt = 20,
        [NativeName("Name", "XR_HAND_JOINT_LITTLE_METACARPAL_EXT")]
        LittleMetacarpalExt = 21,
        [NativeName("Name", "XR_HAND_JOINT_LITTLE_PROXIMAL_EXT")]
        LittleProximalExt = 22,
        [NativeName("Name", "XR_HAND_JOINT_LITTLE_INTERMEDIATE_EXT")]
        LittleIntermediateExt = 23,
        [NativeName("Name", "XR_HAND_JOINT_LITTLE_DISTAL_EXT")]
        LittleDistalExt = 24,
        [NativeName("Name", "XR_HAND_JOINT_LITTLE_TIP_EXT")]
        LittleTipExt = 25,
    }
}
