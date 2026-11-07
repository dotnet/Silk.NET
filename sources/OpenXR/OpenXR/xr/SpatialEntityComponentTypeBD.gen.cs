// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSpatialEntityComponentTypeBD")]
[SupportedApiProfile("openxr")]
public enum SpatialEntityComponentTypeBD : uint
{
    [NativeName("XR_SPATIAL_ENTITY_COMPONENT_TYPE_LOCATION_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_sensing"],
        ImpliesSets = ["XR_EXT_future", "XR_VERSION_1_0"]
    )]
    Location = 0,

    [NativeName("XR_SPATIAL_ENTITY_COMPONENT_TYPE_SEMANTIC_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_sensing"],
        ImpliesSets = ["XR_EXT_future", "XR_VERSION_1_0"]
    )]
    Semantic = 1,

    [NativeName("XR_SPATIAL_ENTITY_COMPONENT_TYPE_BOUNDING_BOX_2D_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_sensing"],
        ImpliesSets = ["XR_EXT_future", "XR_VERSION_1_0"]
    )]
    BoundingBox2D = 2,

    [NativeName("XR_SPATIAL_ENTITY_COMPONENT_TYPE_POLYGON_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_sensing"],
        ImpliesSets = ["XR_EXT_future", "XR_VERSION_1_0"]
    )]
    Polygon = 3,

    [NativeName("XR_SPATIAL_ENTITY_COMPONENT_TYPE_BOUNDING_BOX_3D_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_sensing"],
        ImpliesSets = ["XR_EXT_future", "XR_VERSION_1_0"]
    )]
    BoundingBox3D = 4,

    [NativeName("XR_SPATIAL_ENTITY_COMPONENT_TYPE_TRIANGLE_MESH_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_sensing"],
        ImpliesSets = ["XR_EXT_future", "XR_VERSION_1_0"]
    )]
    TriangleMesh = 5,

    [NativeName("XR_SPATIAL_ENTITY_COMPONENT_TYPE_PLANE_ORIENTATION_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_plane"],
        ImpliesSets = ["XR_BD_spatial_sensing"]
    )]
    PlaneOrientation = 1000396000,
}
