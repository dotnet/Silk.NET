// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSpaceComponentFilterInfoFB")]
[SupportedApiProfile("openxr")]
public unsafe partial struct SpaceComponentFilterInfoFB
{
    [NativeName("type")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_spatial_entity_query"],
        ImpliesSets = ["XR_FB_spatial_entity_storage", "XR_VERSION_1_0"]
    )]
    public StructureType Type = StructureType.SpaceComponentFilterInfoFB;

    [NativeName("next")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_spatial_entity_query"],
        ImpliesSets = ["XR_FB_spatial_entity_storage", "XR_VERSION_1_0"]
    )]
    public void* Next;

    [NativeName("componentType")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_spatial_entity_query"],
        ImpliesSets = ["XR_FB_spatial_entity_storage", "XR_VERSION_1_0"]
    )]
    public SpaceComponentTypeFB ComponentType;

    [SupportedApiProfile(
        "openxr",
        ["XR_FB_spatial_entity_query"],
        ImpliesSets = ["XR_FB_spatial_entity_storage", "XR_VERSION_1_0"]
    )]
    public SpaceComponentFilterInfoFB() { }
}
