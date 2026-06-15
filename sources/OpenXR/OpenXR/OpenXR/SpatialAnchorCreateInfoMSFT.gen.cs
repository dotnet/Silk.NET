// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSpatialAnchorCreateInfoMSFT")]
[SupportedApiProfile("openxr")]
public unsafe partial struct SpatialAnchorCreateInfoMSFT
{
    [NativeName("type")]
    [SupportedApiProfile("openxr")]
    public StructureType Type = StructureType.TypeSpatialAnchorCreateInfoMSFT;

    [NativeName("next")]
    [SupportedApiProfile("openxr")]
    public void* Next;

    [NativeName("space")]
    [SupportedApiProfile("openxr")]
    public SpaceHandle Space;

    [NativeName("pose")]
    [SupportedApiProfile("openxr")]
    public Posef Pose;

    [NativeName("time")]
    [SupportedApiProfile("openxr")]
    public long Time;

    [SupportedApiProfile("openxr")]
    public SpatialAnchorCreateInfoMSFT() { }
}
