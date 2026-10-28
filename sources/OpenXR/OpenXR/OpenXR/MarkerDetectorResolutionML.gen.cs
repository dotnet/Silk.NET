// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrMarkerDetectorResolutionML")]
[SupportedApiProfile("openxr")]
public enum MarkerDetectorResolutionML : uint
{
    [NativeName("XR_MARKER_DETECTOR_RESOLUTION_LOW_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_marker_understanding"])]
    Low = 0,

    [NativeName("XR_MARKER_DETECTOR_RESOLUTION_MEDIUM_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_marker_understanding"])]
    Medium = 1,

    [NativeName("XR_MARKER_DETECTOR_RESOLUTION_HIGH_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_marker_understanding"])]
    High = 2,
}
