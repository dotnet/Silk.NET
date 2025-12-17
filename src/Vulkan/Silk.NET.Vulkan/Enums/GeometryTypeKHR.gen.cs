// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkGeometryTypeKHR")]
    public enum GeometryTypeKHR : int
    {
        [Obsolete("Deprecated in favour of \"TrianglesKhr\"")]
        [NativeName("Name", "VK_GEOMETRY_TYPE_TRIANGLES_KHR")]
        GeometryTypeTrianglesKhr = 0,
        [Obsolete("Deprecated in favour of \"AabbsKhr\"")]
        [NativeName("Name", "VK_GEOMETRY_TYPE_AABBS_KHR")]
        GeometryTypeAabbsKhr = 1,
        [Obsolete("Deprecated in favour of \"InstancesKhr\"")]
        [NativeName("Name", "VK_GEOMETRY_TYPE_INSTANCES_KHR")]
        GeometryTypeInstancesKhr = 2,
        [Obsolete("Deprecated in favour of \"SpheresNV\"")]
        [NativeName("Name", "VK_GEOMETRY_TYPE_SPHERES_NV")]
        GeometryTypeSpheresNV = 1000429004,
        [Obsolete("Deprecated in favour of \"LinearSweptSpheresNV\"")]
        [NativeName("Name", "VK_GEOMETRY_TYPE_LINEAR_SWEPT_SPHERES_NV")]
        GeometryTypeLinearSweptSpheresNV = 1000429005,
        [Obsolete("Deprecated in favour of \"DenseGeometryFormatTrianglesAmdx\"")]
        [NativeName("Name", "VK_GEOMETRY_TYPE_DENSE_GEOMETRY_FORMAT_TRIANGLES_AMDX")]
        GeometryTypeDenseGeometryFormatTrianglesAmdx = 1000478000,
        [NativeName("Name", "VK_GEOMETRY_TYPE_TRIANGLES_KHR")]
        TrianglesKhr = 0,
        [NativeName("Name", "VK_GEOMETRY_TYPE_AABBS_KHR")]
        AabbsKhr = 1,
        [NativeName("Name", "VK_GEOMETRY_TYPE_INSTANCES_KHR")]
        InstancesKhr = 2,
        [NativeName("Name", "VK_GEOMETRY_TYPE_SPHERES_NV")]
        SpheresNV = 1000429004,
        [NativeName("Name", "VK_GEOMETRY_TYPE_LINEAR_SWEPT_SPHERES_NV")]
        LinearSweptSpheresNV = 1000429005,
        [NativeName("Name", "VK_GEOMETRY_TYPE_DENSE_GEOMETRY_FORMAT_TRIANGLES_AMDX")]
        DenseGeometryFormatTrianglesAmdx = 1000478000,
    }
}
