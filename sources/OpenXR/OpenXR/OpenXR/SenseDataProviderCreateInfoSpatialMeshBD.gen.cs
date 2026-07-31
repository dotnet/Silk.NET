// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSenseDataProviderCreateInfoSpatialMeshBD")]
[SupportedApiProfile("openxr")]
public unsafe partial struct SenseDataProviderCreateInfoSpatialMeshBD
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_mesh"], ImpliesSets = ["XR_BD_spatial_sensing"])]
    public StructureType Type = StructureType.SenseDataProviderCreateInfoSpatialMeshBD;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_mesh"], ImpliesSets = ["XR_BD_spatial_sensing"])]
    public void* Next;

    [NativeName("configFlags")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_mesh"], ImpliesSets = ["XR_BD_spatial_sensing"])]
    public SpatialMeshConfigFlagsBD ConfigFlags;

    [NativeName("lod")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_mesh"], ImpliesSets = ["XR_BD_spatial_sensing"])]
    public SpatialMeshLodBD Lod;

    [SupportedApiProfile("openxr", ["XR_BD_spatial_mesh"], ImpliesSets = ["XR_BD_spatial_sensing"])]
    public SenseDataProviderCreateInfoSpatialMeshBD() { }
}
