// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSpatialPlaneAlignmentEXT")]
[SupportedApiProfile("openxr")]
public enum SpatialPlaneAlignmentEXT : uint
{
    [NativeName("XR_SPATIAL_PLANE_ALIGNMENT_HORIZONTAL_UPWARD_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_plane_tracking"],
        ImpliesSets = ["XR_EXT_spatial_entity"]
    )]
    HorizontalUpward = 0,

    [NativeName("XR_SPATIAL_PLANE_ALIGNMENT_HORIZONTAL_DOWNWARD_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_plane_tracking"],
        ImpliesSets = ["XR_EXT_spatial_entity"]
    )]
    HorizontalDownward = 1,

    [NativeName("XR_SPATIAL_PLANE_ALIGNMENT_VERTICAL_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_plane_tracking"],
        ImpliesSets = ["XR_EXT_spatial_entity"]
    )]
    Vertical = 2,

    [NativeName("XR_SPATIAL_PLANE_ALIGNMENT_ARBITRARY_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_plane_tracking"],
        ImpliesSets = ["XR_EXT_spatial_entity"]
    )]
    Arbitrary = 3,
}
