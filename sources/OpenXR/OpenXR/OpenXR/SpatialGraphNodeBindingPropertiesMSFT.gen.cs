// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSpatialGraphNodeBindingPropertiesMSFT")]
[SupportedApiProfile("openxr")]
public unsafe partial struct SpatialGraphNodeBindingPropertiesMSFT
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_MSFT_spatial_graph_bridge"])]
    public StructureType Type = StructureType.TypeSpatialGraphNodeBindingPropertiesMSFT;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_MSFT_spatial_graph_bridge"])]
    public void* Next;

    [NativeName("nodeId")]
    [SupportedApiProfile("openxr", ["XR_MSFT_spatial_graph_bridge"])]
    public SpatialGraphNodeBindingPropertiesMSFTNodeId NodeId;

    [NativeName("poseInNodeSpace")]
    [SupportedApiProfile("openxr", ["XR_MSFT_spatial_graph_bridge"])]
    public Posef PoseInNodeSpace;

    [SupportedApiProfile("openxr", ["XR_MSFT_spatial_graph_bridge"])]
    public SpatialGraphNodeBindingPropertiesMSFT() { }
}
