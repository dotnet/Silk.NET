// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrSpatialEntityComponentTypeBD")]
    public enum SpatialEntityComponentTypeBD : int
    {
        [Obsolete("Deprecated in favour of \"LocationBD\"")]
        [NativeName("Name", "XR_SPATIAL_ENTITY_COMPONENT_TYPE_LOCATION_BD")]
        SpatialEntityComponentTypeLocationBD = 0,
        [Obsolete("Deprecated in favour of \"SemanticBD\"")]
        [NativeName("Name", "XR_SPATIAL_ENTITY_COMPONENT_TYPE_SEMANTIC_BD")]
        SpatialEntityComponentTypeSemanticBD = 1,
        [Obsolete("Deprecated in favour of \"BoundingBox2DBD\"")]
        [NativeName("Name", "XR_SPATIAL_ENTITY_COMPONENT_TYPE_BOUNDING_BOX_2D_BD")]
        SpatialEntityComponentTypeBoundingBox2DBD = 2,
        [Obsolete("Deprecated in favour of \"PolygonBD\"")]
        [NativeName("Name", "XR_SPATIAL_ENTITY_COMPONENT_TYPE_POLYGON_BD")]
        SpatialEntityComponentTypePolygonBD = 3,
        [Obsolete("Deprecated in favour of \"BoundingBox3DBD\"")]
        [NativeName("Name", "XR_SPATIAL_ENTITY_COMPONENT_TYPE_BOUNDING_BOX_3D_BD")]
        SpatialEntityComponentTypeBoundingBox3DBD = 4,
        [Obsolete("Deprecated in favour of \"TriangleMeshBD\"")]
        [NativeName("Name", "XR_SPATIAL_ENTITY_COMPONENT_TYPE_TRIANGLE_MESH_BD")]
        SpatialEntityComponentTypeTriangleMeshBD = 5,
        [Obsolete("Deprecated in favour of \"PlaneOrientationBD\"")]
        [NativeName("Name", "XR_SPATIAL_ENTITY_COMPONENT_TYPE_PLANE_ORIENTATION_BD")]
        SpatialEntityComponentTypePlaneOrientationBD = 1000396000,
        [NativeName("Name", "XR_SPATIAL_ENTITY_COMPONENT_TYPE_LOCATION_BD")]
        LocationBD = 0,
        [NativeName("Name", "XR_SPATIAL_ENTITY_COMPONENT_TYPE_SEMANTIC_BD")]
        SemanticBD = 1,
        [NativeName("Name", "XR_SPATIAL_ENTITY_COMPONENT_TYPE_BOUNDING_BOX_2D_BD")]
        BoundingBox2DBD = 2,
        [NativeName("Name", "XR_SPATIAL_ENTITY_COMPONENT_TYPE_POLYGON_BD")]
        PolygonBD = 3,
        [NativeName("Name", "XR_SPATIAL_ENTITY_COMPONENT_TYPE_BOUNDING_BOX_3D_BD")]
        BoundingBox3DBD = 4,
        [NativeName("Name", "XR_SPATIAL_ENTITY_COMPONENT_TYPE_TRIANGLE_MESH_BD")]
        TriangleMeshBD = 5,
        [NativeName("Name", "XR_SPATIAL_ENTITY_COMPONENT_TYPE_PLANE_ORIENTATION_BD")]
        PlaneOrientationBD = 1000396000,
    }
}
