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
    [NativeName("Name", "VkPhysicalDeviceShadingRateImageFeaturesNV")]
    public unsafe partial struct PhysicalDeviceShadingRateImageFeaturesNV
    {
        public PhysicalDeviceShadingRateImageFeaturesNV
        (
            StructureType sType = StructureType.PhysicalDeviceShadingRateImageFeaturesNV,
            void* pNext = default,
            Bool32 shadingRateImage = default,
            Bool32 shadingRateCoarseSampleOrder = default
        )
        {
            SType = sType;
            PNext = pNext;
            ShadingRateImage = shadingRateImage;
            ShadingRateCoarseSampleOrder = shadingRateCoarseSampleOrder;
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
        [NativeName("Name", "shadingRateImage")]
        public Bool32 ShadingRateImage;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shadingRateCoarseSampleOrder")]
        public Bool32 ShadingRateCoarseSampleOrder;
    }
}
