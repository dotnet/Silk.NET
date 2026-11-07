// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrMarkerDetectorProfileML")]
[SupportedApiProfile("openxr")]
public enum MarkerDetectorProfileML : uint
{
    [NativeName("XR_MARKER_DETECTOR_PROFILE_DEFAULT_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_marker_understanding"])]
    Default = 0,

    [NativeName("XR_MARKER_DETECTOR_PROFILE_SPEED_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_marker_understanding"])]
    Speed = 1,

    [NativeName("XR_MARKER_DETECTOR_PROFILE_ACCURACY_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_marker_understanding"])]
    Accuracy = 2,

    [NativeName("XR_MARKER_DETECTOR_PROFILE_SMALL_TARGETS_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_marker_understanding"])]
    SmallTargets = 3,

    [NativeName("XR_MARKER_DETECTOR_PROFILE_LARGE_FOV_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_marker_understanding"])]
    LargeFov = 4,

    [NativeName("XR_MARKER_DETECTOR_PROFILE_CUSTOM_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_marker_understanding"])]
    Custom = 5,
}
