// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSpatialAnchorSpaceCreateInfoMSFT")]
[SupportedApiProfile("openxr")]
public unsafe partial struct SpatialAnchorSpaceCreateInfoMSFT
{
    [NativeName("type")]
    [SupportedApiProfile("openxr")]
    public StructureType Type = StructureType.TypeSpatialAnchorSpaceCreateInfoMSFT;

    [NativeName("next")]
    [SupportedApiProfile("openxr")]
    public void* Next;

    [NativeName("anchor")]
    [SupportedApiProfile("openxr")]
    public SpatialAnchorHandleMSFT Anchor;

    [NativeName("poseInAnchorSpace")]
    [SupportedApiProfile("openxr")]
    public Posef PoseInAnchorSpace;

    [SupportedApiProfile("openxr")]
    public SpatialAnchorSpaceCreateInfoMSFT() { }
}
