// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [Flags]
    [NativeName("Name", "XrHandTrackingAimFlagsFB")]
    public enum HandTrackingAimFlagsFB : long
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"ComputedBitFB\"")]
        [NativeName("Name", "XR_HAND_TRACKING_AIM_COMPUTED_BIT_FB")]
        HandTrackingAimComputedBitFB = 1,
        [Obsolete("Deprecated in favour of \"ValidBitFB\"")]
        [NativeName("Name", "XR_HAND_TRACKING_AIM_VALID_BIT_FB")]
        HandTrackingAimValidBitFB = 2,
        [Obsolete("Deprecated in favour of \"IndexPinchingBitFB\"")]
        [NativeName("Name", "XR_HAND_TRACKING_AIM_INDEX_PINCHING_BIT_FB")]
        HandTrackingAimIndexPinchingBitFB = 4,
        [Obsolete("Deprecated in favour of \"MiddlePinchingBitFB\"")]
        [NativeName("Name", "XR_HAND_TRACKING_AIM_MIDDLE_PINCHING_BIT_FB")]
        HandTrackingAimMiddlePinchingBitFB = 8,
        [Obsolete("Deprecated in favour of \"RingPinchingBitFB\"")]
        [NativeName("Name", "XR_HAND_TRACKING_AIM_RING_PINCHING_BIT_FB")]
        HandTrackingAimRingPinchingBitFB = 16,
        [Obsolete("Deprecated in favour of \"LittlePinchingBitFB\"")]
        [NativeName("Name", "XR_HAND_TRACKING_AIM_LITTLE_PINCHING_BIT_FB")]
        HandTrackingAimLittlePinchingBitFB = 32,
        [Obsolete("Deprecated in favour of \"SystemGestureBitFB\"")]
        [NativeName("Name", "XR_HAND_TRACKING_AIM_SYSTEM_GESTURE_BIT_FB")]
        HandTrackingAimSystemGestureBitFB = 64,
        [Obsolete("Deprecated in favour of \"DominantHandBitFB\"")]
        [NativeName("Name", "XR_HAND_TRACKING_AIM_DOMINANT_HAND_BIT_FB")]
        HandTrackingAimDominantHandBitFB = 128,
        [Obsolete("Deprecated in favour of \"MenuPressedBitFB\"")]
        [NativeName("Name", "XR_HAND_TRACKING_AIM_MENU_PRESSED_BIT_FB")]
        HandTrackingAimMenuPressedBitFB = 256,
        [NativeName("Name", "XR_HAND_TRACKING_AIM_COMPUTED_BIT_FB")]
        ComputedBitFB = 1,
        [NativeName("Name", "XR_HAND_TRACKING_AIM_VALID_BIT_FB")]
        ValidBitFB = 2,
        [NativeName("Name", "XR_HAND_TRACKING_AIM_INDEX_PINCHING_BIT_FB")]
        IndexPinchingBitFB = 4,
        [NativeName("Name", "XR_HAND_TRACKING_AIM_MIDDLE_PINCHING_BIT_FB")]
        MiddlePinchingBitFB = 8,
        [NativeName("Name", "XR_HAND_TRACKING_AIM_RING_PINCHING_BIT_FB")]
        RingPinchingBitFB = 16,
        [NativeName("Name", "XR_HAND_TRACKING_AIM_LITTLE_PINCHING_BIT_FB")]
        LittlePinchingBitFB = 32,
        [NativeName("Name", "XR_HAND_TRACKING_AIM_SYSTEM_GESTURE_BIT_FB")]
        SystemGestureBitFB = 64,
        [NativeName("Name", "XR_HAND_TRACKING_AIM_DOMINANT_HAND_BIT_FB")]
        DominantHandBitFB = 128,
        [NativeName("Name", "XR_HAND_TRACKING_AIM_MENU_PRESSED_BIT_FB")]
        MenuPressedBitFB = 256,
    }
}
