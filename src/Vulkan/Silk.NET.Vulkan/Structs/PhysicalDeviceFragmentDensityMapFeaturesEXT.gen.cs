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
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public Bool32 FragmentDensityMap;
/// <summary></summary>
        public Bool32 FragmentDensityMapDynamic;
/// <summary></summary>
        public Bool32 FragmentDensityMapNonSubsampledImages;
    }
}
