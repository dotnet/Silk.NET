// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkGeometryTrianglesNV")]
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
        [NativeName("Type", "VkStructureType")]
        [NativeName("Type.Name", "VkStructureType")]
        [NativeName("Name", "sType")]
        public StructureType SType;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "pNext")]
        public void* PNext;
/// <summary></summary>
        [NativeName("Type", "VkBuffer")]
        [NativeName("Type.Name", "VkBuffer")]
        [NativeName("Name", "vertexData")]
        public Buffer VertexData;
/// <summary></summary>
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "vertexOffset")]
        public ulong VertexOffset;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "vertexCount")]
        public uint VertexCount;
/// <summary></summary>
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "vertexStride")]
        public ulong VertexStride;
/// <summary></summary>
        [NativeName("Type", "VkFormat")]
        [NativeName("Type.Name", "VkFormat")]
        [NativeName("Name", "vertexFormat")]
        public Format VertexFormat;
/// <summary></summary>
        [NativeName("Type", "VkBuffer")]
        [NativeName("Type.Name", "VkBuffer")]
        [NativeName("Name", "indexData")]
        public Buffer IndexData;
/// <summary></summary>
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "indexOffset")]
        public ulong IndexOffset;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "indexCount")]
        public uint IndexCount;
/// <summary></summary>
        [NativeName("Type", "VkIndexType")]
        [NativeName("Type.Name", "VkIndexType")]
        [NativeName("Name", "indexType")]
        public IndexType IndexType;
/// <summary></summary>
        [NativeName("Type", "VkBuffer")]
        [NativeName("Type.Name", "VkBuffer")]
        [NativeName("Name", "transformData")]
        public Buffer TransformData;
/// <summary></summary>
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "transformOffset")]
        public ulong TransformOffset;
    }
}
