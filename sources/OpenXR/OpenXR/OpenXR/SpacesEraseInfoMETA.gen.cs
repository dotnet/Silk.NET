// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSpacesEraseInfoMETA")]
[SupportedApiProfile("openxr")]
public unsafe partial struct SpacesEraseInfoMETA
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_META_spatial_entity_persistence"])]
    public StructureType Type = StructureType.SpacesEraseInfoMETA;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_META_spatial_entity_persistence"])]
    public void* Next;

    [NativeName("spaceCount")]
    [SupportedApiProfile("openxr", ["XR_META_spatial_entity_persistence"])]
    public uint SpaceCount;

    [NativeName("spaces")]
    [SupportedApiProfile("openxr", ["XR_META_spatial_entity_persistence"])]
    public SpaceHandle* Spaces;

    [NativeName("uuidCount")]
    [SupportedApiProfile("openxr", ["XR_META_spatial_entity_persistence"])]
    public uint UuidCount;

    [NativeName("uuids")]
    [SupportedApiProfile("openxr", ["XR_META_spatial_entity_persistence"])]
    public Uuid* Uuids;

    [SupportedApiProfile("openxr", ["XR_META_spatial_entity_persistence"])]
    public SpacesEraseInfoMETA() { }
}
