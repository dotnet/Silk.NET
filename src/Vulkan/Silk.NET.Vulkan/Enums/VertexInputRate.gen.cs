// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkVertexInputRate")]
    public enum VertexInputRate : int
    {
        [NativeName("Name", "VK_VERTEX_INPUT_RATE_VERTEX")]
        Vertex = 0,
        [NativeName("Name", "VK_VERTEX_INPUT_RATE_INSTANCE")]
        Instance = 1,
    }
}
