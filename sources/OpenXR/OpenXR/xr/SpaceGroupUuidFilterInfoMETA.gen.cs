// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSpaceGroupUuidFilterInfoMETA")]
[SupportedApiProfile("openxr")]
public unsafe partial struct SpaceGroupUuidFilterInfoMETA
{
    [NativeName("type")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_spatial_entity_query", "XR_META_spatial_entity_group_sharing"],
        RequireAll = true
    )]
    public StructureType Type = StructureType.SpaceGroupUuidFilterInfoMETA;

    [NativeName("next")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_spatial_entity_query", "XR_META_spatial_entity_group_sharing"],
        RequireAll = true
    )]
    public void* Next;

    [NativeName("groupUuid")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_spatial_entity_query", "XR_META_spatial_entity_group_sharing"],
        RequireAll = true
    )]
    public Uuid GroupUuid;

    [SupportedApiProfile(
        "openxr",
        ["XR_FB_spatial_entity_query", "XR_META_spatial_entity_group_sharing"],
        RequireAll = true
    )]
    public SpaceGroupUuidFilterInfoMETA() { }
}
