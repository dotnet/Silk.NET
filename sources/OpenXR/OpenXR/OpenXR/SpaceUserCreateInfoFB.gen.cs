// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSpaceUserCreateInfoFB")]
[SupportedApiProfile("openxr")]
public unsafe partial struct SpaceUserCreateInfoFB
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_FB_spatial_entity_user"])]
    public StructureType Type = StructureType.TypeSpaceUserCreateInfoFB;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_FB_spatial_entity_user"])]
    public void* Next;

    [NativeName("userId")]
    [SupportedApiProfile("openxr", ["XR_FB_spatial_entity_user"])]
    public ulong UserId;

    [SupportedApiProfile("openxr", ["XR_FB_spatial_entity_user"])]
    public SpaceUserCreateInfoFB() { }
}
