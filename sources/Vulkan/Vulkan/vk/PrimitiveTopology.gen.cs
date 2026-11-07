// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPrimitiveTopology")]
public enum PrimitiveTopology : uint
{
    [NativeName("VK_PRIMITIVE_TOPOLOGY_POINT_LIST")]
    PointList = 0,

    [NativeName("VK_PRIMITIVE_TOPOLOGY_LINE_LIST")]
    LineList = 1,

    [NativeName("VK_PRIMITIVE_TOPOLOGY_LINE_STRIP")]
    LineStrip = 2,

    [NativeName("VK_PRIMITIVE_TOPOLOGY_TRIANGLE_LIST")]
    TriangleList = 3,

    [NativeName("VK_PRIMITIVE_TOPOLOGY_TRIANGLE_STRIP")]
    TriangleStrip = 4,

    [NativeName("VK_PRIMITIVE_TOPOLOGY_TRIANGLE_FAN")]
    TriangleFan = 5,

    [NativeName("VK_PRIMITIVE_TOPOLOGY_LINE_LIST_WITH_ADJACENCY")]
    LineListWithAdjacency = 6,

    [NativeName("VK_PRIMITIVE_TOPOLOGY_LINE_STRIP_WITH_ADJACENCY")]
    LineStripWithAdjacency = 7,

    [NativeName("VK_PRIMITIVE_TOPOLOGY_TRIANGLE_LIST_WITH_ADJACENCY")]
    TriangleListWithAdjacency = 8,

    [NativeName("VK_PRIMITIVE_TOPOLOGY_TRIANGLE_STRIP_WITH_ADJACENCY")]
    TriangleStripWithAdjacency = 9,

    [NativeName("VK_PRIMITIVE_TOPOLOGY_PATCH_LIST")]
    PatchList = 10,
}
