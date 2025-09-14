// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [Flags]
    [NativeName("Name", "XrSpatialMeshConfigFlagsBD")]
    public enum SpatialMeshConfigFlagsBD : long
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"SemanticBitBD\"")]
        [NativeName("Name", "XR_SPATIAL_MESH_CONFIG_SEMANTIC_BIT_BD")]
        SpatialMeshConfigSemanticBitBD = 1,
        [Obsolete("Deprecated in favour of \"AlignSemanticWithVertexBitBD\"")]
        [NativeName("Name", "XR_SPATIAL_MESH_CONFIG_ALIGN_SEMANTIC_WITH_VERTEX_BIT_BD")]
        SpatialMeshConfigAlignSemanticWithVertexBitBD = 2,
        [NativeName("Name", "XR_SPATIAL_MESH_CONFIG_SEMANTIC_BIT_BD")]
        SemanticBitBD = 1,
        [NativeName("Name", "XR_SPATIAL_MESH_CONFIG_ALIGN_SEMANTIC_WITH_VERTEX_BIT_BD")]
        AlignSemanticWithVertexBitBD = 2,
    }
}
