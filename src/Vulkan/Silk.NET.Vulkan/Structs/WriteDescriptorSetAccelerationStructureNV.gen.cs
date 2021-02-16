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
    [NativeName("Name", "VkWriteDescriptorSetAccelerationStructureNV")]
    public unsafe partial struct WriteDescriptorSetAccelerationStructureNV
    {
        public WriteDescriptorSetAccelerationStructureNV
        (
            StructureType? sType = StructureType.WriteDescriptorSetAccelerationStructureNV,
            void* pNext = null,
            uint? accelerationStructureCount = null,
            AccelerationStructureNV* pAccelerationStructures = null
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

            if (accelerationStructureCount is not null)
            {
                AccelerationStructureCount = accelerationStructureCount.Value;
            }

            if (pAccelerationStructures is not null)
            {
                PAccelerationStructures = pAccelerationStructures;
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
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "accelerationStructureCount")]
        public uint AccelerationStructureCount;
/// <summary></summary>
        [NativeName("Type", "VkAccelerationStructureNV*")]
        [NativeName("Type.Name", "VkAccelerationStructureNV")]
        [NativeName("Name", "pAccelerationStructures")]
        public AccelerationStructureNV* PAccelerationStructures;
    }
}
