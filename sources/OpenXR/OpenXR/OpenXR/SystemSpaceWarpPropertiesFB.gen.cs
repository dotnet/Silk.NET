// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSystemSpaceWarpPropertiesFB")]
[SupportedApiProfile("openxr")]
public unsafe partial struct SystemSpaceWarpPropertiesFB
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_FB_space_warp"])]
    public StructureType Type = StructureType.TypeSystemSpaceWarpPropertiesFB;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_FB_space_warp"])]
    public void* Next;

    [NativeName("recommendedMotionVectorImageRectWidth")]
    [SupportedApiProfile("openxr", ["XR_FB_space_warp"])]
    public uint RecommendedMotionVectorImageRectWidth;

    [NativeName("recommendedMotionVectorImageRectHeight")]
    [SupportedApiProfile("openxr", ["XR_FB_space_warp"])]
    public uint RecommendedMotionVectorImageRectHeight;

    [SupportedApiProfile("openxr", ["XR_FB_space_warp"])]
    public SystemSpaceWarpPropertiesFB() { }
}
