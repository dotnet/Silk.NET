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
        [NativeName("Name", "XR_HAND_TRACKING_AIM_COMPUTED_BIT_FB")]
        HandTrackingAimComputedBitFB = 1,
        [NativeName("Name", "XR_HAND_TRACKING_AIM_VALID_BIT_FB")]
        HandTrackingAimValidBitFB = 2,
        [NativeName("Name", "XR_HAND_TRACKING_AIM_INDEX_PINCHING_BIT_FB")]
        HandTrackingAimIndexPinchingBitFB = 4,
        [NativeName("Name", "XR_HAND_TRACKING_AIM_MIDDLE_PINCHING_BIT_FB")]
        HandTrackingAimMiddlePinchingBitFB = 8,
        [NativeName("Name", "XR_HAND_TRACKING_AIM_RING_PINCHING_BIT_FB")]
        HandTrackingAimRingPinchingBitFB = 16,
        [NativeName("Name", "XR_HAND_TRACKING_AIM_LITTLE_PINCHING_BIT_FB")]
        HandTrackingAimLittlePinchingBitFB = 32,
        [NativeName("Name", "XR_HAND_TRACKING_AIM_SYSTEM_GESTURE_BIT_FB")]
        HandTrackingAimSystemGestureBitFB = 64,
        [NativeName("Name", "XR_HAND_TRACKING_AIM_DOMINANT_HAND_BIT_FB")]
        HandTrackingAimDominantHandBitFB = 128,
        [NativeName("Name", "XR_HAND_TRACKING_AIM_MENU_PRESSED_BIT_FB")]
        HandTrackingAimMenuPressedBitFB = 256,
    }
}
