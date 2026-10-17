// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrMarkerDetectorProfileML")]
public enum MarkerDetectorProfileML : uint
{
    [NativeName("XR_MARKER_DETECTOR_PROFILE_DEFAULT_ML")]
    Default = 0,

    [NativeName("XR_MARKER_DETECTOR_PROFILE_SPEED_ML")]
    Speed = 1,

    [NativeName("XR_MARKER_DETECTOR_PROFILE_ACCURACY_ML")]
    Accuracy = 2,

    [NativeName("XR_MARKER_DETECTOR_PROFILE_SMALL_TARGETS_ML")]
    SmallTargets = 3,

    [NativeName("XR_MARKER_DETECTOR_PROFILE_LARGE_FOV_ML")]
    LargeFov = 4,

    [NativeName("XR_MARKER_DETECTOR_PROFILE_CUSTOM_ML")]
    Custom = 5,
}
