// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSpatialComponentTypeEXT")]
public enum SpatialComponentTypeEXT : uint
{
    [NativeName("XR_SPATIAL_COMPONENT_TYPE_BOUNDED_2D_EXT")]
    Bounded2D = 1,

    [NativeName("XR_SPATIAL_COMPONENT_TYPE_BOUNDED_3D_EXT")]
    Bounded3D = 2,

    [NativeName("XR_SPATIAL_COMPONENT_TYPE_PARENT_EXT")]
    Parent = 3,

    [NativeName("XR_SPATIAL_COMPONENT_TYPE_MESH_3D_EXT")]
    Mesh3D = 4,

    [NativeName("XR_SPATIAL_COMPONENT_TYPE_PLANE_ALIGNMENT_EXT")]
    PlaneAlignment = 1000741000,

    [NativeName("XR_SPATIAL_COMPONENT_TYPE_MESH_2D_EXT")]
    Mesh2D = 1000741001,

    [NativeName("XR_SPATIAL_COMPONENT_TYPE_POLYGON_2D_EXT")]
    Polygon2D = 1000741002,

    [NativeName("XR_SPATIAL_COMPONENT_TYPE_PLANE_SEMANTIC_LABEL_EXT")]
    PlaneSemanticLabel = 1000741003,

    [NativeName("XR_SPATIAL_COMPONENT_TYPE_MARKER_EXT")]
    Marker = 1000743000,

    [NativeName("XR_SPATIAL_COMPONENT_TYPE_ANCHOR_EXT")]
    Anchor = 1000762000,

    [NativeName("XR_SPATIAL_COMPONENT_TYPE_PERSISTENCE_EXT")]
    Persistence = 1000763000,

    [NativeName("XR_SPATIAL_COMPONENT_TYPE_OBJECT_SEMANTIC_LABEL_ANDROID")]
    ObjectSemanticLabelANDROID = 1000785000,

    [NativeName("XR_SPATIAL_COMPONENT_TYPE_RAYCAST_RESULT_ANDROID")]
    RaycastResultANDROID = 1000786000,

    [NativeName("XR_SPATIAL_COMPONENT_TYPE_SUBSUMED_BY_ANDROID")]
    SubsumedByANDROID = 1000791000,
}
