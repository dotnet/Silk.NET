// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkGeometryTrianglesNV")]
    public unsafe partial struct GeometryTrianglesNV : IChainable
    {
        public GeometryTrianglesNV
        (
            StructureType? sType = StructureType.GeometryTrianglesNV,
            void* pNext = null,
            Buffer? vertexData = null,
            ulong? vertexOffset = null,
            uint? vertexCount = null,
            ulong? vertexStride = null,
            Format? vertexFormat = null,
            Buffer? indexData = null,
            ulong? indexOffset = null,
            uint? indexCount = null,
            IndexType? indexType = null,
            Buffer? transformData = null,
            ulong? transformOffset = null
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

            if (vertexData is not null)
            {
                VertexData = vertexData.Value;
            }

            if (vertexOffset is not null)
            {
                VertexOffset = vertexOffset.Value;
            }

            if (vertexCount is not null)
            {
                VertexCount = vertexCount.Value;
            }

            if (vertexStride is not null)
            {
                VertexStride = vertexStride.Value;
            }

            if (vertexFormat is not null)
            {
                VertexFormat = vertexFormat.Value;
            }

            if (indexData is not null)
            {
                IndexData = indexData.Value;
            }

            if (indexOffset is not null)
            {
                IndexOffset = indexOffset.Value;
            }

            if (indexCount is not null)
            {
                IndexCount = indexCount.Value;
            }

            if (indexType is not null)
            {
                IndexType = indexType.Value;
            }

            if (transformData is not null)
            {
                TransformData = transformData.Value;
            }

            if (transformOffset is not null)
            {
                TransformOffset = transformOffset.Value;
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

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.GeometryTrianglesNV;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
