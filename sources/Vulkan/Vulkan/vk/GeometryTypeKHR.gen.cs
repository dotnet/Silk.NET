// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkGeometryTypeKHR")]
public enum GeometryTypeKHR : uint
{
    [NativeName("VK_GEOMETRY_TYPE_TRIANGLES_KHR")]
    Triangles = 0,

    [NativeName("VK_GEOMETRY_TYPE_AABBS_KHR")]
    Aabbs = 1,

    [NativeName("VK_GEOMETRY_TYPE_INSTANCES_KHR")]
    Instances = 2,

    [NativeName("VK_GEOMETRY_TYPE_SPHERES_NV")]
    SpheresNV = 1000429004,

    [NativeName("VK_GEOMETRY_TYPE_LINEAR_SWEPT_SPHERES_NV")]
    LinearSweptSpheresNV = 1000429005,

    [NativeName("VK_GEOMETRY_TYPE_DENSE_GEOMETRY_FORMAT_TRIANGLES_AMDX")]
    DenseGeometryFormatTrianglesAMDX = 1000478000,

    [NativeName("VK_GEOMETRY_TYPE_MICROMAP_KHR")]
    Micromap = 1000623000,

    [NativeName("VK_GEOMETRY_TYPE_TRIANGLES_NV")]
    TrianglesNV = Triangles,

    [NativeName("VK_GEOMETRY_TYPE_AABBS_NV")]
    AabbsNV = Aabbs,
}
