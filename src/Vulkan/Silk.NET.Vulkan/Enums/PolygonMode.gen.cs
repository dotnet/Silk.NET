// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkPolygonMode")]
    public enum PolygonMode
    {
        [NativeName("Name", "VK_POLYGON_MODE_FILL")]
        Fill = 0,
        [NativeName("Name", "VK_POLYGON_MODE_LINE")]
        Line = 1,
        [NativeName("Name", "VK_POLYGON_MODE_POINT")]
        Point = 2,
        [NativeName("Name", "VK_POLYGON_MODE_FILL_RECTANGLE_NV")]
        FillRectangleNV = 1000153000,
    }
}
