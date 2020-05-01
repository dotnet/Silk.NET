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
    public unsafe struct PhysicalDeviceVulkanMemoryModelFeatures
    {
        public PhysicalDeviceVulkanMemoryModelFeatures
        (
            StructureType sType = StructureType.PhysicalDeviceVulkanMemoryModelFeatures,
            void* pNext = default,
            Bool32 vulkanMemoryModel = default,
            Bool32 vulkanMemoryModelDeviceScope = default,
            Bool32 vulkanMemoryModelAvailabilityVisibilityChains = default
        )
        {
           SType = sType;
           PNext = pNext;
           VulkanMemoryModel = vulkanMemoryModel;
           VulkanMemoryModelDeviceScope = vulkanMemoryModelDeviceScope;
           VulkanMemoryModelAvailabilityVisibilityChains = vulkanMemoryModelAvailabilityVisibilityChains;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public Bool32 VulkanMemoryModel;
/// <summary></summary>
        public Bool32 VulkanMemoryModelDeviceScope;
/// <summary></summary>
        public Bool32 VulkanMemoryModelAvailabilityVisibilityChains;
    }
}
