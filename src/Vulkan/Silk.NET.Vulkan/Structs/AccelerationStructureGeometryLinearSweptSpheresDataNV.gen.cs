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
    [NativeName("Name", "VkAccelerationStructureGeometryLinearSweptSpheresDataNV")]
    public unsafe partial struct AccelerationStructureGeometryLinearSweptSpheresDataNV : IExtendsChain<AccelerationStructureGeometryKHR>
    {
        public AccelerationStructureGeometryLinearSweptSpheresDataNV
        (
            StructureType? sType = StructureType.AccelerationStructureGeometryLinearSweptSpheresDataNV,
            void* pNext = null,
            Format? vertexFormat = null,
            DeviceOrHostAddressConstKHR? vertexData = null,
            ulong? vertexStride = null,
            Format? radiusFormat = null,
            DeviceOrHostAddressConstKHR? radiusData = null,
            ulong? radiusStride = null,
            IndexType? indexType = null,
            DeviceOrHostAddressConstKHR? indexData = null,
            ulong? indexStride = null,
            RayTracingLssIndexingModeNV? indexingMode = null,
            RayTracingLssPrimitiveEndCapsModeNV? endCapsMode = null
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

            if (radiusFormat is not null)
            {
                RadiusFormat = radiusFormat.Value;
            }

            if (radiusData is not null)
            {
                RadiusData = radiusData.Value;
            }

            if (radiusStride is not null)
            {
                RadiusStride = radiusStride.Value;
            }

            if (indexType is not null)
            {
                IndexType = indexType.Value;
            }

            if (indexData is not null)
            {
                IndexData = indexData.Value;
            }

            if (indexStride is not null)
            {
                IndexStride = indexStride.Value;
            }

            if (indexingMode is not null)
            {
                IndexingMode = indexingMode.Value;
            }

            if (endCapsMode is not null)
            {
                EndCapsMode = endCapsMode.Value;
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
        [NativeName("Type", "VkFormat")]
        [NativeName("Type.Name", "VkFormat")]
        [NativeName("Name", "radiusFormat")]
        public Format RadiusFormat;
/// <summary></summary>
        [NativeName("Type", "VkDeviceOrHostAddressConstKHR")]
        [NativeName("Type.Name", "VkDeviceOrHostAddressConstKHR")]
        [NativeName("Name", "radiusData")]
        public DeviceOrHostAddressConstKHR RadiusData;
/// <summary></summary>
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "radiusStride")]
        public ulong RadiusStride;
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
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "indexStride")]
        public ulong IndexStride;
/// <summary></summary>
        [NativeName("Type", "VkRayTracingLssIndexingModeNV")]
        [NativeName("Type.Name", "VkRayTracingLssIndexingModeNV")]
        [NativeName("Name", "indexingMode")]
        public RayTracingLssIndexingModeNV IndexingMode;
/// <summary></summary>
        [NativeName("Type", "VkRayTracingLssPrimitiveEndCapsModeNV")]
        [NativeName("Type.Name", "VkRayTracingLssPrimitiveEndCapsModeNV")]
        [NativeName("Name", "endCapsMode")]
        public RayTracingLssPrimitiveEndCapsModeNV EndCapsMode;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.AccelerationStructureGeometryLinearSweptSpheresDataNV;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
