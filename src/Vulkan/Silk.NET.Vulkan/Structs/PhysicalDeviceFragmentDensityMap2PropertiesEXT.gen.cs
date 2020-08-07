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
    public unsafe struct PhysicalDeviceFragmentDensityMap2PropertiesEXT
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
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public Bool32 SubsampledLoads;
/// <summary></summary>
        public Bool32 SubsampledCoarseReconstructionEarlyAccess;
/// <summary></summary>
        public uint MaxSubsampledArrayLayers;
/// <summary></summary>
        public uint MaxDescriptorSetSubsampledSamplers;
    }
}
