// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSpatialGraphStaticNodeBindingCreateInfoMSFT")]
[SupportedApiProfile("openxr")]
public unsafe partial struct SpatialGraphStaticNodeBindingCreateInfoMSFT
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_MSFT_spatial_graph_bridge"])]
    public StructureType Type = StructureType.TypeSpatialGraphStaticNodeBindingCreateInfoMSFT;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_MSFT_spatial_graph_bridge"])]
    public void* Next;

    [NativeName("space")]
    [SupportedApiProfile("openxr", ["XR_MSFT_spatial_graph_bridge"])]
    public SpaceHandle Space;

    [NativeName("poseInSpace")]
    [SupportedApiProfile("openxr", ["XR_MSFT_spatial_graph_bridge"])]
    public Posef PoseInSpace;

    [NativeName("time")]
    [SupportedApiProfile("openxr", ["XR_MSFT_spatial_graph_bridge"])]
    public long Time;

    [SupportedApiProfile("openxr", ["XR_MSFT_spatial_graph_bridge"])]
    public SpatialGraphStaticNodeBindingCreateInfoMSFT() { }
}
