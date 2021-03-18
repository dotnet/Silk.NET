// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkGeometryTypeNV")]
    public enum GeometryTypeNV : int
    {
        [NativeName("Name", "VK_GEOMETRY_TYPE_TRIANGLES_KHR")]
        GeometryTypeTrianglesKhr = 0,
        [NativeName("Name", "VK_GEOMETRY_TYPE_AABBS_KHR")]
        GeometryTypeAabbsKhr = 1,
        [NativeName("Name", "VK_GEOMETRY_TYPE_INSTANCES_KHR")]
        GeometryTypeInstancesKhr = 2,
    }
}
