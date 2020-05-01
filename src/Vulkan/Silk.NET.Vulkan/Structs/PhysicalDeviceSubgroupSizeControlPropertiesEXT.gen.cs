// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    public unsafe struct PhysicalDeviceSubgroupSizeControlPropertiesEXT
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
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public uint MinSubgroupSize;
/// <summary></summary>
        public uint MaxSubgroupSize;
/// <summary></summary>
        public uint MaxComputeWorkgroupSubgroups;
/// <summary></summary>
        public ShaderStageFlags RequiredSubgroupSizeStages;
    }
}
