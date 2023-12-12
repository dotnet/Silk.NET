// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrMarkerDetectorFullAnalysisIntervalML")]
    public enum MarkerDetectorFullAnalysisIntervalML : int
    {
        [Obsolete("Deprecated in favour of \"MaxML\"")]
        [NativeName("Name", "XR_MARKER_DETECTOR_FULL_ANALYSIS_INTERVAL_MAX_ML")]
        MarkerDetectorFullAnalysisIntervalMaxML = 0,
        [Obsolete("Deprecated in favour of \"FastML\"")]
        [NativeName("Name", "XR_MARKER_DETECTOR_FULL_ANALYSIS_INTERVAL_FAST_ML")]
        MarkerDetectorFullAnalysisIntervalFastML = 1,
        [Obsolete("Deprecated in favour of \"MediumML\"")]
        [NativeName("Name", "XR_MARKER_DETECTOR_FULL_ANALYSIS_INTERVAL_MEDIUM_ML")]
        MarkerDetectorFullAnalysisIntervalMediumML = 2,
        [Obsolete("Deprecated in favour of \"SlowML\"")]
        [NativeName("Name", "XR_MARKER_DETECTOR_FULL_ANALYSIS_INTERVAL_SLOW_ML")]
        MarkerDetectorFullAnalysisIntervalSlowML = 3,
        [NativeName("Name", "XR_MARKER_DETECTOR_FULL_ANALYSIS_INTERVAL_MAX_ML")]
        MaxML = 0,
        [NativeName("Name", "XR_MARKER_DETECTOR_FULL_ANALYSIS_INTERVAL_FAST_ML")]
        FastML = 1,
        [NativeName("Name", "XR_MARKER_DETECTOR_FULL_ANALYSIS_INTERVAL_MEDIUM_ML")]
        MediumML = 2,
        [NativeName("Name", "XR_MARKER_DETECTOR_FULL_ANALYSIS_INTERVAL_SLOW_ML")]
        SlowML = 3,
    }
}
