// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSpatialComponentAnchorListEXT")]
[SupportedApiProfile("openxr")]
public unsafe partial struct SpatialComponentAnchorListEXT
{
    [NativeName("type")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_anchor"],
        ImpliesSets = ["XR_EXT_spatial_entity"]
    )]
    public StructureType Type = StructureType.SpatialComponentAnchorListEXT;

    [NativeName("next")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_anchor"],
        ImpliesSets = ["XR_EXT_spatial_entity"]
    )]
    public void* Next;

    [NativeName("locationCount")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_anchor"],
        ImpliesSets = ["XR_EXT_spatial_entity"]
    )]
    public uint LocationCount;

    [NativeName("locations")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_anchor"],
        ImpliesSets = ["XR_EXT_spatial_entity"]
    )]
    public Posef* Locations;

    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_anchor"],
        ImpliesSets = ["XR_EXT_spatial_entity"]
    )]
    public SpatialComponentAnchorListEXT() { }
}
