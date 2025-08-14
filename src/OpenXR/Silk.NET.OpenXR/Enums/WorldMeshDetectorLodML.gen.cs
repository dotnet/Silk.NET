// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrWorldMeshDetectorLodML")]
    public enum WorldMeshDetectorLodML : int
    {
        [Obsolete("Deprecated in favour of \"MinimumML\"")]
        [NativeName("Name", "XR_WORLD_MESH_DETECTOR_LOD_MINIMUM_ML")]
        WorldMeshDetectorLodMinimumML = 0,
        [Obsolete("Deprecated in favour of \"MediumML\"")]
        [NativeName("Name", "XR_WORLD_MESH_DETECTOR_LOD_MEDIUM_ML")]
        WorldMeshDetectorLodMediumML = 1,
        [Obsolete("Deprecated in favour of \"MaximumML\"")]
        [NativeName("Name", "XR_WORLD_MESH_DETECTOR_LOD_MAXIMUM_ML")]
        WorldMeshDetectorLodMaximumML = 2,
        [NativeName("Name", "XR_WORLD_MESH_DETECTOR_LOD_MINIMUM_ML")]
        MinimumML = 0,
        [NativeName("Name", "XR_WORLD_MESH_DETECTOR_LOD_MEDIUM_ML")]
        MediumML = 1,
        [NativeName("Name", "XR_WORLD_MESH_DETECTOR_LOD_MAXIMUM_ML")]
        MaximumML = 2,
    }
}
