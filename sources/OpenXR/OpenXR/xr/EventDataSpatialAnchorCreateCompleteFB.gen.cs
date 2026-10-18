// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrEventDataSpatialAnchorCreateCompleteFB")]
[SupportedApiProfile("openxr")]
public unsafe partial struct EventDataSpatialAnchorCreateCompleteFB
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_FB_spatial_entity"])]
    public StructureType Type = StructureType.EventDataSpatialAnchorCreateCompleteFB;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_FB_spatial_entity"])]
    public void* Next;

    [NativeName("requestId")]
    [SupportedApiProfile("openxr", ["XR_FB_spatial_entity"])]
    public ulong RequestId;

    [NativeName("result")]
    [SupportedApiProfile("openxr", ["XR_FB_spatial_entity"])]
    public Result Result;

    [NativeName("space")]
    [SupportedApiProfile("openxr", ["XR_FB_spatial_entity"])]
    public SpaceHandle Space;

    [NativeName("uuid")]
    [SupportedApiProfile("openxr", ["XR_FB_spatial_entity"])]
    public Uuid Uuid;

    [SupportedApiProfile("openxr", ["XR_FB_spatial_entity"])]
    public EventDataSpatialAnchorCreateCompleteFB() { }
}
