// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSpatialComponentTypeEXT")]
[SupportedApiProfile("openxr")]
public enum SpatialComponentTypeEXT : uint
{
    [NativeName("XR_SPATIAL_COMPONENT_TYPE_BOUNDED_2D_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_spatial_entity"], ImpliesSets = ["XR_EXT_future"])]
    Bounded2D = 1,

    [NativeName("XR_SPATIAL_COMPONENT_TYPE_BOUNDED_3D_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_spatial_entity"], ImpliesSets = ["XR_EXT_future"])]
    Bounded3D = 2,

    [NativeName("XR_SPATIAL_COMPONENT_TYPE_PARENT_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_spatial_entity"], ImpliesSets = ["XR_EXT_future"])]
    Parent = 3,

    [NativeName("XR_SPATIAL_COMPONENT_TYPE_MESH_3D_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_spatial_entity"], ImpliesSets = ["XR_EXT_future"])]
    Mesh3D = 4,

    [NativeName("XR_SPATIAL_COMPONENT_TYPE_PLANE_ALIGNMENT_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_plane_tracking"],
        ImpliesSets = ["XR_EXT_spatial_entity"]
    )]
    PlaneAlignment = 1000741000,

    [NativeName("XR_SPATIAL_COMPONENT_TYPE_MESH_2D_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_plane_tracking"],
        ImpliesSets = ["XR_EXT_spatial_entity"]
    )]
    Mesh2D = 1000741001,

    [NativeName("XR_SPATIAL_COMPONENT_TYPE_POLYGON_2D_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_plane_tracking"],
        ImpliesSets = ["XR_EXT_spatial_entity"]
    )]
    Polygon2D = 1000741002,

    [NativeName("XR_SPATIAL_COMPONENT_TYPE_PLANE_SEMANTIC_LABEL_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_plane_tracking"],
        ImpliesSets = ["XR_EXT_spatial_entity"]
    )]
    PlaneSemanticLabel = 1000741003,

    [NativeName("XR_SPATIAL_COMPONENT_TYPE_MARKER_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_marker_tracking"],
        ImpliesSets = ["XR_EXT_spatial_entity"]
    )]
    Marker = 1000743000,

    [NativeName("XR_SPATIAL_COMPONENT_TYPE_ANCHOR_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_anchor"],
        ImpliesSets = ["XR_EXT_spatial_entity"]
    )]
    Anchor = 1000762000,

    [NativeName("XR_SPATIAL_COMPONENT_TYPE_PERSISTENCE_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_persistence"],
        ImpliesSets = ["XR_EXT_future", "XR_EXT_spatial_entity"]
    )]
    Persistence = 1000763000,

    [NativeName("XR_SPATIAL_COMPONENT_TYPE_OBJECT_SEMANTIC_LABEL_ANDROID")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_spatial_object_tracking"],
        ImpliesSets = ["XR_EXT_spatial_entity"]
    )]
    ObjectSemanticLabelANDROID = 1000785000,

    [NativeName("XR_SPATIAL_COMPONENT_TYPE_RAYCAST_RESULT_ANDROID")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_spatial_discovery_raycast"],
        ImpliesSets = ["XR_EXT_spatial_entity"]
    )]
    RaycastResultANDROID = 1000786000,

    [NativeName("XR_SPATIAL_COMPONENT_TYPE_SUBSUMED_BY_ANDROID")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_spatial_component_subsumed_by"],
        ImpliesSets = ["XR_EXT_spatial_entity", "XR_EXT_spatial_plane_tracking"]
    )]
    SubsumedByANDROID = 1000791000,
}
