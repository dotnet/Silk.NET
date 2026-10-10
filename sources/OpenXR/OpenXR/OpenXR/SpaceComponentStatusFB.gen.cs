// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSpaceComponentStatusFB")]
[SupportedApiProfile("openxr")]
public unsafe partial struct SpaceComponentStatusFB
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_FB_spatial_entity"])]
    public StructureType Type = StructureType.SpaceComponentStatusFB;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_FB_spatial_entity"])]
    public void* Next;

    [NativeName("enabled")]
    [SupportedApiProfile("openxr", ["XR_FB_spatial_entity"])]
    public MaybeBool<uint> Enabled;

    [NativeName("changePending")]
    [SupportedApiProfile("openxr", ["XR_FB_spatial_entity"])]
    public MaybeBool<uint> ChangePending;

    [SupportedApiProfile("openxr", ["XR_FB_spatial_entity"])]
    public SpaceComponentStatusFB() { }
}
