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
    public unsafe struct PhysicalDeviceSubgroupProperties
    {
        public PhysicalDeviceSubgroupProperties
        (
            StructureType sType = StructureType.PhysicalDeviceSubgroupProperties,
            void* pNext = default,
            uint subgroupSize = default,
            ShaderStageFlags supportedStages = default,
            SubgroupFeatureFlags supportedOperations = default,
            Bool32 quadOperationsInAllStages = default
        )
        {
           SType = sType;
           PNext = pNext;
           SubgroupSize = subgroupSize;
           SupportedStages = supportedStages;
           SupportedOperations = supportedOperations;
           QuadOperationsInAllStages = quadOperationsInAllStages;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public uint SubgroupSize;
/// <summary></summary>
        public ShaderStageFlags SupportedStages;
/// <summary></summary>
        public SubgroupFeatureFlags SupportedOperations;
/// <summary></summary>
        public Bool32 QuadOperationsInAllStages;
    }
}
