// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrMarkerDetectorCornerRefineMethodML")]
[SupportedApiProfile("openxr")]
public enum MarkerDetectorCornerRefineMethodML : uint
{
    [NativeName("XR_MARKER_DETECTOR_CORNER_REFINE_METHOD_NONE_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_marker_understanding"])]
    None = 0,

    [NativeName("XR_MARKER_DETECTOR_CORNER_REFINE_METHOD_SUBPIX_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_marker_understanding"])]
    Subpix = 1,

    [NativeName("XR_MARKER_DETECTOR_CORNER_REFINE_METHOD_CONTOUR_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_marker_understanding"])]
    Contour = 2,

    [NativeName("XR_MARKER_DETECTOR_CORNER_REFINE_METHOD_APRIL_TAG_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_marker_understanding"])]
    AprilTag = 3,
}
