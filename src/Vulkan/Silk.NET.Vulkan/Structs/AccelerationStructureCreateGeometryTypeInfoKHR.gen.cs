// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkAccelerationStructureCreateGeometryTypeInfoKHR")]
    public unsafe partial struct AccelerationStructureCreateGeometryTypeInfoKHR
    {
        public AccelerationStructureCreateGeometryTypeInfoKHR
        (
            StructureType? sType = StructureType.AccelerationStructureCreateGeometryTypeInfoKhr,
            void* pNext = null,
            GeometryTypeKHR? geometryType = null,
            uint? maxPrimitiveCount = null,
            IndexType? indexType = null,
            uint? maxVertexCount = null,
            Format? vertexFormat = null,
            Bool32? allowsTransforms = null
        ) : this()
        {
            if (sType is not null)
            {
                SType = sType.Value;
            }

            if (pNext is not null)
            {
                PNext = pNext;
            }

            if (geometryType is not null)
            {
                GeometryType = geometryType.Value;
            }

            if (maxPrimitiveCount is not null)
            {
                MaxPrimitiveCount = maxPrimitiveCount.Value;
            }

            if (indexType is not null)
            {
                IndexType = indexType.Value;
            }

            if (maxVertexCount is not null)
            {
                MaxVertexCount = maxVertexCount.Value;
            }

            if (vertexFormat is not null)
            {
                VertexFormat = vertexFormat.Value;
            }

            if (allowsTransforms is not null)
            {
                AllowsTransforms = allowsTransforms.Value;
            }
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
