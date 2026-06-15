// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSpatialGraphNodeSpaceCreateInfoMSFT")]
[SupportedApiProfile("openxr")]
public unsafe partial struct SpatialGraphNodeSpaceCreateInfoMSFT
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_MSFT_spatial_graph_bridge"])]
    public StructureType Type = StructureType.TypeSpatialGraphNodeSpaceCreateInfoMSFT;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_MSFT_spatial_graph_bridge"])]
    public void* Next;

    [NativeName("nodeType")]
    [SupportedApiProfile("openxr", ["XR_MSFT_spatial_graph_bridge"])]
    public SpatialGraphNodeTypeMSFT NodeType;

    [NativeName("nodeId")]
    [SupportedApiProfile("openxr", ["XR_MSFT_spatial_graph_bridge"])]
    public SpatialGraphNodeSpaceCreateInfoMSFTNodeId NodeId;

    [NativeName("pose")]
    [SupportedApiProfile("openxr", ["XR_MSFT_spatial_graph_bridge"])]
    public Posef Pose;

    [SupportedApiProfile("openxr", ["XR_MSFT_spatial_graph_bridge"])]
    public SpatialGraphNodeSpaceCreateInfoMSFT() { }
}
