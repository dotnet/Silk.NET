// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSpaceTriangleMeshGetInfoMETA")]
[SupportedApiProfile("openxr")]
public unsafe partial struct SpaceTriangleMeshGetInfoMETA
{
    [NativeName("type")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_spatial_entity_mesh"],
        ImpliesSets = ["XR_FB_spatial_entity", "XR_VERSION_1_0"]
    )]
    public StructureType Type = StructureType.SpaceTriangleMeshGetInfoMETA;

    [NativeName("next")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_spatial_entity_mesh"],
        ImpliesSets = ["XR_FB_spatial_entity", "XR_VERSION_1_0"]
    )]
    public void* Next;

    [SupportedApiProfile(
        "openxr",
        ["XR_META_spatial_entity_mesh"],
        ImpliesSets = ["XR_FB_spatial_entity", "XR_VERSION_1_0"]
    )]
    public SpaceTriangleMeshGetInfoMETA() { }
}
