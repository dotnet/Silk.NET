// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrSpatialPlaneSemanticLabelEXT")]
    public enum SpatialPlaneSemanticLabelEXT : int
    {
        [Obsolete("Deprecated in favour of \"UncategorizedExt\"")]
        [NativeName("Name", "XR_SPATIAL_PLANE_SEMANTIC_LABEL_UNCATEGORIZED_EXT")]
        SpatialPlaneSemanticLabelUncategorizedExt = 1,
        [Obsolete("Deprecated in favour of \"FloorExt\"")]
        [NativeName("Name", "XR_SPATIAL_PLANE_SEMANTIC_LABEL_FLOOR_EXT")]
        SpatialPlaneSemanticLabelFloorExt = 2,
        [Obsolete("Deprecated in favour of \"WallExt\"")]
        [NativeName("Name", "XR_SPATIAL_PLANE_SEMANTIC_LABEL_WALL_EXT")]
        SpatialPlaneSemanticLabelWallExt = 3,
        [Obsolete("Deprecated in favour of \"CeilingExt\"")]
        [NativeName("Name", "XR_SPATIAL_PLANE_SEMANTIC_LABEL_CEILING_EXT")]
        SpatialPlaneSemanticLabelCeilingExt = 4,
        [Obsolete("Deprecated in favour of \"TableExt\"")]
        [NativeName("Name", "XR_SPATIAL_PLANE_SEMANTIC_LABEL_TABLE_EXT")]
        SpatialPlaneSemanticLabelTableExt = 5,
        [NativeName("Name", "XR_SPATIAL_PLANE_SEMANTIC_LABEL_UNCATEGORIZED_EXT")]
        UncategorizedExt = 1,
        [NativeName("Name", "XR_SPATIAL_PLANE_SEMANTIC_LABEL_FLOOR_EXT")]
        FloorExt = 2,
        [NativeName("Name", "XR_SPATIAL_PLANE_SEMANTIC_LABEL_WALL_EXT")]
        WallExt = 3,
        [NativeName("Name", "XR_SPATIAL_PLANE_SEMANTIC_LABEL_CEILING_EXT")]
        CeilingExt = 4,
        [NativeName("Name", "XR_SPATIAL_PLANE_SEMANTIC_LABEL_TABLE_EXT")]
        TableExt = 5,
    }
}
