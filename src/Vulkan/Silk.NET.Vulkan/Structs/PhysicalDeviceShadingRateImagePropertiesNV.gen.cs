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
    public unsafe struct PhysicalDeviceShadingRateImagePropertiesNV
    {
        public PhysicalDeviceShadingRateImagePropertiesNV
        (
            StructureType sType = StructureType.PhysicalDeviceShadingRateImagePropertiesNV,
            void* pNext = default,
            Extent2D shadingRateTexelSize = default,
            uint shadingRatePaletteSize = default,
            uint shadingRateMaxCoarseSamples = default
        )
        {
           SType = sType;
           PNext = pNext;
           ShadingRateTexelSize = shadingRateTexelSize;
           ShadingRatePaletteSize = shadingRatePaletteSize;
           ShadingRateMaxCoarseSamples = shadingRateMaxCoarseSamples;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public Extent2D ShadingRateTexelSize;
/// <summary></summary>
        public uint ShadingRatePaletteSize;
/// <summary></summary>
        public uint ShadingRateMaxCoarseSamples;
    }
}
