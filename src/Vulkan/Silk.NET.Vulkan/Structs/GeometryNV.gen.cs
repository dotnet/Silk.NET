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
    public unsafe struct GeometryNV
    {
        public GeometryNV
        (
            StructureType sType = StructureType.GeometryNV,
            void* pNext = default,
            GeometryTypeKHR geometryType = default,
            GeometryDataNV geometry = default,
            GeometryFlagsKHR flags = default
        )
        {
           SType = sType;
           PNext = pNext;
           GeometryType = geometryType;
           Geometry = geometry;
           Flags = flags;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public GeometryTypeKHR GeometryType;
/// <summary></summary>
        public GeometryDataNV Geometry;
/// <summary></summary>
        public GeometryFlagsKHR Flags;
    }
}
