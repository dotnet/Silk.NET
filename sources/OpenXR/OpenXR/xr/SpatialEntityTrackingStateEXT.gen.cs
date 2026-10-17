// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSpatialEntityTrackingStateEXT")]
public enum SpatialEntityTrackingStateEXT : uint
{
    [NativeName("XR_SPATIAL_ENTITY_TRACKING_STATE_STOPPED_EXT")]
    Stopped = 1,

    [NativeName("XR_SPATIAL_ENTITY_TRACKING_STATE_PAUSED_EXT")]
    Paused = 2,

    [NativeName("XR_SPATIAL_ENTITY_TRACKING_STATE_TRACKING_EXT")]
    Tracking = 3,
}
