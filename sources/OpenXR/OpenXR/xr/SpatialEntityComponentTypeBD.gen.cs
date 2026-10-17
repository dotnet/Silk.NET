// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSpatialEntityComponentTypeBD")]
public enum SpatialEntityComponentTypeBD : uint
{
    [NativeName("XR_SPATIAL_ENTITY_COMPONENT_TYPE_LOCATION_BD")]
    Location = 0,

    [NativeName("XR_SPATIAL_ENTITY_COMPONENT_TYPE_SEMANTIC_BD")]
    Semantic = 1,

    [NativeName("XR_SPATIAL_ENTITY_COMPONENT_TYPE_BOUNDING_BOX_2D_BD")]
    BoundingBox2D = 2,

    [NativeName("XR_SPATIAL_ENTITY_COMPONENT_TYPE_POLYGON_BD")]
    Polygon = 3,

    [NativeName("XR_SPATIAL_ENTITY_COMPONENT_TYPE_BOUNDING_BOX_3D_BD")]
    BoundingBox3D = 4,

    [NativeName("XR_SPATIAL_ENTITY_COMPONENT_TYPE_TRIANGLE_MESH_BD")]
    TriangleMesh = 5,

    [NativeName("XR_SPATIAL_ENTITY_COMPONENT_TYPE_PLANE_ORIENTATION_BD")]
    PlaneOrientation = 1000396000,
}
