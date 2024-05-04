// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrMarkerDetectorFpsML")]
    public enum MarkerDetectorFpsML : int
    {
        [Obsolete("Deprecated in favour of \"LowML\"")]
        [NativeName("Name", "XR_MARKER_DETECTOR_FPS_LOW_ML")]
        MarkerDetectorFpsLowML = 0,
        [Obsolete("Deprecated in favour of \"MediumML\"")]
        [NativeName("Name", "XR_MARKER_DETECTOR_FPS_MEDIUM_ML")]
        MarkerDetectorFpsMediumML = 1,
        [Obsolete("Deprecated in favour of \"HighML\"")]
        [NativeName("Name", "XR_MARKER_DETECTOR_FPS_HIGH_ML")]
        MarkerDetectorFpsHighML = 2,
        [Obsolete("Deprecated in favour of \"MaxML\"")]
        [NativeName("Name", "XR_MARKER_DETECTOR_FPS_MAX_ML")]
        MarkerDetectorFpsMaxML = 3,
        [NativeName("Name", "XR_MARKER_DETECTOR_FPS_LOW_ML")]
        LowML = 0,
        [NativeName("Name", "XR_MARKER_DETECTOR_FPS_MEDIUM_ML")]
        MediumML = 1,
        [NativeName("Name", "XR_MARKER_DETECTOR_FPS_HIGH_ML")]
        HighML = 2,
        [NativeName("Name", "XR_MARKER_DETECTOR_FPS_MAX_ML")]
        MaxML = 3,
    }
}
