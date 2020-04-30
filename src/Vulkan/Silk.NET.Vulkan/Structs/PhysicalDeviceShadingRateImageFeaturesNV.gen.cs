// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

namespace Silk.NET.Vulkan
{
    public unsafe struct PhysicalDeviceShadingRateImageFeaturesNV
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
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public Bool32 ShadingRateImage;
/// <summary></summary>
        public Bool32 ShadingRateCoarseSampleOrder;
    }
}
