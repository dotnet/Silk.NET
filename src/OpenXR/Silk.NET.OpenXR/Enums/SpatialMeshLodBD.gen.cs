// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrSpatialMeshLodBD")]
    public enum SpatialMeshLodBD : int
    {
        [Obsolete("Deprecated in favour of \"CoarseBD\"")]
        [NativeName("Name", "XR_SPATIAL_MESH_LOD_COARSE_BD")]
        SpatialMeshLodCoarseBD = 0,
        [Obsolete("Deprecated in favour of \"MediumBD\"")]
        [NativeName("Name", "XR_SPATIAL_MESH_LOD_MEDIUM_BD")]
        SpatialMeshLodMediumBD = 1,
        [Obsolete("Deprecated in favour of \"FineBD\"")]
        [NativeName("Name", "XR_SPATIAL_MESH_LOD_FINE_BD")]
        SpatialMeshLodFineBD = 2,
        [NativeName("Name", "XR_SPATIAL_MESH_LOD_COARSE_BD")]
        CoarseBD = 0,
        [NativeName("Name", "XR_SPATIAL_MESH_LOD_MEDIUM_BD")]
        MediumBD = 1,
        [NativeName("Name", "XR_SPATIAL_MESH_LOD_FINE_BD")]
        FineBD = 2,
    }
}
