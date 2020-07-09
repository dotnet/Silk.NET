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
    [NativeName("Name", "VkPhysicalDeviceFragmentDensityMapFeaturesEXT")]
    public unsafe struct PhysicalDeviceFragmentDensityMapFeaturesEXT
    {
        public PhysicalDeviceFragmentDensityMapFeaturesEXT
        (
            StructureType sType = StructureType.PhysicalDeviceFragmentDensityMapFeaturesExt,
            void* pNext = default,
            Bool32 fragmentDensityMap = default,
            Bool32 fragmentDensityMapDynamic = default,
            Bool32 fragmentDensityMapNonSubsampledImages = default
        )
        {
           SType = sType;
           PNext = pNext;
           FragmentDensityMap = fragmentDensityMap;
           FragmentDensityMapDynamic = fragmentDensityMapDynamic;
           FragmentDensityMapNonSubsampledImages = fragmentDensityMapNonSubsampledImages;
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
        [NativeName("Name", "fragmentDensityMap")]
        public Bool32 FragmentDensityMap;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "fragmentDensityMapDynamic")]
        public Bool32 FragmentDensityMapDynamic;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "fragmentDensityMapNonSubsampledImages")]
        public Bool32 FragmentDensityMapNonSubsampledImages;
    }
}
