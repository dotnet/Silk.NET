// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [Flags]
    [NativeName("Name", "XrMeshComputeLodMSFT")]
    public enum MeshComputeLodMSFT : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"CoarseMsft\"")]
        [NativeName("Name", "XR_MESH_COMPUTE_LOD_COARSE_MSFT")]
        MeshComputeLodCoarseMsft = 1,
        [Obsolete("Deprecated in favour of \"MediumMsft\"")]
        [NativeName("Name", "XR_MESH_COMPUTE_LOD_MEDIUM_MSFT")]
        MeshComputeLodMediumMsft = 2,
        [Obsolete("Deprecated in favour of \"FineMsft\"")]
        [NativeName("Name", "XR_MESH_COMPUTE_LOD_FINE_MSFT")]
        MeshComputeLodFineMsft = 3,
        [Obsolete("Deprecated in favour of \"UnlimitedMsft\"")]
        [NativeName("Name", "XR_MESH_COMPUTE_LOD_UNLIMITED_MSFT")]
        MeshComputeLodUnlimitedMsft = 4,
        [NativeName("Name", "XR_MESH_COMPUTE_LOD_COARSE_MSFT")]
        CoarseMsft = 1,
        [NativeName("Name", "XR_MESH_COMPUTE_LOD_MEDIUM_MSFT")]
        MediumMsft = 2,
        [NativeName("Name", "XR_MESH_COMPUTE_LOD_FINE_MSFT")]
        FineMsft = 3,
        [NativeName("Name", "XR_MESH_COMPUTE_LOD_UNLIMITED_MSFT")]
        UnlimitedMsft = 4,
    }
}
