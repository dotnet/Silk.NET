// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSpaceComponentTypeFB")]
[SupportedApiProfile("openxr")]
public enum SpaceComponentTypeFB : uint
{
    [NativeName("XR_SPACE_COMPONENT_TYPE_LOCATABLE_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_spatial_entity"])]
    Locatable = 0,

    [NativeName("XR_SPACE_COMPONENT_TYPE_STORABLE_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_spatial_entity"])]
    Storable = 1,

    [NativeName("XR_SPACE_COMPONENT_TYPE_SHARABLE_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_spatial_entity"])]
    Sharable = 2,

    [NativeName("XR_SPACE_COMPONENT_TYPE_BOUNDED_2D_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_spatial_entity"])]
    Bounded2D = 3,

    [NativeName("XR_SPACE_COMPONENT_TYPE_BOUNDED_3D_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_spatial_entity"])]
    Bounded3D = 4,

    [NativeName("XR_SPACE_COMPONENT_TYPE_SEMANTIC_LABELS_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_spatial_entity"])]
    SemanticLabels = 5,

    [NativeName("XR_SPACE_COMPONENT_TYPE_ROOM_LAYOUT_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_spatial_entity"])]
    RoomLayout = 6,

    [NativeName("XR_SPACE_COMPONENT_TYPE_SPACE_CONTAINER_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_spatial_entity"])]
    SpaceContainer = 7,

    [NativeName("XR_SPACE_COMPONENT_TYPE_TRIANGLE_MESH_META")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_spatial_entity_mesh"],
        ImpliesSets = ["XR_FB_spatial_entity", "XR_VERSION_1_0"]
    )]
    TriangleMeshMETA = 1000269000,

    [NativeName("XR_SPACE_COMPONENT_TYPE_ROOM_MESH_META")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_spatial_entity_room_mesh"],
        ImpliesSets = [
            "XR_FB_spatial_entity",
            "XR_META_spatial_entity_semantic_label",
            "XR_VERSION_1_0",
        ]
    )]
    RoomMeshMETA = 1000553000,
}
