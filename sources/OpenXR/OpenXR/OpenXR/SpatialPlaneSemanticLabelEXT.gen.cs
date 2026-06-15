// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSpatialPlaneSemanticLabelEXT")]
[SupportedApiProfile("openxr")]
public enum SpatialPlaneSemanticLabelEXT : uint
{
    [NativeName("XR_SPATIAL_PLANE_SEMANTIC_LABEL_UNCATEGORIZED_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_plane_tracking"],
        ImpliesSets = ["XR_EXT_spatial_entity"]
    )]
    Uncategorized = 1,

    [NativeName("XR_SPATIAL_PLANE_SEMANTIC_LABEL_FLOOR_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_plane_tracking"],
        ImpliesSets = ["XR_EXT_spatial_entity"]
    )]
    Floor = 2,

    [NativeName("XR_SPATIAL_PLANE_SEMANTIC_LABEL_WALL_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_plane_tracking"],
        ImpliesSets = ["XR_EXT_spatial_entity"]
    )]
    Wall = 3,

    [NativeName("XR_SPATIAL_PLANE_SEMANTIC_LABEL_CEILING_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_plane_tracking"],
        ImpliesSets = ["XR_EXT_spatial_entity"]
    )]
    Ceiling = 4,

    [NativeName("XR_SPATIAL_PLANE_SEMANTIC_LABEL_TABLE_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_plane_tracking"],
        ImpliesSets = ["XR_EXT_spatial_entity"]
    )]
    Table = 5,
}
