// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSpatialDiscoveryUniqueEntitiesFilterANDROID")]
[SupportedApiProfile("openxr")]
public unsafe partial struct SpatialDiscoveryUniqueEntitiesFilterANDROID
{
    [NativeName("type")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_spatial_component_subsumed_by"],
        ImpliesSets = ["XR_EXT_spatial_entity", "XR_EXT_spatial_plane_tracking"]
    )]
    public StructureType Type = StructureType.TypeSpatialDiscoveryUniqueEntitiesFilterANDROID;

    [NativeName("next")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_spatial_component_subsumed_by"],
        ImpliesSets = ["XR_EXT_spatial_entity", "XR_EXT_spatial_plane_tracking"]
    )]
    public void* Next;

    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_spatial_component_subsumed_by"],
        ImpliesSets = ["XR_EXT_spatial_entity", "XR_EXT_spatial_plane_tracking"]
    )]
    public SpatialDiscoveryUniqueEntitiesFilterANDROID() { }
}
