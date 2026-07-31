// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSpatialUpdateSnapshotCreateInfoEXT")]
[SupportedApiProfile("openxr")]
public unsafe partial struct SpatialUpdateSnapshotCreateInfoEXT
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_EXT_spatial_entity"], ImpliesSets = ["XR_EXT_future"])]
    public StructureType Type = StructureType.SpatialUpdateSnapshotCreateInfoEXT;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_EXT_spatial_entity"], ImpliesSets = ["XR_EXT_future"])]
    public void* Next;

    [NativeName("entityCount")]
    [SupportedApiProfile("openxr", ["XR_EXT_spatial_entity"], ImpliesSets = ["XR_EXT_future"])]
    public uint EntityCount;

    [NativeName("entities")]
    [SupportedApiProfile("openxr", ["XR_EXT_spatial_entity"], ImpliesSets = ["XR_EXT_future"])]
    public SpatialEntityHandleEXT* Entities;

    [NativeName("componentTypeCount")]
    [SupportedApiProfile("openxr", ["XR_EXT_spatial_entity"], ImpliesSets = ["XR_EXT_future"])]
    public uint ComponentTypeCount;

    [NativeName("componentTypes")]
    [SupportedApiProfile("openxr", ["XR_EXT_spatial_entity"], ImpliesSets = ["XR_EXT_future"])]
    public SpatialComponentTypeEXT* ComponentTypes;

    [NativeName("baseSpace")]
    [SupportedApiProfile("openxr", ["XR_EXT_spatial_entity"], ImpliesSets = ["XR_EXT_future"])]
    public SpaceHandle BaseSpace;

    [NativeName("time")]
    [SupportedApiProfile("openxr", ["XR_EXT_spatial_entity"], ImpliesSets = ["XR_EXT_future"])]
    public long Time;

    [SupportedApiProfile("openxr", ["XR_EXT_spatial_entity"], ImpliesSets = ["XR_EXT_future"])]
    public SpatialUpdateSnapshotCreateInfoEXT() { }
}
