// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSpatialCapabilityConfigurationObjectTrackingANDROID")]
public unsafe partial struct SpatialCapabilityConfigurationObjectTrackingANDROID
{
    [NativeName("type")]
    public StructureType Type = StructureType.SpatialCapabilityConfigurationObjectTrackingANDROID;

    [NativeName("next")]
    public void* Next;

    [NativeName("capability")]
    public SpatialCapabilityEXT Capability;

    [NativeName("enabledComponentCount")]
    public uint EnabledComponentCount;

    [NativeName("enabledComponents")]
    public SpatialComponentTypeEXT* EnabledComponents;

    [NativeName("activeSemanticLabelCount")]
    public uint ActiveSemanticLabelCount;

    [NativeName("activeSemanticLabels")]
    public SpatialObjectSemanticLabelANDROID* ActiveSemanticLabels;

    public SpatialCapabilityConfigurationObjectTrackingANDROID() { }
}
