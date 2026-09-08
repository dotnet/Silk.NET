// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrMarkerDetectorFullAnalysisIntervalML")]
[SupportedApiProfile("openxr")]
public enum MarkerDetectorFullAnalysisIntervalML : uint
{
    [NativeName("XR_MARKER_DETECTOR_FULL_ANALYSIS_INTERVAL_MAX_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_marker_understanding"])]
    Max = 0,

    [NativeName("XR_MARKER_DETECTOR_FULL_ANALYSIS_INTERVAL_FAST_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_marker_understanding"])]
    Fast = 1,

    [NativeName("XR_MARKER_DETECTOR_FULL_ANALYSIS_INTERVAL_MEDIUM_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_marker_understanding"])]
    Medium = 2,

    [NativeName("XR_MARKER_DETECTOR_FULL_ANALYSIS_INTERVAL_SLOW_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_marker_understanding"])]
    Slow = 3,
}
