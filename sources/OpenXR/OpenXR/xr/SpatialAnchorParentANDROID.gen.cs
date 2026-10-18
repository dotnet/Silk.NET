// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSpatialAnchorParentANDROID")]
[SupportedApiProfile("openxr")]
public unsafe partial struct SpatialAnchorParentANDROID
{
    [NativeName("type")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_spatial_entity_bound_anchor"],
        ImpliesSets = ["XR_EXT_spatial_anchor"]
    )]
    public StructureType Type = StructureType.SpatialAnchorParentANDROID;

    [NativeName("next")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_spatial_entity_bound_anchor"],
        ImpliesSets = ["XR_EXT_spatial_anchor"]
    )]
    public void* Next;

    [NativeName("parentId")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_spatial_entity_bound_anchor"],
        ImpliesSets = ["XR_EXT_spatial_anchor"]
    )]
    public ulong ParentId;

    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_spatial_entity_bound_anchor"],
        ImpliesSets = ["XR_EXT_spatial_anchor"]
    )]
    public SpatialAnchorParentANDROID() { }
}
