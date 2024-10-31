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
    [NativeName("Name", "VkAccelerationStructureTrianglesOpacityMicromapEXT")]
    public unsafe partial struct AccelerationStructureTrianglesOpacityMicromapEXT : IExtendsChain<AccelerationStructureGeometryTrianglesDataKHR>
    {
        public AccelerationStructureTrianglesOpacityMicromapEXT
        (
            StructureType? sType = StructureType.AccelerationStructureTrianglesOpacityMicromapExt,
            void* pNext = null,
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
            return SType = StructureType.AccelerationStructureTrianglesOpacityMicromapExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
