// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSpatialAnchorCreateInfoHTC")]
[SupportedApiProfile("openxr")]
public unsafe partial struct SpatialAnchorCreateInfoHTC
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_HTC_anchor"])]
    public StructureType Type = StructureType.SpatialAnchorCreateInfoHTC;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_HTC_anchor"])]
    public void* Next;

    [NativeName("space")]
    [SupportedApiProfile("openxr", ["XR_HTC_anchor"])]
    public SpaceHandle Space;

    [NativeName("poseInSpace")]
    [SupportedApiProfile("openxr", ["XR_HTC_anchor"])]
    public Posef PoseInSpace;

    [NativeName("name")]
    [SupportedApiProfile("openxr", ["XR_HTC_anchor"])]
    public SpatialAnchorNameHTC Name;

    [SupportedApiProfile("openxr", ["XR_HTC_anchor"])]
    public SpatialAnchorCreateInfoHTC() { }
}
