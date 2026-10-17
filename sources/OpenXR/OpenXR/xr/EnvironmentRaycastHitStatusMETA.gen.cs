// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrEnvironmentRaycastHitStatusMETA")]
public enum EnvironmentRaycastHitStatusMETA : uint
{
    [NativeName("XR_ENVIRONMENT_RAYCAST_HIT_STATUS_HIT_META")]
    Hit = 1,

    [NativeName("XR_ENVIRONMENT_RAYCAST_HIT_STATUS_NO_HIT_META")]
    NoHit = 2,

    [NativeName("XR_ENVIRONMENT_RAYCAST_HIT_STATUS_HIT_POINT_OCCLUDED_META")]
    HitPointOccluded = 3,

    [NativeName("XR_ENVIRONMENT_RAYCAST_HIT_STATUS_HIT_POINT_OUTSIDE_OF_FOV_META")]
    HitPointOutsideOfFov = 4,

    [NativeName("XR_ENVIRONMENT_RAYCAST_HIT_STATUS_RAY_OCCLUDED_META")]
    RayOccluded = 5,

    [NativeName("XR_ENVIRONMENT_RAYCAST_HIT_STATUS_HIT_INVALID_ORIENTATION_META")]
    HitInvalidOrientation = 6,
}
