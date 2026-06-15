// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSpaceContainerFB")]
[SupportedApiProfile("openxr")]
public unsafe partial struct SpaceContainerFB
{
    [NativeName("type")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_spatial_entity_container"],
        ImpliesSets = ["XR_FB_spatial_entity", "XR_VERSION_1_0"]
    )]
    public StructureType Type = StructureType.TypeSpaceContainerFB;

    [NativeName("next")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_spatial_entity_container"],
        ImpliesSets = ["XR_FB_spatial_entity", "XR_VERSION_1_0"]
    )]
    public void* Next;

    [NativeName("uuidCapacityInput")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_spatial_entity_container"],
        ImpliesSets = ["XR_FB_spatial_entity", "XR_VERSION_1_0"]
    )]
    public uint UuidCapacityInput;

    [NativeName("uuidCountOutput")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_spatial_entity_container"],
        ImpliesSets = ["XR_FB_spatial_entity", "XR_VERSION_1_0"]
    )]
    public uint UuidCountOutput;

    [NativeName("uuids")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_spatial_entity_container"],
        ImpliesSets = ["XR_FB_spatial_entity", "XR_VERSION_1_0"]
    )]
    public Uuid* Uuids;

    [SupportedApiProfile(
        "openxr",
        ["XR_FB_spatial_entity_container"],
        ImpliesSets = ["XR_FB_spatial_entity", "XR_VERSION_1_0"]
    )]
    public SpaceContainerFB() { }
}
