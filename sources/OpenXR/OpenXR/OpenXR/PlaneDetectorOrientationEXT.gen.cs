// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrPlaneDetectorOrientationEXT")]
[SupportedApiProfile("openxr")]
public enum PlaneDetectorOrientationEXT : uint
{
    [NativeName("XR_PLANE_DETECTOR_ORIENTATION_HORIZONTAL_UPWARD_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_plane_detection"])]
    HorizontalUpward = 0,

    [NativeName("XR_PLANE_DETECTOR_ORIENTATION_HORIZONTAL_DOWNWARD_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_plane_detection"])]
    HorizontalDownward = 1,

    [NativeName("XR_PLANE_DETECTOR_ORIENTATION_VERTICAL_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_plane_detection"])]
    Vertical = 2,

    [NativeName("XR_PLANE_DETECTOR_ORIENTATION_ARBITRARY_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_plane_detection"])]
    Arbitrary = 3,
}
