// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkAccelerationStructureMemoryRequirementsInfoNV")]
    public unsafe partial struct AccelerationStructureMemoryRequirementsInfoNV
    {
        public AccelerationStructureMemoryRequirementsInfoNV
        (
            StructureType sType = StructureType.AccelerationStructureMemoryRequirementsInfoNV,
            void* pNext = default,
            AccelerationStructureMemoryRequirementsTypeNV type = default,
            AccelerationStructureNV accelerationStructure = default
        )
        {
            SType = sType;
            PNext = pNext;
            Type = type;
            AccelerationStructure = accelerationStructure;
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
        [NativeName("Type", "VkAccelerationStructureMemoryRequirementsTypeNV")]
        [NativeName("Type.Name", "VkAccelerationStructureMemoryRequirementsTypeNV")]
        [NativeName("Name", "type")]
        public AccelerationStructureMemoryRequirementsTypeNV Type;
/// <summary></summary>
        [NativeName("Type", "VkAccelerationStructureNV")]
        [NativeName("Type.Name", "VkAccelerationStructureNV")]
        [NativeName("Name", "accelerationStructure")]
        public AccelerationStructureNV AccelerationStructure;
    }
}
