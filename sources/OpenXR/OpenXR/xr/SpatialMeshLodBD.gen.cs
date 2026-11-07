// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSpatialMeshLodBD")]
[SupportedApiProfile("openxr")]
public enum SpatialMeshLodBD : uint
{
    [NativeName("XR_SPATIAL_MESH_LOD_COARSE_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_mesh"], ImpliesSets = ["XR_BD_spatial_sensing"])]
    Coarse = 0,

    [NativeName("XR_SPATIAL_MESH_LOD_MEDIUM_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_mesh"], ImpliesSets = ["XR_BD_spatial_sensing"])]
    Medium = 1,

    [NativeName("XR_SPATIAL_MESH_LOD_FINE_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_mesh"], ImpliesSets = ["XR_BD_spatial_sensing"])]
    Fine = 2,
}
