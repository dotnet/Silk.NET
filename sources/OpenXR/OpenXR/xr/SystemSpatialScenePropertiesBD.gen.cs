// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSystemSpatialScenePropertiesBD")]
[SupportedApiProfile("openxr")]
public unsafe partial struct SystemSpatialScenePropertiesBD
{
    [NativeName("type")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_scene"],
        ImpliesSets = ["XR_BD_spatial_sensing"]
    )]
    public StructureType Type = StructureType.SystemSpatialScenePropertiesBD;

    [NativeName("next")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_scene"],
        ImpliesSets = ["XR_BD_spatial_sensing"]
    )]
    public void* Next;

    [NativeName("supportsSpatialScene")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_scene"],
        ImpliesSets = ["XR_BD_spatial_sensing"]
    )]
    public MaybeBool<uint> SupportsSpatialScene;

    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_scene"],
        ImpliesSets = ["XR_BD_spatial_sensing"]
    )]
    public SystemSpatialScenePropertiesBD() { }
}
