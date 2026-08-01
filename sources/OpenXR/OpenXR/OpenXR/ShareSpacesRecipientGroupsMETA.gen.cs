// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrShareSpacesRecipientGroupsMETA")]
[SupportedApiProfile("openxr")]
public unsafe partial struct ShareSpacesRecipientGroupsMETA
{
    [NativeName("type")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_spatial_entity_group_sharing", "XR_META_spatial_entity_sharing"],
        RequireAll = true
    )]
    public StructureType Type = StructureType.ShareSpacesRecipientGroupsMETA;

    [NativeName("next")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_spatial_entity_group_sharing", "XR_META_spatial_entity_sharing"],
        RequireAll = true
    )]
    public void* Next;

    [NativeName("groupCount")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_spatial_entity_group_sharing", "XR_META_spatial_entity_sharing"],
        RequireAll = true
    )]
    public uint GroupCount;

    [NativeName("groups")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_spatial_entity_group_sharing", "XR_META_spatial_entity_sharing"],
        RequireAll = true
    )]
    public Uuid* Groups;

    [SupportedApiProfile(
        "openxr",
        ["XR_META_spatial_entity_group_sharing", "XR_META_spatial_entity_sharing"],
        RequireAll = true
    )]
    public ShareSpacesRecipientGroupsMETA() { }
}
