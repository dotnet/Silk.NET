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
    [NativeName("Name", "VkPhysicalDeviceSubgroupSizeControlPropertiesEXT")]
    public unsafe partial struct PhysicalDeviceSubgroupSizeControlPropertiesEXT
    {
        public PhysicalDeviceSubgroupSizeControlPropertiesEXT
        (
            StructureType sType = StructureType.PhysicalDeviceSubgroupSizeControlPropertiesExt,
            void* pNext = default,
            uint minSubgroupSize = default,
            uint maxSubgroupSize = default,
            uint maxComputeWorkgroupSubgroups = default,
            ShaderStageFlags requiredSubgroupSizeStages = default
        )
        {
            SType = sType;
            PNext = pNext;
            MinSubgroupSize = minSubgroupSize;
            MaxSubgroupSize = maxSubgroupSize;
            MaxComputeWorkgroupSubgroups = maxComputeWorkgroupSubgroups;
            RequiredSubgroupSizeStages = requiredSubgroupSizeStages;
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
        [NativeName("Name", "minSubgroupSize")]
        public uint MinSubgroupSize;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxSubgroupSize")]
        public uint MaxSubgroupSize;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxComputeWorkgroupSubgroups")]
        public uint MaxComputeWorkgroupSubgroups;
/// <summary></summary>
        [NativeName("Type", "VkShaderStageFlags")]
        [NativeName("Type.Name", "VkShaderStageFlags")]
        [NativeName("Name", "requiredSubgroupSizeStages")]
        public ShaderStageFlags RequiredSubgroupSizeStages;
    }
}
