// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrMeshComputeLodMSFT")]
    public enum MeshComputeLodMSFT : int
    {
        [NativeName("Name", "XR_MESH_COMPUTE_LOD_COARSE_MSFT")]
        MeshComputeLodCoarseMsft = 1,
        [NativeName("Name", "XR_MESH_COMPUTE_LOD_MEDIUM_MSFT")]
        MeshComputeLodMediumMsft = 2,
        [NativeName("Name", "XR_MESH_COMPUTE_LOD_FINE_MSFT")]
        MeshComputeLodFineMsft = 3,
        [NativeName("Name", "XR_MESH_COMPUTE_LOD_UNLIMITED_MSFT")]
        MeshComputeLodUnlimitedMsft = 4,
    }
}
