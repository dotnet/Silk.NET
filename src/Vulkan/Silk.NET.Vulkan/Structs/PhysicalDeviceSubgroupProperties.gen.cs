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
    [NativeName("Name", "VkPhysicalDeviceSubgroupProperties")]
    public unsafe partial struct PhysicalDeviceSubgroupProperties
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
        [NativeName("Name", "subgroupSize")]
        public uint SubgroupSize;
/// <summary></summary>
        [NativeName("Type", "VkShaderStageFlags")]
        [NativeName("Type.Name", "VkShaderStageFlags")]
        [NativeName("Name", "supportedStages")]
        public ShaderStageFlags SupportedStages;
/// <summary></summary>
        [NativeName("Type", "VkSubgroupFeatureFlags")]
        [NativeName("Type.Name", "VkSubgroupFeatureFlags")]
        [NativeName("Name", "supportedOperations")]
        public SubgroupFeatureFlags SupportedOperations;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "quadOperationsInAllStages")]
        public Bool32 QuadOperationsInAllStages;
    }
}
