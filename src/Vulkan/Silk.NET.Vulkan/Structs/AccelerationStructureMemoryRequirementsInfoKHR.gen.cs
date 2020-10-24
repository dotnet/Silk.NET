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
    [NativeName("Name", "VkAccelerationStructureMemoryRequirementsInfoKHR")]
    public unsafe partial struct AccelerationStructureMemoryRequirementsInfoKHR
    {
        public AccelerationStructureMemoryRequirementsInfoKHR
        (
            StructureType? sType = StructureType.AccelerationStructureMemoryRequirementsInfoKhr,
            void* pNext = null,
            AccelerationStructureMemoryRequirementsTypeKHR? type = null,
            AccelerationStructureBuildTypeKHR? buildType = null,
            AccelerationStructureKHR? accelerationStructure = null
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

            if (type is not null)
            {
                Type = type.Value;
            }

            if (buildType is not null)
            {
                BuildType = buildType.Value;
            }

            if (accelerationStructure is not null)
            {
                AccelerationStructure = accelerationStructure.Value;
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
        [NativeName("Type", "VkAccelerationStructureMemoryRequirementsTypeKHR")]
        [NativeName("Type.Name", "VkAccelerationStructureMemoryRequirementsTypeKHR")]
        [NativeName("Name", "type")]
        public AccelerationStructureMemoryRequirementsTypeKHR Type;
/// <summary></summary>
        [NativeName("Type", "VkAccelerationStructureBuildTypeKHR")]
        [NativeName("Type.Name", "VkAccelerationStructureBuildTypeKHR")]
        [NativeName("Name", "buildType")]
        public AccelerationStructureBuildTypeKHR BuildType;
/// <summary></summary>
        [NativeName("Type", "VkAccelerationStructureKHR")]
        [NativeName("Type.Name", "VkAccelerationStructureKHR")]
        [NativeName("Name", "accelerationStructure")]
        public AccelerationStructureKHR AccelerationStructure;
    }
}
