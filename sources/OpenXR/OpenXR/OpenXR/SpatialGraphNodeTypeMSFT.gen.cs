// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSpatialGraphNodeTypeMSFT")]
[SupportedApiProfile("openxr")]
public enum SpatialGraphNodeTypeMSFT : uint
{
    [NativeName("XR_SPATIAL_GRAPH_NODE_TYPE_STATIC_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_spatial_graph_bridge"])]
    Static = 1,

    [NativeName("XR_SPATIAL_GRAPH_NODE_TYPE_DYNAMIC_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_spatial_graph_bridge"])]
    Dynamic = 2,
}
