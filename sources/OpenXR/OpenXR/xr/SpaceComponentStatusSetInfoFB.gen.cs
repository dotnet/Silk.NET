// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSpaceComponentStatusSetInfoFB")]
[SupportedApiProfile("openxr")]
public unsafe partial struct SpaceComponentStatusSetInfoFB
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_FB_spatial_entity"])]
    public StructureType Type = StructureType.SpaceComponentStatusSetInfoFB;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_FB_spatial_entity"])]
    public void* Next;

    [NativeName("componentType")]
    [SupportedApiProfile("openxr", ["XR_FB_spatial_entity"])]
    public SpaceComponentTypeFB ComponentType;

    [NativeName("enabled")]
    [SupportedApiProfile("openxr", ["XR_FB_spatial_entity"])]
    public MaybeBool<uint> Enabled;

    [NativeName("timeout")]
    [SupportedApiProfile("openxr", ["XR_FB_spatial_entity"])]
    public long Timeout;

    [SupportedApiProfile("openxr", ["XR_FB_spatial_entity"])]
    public SpaceComponentStatusSetInfoFB() { }
}
