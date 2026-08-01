// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSpatialCapabilityComponentTypesEXT")]
[SupportedApiProfile("openxr")]
public unsafe partial struct SpatialCapabilityComponentTypesEXT
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_EXT_spatial_entity"], ImpliesSets = ["XR_EXT_future"])]
    public StructureType Type = StructureType.SpatialCapabilityComponentTypesEXT;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_EXT_spatial_entity"], ImpliesSets = ["XR_EXT_future"])]
    public void* Next;

    [NativeName("componentTypeCapacityInput")]
    [SupportedApiProfile("openxr", ["XR_EXT_spatial_entity"], ImpliesSets = ["XR_EXT_future"])]
    public uint ComponentTypeCapacityInput;

    [NativeName("componentTypeCountOutput")]
    [SupportedApiProfile("openxr", ["XR_EXT_spatial_entity"], ImpliesSets = ["XR_EXT_future"])]
    public uint ComponentTypeCountOutput;

    [NativeName("componentTypes")]
    [SupportedApiProfile("openxr", ["XR_EXT_spatial_entity"], ImpliesSets = ["XR_EXT_future"])]
    public SpatialComponentTypeEXT* ComponentTypes;

    [SupportedApiProfile("openxr", ["XR_EXT_spatial_entity"], ImpliesSets = ["XR_EXT_future"])]
    public SpatialCapabilityComponentTypesEXT() { }
}
