// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

namespace Silk.NET.Vulkan
{
    public unsafe struct GeometryDataNV
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
        public GeometryTrianglesNV Triangles;
/// <summary></summary>
        public GeometryAABBNV Aabbs;
    }
}
