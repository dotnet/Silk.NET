// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkPhysicalDeviceShadingRateImagePropertiesNV")]
    public unsafe partial struct PhysicalDeviceShadingRateImagePropertiesNV
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
        [NativeName("Type", "VkExtent2D")]
        [NativeName("Type.Name", "VkExtent2D")]
        [NativeName("Name", "shadingRateTexelSize")]
        public Extent2D ShadingRateTexelSize;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "shadingRatePaletteSize")]
        public uint ShadingRatePaletteSize;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "shadingRateMaxCoarseSamples")]
        public uint ShadingRateMaxCoarseSamples;
    }
}
