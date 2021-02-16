// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


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
    [NativeName("Name", "VkPhysicalDeviceAccelerationStructurePropertiesKHR")]
    public unsafe partial struct PhysicalDeviceAccelerationStructurePropertiesKHR
    {
        public PhysicalDeviceAccelerationStructurePropertiesKHR
        (
            StructureType? sType = StructureType.PhysicalDeviceAccelerationStructurePropertiesKhr,
            void* pNext = null,
            ulong? maxGeometryCount = null,
            ulong? maxInstanceCount = null,
            ulong? maxPrimitiveCount = null,
            uint? maxPerStageDescriptorAccelerationStructures = null,
            uint? maxPerStageDescriptorUpdateAfterBindAccelerationStructures = null,
            uint? maxDescriptorSetAccelerationStructures = null,
            uint? maxDescriptorSetUpdateAfterBindAccelerationStructures = null,
            uint? minAccelerationStructureScratchOffsetAlignment = null
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

            if (maxGeometryCount is not null)
            {
                MaxGeometryCount = maxGeometryCount.Value;
            }

            if (maxInstanceCount is not null)
            {
                MaxInstanceCount = maxInstanceCount.Value;
            }

            if (maxPrimitiveCount is not null)
            {
                MaxPrimitiveCount = maxPrimitiveCount.Value;
            }

            if (maxPerStageDescriptorAccelerationStructures is not null)
            {
                MaxPerStageDescriptorAccelerationStructures = maxPerStageDescriptorAccelerationStructures.Value;
            }

            if (maxPerStageDescriptorUpdateAfterBindAccelerationStructures is not null)
            {
                MaxPerStageDescriptorUpdateAfterBindAccelerationStructures = maxPerStageDescriptorUpdateAfterBindAccelerationStructures.Value;
            }

            if (maxDescriptorSetAccelerationStructures is not null)
            {
                MaxDescriptorSetAccelerationStructures = maxDescriptorSetAccelerationStructures.Value;
            }

            if (maxDescriptorSetUpdateAfterBindAccelerationStructures is not null)
            {
                MaxDescriptorSetUpdateAfterBindAccelerationStructures = maxDescriptorSetUpdateAfterBindAccelerationStructures.Value;
            }

            if (minAccelerationStructureScratchOffsetAlignment is not null)
            {
                MinAccelerationStructureScratchOffsetAlignment = minAccelerationStructureScratchOffsetAlignment.Value;
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
        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "maxGeometryCount")]
        public ulong MaxGeometryCount;
/// <summary></summary>
        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "maxInstanceCount")]
        public ulong MaxInstanceCount;
/// <summary></summary>
        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "maxPrimitiveCount")]
        public ulong MaxPrimitiveCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxPerStageDescriptorAccelerationStructures")]
        public uint MaxPerStageDescriptorAccelerationStructures;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxPerStageDescriptorUpdateAfterBindAccelerationStructures")]
        public uint MaxPerStageDescriptorUpdateAfterBindAccelerationStructures;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxDescriptorSetAccelerationStructures")]
        public uint MaxDescriptorSetAccelerationStructures;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxDescriptorSetUpdateAfterBindAccelerationStructures")]
        public uint MaxDescriptorSetUpdateAfterBindAccelerationStructures;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "minAccelerationStructureScratchOffsetAlignment")]
        public uint MinAccelerationStructureScratchOffsetAlignment;
    }
}
