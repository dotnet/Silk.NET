// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSystemSpatialAnchorSharingPropertiesBD")]
[SupportedApiProfile("openxr")]
public unsafe partial struct SystemSpatialAnchorSharingPropertiesBD
{
    [NativeName("type")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_anchor_sharing"],
        ImpliesSets = ["XR_BD_spatial_anchor"]
    )]
    public StructureType Type = StructureType.SystemSpatialAnchorSharingPropertiesBD;

    [NativeName("next")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_anchor_sharing"],
        ImpliesSets = ["XR_BD_spatial_anchor"]
    )]
    public void* Next;

    [NativeName("supportsSpatialAnchorSharing")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_anchor_sharing"],
        ImpliesSets = ["XR_BD_spatial_anchor"]
    )]
    public MaybeBool<uint> SupportsSpatialAnchorSharing;

    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_anchor_sharing"],
        ImpliesSets = ["XR_BD_spatial_anchor"]
    )]
    public SystemSpatialAnchorSharingPropertiesBD() { }
}
