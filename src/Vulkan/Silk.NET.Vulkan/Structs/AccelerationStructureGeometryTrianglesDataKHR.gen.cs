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
    [NativeName("Name", "VkAccelerationStructureGeometryTrianglesDataKHR")]
    public unsafe partial struct AccelerationStructureGeometryTrianglesDataKHR : IChainStart
    {
        public AccelerationStructureGeometryTrianglesDataKHR
        (
            StructureType? sType = StructureType.AccelerationStructureGeometryTrianglesDataKhr,
            void* pNext = null,
            Format? vertexFormat = null,
            DeviceOrHostAddressConstKHR? vertexData = null,
            ulong? vertexStride = null,
            uint? maxVertex = null,
            IndexType? indexType = null,
            DeviceOrHostAddressConstKHR? indexData = null,
            DeviceOrHostAddressConstKHR? transformData = null
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

            if (vertexFormat is not null)
            {
                VertexFormat = vertexFormat.Value;
            }

            if (vertexData is not null)
            {
                VertexData = vertexData.Value;
            }

            if (vertexStride is not null)
            {
                VertexStride = vertexStride.Value;
            }

            if (maxVertex is not null)
            {
                MaxVertex = maxVertex.Value;
            }

            if (indexType is not null)
            {
                IndexType = indexType.Value;
            }

            if (indexData is not null)
            {
                IndexData = indexData.Value;
            }

            if (transformData is not null)
            {
                TransformData = transformData.Value;
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
        [NativeName("Type", "VkFormat")]
        [NativeName("Type.Name", "VkFormat")]
        [NativeName("Name", "vertexFormat")]
        public Format VertexFormat;
/// <summary></summary>
        [NativeName("Type", "VkDeviceOrHostAddressConstKHR")]
        [NativeName("Type.Name", "VkDeviceOrHostAddressConstKHR")]
        [NativeName("Name", "vertexData")]
        public DeviceOrHostAddressConstKHR VertexData;
/// <summary></summary>
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "vertexStride")]
        public ulong VertexStride;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxVertex")]
        public uint MaxVertex;
/// <summary></summary>
        [NativeName("Type", "VkIndexType")]
        [NativeName("Type.Name", "VkIndexType")]
        [NativeName("Name", "indexType")]
        public IndexType IndexType;
/// <summary></summary>
        [NativeName("Type", "VkDeviceOrHostAddressConstKHR")]
        [NativeName("Type.Name", "VkDeviceOrHostAddressConstKHR")]
        [NativeName("Name", "indexData")]
        public DeviceOrHostAddressConstKHR IndexData;
/// <summary></summary>
        [NativeName("Type", "VkDeviceOrHostAddressConstKHR")]
        [NativeName("Type.Name", "VkDeviceOrHostAddressConstKHR")]
        [NativeName("Name", "transformData")]
        public DeviceOrHostAddressConstKHR TransformData;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.AccelerationStructureGeometryTrianglesDataKhr;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }

        /// <summary>
        /// Convenience method to start a chain.
        /// </summary>
        /// <param name="capture">The newly created chain root</param>
        /// <returns>A reference to the newly created chain.</returns>
        public static unsafe ref AccelerationStructureGeometryTrianglesDataKHR Chain(
            out AccelerationStructureGeometryTrianglesDataKHR capture)
        {
            capture = new AccelerationStructureGeometryTrianglesDataKHR(StructureType.AccelerationStructureGeometryTrianglesDataKhr);
            return ref capture;
        }
    }
}
