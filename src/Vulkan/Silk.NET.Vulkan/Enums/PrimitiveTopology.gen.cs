// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkPrimitiveTopology")]
    public enum PrimitiveTopology : int
    {
        [NativeName("Name", "VK_PRIMITIVE_TOPOLOGY_POINT_LIST")]
        PointList = 0,
        [NativeName("Name", "VK_PRIMITIVE_TOPOLOGY_LINE_LIST")]
        LineList = 1,
        [NativeName("Name", "VK_PRIMITIVE_TOPOLOGY_LINE_STRIP")]
        LineStrip = 2,
        [NativeName("Name", "VK_PRIMITIVE_TOPOLOGY_TRIANGLE_LIST")]
        TriangleList = 3,
        [NativeName("Name", "VK_PRIMITIVE_TOPOLOGY_TRIANGLE_STRIP")]
        TriangleStrip = 4,
        [NativeName("Name", "VK_PRIMITIVE_TOPOLOGY_TRIANGLE_FAN")]
        TriangleFan = 5,
        [NativeName("Name", "VK_PRIMITIVE_TOPOLOGY_LINE_LIST_WITH_ADJACENCY")]
        LineListWithAdjacency = 6,
        [NativeName("Name", "VK_PRIMITIVE_TOPOLOGY_LINE_STRIP_WITH_ADJACENCY")]
        LineStripWithAdjacency = 7,
        [NativeName("Name", "VK_PRIMITIVE_TOPOLOGY_TRIANGLE_LIST_WITH_ADJACENCY")]
        TriangleListWithAdjacency = 8,
        [NativeName("Name", "VK_PRIMITIVE_TOPOLOGY_TRIANGLE_STRIP_WITH_ADJACENCY")]
        TriangleStripWithAdjacency = 9,
        [NativeName("Name", "VK_PRIMITIVE_TOPOLOGY_PATCH_LIST")]
        PatchList = 10,
    }
}
