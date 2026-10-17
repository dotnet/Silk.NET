// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrMarkerDetectorCornerRefineMethodML")]
public enum MarkerDetectorCornerRefineMethodML : uint
{
    [NativeName("XR_MARKER_DETECTOR_CORNER_REFINE_METHOD_NONE_ML")]
    None = 0,

    [NativeName("XR_MARKER_DETECTOR_CORNER_REFINE_METHOD_SUBPIX_ML")]
    Subpix = 1,

    [NativeName("XR_MARKER_DETECTOR_CORNER_REFINE_METHOD_CONTOUR_ML")]
    Contour = 2,

    [NativeName("XR_MARKER_DETECTOR_CORNER_REFINE_METHOD_APRIL_TAG_ML")]
    AprilTag = 3,
}
