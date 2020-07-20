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
    [NativeName("Name", "VkPhysicalDeviceFragmentDensityMap2PropertiesEXT")]
    public unsafe partial struct PhysicalDeviceFragmentDensityMap2PropertiesEXT
    {
        public PhysicalDeviceFragmentDensityMap2PropertiesEXT
        (
            StructureType sType = StructureType.PhysicalDeviceFragmentDensityMap2PropertiesExt,
            void* pNext = default,
            Bool32 subsampledLoads = default,
            Bool32 subsampledCoarseReconstructionEarlyAccess = default,
            uint maxSubsampledArrayLayers = default,
            uint maxDescriptorSetSubsampledSamplers = default
        )
        {
            SType = sType;
            PNext = pNext;
            SubsampledLoads = subsampledLoads;
            SubsampledCoarseReconstructionEarlyAccess = subsampledCoarseReconstructionEarlyAccess;
            MaxSubsampledArrayLayers = maxSubsampledArrayLayers;
            MaxDescriptorSetSubsampledSamplers = maxDescriptorSetSubsampledSamplers;
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
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "subsampledLoads")]
        public Bool32 SubsampledLoads;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "subsampledCoarseReconstructionEarlyAccess")]
        public Bool32 SubsampledCoarseReconstructionEarlyAccess;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxSubsampledArrayLayers")]
        public uint MaxSubsampledArrayLayers;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxDescriptorSetSubsampledSamplers")]
        public uint MaxDescriptorSetSubsampledSamplers;
    }
}
