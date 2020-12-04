// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkPhysicalDeviceFragmentDensityMapFeaturesEXT")]
    public unsafe partial struct PhysicalDeviceFragmentDensityMapFeaturesEXT
    {
        public PhysicalDeviceFragmentDensityMapFeaturesEXT
        (
            StructureType? sType = StructureType.PhysicalDeviceFragmentDensityMapFeaturesExt,
            void* pNext = null,
            Bool32? fragmentDensityMap = null,
            Bool32? fragmentDensityMapDynamic = null,
            Bool32? fragmentDensityMapNonSubsampledImages = null
        ) : this()
        {
            if (sType is not null)
            {
                SType = sType.Value;
            }

            if (pNext is not null)
            {
                PNext = pNext;
            }

            if (fragmentDensityMap is not null)
            {
                FragmentDensityMap = fragmentDensityMap.Value;
            }

            if (fragmentDensityMapDynamic is not null)
            {
                FragmentDensityMapDynamic = fragmentDensityMapDynamic.Value;
            }

            if (fragmentDensityMapNonSubsampledImages is not null)
            {
                FragmentDensityMapNonSubsampledImages = fragmentDensityMapNonSubsampledImages.Value;
            }
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
