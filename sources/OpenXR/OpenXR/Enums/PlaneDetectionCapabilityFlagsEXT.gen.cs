// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrPlaneDetectionCapabilityFlagsEXT")]
[Flags]
public enum PlaneDetectionCapabilityFlagsEXT : ulong
{
    None = 0x0,

    [NativeName("XR_PLANE_DETECTION_CAPABILITY_PLANE_DETECTION_BIT_EXT")]
    PlaneDetectionBit = 0x1,

    [NativeName("XR_PLANE_DETECTION_CAPABILITY_PLANE_HOLES_BIT_EXT")]
    PlaneHolesBit = 0x2,

    [NativeName("XR_PLANE_DETECTION_CAPABILITY_SEMANTIC_CEILING_BIT_EXT")]
    SemanticCeilingBit = 0x4,

    [NativeName("XR_PLANE_DETECTION_CAPABILITY_SEMANTIC_FLOOR_BIT_EXT")]
    SemanticFloorBit = 0x8,

    [NativeName("XR_PLANE_DETECTION_CAPABILITY_SEMANTIC_WALL_BIT_EXT")]
    SemanticWallBit = 0x10,

    [NativeName("XR_PLANE_DETECTION_CAPABILITY_SEMANTIC_PLATFORM_BIT_EXT")]
    SemanticPlatformBit = 0x20,

    [NativeName("XR_PLANE_DETECTION_CAPABILITY_ORIENTATION_BIT_EXT")]
    OrientationBit = 0x40,
}
