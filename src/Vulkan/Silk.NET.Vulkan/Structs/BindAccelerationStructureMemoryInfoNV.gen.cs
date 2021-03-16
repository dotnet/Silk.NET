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
    [NativeName("Name", "VkBindAccelerationStructureMemoryInfoNV")]
    public unsafe partial struct BindAccelerationStructureMemoryInfoNV
    {
        public BindAccelerationStructureMemoryInfoNV
        (
            StructureType? sType = StructureType.BindAccelerationStructureMemoryInfoNV,
            void* pNext = null,
            AccelerationStructureNV? accelerationStructure = null,
            DeviceMemory? memory = null,
            ulong? memoryOffset = null,
            uint? deviceIndexCount = null,
            uint* pDeviceIndices = null
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

            if (accelerationStructure is not null)
            {
                AccelerationStructure = accelerationStructure.Value;
            }

            if (memory is not null)
            {
                Memory = memory.Value;
            }

            if (memoryOffset is not null)
            {
                MemoryOffset = memoryOffset.Value;
            }

            if (deviceIndexCount is not null)
            {
                DeviceIndexCount = deviceIndexCount.Value;
            }

            if (pDeviceIndices is not null)
            {
                PDeviceIndices = pDeviceIndices;
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
        [NativeName("Type", "VkAccelerationStructureNV")]
        [NativeName("Type.Name", "VkAccelerationStructureNV")]
        [NativeName("Name", "accelerationStructure")]
        public AccelerationStructureNV AccelerationStructure;
/// <summary></summary>
        [NativeName("Type", "VkDeviceMemory")]
        [NativeName("Type.Name", "VkDeviceMemory")]
        [NativeName("Name", "memory")]
        public DeviceMemory Memory;
/// <summary></summary>
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "memoryOffset")]
        public ulong MemoryOffset;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "deviceIndexCount")]
        public uint DeviceIndexCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t*")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "pDeviceIndices")]
        public uint* PDeviceIndices;
    }
}
