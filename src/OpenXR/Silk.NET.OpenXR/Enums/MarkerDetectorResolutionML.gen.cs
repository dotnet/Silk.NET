// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrMarkerDetectorResolutionML")]
    public enum MarkerDetectorResolutionML : int
    {
        [Obsolete("Deprecated in favour of \"LowML\"")]
        [NativeName("Name", "XR_MARKER_DETECTOR_RESOLUTION_LOW_ML")]
        MarkerDetectorResolutionLowML = 0,
        [Obsolete("Deprecated in favour of \"MediumML\"")]
        [NativeName("Name", "XR_MARKER_DETECTOR_RESOLUTION_MEDIUM_ML")]
        MarkerDetectorResolutionMediumML = 1,
        [Obsolete("Deprecated in favour of \"HighML\"")]
        [NativeName("Name", "XR_MARKER_DETECTOR_RESOLUTION_HIGH_ML")]
        MarkerDetectorResolutionHighML = 2,
        [NativeName("Name", "XR_MARKER_DETECTOR_RESOLUTION_LOW_ML")]
        LowML = 0,
        [NativeName("Name", "XR_MARKER_DETECTOR_RESOLUTION_MEDIUM_ML")]
        MediumML = 1,
        [NativeName("Name", "XR_MARKER_DETECTOR_RESOLUTION_HIGH_ML")]
        HighML = 2,
    }
}
