// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkGeometryTypeKHR")]
    public enum GeometryTypeKHR : int
    {
        [NativeName("Name", "VK_GEOMETRY_TYPE_TRIANGLES_KHR")]
        GeometryTypeTrianglesKhr = 0,
        [NativeName("Name", "VK_GEOMETRY_TYPE_AABBS_KHR")]
        GeometryTypeAabbsKhr = 1,
        [NativeName("Name", "VK_GEOMETRY_TYPE_INSTANCES_KHR")]
        GeometryTypeInstancesKhr = 2,
    }
}
