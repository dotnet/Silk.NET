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
    public unsafe struct GeometryTrianglesNV
    {
        public GeometryTrianglesNV
        (
            StructureType sType = StructureType.GeometryTrianglesNV,
            void* pNext = default,
            Buffer vertexData = default,
            ulong vertexOffset = default,
            uint vertexCount = default,
            ulong vertexStride = default,
            Format vertexFormat = default,
            Buffer indexData = default,
            ulong indexOffset = default,
            uint indexCount = default,
            IndexType indexType = default,
            Buffer transformData = default,
            ulong transformOffset = default
        )
        {
           SType = sType;
           PNext = pNext;
           VertexData = vertexData;
           VertexOffset = vertexOffset;
           VertexCount = vertexCount;
           VertexStride = vertexStride;
           VertexFormat = vertexFormat;
           IndexData = indexData;
           IndexOffset = indexOffset;
           IndexCount = indexCount;
           IndexType = indexType;
           TransformData = transformData;
           TransformOffset = transformOffset;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public Buffer VertexData;
/// <summary></summary>
        public ulong VertexOffset;
/// <summary></summary>
        public uint VertexCount;
/// <summary></summary>
        public ulong VertexStride;
/// <summary></summary>
        public Format VertexFormat;
/// <summary></summary>
        public Buffer IndexData;
/// <summary></summary>
        public ulong IndexOffset;
/// <summary></summary>
        public uint IndexCount;
/// <summary></summary>
        public IndexType IndexType;
/// <summary></summary>
        public Buffer TransformData;
/// <summary></summary>
        public ulong TransformOffset;
    }
}
