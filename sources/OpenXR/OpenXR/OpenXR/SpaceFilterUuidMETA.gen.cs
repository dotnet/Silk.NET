// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSpaceFilterUuidMETA")]
[SupportedApiProfile("openxr")]
public unsafe partial struct SpaceFilterUuidMETA
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_META_spatial_entity_discovery"])]
    public StructureType Type = StructureType.SpaceFilterUuidMETA;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_META_spatial_entity_discovery"])]
    public void* Next;

    [NativeName("uuidCount")]
    [SupportedApiProfile("openxr", ["XR_META_spatial_entity_discovery"])]
    public uint UuidCount;

    [NativeName("uuids")]
    [SupportedApiProfile("openxr", ["XR_META_spatial_entity_discovery"])]
    public Uuid* Uuids;

    [SupportedApiProfile("openxr", ["XR_META_spatial_entity_discovery"])]
    public SpaceFilterUuidMETA() { }
}
