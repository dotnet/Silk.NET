// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSystemSpatialEntitySharingPropertiesMETA")]
[SupportedApiProfile("openxr")]
public unsafe partial struct SystemSpatialEntitySharingPropertiesMETA
{
    [NativeName("type")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_spatial_entity_sharing"],
        ImpliesSets = ["XR_FB_spatial_entity"]
    )]
    public StructureType Type = StructureType.SystemSpatialEntitySharingPropertiesMETA;

    [NativeName("next")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_spatial_entity_sharing"],
        ImpliesSets = ["XR_FB_spatial_entity"]
    )]
    public void* Next;

    [NativeName("supportsSpatialEntitySharing")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_spatial_entity_sharing"],
        ImpliesSets = ["XR_FB_spatial_entity"]
    )]
    public MaybeBool<uint> SupportsSpatialEntitySharing;

    [SupportedApiProfile(
        "openxr",
        ["XR_META_spatial_entity_sharing"],
        ImpliesSets = ["XR_FB_spatial_entity"]
    )]
    public SystemSpatialEntitySharingPropertiesMETA() { }
}
