// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSystemSpacePersistencePropertiesMETA")]
[SupportedApiProfile("openxr")]
public unsafe partial struct SystemSpacePersistencePropertiesMETA
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_META_spatial_entity_persistence"])]
    public StructureType Type = StructureType.TypeSystemSpacePersistencePropertiesMETA;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_META_spatial_entity_persistence"])]
    public void* Next;

    [NativeName("supportsSpacePersistence")]
    [SupportedApiProfile("openxr", ["XR_META_spatial_entity_persistence"])]
    public MaybeBool<uint> SupportsSpacePersistence;

    [SupportedApiProfile("openxr", ["XR_META_spatial_entity_persistence"])]
    public SystemSpacePersistencePropertiesMETA() { }
}
