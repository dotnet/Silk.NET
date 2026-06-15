// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrEventDataSpacesEraseResultMETA")]
[SupportedApiProfile("openxr")]
public unsafe partial struct EventDataSpacesEraseResultMETA
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_META_spatial_entity_persistence"])]
    public StructureType Type = StructureType.TypeEventDataSpacesEraseResultMETA;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_META_spatial_entity_persistence"])]
    public void* Next;

    [NativeName("requestId")]
    [SupportedApiProfile("openxr", ["XR_META_spatial_entity_persistence"])]
    public ulong RequestId;

    [NativeName("result")]
    [SupportedApiProfile("openxr", ["XR_META_spatial_entity_persistence"])]
    public Result Result;

    [SupportedApiProfile("openxr", ["XR_META_spatial_entity_persistence"])]
    public EventDataSpacesEraseResultMETA() { }
}
