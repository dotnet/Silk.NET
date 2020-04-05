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
    public unsafe struct AccelerationStructureCreateGeometryTypeInfoKHR
    {
        public AccelerationStructureCreateGeometryTypeInfoKHR
        (
            StructureType sType = StructureType.AccelerationStructureCreateGeometryTypeInfoKhr,
            void* pNext = default,
            GeometryTypeKHR geometryType = default,
            uint maxPrimitiveCount = default,
            IndexType indexType = default,
            uint maxVertexCount = default,
            Format vertexFormat = default,
            Bool32 allowsTransforms = default
        )
        {
           SType = sType;
           PNext = pNext;
           GeometryType = geometryType;
           MaxPrimitiveCount = maxPrimitiveCount;
           IndexType = indexType;
           MaxVertexCount = maxVertexCount;
           VertexFormat = vertexFormat;
           AllowsTransforms = allowsTransforms;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public GeometryTypeKHR GeometryType;
/// <summary></summary>
        public uint MaxPrimitiveCount;
/// <summary></summary>
        public IndexType IndexType;
/// <summary></summary>
        public uint MaxVertexCount;
/// <summary></summary>
        public Format VertexFormat;
/// <summary></summary>
        public Bool32 AllowsTransforms;
    }
}
