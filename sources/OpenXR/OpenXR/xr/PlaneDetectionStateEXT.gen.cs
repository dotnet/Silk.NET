// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrPlaneDetectionStateEXT")]
public enum PlaneDetectionStateEXT : uint
{
    [NativeName("XR_PLANE_DETECTION_STATE_NONE_EXT")]
    None = 0,

    [NativeName("XR_PLANE_DETECTION_STATE_PENDING_EXT")]
    Pending = 1,

    [NativeName("XR_PLANE_DETECTION_STATE_DONE_EXT")]
    Done = 2,

    [NativeName("XR_PLANE_DETECTION_STATE_ERROR_EXT")]
    Error = 3,

    [NativeName("XR_PLANE_DETECTION_STATE_FATAL_EXT")]
    Fatal = 4,
}
