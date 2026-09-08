// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSpaceShareInfoFB")]
[SupportedApiProfile("openxr")]
public unsafe partial struct SpaceShareInfoFB
{
    [NativeName("type")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_spatial_entity_sharing"],
        ImpliesSets = ["XR_FB_spatial_entity", "XR_VERSION_1_0"]
    )]
    public StructureType Type = StructureType.SpaceShareInfoFB;

    [NativeName("next")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_spatial_entity_sharing"],
        ImpliesSets = ["XR_FB_spatial_entity", "XR_VERSION_1_0"]
    )]
    public void* Next;

    [NativeName("spaceCount")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_spatial_entity_sharing"],
        ImpliesSets = ["XR_FB_spatial_entity", "XR_VERSION_1_0"]
    )]
    public uint SpaceCount;

    [NativeName("spaces")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_spatial_entity_sharing"],
        ImpliesSets = ["XR_FB_spatial_entity", "XR_VERSION_1_0"]
    )]
    public SpaceHandle* Spaces;

    [NativeName("userCount")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_spatial_entity_sharing"],
        ImpliesSets = ["XR_FB_spatial_entity", "XR_VERSION_1_0"]
    )]
    public uint UserCount;

    [NativeName("users")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_spatial_entity_sharing"],
        ImpliesSets = ["XR_FB_spatial_entity", "XR_VERSION_1_0"]
    )]
    public SpaceUserHandleFB* Users;

    [SupportedApiProfile(
        "openxr",
        ["XR_FB_spatial_entity_sharing"],
        ImpliesSets = ["XR_FB_spatial_entity", "XR_VERSION_1_0"]
    )]
    public SpaceShareInfoFB() { }
}
