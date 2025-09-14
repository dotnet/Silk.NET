// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrSpatialComponentTypeEXT")]
    public enum SpatialComponentTypeEXT : int
    {
        [Obsolete("Deprecated in favour of \"Bounded2DExt\"")]
        [NativeName("Name", "XR_SPATIAL_COMPONENT_TYPE_BOUNDED_2D_EXT")]
        SpatialComponentTypeBounded2DExt = 1,
        [Obsolete("Deprecated in favour of \"Bounded3DExt\"")]
        [NativeName("Name", "XR_SPATIAL_COMPONENT_TYPE_BOUNDED_3D_EXT")]
        SpatialComponentTypeBounded3DExt = 2,
        [Obsolete("Deprecated in favour of \"ParentExt\"")]
        [NativeName("Name", "XR_SPATIAL_COMPONENT_TYPE_PARENT_EXT")]
        SpatialComponentTypeParentExt = 3,
        [Obsolete("Deprecated in favour of \"Mesh3DExt\"")]
        [NativeName("Name", "XR_SPATIAL_COMPONENT_TYPE_MESH_3D_EXT")]
        SpatialComponentTypeMesh3DExt = 4,
        [Obsolete("Deprecated in favour of \"PlaneAlignmentExt\"")]
        [NativeName("Name", "XR_SPATIAL_COMPONENT_TYPE_PLANE_ALIGNMENT_EXT")]
        SpatialComponentTypePlaneAlignmentExt = 1000741000,
        [Obsolete("Deprecated in favour of \"Mesh2DExt\"")]
        [NativeName("Name", "XR_SPATIAL_COMPONENT_TYPE_MESH_2D_EXT")]
        SpatialComponentTypeMesh2DExt = 1000741001,
        [Obsolete("Deprecated in favour of \"Polygon2DExt\"")]
        [NativeName("Name", "XR_SPATIAL_COMPONENT_TYPE_POLYGON_2D_EXT")]
        SpatialComponentTypePolygon2DExt = 1000741002,
        [Obsolete("Deprecated in favour of \"PlaneSemanticLabelExt\"")]
        [NativeName("Name", "XR_SPATIAL_COMPONENT_TYPE_PLANE_SEMANTIC_LABEL_EXT")]
        SpatialComponentTypePlaneSemanticLabelExt = 1000741003,
        [Obsolete("Deprecated in favour of \"MarkerExt\"")]
        [NativeName("Name", "XR_SPATIAL_COMPONENT_TYPE_MARKER_EXT")]
        SpatialComponentTypeMarkerExt = 1000743000,
        [Obsolete("Deprecated in favour of \"AnchorExt\"")]
        [NativeName("Name", "XR_SPATIAL_COMPONENT_TYPE_ANCHOR_EXT")]
        SpatialComponentTypeAnchorExt = 1000762000,
        [Obsolete("Deprecated in favour of \"PersistenceExt\"")]
        [NativeName("Name", "XR_SPATIAL_COMPONENT_TYPE_PERSISTENCE_EXT")]
        SpatialComponentTypePersistenceExt = 1000763000,
        [NativeName("Name", "XR_SPATIAL_COMPONENT_TYPE_BOUNDED_2D_EXT")]
        Bounded2DExt = 1,
        [NativeName("Name", "XR_SPATIAL_COMPONENT_TYPE_BOUNDED_3D_EXT")]
        Bounded3DExt = 2,
        [NativeName("Name", "XR_SPATIAL_COMPONENT_TYPE_PARENT_EXT")]
        ParentExt = 3,
        [NativeName("Name", "XR_SPATIAL_COMPONENT_TYPE_MESH_3D_EXT")]
        Mesh3DExt = 4,
        [NativeName("Name", "XR_SPATIAL_COMPONENT_TYPE_PLANE_ALIGNMENT_EXT")]
        PlaneAlignmentExt = 1000741000,
        [NativeName("Name", "XR_SPATIAL_COMPONENT_TYPE_MESH_2D_EXT")]
        Mesh2DExt = 1000741001,
        [NativeName("Name", "XR_SPATIAL_COMPONENT_TYPE_POLYGON_2D_EXT")]
        Polygon2DExt = 1000741002,
        [NativeName("Name", "XR_SPATIAL_COMPONENT_TYPE_PLANE_SEMANTIC_LABEL_EXT")]
        PlaneSemanticLabelExt = 1000741003,
        [NativeName("Name", "XR_SPATIAL_COMPONENT_TYPE_MARKER_EXT")]
        MarkerExt = 1000743000,
        [NativeName("Name", "XR_SPATIAL_COMPONENT_TYPE_ANCHOR_EXT")]
        AnchorExt = 1000762000,
        [NativeName("Name", "XR_SPATIAL_COMPONENT_TYPE_PERSISTENCE_EXT")]
        PersistenceExt = 1000763000,
    }
}
