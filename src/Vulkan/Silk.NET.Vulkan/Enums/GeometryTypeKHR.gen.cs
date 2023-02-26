// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkGeometryTypeKHR")]
    public enum GeometryTypeKHR : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"TrianglesKhr\"")]
        [NativeName("Name", "VK_GEOMETRY_TYPE_TRIANGLES_KHR")]
        GeometryTypeTrianglesKhr = 0,
        [Obsolete("Deprecated in favour of \"AabbsKhr\"")]
        [NativeName("Name", "VK_GEOMETRY_TYPE_AABBS_KHR")]
        GeometryTypeAabbsKhr = 1,
        [Obsolete("Deprecated in favour of \"InstancesKhr\"")]
        [NativeName("Name", "VK_GEOMETRY_TYPE_INSTANCES_KHR")]
        GeometryTypeInstancesKhr = 2,
        [NativeName("Name", "VK_GEOMETRY_TYPE_TRIANGLES_KHR")]
        TrianglesKhr = 0,
        [NativeName("Name", "VK_GEOMETRY_TYPE_AABBS_KHR")]
        AabbsKhr = 1,
        [NativeName("Name", "VK_GEOMETRY_TYPE_INSTANCES_KHR")]
        InstancesKhr = 2,
    }
}
