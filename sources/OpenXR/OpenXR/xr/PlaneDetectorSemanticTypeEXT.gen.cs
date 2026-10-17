// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrPlaneDetectorSemanticTypeEXT")]
public enum PlaneDetectorSemanticTypeEXT : uint
{
    [NativeName("XR_PLANE_DETECTOR_SEMANTIC_TYPE_UNDEFINED_EXT")]
    Undefined = 0,

    [NativeName("XR_PLANE_DETECTOR_SEMANTIC_TYPE_CEILING_EXT")]
    Ceiling = 1,

    [NativeName("XR_PLANE_DETECTOR_SEMANTIC_TYPE_FLOOR_EXT")]
    Floor = 2,

    [NativeName("XR_PLANE_DETECTOR_SEMANTIC_TYPE_WALL_EXT")]
    Wall = 3,

    [NativeName("XR_PLANE_DETECTOR_SEMANTIC_TYPE_PLATFORM_EXT")]
    Platform = 4,
}
