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
    [NativeName("Name", "VkAccelerationStructureCreateGeometryTypeInfoKHR")]
    public unsafe partial struct AccelerationStructureCreateGeometryTypeInfoKHR
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
        [NativeName("Type", "VkGeometryTypeKHR")]
        [NativeName("Type.Name", "VkGeometryTypeKHR")]
        [NativeName("Name", "geometryType")]
        public GeometryTypeKHR GeometryType;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxPrimitiveCount")]
        public uint MaxPrimitiveCount;
/// <summary></summary>
        [NativeName("Type", "VkIndexType")]
        [NativeName("Type.Name", "VkIndexType")]
        [NativeName("Name", "indexType")]
        public IndexType IndexType;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxVertexCount")]
        public uint MaxVertexCount;
/// <summary></summary>
        [NativeName("Type", "VkFormat")]
        [NativeName("Type.Name", "VkFormat")]
        [NativeName("Name", "vertexFormat")]
        public Format VertexFormat;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "allowsTransforms")]
        public Bool32 AllowsTransforms;
    }
}
