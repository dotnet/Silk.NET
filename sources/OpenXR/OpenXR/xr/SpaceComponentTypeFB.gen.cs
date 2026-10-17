// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSpaceComponentTypeFB")]
public enum SpaceComponentTypeFB : uint
{
    [NativeName("XR_SPACE_COMPONENT_TYPE_LOCATABLE_FB")]
    Locatable = 0,

    [NativeName("XR_SPACE_COMPONENT_TYPE_STORABLE_FB")]
    Storable = 1,

    [NativeName("XR_SPACE_COMPONENT_TYPE_SHARABLE_FB")]
    Sharable = 2,

    [NativeName("XR_SPACE_COMPONENT_TYPE_BOUNDED_2D_FB")]
    Bounded2D = 3,

    [NativeName("XR_SPACE_COMPONENT_TYPE_BOUNDED_3D_FB")]
    Bounded3D = 4,

    [NativeName("XR_SPACE_COMPONENT_TYPE_SEMANTIC_LABELS_FB")]
    SemanticLabels = 5,

    [NativeName("XR_SPACE_COMPONENT_TYPE_ROOM_LAYOUT_FB")]
    RoomLayout = 6,

    [NativeName("XR_SPACE_COMPONENT_TYPE_SPACE_CONTAINER_FB")]
    SpaceContainer = 7,

    [NativeName("XR_SPACE_COMPONENT_TYPE_TRIANGLE_MESH_META")]
    TriangleMeshMETA = 1000269000,

    [NativeName("XR_SPACE_COMPONENT_TYPE_ROOM_MESH_META")]
    RoomMeshMETA = 1000553000,
}
