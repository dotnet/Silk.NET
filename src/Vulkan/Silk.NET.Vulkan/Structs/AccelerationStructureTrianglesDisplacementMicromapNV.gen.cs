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
    [NativeName("Name", "VkAccelerationStructureTrianglesDisplacementMicromapNV")]
    public unsafe partial struct AccelerationStructureTrianglesDisplacementMicromapNV : IExtendsChain<AccelerationStructureGeometryTrianglesDataKHR>
    {
        public AccelerationStructureTrianglesDisplacementMicromapNV
        (
            StructureType? sType = StructureType.AccelerationStructureTrianglesDisplacementMicromapNV,
            void* pNext = null,
            Format? displacementBiasAndScaleFormat = null,
            Format? displacementVectorFormat = null,
            DeviceOrHostAddressConstKHR? displacementBiasAndScaleBuffer = null,
            ulong? displacementBiasAndScaleStride = null,
            DeviceOrHostAddressConstKHR? displacementVectorBuffer = null,
            ulong? displacementVectorStride = null,
            DeviceOrHostAddressConstKHR? displacedMicromapPrimitiveFlags = null,
            ulong? displacedMicromapPrimitiveFlagsStride = null,
            IndexType? indexType = null,
            DeviceOrHostAddressConstKHR? indexBuffer = null,
            ulong? indexStride = null,
            uint? baseTriangle = null,
            uint? usageCountsCount = null,
            MicromapUsageEXT* pUsageCounts = null,
            MicromapUsageEXT** ppUsageCounts = null,
            MicromapEXT? micromap = null
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

            if (displacementBiasAndScaleFormat is not null)
            {
                DisplacementBiasAndScaleFormat = displacementBiasAndScaleFormat.Value;
            }

            if (displacementVectorFormat is not null)
            {
                DisplacementVectorFormat = displacementVectorFormat.Value;
            }

            if (displacementBiasAndScaleBuffer is not null)
            {
                DisplacementBiasAndScaleBuffer = displacementBiasAndScaleBuffer.Value;
            }

            if (displacementBiasAndScaleStride is not null)
            {
                DisplacementBiasAndScaleStride = displacementBiasAndScaleStride.Value;
            }

            if (displacementVectorBuffer is not null)
            {
                DisplacementVectorBuffer = displacementVectorBuffer.Value;
            }

            if (displacementVectorStride is not null)
            {
                DisplacementVectorStride = displacementVectorStride.Value;
            }

            if (displacedMicromapPrimitiveFlags is not null)
            {
                DisplacedMicromapPrimitiveFlags = displacedMicromapPrimitiveFlags.Value;
            }

            if (displacedMicromapPrimitiveFlagsStride is not null)
            {
                DisplacedMicromapPrimitiveFlagsStride = displacedMicromapPrimitiveFlagsStride.Value;
            }

            if (indexType is not null)
            {
                IndexType = indexType.Value;
            }

            if (indexBuffer is not null)
            {
                IndexBuffer = indexBuffer.Value;
            }

            if (indexStride is not null)
            {
                IndexStride = indexStride.Value;
            }

            if (baseTriangle is not null)
            {
                BaseTriangle = baseTriangle.Value;
            }

            if (usageCountsCount is not null)
            {
                UsageCountsCount = usageCountsCount.Value;
            }

            if (pUsageCounts is not null)
            {
                PUsageCounts = pUsageCounts;
            }

            if (ppUsageCounts is not null)
            {
                PpUsageCounts = ppUsageCounts;
            }

            if (micromap is not null)
            {
                Micromap = micromap.Value;
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
        [NativeName("Name", "displacementBiasAndScaleFormat")]
        public Format DisplacementBiasAndScaleFormat;
/// <summary></summary>
        [NativeName("Type", "VkFormat")]
        [NativeName("Type.Name", "VkFormat")]
        [NativeName("Name", "displacementVectorFormat")]
        public Format DisplacementVectorFormat;
/// <summary></summary>
        [NativeName("Type", "VkDeviceOrHostAddressConstKHR")]
        [NativeName("Type.Name", "VkDeviceOrHostAddressConstKHR")]
        [NativeName("Name", "displacementBiasAndScaleBuffer")]
        public DeviceOrHostAddressConstKHR DisplacementBiasAndScaleBuffer;
/// <summary></summary>
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "displacementBiasAndScaleStride")]
        public ulong DisplacementBiasAndScaleStride;
/// <summary></summary>
        [NativeName("Type", "VkDeviceOrHostAddressConstKHR")]
        [NativeName("Type.Name", "VkDeviceOrHostAddressConstKHR")]
        [NativeName("Name", "displacementVectorBuffer")]
        public DeviceOrHostAddressConstKHR DisplacementVectorBuffer;
/// <summary></summary>
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "displacementVectorStride")]
        public ulong DisplacementVectorStride;
/// <summary></summary>
        [NativeName("Type", "VkDeviceOrHostAddressConstKHR")]
        [NativeName("Type.Name", "VkDeviceOrHostAddressConstKHR")]
        [NativeName("Name", "displacedMicromapPrimitiveFlags")]
        public DeviceOrHostAddressConstKHR DisplacedMicromapPrimitiveFlags;
/// <summary></summary>
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "displacedMicromapPrimitiveFlagsStride")]
        public ulong DisplacedMicromapPrimitiveFlagsStride;
/// <summary></summary>
        [NativeName("Type", "VkIndexType")]
        [NativeName("Type.Name", "VkIndexType")]
        [NativeName("Name", "indexType")]
        public IndexType IndexType;
/// <summary></summary>
        [NativeName("Type", "VkDeviceOrHostAddressConstKHR")]
        [NativeName("Type.Name", "VkDeviceOrHostAddressConstKHR")]
        [NativeName("Name", "indexBuffer")]
        public DeviceOrHostAddressConstKHR IndexBuffer;
/// <summary></summary>
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "indexStride")]
        public ulong IndexStride;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "baseTriangle")]
        public uint BaseTriangle;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "usageCountsCount")]
        public uint UsageCountsCount;
/// <summary></summary>
        [NativeName("Type", "VkMicromapUsageEXT*")]
        [NativeName("Type.Name", "VkMicromapUsageEXT")]
        [NativeName("Name", "pUsageCounts")]
        public MicromapUsageEXT* PUsageCounts;
/// <summary></summary>
        [NativeName("Type", "VkMicromapUsageEXT**")]
        [NativeName("Type.Name", "VkMicromapUsageEXT")]
        [NativeName("Name", "ppUsageCounts")]
        public MicromapUsageEXT** PpUsageCounts;
/// <summary></summary>
        [NativeName("Type", "VkMicromapEXT")]
        [NativeName("Type.Name", "VkMicromapEXT")]
        [NativeName("Name", "micromap")]
        public MicromapEXT Micromap;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.AccelerationStructureTrianglesDisplacementMicromapNV;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
