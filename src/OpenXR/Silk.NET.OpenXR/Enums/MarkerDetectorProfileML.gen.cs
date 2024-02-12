// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrMarkerDetectorProfileML")]
    public enum MarkerDetectorProfileML : int
    {
        [Obsolete("Deprecated in favour of \"DefaultML\"")]
        [NativeName("Name", "XR_MARKER_DETECTOR_PROFILE_DEFAULT_ML")]
        MarkerDetectorProfileDefaultML = 0,
        [Obsolete("Deprecated in favour of \"SpeedML\"")]
        [NativeName("Name", "XR_MARKER_DETECTOR_PROFILE_SPEED_ML")]
        MarkerDetectorProfileSpeedML = 1,
        [Obsolete("Deprecated in favour of \"AccuracyML\"")]
        [NativeName("Name", "XR_MARKER_DETECTOR_PROFILE_ACCURACY_ML")]
        MarkerDetectorProfileAccuracyML = 2,
        [Obsolete("Deprecated in favour of \"SmallTargetsML\"")]
        [NativeName("Name", "XR_MARKER_DETECTOR_PROFILE_SMALL_TARGETS_ML")]
        MarkerDetectorProfileSmallTargetsML = 3,
        [Obsolete("Deprecated in favour of \"LargeFovML\"")]
        [NativeName("Name", "XR_MARKER_DETECTOR_PROFILE_LARGE_FOV_ML")]
        MarkerDetectorProfileLargeFovML = 4,
        [Obsolete("Deprecated in favour of \"CustomML\"")]
        [NativeName("Name", "XR_MARKER_DETECTOR_PROFILE_CUSTOM_ML")]
        MarkerDetectorProfileCustomML = 5,
        [NativeName("Name", "XR_MARKER_DETECTOR_PROFILE_DEFAULT_ML")]
        DefaultML = 0,
        [NativeName("Name", "XR_MARKER_DETECTOR_PROFILE_SPEED_ML")]
        SpeedML = 1,
        [NativeName("Name", "XR_MARKER_DETECTOR_PROFILE_ACCURACY_ML")]
        AccuracyML = 2,
        [NativeName("Name", "XR_MARKER_DETECTOR_PROFILE_SMALL_TARGETS_ML")]
        SmallTargetsML = 3,
        [NativeName("Name", "XR_MARKER_DETECTOR_PROFILE_LARGE_FOV_ML")]
        LargeFovML = 4,
        [NativeName("Name", "XR_MARKER_DETECTOR_PROFILE_CUSTOM_ML")]
        CustomML = 5,
    }
}
