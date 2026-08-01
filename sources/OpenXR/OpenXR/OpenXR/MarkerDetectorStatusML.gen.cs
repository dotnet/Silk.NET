// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrMarkerDetectorStatusML")]
[SupportedApiProfile("openxr")]
public enum MarkerDetectorStatusML : uint
{
    [NativeName("XR_MARKER_DETECTOR_STATUS_PENDING_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_marker_understanding"])]
    Pending = 0,

    [NativeName("XR_MARKER_DETECTOR_STATUS_READY_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_marker_understanding"])]
    Ready = 1,

    [NativeName("XR_MARKER_DETECTOR_STATUS_ERROR_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_marker_understanding"])]
    Error = 2,
}
