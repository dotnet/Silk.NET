// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkGeometryDataNV")]
    public unsafe partial struct GeometryDataNV
    {
        public GeometryDataNV
        (
            GeometryTrianglesNV triangles = default,
            GeometryAABBNV aabbs = default
        )
        {
            Triangles = triangles;
            Aabbs = aabbs;
        }

/// <summary></summary>
        [NativeName("Type", "VkGeometryTrianglesNV")]
        [NativeName("Type.Name", "VkGeometryTrianglesNV")]
        [NativeName("Name", "triangles")]
        public GeometryTrianglesNV Triangles;
/// <summary></summary>
        [NativeName("Type", "VkGeometryAABBNV")]
        [NativeName("Type.Name", "VkGeometryAABBNV")]
        [NativeName("Name", "aabbs")]
        public GeometryAABBNV Aabbs;
    }
}
